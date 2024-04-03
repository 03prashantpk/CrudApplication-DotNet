using System.ComponentModel.DataAnnotations;

namespace CrudApplication.Models
{
    public class Customer
    {
        [Key]
        public int CusID { get; set; }

        public string? Name { get; set; }

        public double? Price { get; set; }
    }
}
