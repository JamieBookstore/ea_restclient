using RestClientApp.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RestClientApp
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        public DetailWindow(EventDetailDto dto)
        {
            InitializeComponent();

            string detail = "Event\nId: " + dto.Id + "\nName: " + dto.Name + "\nDate: " + dto.Date + "\nStart Time: " + dto.StartTime + 
                "\nEnd Time: " + dto.EndTime + "\nGenre: " + dto.Genre + "\nArtist Names: " + dto.ArtistNames + "\n\nLocation\nName: " + dto.LocationName + 
                "\nBuilding: " +  dto.LocationBuilding + "\nRoom: " + dto.LocationRoom + "\nStreet: " + dto.LocationStreet + "\nZip: " + dto.LocationZip +
                "\nCity: " + dto.LocationCity + "\nCountry: " + dto.LocationCity + "\n\nEvent Series\nName: " + dto.EventSeriesName +
                "\nDescription: " + dto.EventSeriesDescription + "\n\nHost\nFirst Name:" + dto.EventHostFirstName + "\nLast Name: " + dto.EventHostLastName +
                "\nEmail: " + dto.EventHostEmail + "\nPhone: " + dto.EventHostPhone;

            eventDetail.Text = detail;
            

        }
    }
}
