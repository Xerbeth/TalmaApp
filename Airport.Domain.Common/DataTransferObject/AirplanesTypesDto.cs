using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Domain.Common.DataTransferObject
{
    public class AirplanesTypesDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public AirplanesTypesDto()
        {
            Id = 0;
            Name = string.Empty;
        }
    }
}
