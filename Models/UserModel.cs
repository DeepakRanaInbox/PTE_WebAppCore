using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Pte.Models
{
    public class Users
    {

        public int ID { set; get; }
        [Required(ErrorMessage = "Name is required")]
        public string vName { set; get; }
        public string vFather_Name { set; get; }
        [Required(ErrorMessage = "Username is required")]
        public string vUsername { set; get; }
        [Required(ErrorMessage = "Password is required")]
        public string vPassword { set; get; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress( ErrorMessage ="Please enter valid email-id")]
        public string vEmail { set; get; }
        [Required(ErrorMessage = "Phone is required")]
        public string vPhoneNo { set; get; }
        [Required(ErrorMessage = "Address is required")]
        public string vAddress { set; get; }
        public string vImagePath { set; get; }
        [Required(ErrorMessage = "ImagePath is required")]

        public IFormFile UploadImageUrl { get; set; }
        [Required(ErrorMessage = "DOB is required")]

        public string vDOB { set; get; }
        [Required(ErrorMessage = "Gender is required")]
        public string Gender { set; get; }

        // Following fields will be use in User Grid only
        public string iRoleID { set; get; }
        public string Role { set; get; }
        public int iTargetedScore { set; get; }
        public int iCredit { set; get; }
        public string isStatus { set; get; }
        public string ExpiryDate { set; get; }

        public List<Users> UserList { set; get; }

    }

    public class ChangePasswordModel
    {
        [Required(ErrorMessage = "Old Password is required")]
        public string OldPassword { set; get; }


        [Required(ErrorMessage = "New Password is required")]
        public string NewPassword { set; get; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("NewPassword", ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string ConfirmPassword { set; get; }
    }
    public class ForgotPasswordModel
    {
        [Required(ErrorMessage = "Please enter Email")]
        public string EmailId { set; get; }
    }
    public class LoginModel
    {

        [Required(ErrorMessage = "User name is required")]
        public string username { set; get; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { set; get; }

    }
}