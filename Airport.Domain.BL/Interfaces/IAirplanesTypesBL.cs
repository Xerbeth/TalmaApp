using Airport.Domain.Common.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Domain.BL.Interfaces
{
    public interface IAirplanesTypesBL
    {
        public TransactionDto<List<AirplanesTypesDto>> GetAllAirplanesTypes();
    }
}
