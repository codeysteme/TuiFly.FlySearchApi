using System.Collections.Generic;
using TuiFly.FlySearchApi.Domain.Models.Dto;
using TuiFly.FlySearchApi.Domain.Models.Queries;

namespace TuiFly.FlySearchApi.Domain.Interfaces
{
    public interface IFlightsManagerService
    {
        /// <summary>
        /// Get list of flights by user query
        /// </summary>
        /// <param name="flightsRequestQuery">the flight query</param>
        /// <returns></returns>
        public IEnumerable<FlightPackageDto> GetflightsList(FlightsRequestQuery flightsRequestQuery);
    }
}
