using System.Collections.Generic;
using System.Linq;
using TuiFly.FlySearchApi.Api.Controllers.Airports.Models;
using TuiFly.FlySearchApi.Api.Controllers.Fligths.Model.Requests;
using TuiFly.FlySearchApi.Domain.Models.Dto;
using TuiFly.FlySearchApi.Domain.Models.Queries;

namespace TuiFly.FlySearchApi.Api.Common.Helpers
{
    public static class ApiBuilder
    {
        /// <summary>
        /// build an airports list of data
        /// </summary>
        /// <param name="airportDtos"></param>
        /// <returns></returns>
        public static IEnumerable<AirportsResponse> ToAirportModels(this IEnumerable<AirportDto> airportDtos)
        {
            return airportDtos.Select(a => new AirportsResponse
            {
                Available = a.Available,
                CountryName = a.CountryName,
                Id = a.Id,
                Name = a.Name
            }).ToList();
        }

        /// <summary>
        /// Build flight request query
        /// </summary>
        /// <param name="flightsRequest"></param>
        /// <returns></returns>
        public static FlightsRequestQuery ToFlightsRequestQuery(this GetFlightsRequest flightsRequest)
        {
            return new FlightsRequestQuery
            {
                Arrival = flightsRequest.Arrival,
                Departure = flightsRequest.Departure,
                ReturnDate = flightsRequest.ReturnDate,
                DepartureDate = flightsRequest.DepartureDate,
                PassengerNumbers = flightsRequest.PassengerNumbers
            };
        }
    }
}
