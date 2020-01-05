using System;

namespace RestClient.Dto
{
    public class EventDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Genre { get; set; }
        public string ArtistNames { get; set; }
        public int TotalAvailableTickets { get; set; }

        public override string ToString()
        {
            return $"Id={Id}, Name={Name}, Location={Location}, Genre={Genre}, ArtistName={ArtistNames}, TotalAvailableTickets={TotalAvailableTickets}";
        }
    }
}
