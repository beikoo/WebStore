using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Customer : BaseModel
    {
        public string AccountNumber { get; set; }
        public int? PersonId { get; set; }
        [Required]
        public virtual Person Person { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
    }
}
