//using AICPDAL;

//using AICPJOBPORTAL.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
////using System.Web.Security;
using System;
using System.ComponentModel;
using AICPCommonModels;
using AICPDAL;

namespace AICPJOBPORTAL.ViewModel
{
    public class UserVM
    {
        public UserVM()
        {
            this.objUserDetail = new userdetail();
            this.objUserInitials = new user();
            this.objJobSeeker = new AICPDAL.jobseekerprofile();
            // this.queList = new List<securityquestion>();

            this.queList = new List<System.Web.Mvc.SelectListItem>();

            // this.industryList = new List<category>();

             this.industrList = new List<System.Web.Mvc.SelectListItem>();
            //this.memberTypeList = new List<role>();
            this.memberList = new List<System.Web.Mvc.SelectListItem>();
          // this.guidelinelist=new List<System>.Web.Mvc.SelectListItem> ();
        }

        public userdetail objUserDetail { get; set; }
        public user objUserInitials { get; set; }
        public AICPDAL.jobseekerprofile objJobSeeker {get; set;}
        // public List<securityquestion> queList { get; set; }

        //public  List<System.Web.Mvc.SelectListItem> queList { get; set; }
        public List<System.Web.Mvc.SelectListItem> queList { get; set; }
        
        // public List<category> industryList { get; set; }
        public List<System.Web.Mvc.SelectListItem> industrList { get; set; }
        public List<System.Web.Mvc.SelectListItem> memberList { get; set; }

        [DataType(DataType.Password)]
        [StringLength(255, MinimumLength = 8)]
        [Required(ErrorMessage = "Please enter the Password!!!")]
        //[MembershipPassword()]
        public string Password
            { get; set; }           

        [System.ComponentModel.DataAnnotations.Compare("Password")]
        [DataType(DataType.Password)]
        [StringLength(255, MinimumLength = 8)]
        [Required(ErrorMessage = "Please confirm the Password!!!")]
        //[MembershipPassword()]
        public string ConfirmPassword { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
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
        public virtual AICPDAL.role role { get; set; }
       // public virtual subcategory subcategory { get; set; }
        public virtual user user { get; set; }
    }

    public class userdetailMetaData
    {
        [DisplayName("First Name")]
        [Required(ErrorMessage = "Please enter the First name!!!")]
        [RegularExpression(@"^[A-Za-z]*$", ErrorMessage = " Characters only ,special characters are not  allowed!!")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter the Last name!!!")]
        [RegularExpression(@"^[A-Za-z]*$", ErrorMessage = " Characters only ,special characters are not  allowed!!")]
        public string LastName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }


        [Display(Name = "Address1")]
        [Required(ErrorMessage = "Please enter Address1 !!!")]
        [RegularExpression(@"(^[#.0-9a-zA-Z\s,-]+$)", ErrorMessage = "Enter street name and apt num!!")]

        public string Address1 { get; set; }

        [Display(Name = "Address2")]
        public string Address2 { get; set; }
        [Required(ErrorMessage = "Please enter City !!!")]

        [DisplayName("City")]
        [RegularExpression(@"^[a-zA-Z'.\s]{1,40}$", ErrorMessage = "Numbers and Special Characters not allowed!!")]


        [StringLength(50, ErrorMessage = "Less than 50 characters")]

        public string City { get; set; }

        [Required(ErrorMessage = "Please enter State !!!")]

        [RegularExpression(@"^[a-zA-Z'.\s]{1,40}$", ErrorMessage = "Numbers and Special Characters not allowed!!")]


        [StringLength(50, ErrorMessage = "Less than 50 characters")]

        public string State { get; set; }
        [Required(ErrorMessage = "Please enter Country !!!")]
        [RegularExpression(@"^[a-zA-Z'.\s]{1,40}$", ErrorMessage = "Numbers and Special Characters not allowed!!")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Please Enter Zipcode!!!")]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip!!Required atleast 5 digits!!")]

        [StringLength(10, MinimumLength = 5)]

        public string Zipcode { get; set; }
        [Required(ErrorMessage = "Please Enter Phone No!!!")]

        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Work Contact.Enter 10 digits only!!")]

        [StringLength(10, ErrorMessage = "The Mobile must contains 10 characters", MinimumLength = 10)]

        public string WorkContact { get; set; }


        [Display(Name = "Mobile")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.Enter 10 digits only")]
        [StringLength(10, ErrorMessage = "The Mobile must contains 10 characters", MinimumLength = 10)]

        [Required(ErrorMessage = "Please enter the Mobile Number!!!")]

        public string MobileContact { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter the Email ID!!!")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]


        public string EmailID { get; set; }

        [Display(Name = "Company Name")]
        [Required(ErrorMessage = "Please enter Company Name!!!")]
        public string companyname { get; set; }

        [Display(Name = "Industry")]
        [Required(ErrorMessage = "Please select the Category!!!")]
        public int categoryid { get; set; }

        [Display(Name = "Member Type")]
        [Required(ErrorMessage = "Please select the Member Type!!!")]
        public int RoleID { get; set; }

        [Display(Name = "Sub Category")]
        public int subcategoryid { get; set; }


    }

   
    public partial class jobseekerprofile
    {
        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> highestdegree { get; set; }
        public Nullable<int> Experience { get; set; }
        public int categoryid { get; set; }
        public Nullable<int> subcategoryid { get; set; }
        public string CurrentCompanyName { get; set; }
        public Nullable<int> CurrentSalary { get; set; }
        public string ResumeName { get; set; }
        public System.DateTime createddate { get; set; }
        public System.DateTime modifieddate { get; set; }
        public virtual user user { get; set; }
    }

    
    public class jobseekerMetaData
    {
        public int UserID { get; set; }

        [Display(Name = "Highest Degree")]
        [Required(ErrorMessage = "Please enter the Highest Degree!!!")]
        public int highestdegree { get; set; }
                    
        [Display(Name = "Experience")]
        [Required(ErrorMessage = "Please  enter the Experience!!!")]
        public int Experience { get; set; }

        [Display(Name = "Category Id")]
        [Required(ErrorMessage = "Please enter the category id!!!")]
        public int categoryid { get; set; }

        [Display(Name = "subcategoryid")]
        [Required(ErrorMessage = "Please select the Subcategoryid!!!")]
        public int subcategoryid { get; set; }

        [Display(Name = "Current company name")]
        [Required(ErrorMessage = "Please enter the CompanyName!!!")]
        public string CurrentCompanyName { get; set; }

        [Display(Name = "CurrentSalary")]
        [Required(ErrorMessage = "Please select the Current Salary !!!")]
        public int CurrentSalary { get; set; }

        [Display(Name = "ResumeName")]
        [Required(ErrorMessage = "Please enter the Resume Name!!!")]
        public string ResumeName { get; set; }

    }



}