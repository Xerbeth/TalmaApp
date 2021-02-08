using Airport.Domain.Common.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Airport.Domain.Services.Interfaces
{
    public interface IAirplanesTypesServices
    {
        public TransactionDto<List<AirplanesTypesDto>> GetAllAirplanesTypes();
    }
}
