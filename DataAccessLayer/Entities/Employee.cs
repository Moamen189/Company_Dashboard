﻿using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DataAccessLayer.Entities
{
    public class Employee
    {
        public int Id { get; set; }
     
        public string Name { get; set; }
        
        public int? Age { get; set; }
       
        public string Address { get; set; }
        [DataType(DataType.Currency)]
       
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }

        public DateTime HireDate { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        //public IFormFile Image { get; set; }
        //public IFormFile Image { get; set; }

        public string ImageName { get; set; }

    }
}
