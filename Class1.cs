//using AICPDAL;

//using AICPJOBPORTAL.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
////using System.Web.Security;
using System;

using System.ComponentModel;

using System.Linq;
using System.Web;

using System.Web.Mvc;
namespace AICPDAL.ViewModel
{
    public class UserVM
    {
        public UserVM()
        {
            this.objUserDetail = new userdetail();
            this.objUserInitials = new user();
            // this.queList = new List<securityquestion>();

            this.queList = new List<System.Web.Mvc.SelectListItem>();

            // this.industryList = new List<category>();

            this.industrList = new List<System.Web.Mvc.SelectListItem>();
            //this.memberTypeList = new List<role>();
            this.memberList = new List<System.Web.Mvc.SelectListItem>();
        }

        public userdetail objUserDetail { get; set; }
        public user objUserInitials { get; set; }
        // public List<securityquestion> queList { get; set; }

        public List<System.Web.Mvc.SelectListItem> queList { get; set; }
        // public List<category> industryList { get; set; }
        public List<System.Web.Mvc.SelectListItem> industrList { get; set; }
        public List<System.Web.Mvc.SelectListItem> memberList { get; set; }

        [DataType(DataType.Password)]
        [StringLength(255, MinimumLength = 8)]
        [Required(ErrorMessage = "Please enter the Password!!!")]
        //[MembershipPassword()]
        public string Password { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("Password")]
        [DataType(DataType.Password)]
        [StringLength(255, MinimumLength = 8)]
        [Required(ErrorMessage = "Please confirm the Password!!!")]
        //[MembershipPassword()]
        public string ConfirmPassword { get; set; }
        public int UserID { get; set; }

       
    }


    [MetadataType(typeof(userdetailMetaData))]
    public partial class userdetail
    {
        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public int RoleID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }
        public string WorkContact { get; set; }
        public string MobileContact { get; set; }
        public string EmailID { get; set; }
        public System.DateTime createddate { get; set; }
        public System.DateTime modifieddate { get; set; }
        public Nullable<int> categoryid { get; set; }
        public Nullable<int> subcategoryid { get; set; }
        public string companyname { get; set; }

        public virtual System.Web.Mvc.SelectListItem category { get; set; }
        public virtual role role { get; set; }
        // public virtual subcategory subcategory { get; set; }
        public virtual user user { get; set; }
    }

    public class userdetailMetaData
    {
        [DisplayName("First Name")]
        [Required(ErrorMessage = "Please enter the First name!!!")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter the Last name!!!")]
        public string LastName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Display(Name = "Address1")]
        public string Address1 { get; set; }

        [Display(Name = "Address2")]
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        [Display(Name = "Zip Code")]
        public string Zipcode { get; set; }

        [Display(Name = "Phone No.")]
        public string WorkContact { get; set; }

        [Display(Name = "Mobile")]
        [Required(ErrorMessage = "Please enter the Mobile Number!!!")]
        public string MobileContact { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter the Email ID!!!")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailID { get; set; }

        //[Display(Name = "Company Name")]
        //public string CompanyName { get; set; }

        //[Display(Name = "Industry")]
        //[Required(ErrorMessage = "Please select the Category!!!")]
        //public int categoryid { get; set; }

        [Display(Name = "Member Type")]
        [Required(ErrorMessage = "Please select the Member Type!!!")]
        public int RoleID { get; set; }

        //[Display(Name = "Sub Category")]
        //public int subcategoryid { get; set; }

    }

    [MetadataType(typeof(userMetaData))]
    public partial class user
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int questionid { get; set; }
        public string hintanswer { get; set; }
        public System.DateTime createddate { get; set; }
        public System.DateTime modifieddate { get; set; }
        public Nullable<bool> IsForgotPassword { get; set; }
        public int hintquestion2id { get; set; }
        public string hintanswer2 { get; set; }
        public int hintquestion3id { get; set; }
        public string hintanswer3 { get; set; }

    }
    public class userMetaData
    {
        public int UserID { get; set; }

        [Display(Name = "UserName")]
        [Required(ErrorMessage = "Please enter the Login Name!!!")]
        public string UserName { get; set; }

        [Display(Name = "Hint Question")]
        [Required(ErrorMessage = "Please select the Security Question!!!")]
        public int questionid { get; set; }

        [Display(Name = "Hint Answer")]
        [Required(ErrorMessage = "Please enter the Security Answer!!!")]
        public string hintanswer { get; set; }

        [Display(Name = "Hint Question1")]
        [Required(ErrorMessage = "Please select the Security Question!!!")]
        public int hintquestion2id { get; set; }

        [Display(Name = "Hint Answer")]
        [Required(ErrorMessage = "Please enter the Security Answer!!!")]
        public string hintanswer2 { get; set; }

        [Display(Name = "Hint Question1")]
        [Required(ErrorMessage = "Please select the Security Question!!!")]
        public int hintquestion3id { get; set; }

        [Display(Name = "Hint Answer")]
        [Required(ErrorMessage = "Please enter the Security Answer!!!")]
        public string hintanswer3 { get; set; }

    }


}