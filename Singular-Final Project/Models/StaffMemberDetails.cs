using System.ComponentModel.DataAnnotations;

namespace Singular_Final_Project.Models
{
    public class StaffMemberDetails
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Surname is required.")]
        [MaxLength(100)]
        public string Surname { get; set; }

        public string StreetAddress { get; set; }

        [MaxLength(100)]
        public string Suburb { get; set; }

        [MaxLength(100)]
        public string Town { get; set; }

        [Required(ErrorMessage = "Postal Code is required.")]
        [MaxLength(100)]
        public string PostalCode { get; set; }
    }//Data validation is good for assisting our system to work with accurate information.

}

