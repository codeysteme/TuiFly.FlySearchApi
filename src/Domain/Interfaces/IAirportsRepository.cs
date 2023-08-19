using System.Collections.Generic;
using TuiFly.FlySearchApi.Domain.Models;

namespace TuiFly.FlySearchApi.Domain.Interfaces
{
    public interface IAirportsRepository
    {
        /// <summary>
        /// Get list of airport data
        /// </summary>
        /// <returns></returns>
        IEnumerable<AirportDto> GetAirportList();
    }
}
