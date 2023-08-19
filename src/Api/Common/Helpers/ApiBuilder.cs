using System.Collections.Generic;
using System.Linq;
using TuiFly.FlySearchApi.Api.Controllers.Airports.Models;
using TuiFly.FlySearchApi.Domain.Models;

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
    }
}
