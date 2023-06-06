﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.DTOLayer.Concrete.DTOs.DepartmentDTOs
{
    public class DepartmentDTO
    {
        public int DepartmentID { get; set; }

        public string? DepartmentName { get; set; }

        public char AreaID { get; set; }

        public decimal DepartmentBudget { get; set; }
    }
}
