using Airport.Domain.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Domain.DAL.Repository.Interfaces
{
    public interface IAirplanesTypesRepository
    {
        public List<AirplanesTypesModel> GetAllAirplanesTypes();
    }
}
