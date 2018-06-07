using AICPDAL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AICPDAL
{
    public class AICPDAL
    {
         public List<SelectListItem> memberList()
        {
            using (aicpdataEntities db = new aicpdataEntities())
            {
                //Fetching Member Type
                List<SelectListItem> memberList = new List<SelectListItem>();
                foreach (var item in db.roles.ToList())
                {
                    memberList.Add(new SelectListItem() { Text = item.RoleName, Value = item.RoleID.ToString() });
                }
                //ViewBag.MembershipType = memberList;
                return memberList;
            }
        }
        public void GetLoginDetails(string loginName,string pwd)
        {
            using (aicpdataEntities db = new aicpdataEntities())
            {
                var objUseInitials = db.users.Where(x => string.Equals(x.UserName, loginName) && string.Equals(x.Password, pwd)).FirstOrDefault();

                if (objUseInitials != null)
                {
                    var objUserDetails = db.userdetails.Where(x => x.UserID == objUseInitials.UserID).FirstOrDefault();
                    if (objUserDetails != null)
                    {
                        //-------Store Login Information-------
                        HttpContext.Current.Session["AllUserDetails"] = objUserDetails;
                        HttpContext.Current.Session["LoginDetails"] = objUseInitials;

                        //Session["LoginDetails"] = LoginDetails;
                    }
                }
            }
        }
        //public /*JsonResult*/ void GetSubCategory(int catID)
        //{
        //    using (aicpdataEntities db = new aicpdataEntities())
        //    {
        //        var subCategory = db.subcategories.Where(c => c.categoryid == catID).ToList();
        //        SelectList subCategoryList = new SelectList(subCategory, "subcategoryid", "subcategoryname", 0);
        //        return /*Json*/subCategoryList;
        //    }
        //}
        //public void GetUserRegistrationDetails(string Password, int userID)
        //{
        //    UserVM objModel = new UserVM();

        //    using (aicpdataEntities db = new aicpdataEntities())
        //    {

        //        if (Session["queryList"] != null)
        //        {
        //            objModel.queList = (List<securityquestion>)Session["queryList"];
        //        }
        //        else
        //        {
        //            objModel.queList = db.securityquestions.ToList();
        //            Session["queryList"] = objModel.queList;
        //        }

        //        objModel.queList = db.securityquestions.ToList();



        //        objModel.industryList = db.categories.ToList();
        //        objModel.memberTypeList = db.roles.ToList();

                //Fetching Question List
                //List<SelectListItem> queList = new List<SelectListItem>();
                //foreach(var item in db.securityquestions.ToList())
                //{
                //    queList.Add(new SelectListItem() { Text = item.question, Value = item.questionid.ToString() });
                //}
                //ViewBag.QuestionList = queList;

                //Fetching Member Type
                //List<SelectListItem> memberList = new List<SelectListItem>();
                //foreach (var item in db.roles.ToList())
                //{
                //    memberList.Add(new SelectListItem() { Text = item.RoleName, Value = item.RoleID.ToString() });
                //}
                //ViewBag.MemberList = memberList;

                //Fetching IndustryList
                //List<SelectListItem> industryList = new List<SelectListItem>();
                //foreach (var item in db.categories.ToList())
                //{
                //    industryList.Add(new SelectListItem() { Text = item.categoryname, Value = item.categoryid.ToString() });
                //}

                //ViewBag.IndustryList = industryList;
        //    }
        //}

        public List<SelectListItem> queList()
        {
            using (aicpdataEntities db = new aicpdataEntities())
            {
                //Fetching Question List
                List<SelectListItem> queList = new List<SelectListItem>();

               
                foreach (var item in db.securityquestions.ToList())
                {
                    queList.Add(new SelectListItem() { Text = item.question, Value = item.questionid.ToString() });
                }
                //  ViewBag.QuestionList = queList;
                return queList;
            }

        }

        public void GetPasswordDetails(string loginName, string pwd)
        {
            using (aicpdataEntities db = new aicpdataEntities())
            {
                var objUseInitials = db.users.Where(x => string.Equals(x.UserName, loginName) && string.Equals(x.Password, pwd)).FirstOrDefault();

                if (objUseInitials != null)
                {
                    var objUserDetails = db.userdetails.Where(x => x.UserID == objUseInitials.UserID).FirstOrDefault();
                    if (objUserDetails != null)
                    {
                        //-------Store Login Information-------
                        HttpContext.Current.Session["AllUserDetails"] = objUserDetails;
                        HttpContext.Current.Session["LoginDetails"] = objUseInitials;

                        //Session["LoginDetails"] = LoginDetails;
                    }
                }
            }
        }
        //public List<SelectListItem> industryList()
        //{
        //    Fetching IndustryList
        //    List<SelectListItem> industryList = new List<SelectListItem>();
        //    foreach (var item in db.categories.ToList())
        //    {
        //        industryList.Add(new SelectListItem() { Text = item.categoryname, Value = item.categoryid.ToString() });
        //    }
        //    return industryList;
        //    ViewBag.IndustryList = industryList;
        //}

        //public void GetUserProfile()
        //{
        //    using (aicpdataEntities db = new aicpdataEntities())
        //    {
        //        objModel.industryList = db.categories.ToList();
        //        objModel.objUserDetail = db.userdetails.Single(x => x.UserID == userId); //I have wrote Linq query for getting data from database based on userid
        //        objModel.objUserInitials = db.users.Single(x => x.UserID == userId);
        //        objModel.UserID = user;
        //    }
        //}
        //public void PostUserProfileDetail()
        //{
        //    using (aicpdataEntities db = new aicpdataEntities())
        //    {
        //        UserVM objUserVM = new UserVM();

        //        objUserVM.objUserInitials = db.users.Where(x => x.UserID == frmData.UserID).FirstOrDefault();
        //        objUserVM.objUserDetail = db.userdetails.Where(x => x.UserID == frmData.UserID).FirstOrDefault();

        //        objUserVM.objUserDetail.FirstName = frmData.objUserDetail.FirstName;   //fill the data into the ViewModel object
        //        objUserVM.objUserDetail.LastName = frmData.objUserDetail.LastName;
        //        objUserVM.objUserDetail.EmailID = frmData.objUserDetail.EmailID;
        //        objUserVM.objUserDetail.Address1 = frmData.objUserDetail.Address1;
        //        objUserVM.objUserDetail.Address2 = frmData.objUserDetail.Address2;
        //        objUserVM.objUserDetail.City = frmData.objUserDetail.City;
        //        objUserVM.objUserDetail.State = frmData.objUserDetail.State;
        //        objUserVM.objUserDetail.Country = frmData.objUserDetail.Country;
        //        objUserVM.objUserDetail.Zipcode = frmData.objUserDetail.Zipcode;
        //        objUserVM.objUserDetail.WorkContact = frmData.objUserDetail.WorkContact;
        //        objUserVM.objUserDetail.MobileContact = frmData.objUserDetail.MobileContact;
        //        objUserVM.objUserDetail.categoryid = frmData.objUserDetail.categoryid;
        //        objUserVM.objUserDetail.subcategoryid = frmData.objUserDetail.subcategoryid;
        //        objUserVM.objUserInitials.UserName = frmData.objUserInitials.UserName;

        //        db.SaveChanges();


        //    }

        //public void RecoverPassword()
        //    {
        //    using (aicpdataEntities db = new aicpdataEntities())
        //    {
        //        var objUser = db.users.Where(x => x.UserID == /*objModel.*/objUserInitials.UserID /*&& objModel.objUserInitials.IsForgotPassword.HasValue*/).FirstOrDefault();
        //        if (objUser != null)
        //        {
        //            if ((bool)objUser.IsForgotPassword)
        //            {
        //                //    objUser.Password = /*objModel.*/Password;
        //                objUser.IsForgotPassword = false;
        //                db.SaveChanges();
        //                //ViewBag.InfoMessage = "Password has successfully changed.";
        //            }
        //        }
        //    }

        //}




    }
}
