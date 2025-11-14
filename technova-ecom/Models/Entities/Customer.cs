using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    [Table("Customers")]
    public class Customer
    {
        [Column("customer_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }

        [Column("first_name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        [Display(Name = "Surname")]
        public string LastName { get; set; }

        [Column("email")]
        [Display(Name = "email")]
        //Validation for email format
        //regex pattern for email validation

        public string Email { get; set; }

        [Column("password")]
        
        public string Password { get; set; }

        [Column("address")]
        [Display(Name = "address")]
        public string Address { get; set; }

        [Column("phone_number")]
        [Display(Name = "phone number")]
        public string PhoneNumber { get; set; }
    }
}
