using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Airport.Domain.Common.Models
{
    public class AirplanesTypesModel
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        public long Capacity { get; set; }
        public decimal TopSpeed { get; set; }
        public decimal Height { get; set; }
        public decimal MaximumWeight { get; set; }
        public decimal Lenght { get; set; }
        public decimal Wingspan { get; set; }
        public AirplanesTypesModel()
        {
            Id = 0;
            Name = string.Empty;
            Capacity = 0;
            TopSpeed = 0;
            MaximumWeight = 0;
            Lenght = 0;
            Wingspan = 0;
        }
    }
}
