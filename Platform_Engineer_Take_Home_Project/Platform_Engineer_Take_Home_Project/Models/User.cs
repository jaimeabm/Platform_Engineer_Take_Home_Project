using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Platform_Engineer_Take_Home_Project.Models
{
    public class User
    {
        public User()
        {
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "First name required")]
        [MinLength(3, ErrorMessage = "At least 3 letters")]
        [StringLength(100, ErrorMessage = "First name length can't be more than 100.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name required")]
        [MinLength(3, ErrorMessage = "At least 3 letters")]
        [StringLength(100, ErrorMessage = "Last name length can't be more than 100.")]
        public string LastName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email required")]
        [MinLength(5, ErrorMessage = "At least 5 letters")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        [StringLength(50, ErrorMessage = "Email length can't be more than 50.")]
        public string Email { get; set; }

        [Phone]
        [Required(ErrorMessage = "Phone required")]
        [MinLength(10, ErrorMessage = "At least 10 digits")]
        [StringLength(13, ErrorMessage = "Phone length can't be more than 13.")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Addreess needed")]
        [MinLength(10, ErrorMessage = "At least 10 letters")]
        [StringLength(100, ErrorMessage = "Address length can't be more than 100.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City needed")]
        [MinLength(2, ErrorMessage = "At least 2 letters")]
        [StringLength(100, ErrorMessage = "City length can't be more than 100.")]
        public string City { get; set; }

        [Required(ErrorMessage = "State needed")]
        [MinLength(2, ErrorMessage = "At least 2 letters (TX, CA, NM)")]
        [StringLength(2, ErrorMessage = "State length can't be more than 2.")]
        public string State { get; set; }

        [StringLength(5, ErrorMessage = "Zip length can't be more than 5.")]
        [RegularExpression(@"^([0-9]{5})|([0-9]{0})$", ErrorMessage = "5 digits (Optional field)")]
        public string Zip { get; set; }

        [DataType(DataType.Currency)]
        public decimal RentEstimated { get; set; }

        [DisplayFormat(DataFormatString = "{0:C0}")]
        [Required(ErrorMessage = "Rent Expected")]
        [Range(100, 99999, ErrorMessage = "The min: $100 - max: $99999")]
        [DataType(DataType.Currency)]
        public decimal RentExpected { get; set; }

        [DataType(DataType.Currency)]
        public decimal PropertyPrice { get; set; }

        [StringLength(25)]
        public string IP { get; set; }


        /*
        [Required(ErrorMessage = "Please provide your password")]
        [MinLength(10, ErrorMessage = "At least 10 letters")]
        [UIHint("password")]
        [StringLength(20, ErrorMessage = "Passwords length can't be more than 20.")]
        public string Password { get; set; }

        [NotMapped] // Does not effect with your database
        [Compare("Password", ErrorMessage = "Password doesn't match.")]
        [UIHint("password")]
        [StringLength(20, ErrorMessage = "Confirm Passwords length can't be more than 20.")]
        public string ConfirmPassword { get; set; }
        */

        [NotMapped] // Does not effect with your database
        public string RangeRentEstimated
        {
            get => $"The rent is between: ${this.RentEstimated - (this.RentEstimated * 0.1m )} and ${this.RentEstimated + (this.RentEstimated * 0.1m)}";
        }

        [NotMapped] // Does not effect with your database
        public string FullName
        {
            get => $"{this.FirstName} {this.LastName}";
        }

        [NotMapped] // Does not effect with your database
        public string FullAddress
        {
            get => $"{this.Address}, {this.City}, {this.State} {this.Zip}";
        }

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
