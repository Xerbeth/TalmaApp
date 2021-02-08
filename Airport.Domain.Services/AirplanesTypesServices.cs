using Airport.Domain.BL.Interfaces;
using Airport.Domain.Common.DataTransferObject;
using Airport.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Domain.Services
{
    public class AirplanesTypesServices : IAirplanesTypesServices
    {
        private readonly IAirplanesTypesBL _airplanesTypesBL;

        public AirplanesTypesServices(IAirplanesTypesBL airplanesTypesBL)
        {
            _airplanesTypesBL = airplanesTypesBL;
        }
        public TransactionDto<List<AirplanesTypesDto>> GetAllAirplanesTypes()
        {
            return _airplanesTypesBL.GetAllAirplanesTypes();
        }
    }
}
