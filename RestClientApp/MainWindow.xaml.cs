using RestClient;
using RestClient.Dto;
using RestClientApp.Dto;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace RestClientApp
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private const string _fh = "http://10.0.51.92:8080/fh-ticket-server/event/";
        private const string _local = "http://localhost:8080/fh-ticket-server/event/";

        private ObservableCollection<EventDto> _events;

        private string _selectedValue;
        public string SelectedValue
        {
            get { return _selectedValue; }
            set
            {
              _selectedValue = value;
              OnPropertyChanged("SelectedValue");
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            _events = new ObservableCollection<EventDto>();
            events.ItemsSource = _events;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            RestRequest request = new RestRequest();

            string server = null;
            ComboBoxItem item = serverSelect.SelectedItem as ComboBoxItem;
            server = item.Content.ToString() == "FH" ? _fh : _local;

            SelectedValue = server;
            try
            {
                _events = new ObservableCollection<EventDto>(await request.GetEvents(server + "list"));
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                MessageBox.Show(ex.Message, "Exception occured", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            events.ItemsSource = _events;
            events.Items.Refresh();
        }
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        private async void DataGridRow_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DataGridRow row = sender as DataGridRow;
            EventDto eventDto = row.Item as EventDto;

            string eventId = eventDto.Id.ToString();
            RestRequest request = new RestRequest();

            string server = null;
            ComboBoxItem item = serverSelect.SelectedItem as ComboBoxItem;
            server = item.Content.ToString() == "FH" ? _fh : _local;

            EventDetailDto detailDto = await request.GetEvent(server + eventId);

            DetailWindow window = new DetailWindow(detailDto);

            window.ShowDialog();
        }
    }
}
