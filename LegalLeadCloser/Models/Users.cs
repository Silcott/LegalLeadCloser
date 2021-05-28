using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LegalLeadCloser.Models
{
    public class Users
    {
        //Used to create a timestamp when a user is created
        private DateTime? creationDate;

        private string roles = "USER";
        private string imageName = "no-image.png";


        //UserID
        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int UserID { get; set; }

        //Company Name
        [DisplayName("Company Name")]
        [Required(ErrorMessage = "Company Name is Required")]
        public string CompanyName { get; set; }

        //Company Start Date
        [DisplayName("Company Start Date")]
        [Required(ErrorMessage = "Company Start Date is Required")]
        [DataType(DataType.Date)]
        public DateTime? CompanyStartDate { get; set; }

        //First Name
        [PersonalData]
        [StringLength(50, MinimumLength = 3)]
        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is Required")]
        public string FirstName { get; set; }

        //Last Name
        [PersonalData]
        [DisplayName("Last Name")]
        [StringLength(50, MinimumLength = 3)]
        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }

        //Street
        [PersonalData]
        [DisplayName("Street")]
        [StringLength(50, MinimumLength = 3)]
        [Required(ErrorMessage = "Street Address is Required")]
        public string StreetAddress { get; set; }

        //City
        [PersonalData]
        [DisplayName("City")]
        [StringLength(50, MinimumLength = 3)]
        [Required(ErrorMessage = "City is Required")]
        public string CityAddress { get; set; }

        //State
        [PersonalData]
        [DisplayName("State")]
        [Required(ErrorMessage = "State is Required")]
        public string StateAddress { get; set; }

        //Zip
        [PersonalData]
        [DisplayName("Zip Code")]
        [RegularExpression(@"(^\d{5}(-\d{4})?$)|(^[ABCEGHJKLMNPRSTVXYabceghjklmnprstvxy]{1}\d{1}[ABCEGHJKLMNPRSTVWXYZabceghjklmnprstv‌​xy]{1} *\d{1}[ABCEGHJKLMNPRSTVWXYZabceghjklmnprstvxy]{1}\d{1}$)", ErrorMessage = "That postal code is not a valid US or Canadian postal code.")]
        [Required(ErrorMessage = "Zip Code is Required")]
        public string ZipCodeAddress { get; set; }

        //Phone
        [PersonalData]
        [Required(ErrorMessage = "Phone Number is Required")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }

        //Email
        [PersonalData]
        [Required(ErrorMessage = "Email Address is Required")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        public string Email { get; set; }

        //Image Name
        [ScaffoldColumn(false)]
        [DisplayName("Image File Path")]
        public string ImageName
        {
            get { return imageName; }
            set { imageName = value; }
        }

        //Date Created - Timestamp of when User is Created
        [ScaffoldColumn(false)]
        [DisplayName("Date Created")]
        public DateTime CreationDate
        {
            get { return creationDate ?? DateTime.Now; }
            set { creationDate = value; }
        }

        //Subscription Service
        [Required(ErrorMessage = "Subscription is Required")]
        [DisplayName("Subscription Service")]
        public string SubscriptionService { get; set; }

        //Security Level
        //TODO may need to put 'requiredif attribute' statement to say required if IsAdmin = true 
        [ScaffoldColumn(false)]
        //[HiddenInput(DisplayValue = false)]
        [ReadOnly(true)]
        public string Roles
        {
            get { return roles; }
            set { roles = value; }
        }

        //Username
        [StringLength(50, MinimumLength = 3)]
        [DisplayName("Username")]
        [Required(ErrorMessage = "Username is Required")]
        public string Username { get; set; }
        
        //Password
        [Required(ErrorMessage = @"Password is Required")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z])(.{8,15})$", ErrorMessage = @"
        Incorrect Email Format,
        Must Contain 1 Uppercase,
        1 Lowercase, 1 Number,
        1 Special and minimium of 8 Characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //Confirm Password
        [NotMapped]
        [Required(ErrorMessage = "Confirm Password is required")]
        //[ReadOnly(true)]
        [StringLength(24, ErrorMessage = "Must be between 8 and 24 characters", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        //Last Login Date
        [DisplayName("Last Login Date")]
        [ScaffoldColumn(false)]
        public string LastLogin { get; set; }

    }
}
