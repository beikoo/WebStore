﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Employee : BaseModel
    {
        public string EmployeeNumber { get; set; }
        public string PhoneNumber { get; set; }
        public int? PersonId { get; set; }
        [Required]
        public virtual Person Person { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
