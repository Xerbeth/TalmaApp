using Airport.Domain.BL.Interfaces;
using Airport.Domain.Common.DataTransferObject;
using Airport.Domain.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace Airport.Domain.BL
{
    public class AirplanesTypesBL : IAirplanesTypesBL
    {
        private readonly IAirplanesTypesRepository _airplanesTypesRepository;

        public AirplanesTypesBL(IAirplanesTypesRepository airplanesTypesRepository)
        {
            _airplanesTypesRepository = airplanesTypesRepository;
        }

        public TransactionDto<List<AirplanesTypesDto>> GetAllAirplanesTypes()
        {
            TransactionDto<List<AirplanesTypesDto>> transaction = new TransactionDto<List<AirplanesTypesDto>>();
            transaction.Data = new List<AirplanesTypesDto>();
            try
            {
                var getAllAirplanesTypes = _airplanesTypesRepository.GetAllAirplanesTypes();
                if (getAllAirplanesTypes.Count == 0)
                {
                    transaction.Message = "No existen registros.";
                    return transaction;
                }
                foreach (var item in getAllAirplanesTypes)
                {
                    AirplanesTypesDto airplanesTypes = new AirplanesTypesDto();
                    airplanesTypes.Id = item.Id;
                    airplanesTypes.Name = item.Name;
                    transaction.Data.Add(airplanesTypes);
                }
                transaction.Message = "Datos consultados correctamente.";
                transaction.Status = Status.Success;
            }
            catch (ArgumentException ex)
            {
                transaction.Message = ex.Message;
            }

            return transaction;
        }
    }
}
