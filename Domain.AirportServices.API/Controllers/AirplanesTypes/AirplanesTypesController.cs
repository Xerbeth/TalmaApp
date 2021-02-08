using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using Airport.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AirportServices.API.Controllers.AirplanesTypes
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirplanesTypesController : ControllerBase
    {
        private readonly IAirplanesTypesServices _airplanesTypesServices;

        public AirplanesTypesController(IAirplanesTypesServices airplanesTypesServices)
        {
            _airplanesTypesServices = airplanesTypesServices;
        }

        [HttpGet("GetAllAirplanesTypes")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult GetAllAirplanesTypes()
        {
            try
            {                
                return Ok(_airplanesTypesServices.GetAllAirplanesTypes());
            }
            catch (Exception ex)
            {
                return null;
                //return StatusCode(StatusCodes.Status400BadRequest, new ErrorAnswerDTO()
                //{
                //    State = StatusCodes.Status400BadRequest,
                //    Mistakes = new List<ErrorDTO>(new[]
                //    {
                //         new ErrorDTO()
                //         {
                //             Code = "",
                //             Description = ex.Message
                //         }
                //     })
                //});
            }
        }

    }
}