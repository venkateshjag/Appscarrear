using AICPDAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.UI.WebControls;
//using AICPDAL.ViewModel;
//using AICPJOBPORTAL.ViewModel;
namespace AICPDAL
{
    public class UserProfileDAL
    {

        public List<securityquestion> SecurityQuestionList()
        {
            using (aicpdataEntities db = new aicpdataEntities())
            {
                //Fetching Question List
                //List<SelectListItem> queList = new List<SelectListItem>();


                //foreach (var item in db.securityquestions.ToList())
                //{
                //    queList.Add(new SelectListItem() { Text = item.question, Value = item.questionid.ToString() });
                //}
                ////  ViewBag.QuestionList = queList;
                //return queList;
                return db.securityquestions.ToList();
            }

        }
        public List<category> IndustryList()
        {
            using (aicpdataEntities db = new aicpdataEntities())
            {
                //Fetching Question List
                //List<SelectListItem> queList = new List<SelectListItem>();


                //foreach (var item in db.securityquestions.ToList())
                //{
                //    queList.Add(new SelectListItem() { Text = item.question, Value = item.questionid.ToString() });
                //}
                ////  ViewBag.QuestionList = queList;
                //return queList;
                return db.categories.ToList();
            }

        }
        public List<role> memberTypeList()
        {
            using (aicpdataEntities db = new aicpdataEntities())
            {
                //Fetching Question List
                //List<SelectListItem> queList = new List<SelectListItem>();


                //foreach (var item in db.securityquestions.ToList())
                //{
                //    queList.Add(new SelectListItem() { Text = item.question, Value = item.questionid.ToString() });
                //}
                ////  ViewBag.QuestionList = queList;
                //return queList;
                return db.roles.ToList();
            }

        }
        //public List<JobSearch> searchData()
        //{
        //    using (aicpdataEntities db = new aicpdataEntities())
        //    {
        //        return searchData;
        //    }
           
        //}
        public user FetchUserData(string usrName, int questid, int quest2id, int quest3id, string hintan1, string hintan2, string hintan3)

        {
            using (aicpdataEntities db = new aicpdataEntities())
            {
                var userData = db.users.Where(x => string.Equals(x.UserName, usrName) && x.questionid == questid /*&& string.Equals(x.hintanswer, hintan1) && x.hintquestion2id == quest2id && string.Equals(x.hintanswer, hintan2) && x.hintquestion3id == quest3id && string.Equals(x.hintanswer, hintan3)*/).FirstOrDefault();
                return userData;
            }
        }


        public void saveforgotpasswordattribute(string userName, int questionid, int question2id, int question3id, string hintanswer1, string hintanswer2, string hintanswer3)

        {
            using (aicpdataEntities db = new aicpdataEntities())
            {


                var userData = db.users.Where(x => string.Equals(x.UserName, userName) && x.questionid == questionid /*&& x.hintquestion2id == question2id && x.hintquestion3id == question3id && string.Equals(x.hintanswer, hintanswer1) && string.Equals(x.hintanswer, hintanswer2) && string.Equals(x.hintanswer, hintanswer3)*/).FirstOrDefault();

                userData.IsForgotPassword = true;

                db.SaveChanges();
            }
        }
        public userdetail FetchUserdetailsData(user userData, int UserID)

        {
            using (aicpdataEntities db = new aicpdataEntities())
            {
                var userDetailData = db.userdetails.Where(x => x.UserID == userData.UserID).FirstOrDefault();
                return userDetailData;
            }
        }
        public user RecoverData(int id)

        {
            using (aicpdataEntities db = new aicpdataEntities())
            {
                //var data = db.userdetails.Where(x => x.UserID == id).FirstOrDefault();
                var data = db.users.Where( x=> x.UserID == id).FirstOrDefault();
                //objModel.objUserInitials.UserName = data.FirstName + " " + (!string.IsNullOrEmpty(data.MiddleName) ? data.MiddleName : string.Empty) + " " + data.LastName;
                return data;

            }
        }
        public void RecoverDataattribute(string password, int id)

        {
            using (aicpdataEntities db = new aicpdataEntities())
            {
                var data = db.users.Where(x => x.UserID == id).FirstOrDefault();
                data.Password = password;
                // var data1 = db.users.Where(x => string.Equals(x.Password, password) && x.Password == confirmpassword).FirstOrDefault();

                //   var data1=  db.users.Where(x => (x.Password.Equals(password) && x.Password.Equals(confirmpassword))).FirstOrDefault();
                //var usres = db.users;
                //var test2 = db.users.FirstOrDefault();
                //var test1 = db.users.FirstOrDefault(x => x.Password == password);
                //var data1=   db.users.FirstOrDefault(x => x.Password == password && x.Password == confirmpassword) ;
               // db.users.Add(data1);
              //objModel.objUserInitials.UserName = data.FirstName + " " + (!string.IsNullOrEmpty(data.MiddleName) ? data.MiddleName : string.Empty) + " " + data.LastName;
              // return data;
              //  data.IsForgotPassword = true;
              //   db.Entry(password).CurrentValues.SetValues(confirmpassword);
                db.SaveChanges();
            }
        }
        public userdetail EditReg(int userId)
        {

            using (aicpdataEntities db = new aicpdataEntities())
            {
                var editp= db.userdetails.Where(x => x.UserID == userId).FirstOrDefault(); //I have wrote Linq query for getting data from database based on userid

                //  var objUserInitials1 = db.users.Where(x => x.UserID == userId);


                //  var UserID = userId;

                return editp;
            //   db.SaveChanges();
            }
        }
        public void editprofileDAL(int id,string firstname,string lastname,string middlename,string emailid,string address1, string address2, string city, string state, string cntry)

        {
            using (aicpdataEntities db = new aicpdataEntities())
            {
                var data = db.userdetails.Where(x => x.UserID == id).FirstOrDefault();
                data.FirstName = firstname;
                data.LastName = lastname;
                data.MiddleName = middlename;
                data.EmailID = emailid;
                //data.Zipcode = Convert.ToInt32(zipcode);
                //data.MobileContact =Convert.ToInt32( mcontact);
                data.Address1 = address1;
                data.Address2 = address2;
                data.City = city;
                data.State = state;
                data.Country = cntry;
                //data.WorkContact = wcontact;
                //data.category = catgory;
                //data.subcategory = scategory;
                   

                // data.Password = password;
                // var data1 = db.users.Where(x => string.Equals(x.Password, password) && x.Password == confirmpassword).FirstOrDefault();

                // var data1=  db.users.Where(x => (x.Password.Equals(password) && x.Password.Equals(confirmpassword))).FirstOrDefault();
                //var usres = db.users;
                //var test2 = db.users.FirstOrDefault();
                //var test1 = db.users.FirstOrDefault(x => x.Password == password);
                //var data1=   db.users.FirstOrDefault(x => x.Password == password && x.Password == confirmpassword) ;
                // db.users.Add(data1);
                //objModel.objUserInitials.UserName = data.FirstName + " " + (!string.IsNullOrEmpty(data.MiddleName) ? data.MiddleName : string.Empty) + " " + data.LastName;
                // return data;
                //  data.IsForgotPassword = true;
                //   db.Entry(password).CurrentValues.SetValues(confirmpassword);
                db.SaveChanges();
            }
        }
        public SelectList GetSubCategory(int catID)
        {
            //using (aicpdataEntities db = new aicpdataEntities())
            //{
            //    //    //            var subCategory = db.subcategories.Where(c => c.categoryid == catID).ToList();
            //    //    //SelectList subCategoryList = new SelectList(subCategory, "subcategoryid", "subcategoryname", 0);
            //    //    //            return Json(subCategoryList);

            //    //    return db.subcategories.ToList();
            //    //}
            //    //using (aicpdataEntities db = new aicpdataEntities())
            //    //{
            //    //    var subCategory = db.subcategories.Where(c => c.categoryid == catID).ToList();
            //    //    SelectList subCategoryList = new SelectList(subCategory, "subcategoryid", "subcategoryname", 0);

            //    return db.subcategories.ToList();

            //}


            using (aicpdataEntities db = new aicpdataEntities())
            {
                var subCategory = db.subcategories.Where(c => c.categoryid == catID).ToList();
                SelectList subCategoryList = new SelectList(subCategory, "subcategoryid", "subcategoryname", 0);
                return subCategoryList;
            }
        }


        public void CreateNewUser(userdetail userDetail, user user)
        {
            // string resultMessage = "successfully created user record";

            // var x = (AICPDAL.ViewModel.UserVM) userDetails;

            //var userInformation = userDetails;

            using (aicpdataEntities db = new aicpdataEntities())
            {

                //user userInfoNew = new user();

                //userInfo.UserID = user.UserID;
                //userInfoNew.UserName = user.UserName;
                //userInfoNew.Password = user.Password;
                //userInfoNew.questionid = user.questionid;
                //userInfoNew.hintanswer = user.hintanswer;
                //userInfoNew.createddate = System.DateTime.Now;
                //userInfoNew.modifieddate = System.DateTime.Now;
                //userInfoNew.IsForgotPassword = false;
                //userInfoNew.hintquestion2id = user.hintquestion2id;
                //userInfoNew.hintanswer2 = user.hintanswer2;
                //userInfoNew.hintquestion3id = user.hintquestion3id;
                //userInfoNew.hintanswer3 = user.hintanswer3;
                //userInfoNew.UserName = user.UserName;

                db.users.Add(user);
                db.SaveChanges();

                userDetail.UserID = user.UserID;

                //userdetail userDetailInfo = new userdetail();
                //userDetailInfo.UserID = user.UserID;
                //userDetailInfo.Address1 = userDetail.Address1;
                //userDetailInfo.Address2 = userDetail.Address2;
                //// userDetail.category = "software";
                //userDetailInfo.categoryid = userDetail.categoryid;
                //userDetailInfo.City = userDetail.City;
                //userDetailInfo.companyname = userDetail.companyname;
                //userDetailInfo.Country = userDetail.Country;
                //userDetailInfo.createddate = System.DateTime.Now;
                //userDetailInfo.EmailID = userDetail.EmailID;
                //userDetailInfo.FirstName = userDetail.FirstName;
                //userDetailInfo.LastName = userDetail.LastName;
                //userDetailInfo.MiddleName = userDetail.MiddleName;
                //userDetailInfo.MobileContact = userDetail.MobileContact;
                //userDetailInfo.State = userDetail.State;
                //userDetailInfo.subcategoryid = userDetail.subcategoryid;
                //userDetailInfo.Zipcode = userDetail.Zipcode;
                //userDetailInfo.WorkContact = userDetail.WorkContact;
                //userDetailInfo.MobileContact = userDetail.MobileContact;
                //  userDetail.FirstName = userDetails.

                db.userdetails.Add(userDetail);
                db.SaveChanges();
            }

            //    public SelectList GetResumeGuideLines()
            //{

            //    using (aicpdataEntities db = new aicpdataEntities())
            //    {
            //        var guidelines = db.resumeguidelines.Select(x => x.Guideline).ToList();
            //        //ViewBag.ResumeGuideLines = guidelines;
            //        return guidelines;
            //    }


        }


    }



}

