using System.Collections.Generic;
using TuiFly.FlySearchApi.Domain.Interfaces;
using TuiFly.FlySearchApi.Domain.Models;

namespace TuiFly.FlySearchApi.Domain.Services
{
    public class AirportsManagerService : IAirportsManagerService
    {
        /// <summary>
        /// the airports repository services
        /// </summary>
        private readonly IAirportsRepository _airportsRepository;

        public AirportsManagerService(IAirportsRepository airportsRepository)
        {
            _airportsRepository = airportsRepository;
        }


        /// <summary>
        /// Get list of airport data
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AirportDto> GetAllAirportsValue()
        {
            return _airportsRepository.GetAirportList();
        }
    }
}
