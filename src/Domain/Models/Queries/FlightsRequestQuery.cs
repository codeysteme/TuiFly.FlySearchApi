using System;

namespace TuiFly.FlySearchApi.Domain.Models.Queries
{
    public class FlightsRequestQuery
    {
        public string Departure { get; set; }

        public string Arrival { get; set; }

        public DateTime DepartureDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public int PassengerNumbers { get; set; }
    }
}
