using System;
using System.Collections.Generic;
using System.Text;

namespace RestClientApp.Dto
{
    public class EventDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string LocationName { get; set; }
        public string LocationBuilding { get; set; }
        public string LocationRoom { get; set; }
        public string LocationStreet { get; set; }
        public string LocationZip { get; set; }
        public string LocationCity { get; set; }
        public string LocationCountry { get; set; }
        public string EventSeriesName { get; set; }
        public string EventSeriesDescription { get; set; }
        public string EventHostFirstName { get; set; }
        public string EventHostLastName { get; set; }
        public string EventHostEmail { get; set; }
        public string EventHostPhone { get; set; }
        public string Genre { get; set; }
        public string ArtistNames { get; set; }
    }
}
