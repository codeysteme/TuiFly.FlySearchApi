using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using TuiFly.FlySearchApi.Api.Common.Helpers;
using TuiFly.FlySearchApi.Api.Controllers.Airports.Models;
using TuiFly.FlySearchApi.Api.Controllers.Fligths.Model;

namespace TuiFly.FlySearchApi.Api.Controllers.Fligths
{
    public partial class FligthsController : ControllerBase
    {
        /// <summary>
        /// Get list of available flight for a user request
        /// </summary>
        /// <param name="getFlightsRequest">request for retreive a valid flights informations</param>
        /// <returns></returns>
        /// <response code="200">The flights data list is found</response> 
        /// <response code="204">There is no content for this query</response> 
        /// <response code="400">Bad request provided</response> 
        /// <response code="500">Internal server error</response> 
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<AirportsResponse>))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult GetAvailableFlights([FromQuery] GetFlightsRequest getFlightsRequest)
        {


            var response = _airportsManagerService.GetAllAirportsValue();

            if (response.Any())
            {
                return Ok(response.ToAirportModels());
            }

            return BadRequest();
        }
    }
}
