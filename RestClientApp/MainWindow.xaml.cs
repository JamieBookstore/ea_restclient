using RestClient;
using RestClient.Dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RestClientApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private const string _fh = "http://10.0.51.92/fh-ticket-server/event/list";
        private const string _local = "http://localhost:8080/fh-ticket-server/event/list";

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
            _events = new ObservableCollection<EventDto>(await request.GetEvents(server));
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
    }
}
