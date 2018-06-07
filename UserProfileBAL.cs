using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AICPDAL;
using AICPJOBPORTAL.ViewModel;
using System.Web.Mvc;


namespace AICPBAL
{
    public class UserProfileBAL
    {
        //public bool SaveUserRegistration(userdetail objUserDetail, user objUser)
        //{
        //    try
        //    {
        //        using (aicpdataEntities db = new aicpdataEntities())
        //        {
        //            db.users.Add(objUser);
        //            db.SaveChanges();
        //            int userID = objUser.UserID;

        //            objUserDetail.UserID = userID;
        //            db.userdetails.Add(objUserDetail);
        //            db.SaveChanges();
        //            //return RedirectToAction("Index", "Home");
        //            return true;
        //        }
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        public List<SelectListItem> SecurityQuestionList()
        {
            AICPDAL.UserProfileDAL DAL = new AICPDAL.UserProfileDAL();

            UserVM finalsecurityquestionlist = new UserVM();
            //  x.queList =  DAL.SecurityQuestionList();
            var securityquestionlist = DAL.SecurityQuestionList();

            foreach (var item in securityquestionlist.ToList())
            {
                finalsecurityquestionlist.queList.Add(new SelectListItem() { Text = item.question, Value = item.questionid.ToString() });
            }

            return finalsecurityquestionlist.queList;

        }
        public List<SelectListItem> IndustryList()
        {
            AICPDAL.UserProfileDAL DAL = new AICPDAL.UserProfileDAL();
            UserVM finalindustrylist = new UserVM();
            //  x.queList =  DAL.SecurityQuestionList();
            var industrylist = DAL.IndustryList();

            foreach (var item in industrylist.ToList())
            {
                finalindustrylist.industrList.Add(new SelectListItem() { Text = item.categoryname, Value = item.categoryid.ToString() });
            }

            return finalindustrylist.industrList;

        }
        public List<SelectListItem> MemberTypeList()
        {
            AICPDAL.UserProfileDAL DAL = new AICPDAL.UserProfileDAL();
            UserVM finalmemberlist = new UserVM();
            //  x.queList =  DAL.SecurityQuestionList();
            var memlist = DAL.memberTypeList();

            foreach (var item in memlist.ToList())
            {
                finalmemberlist.memberList.Add(new SelectListItem() { Text = item.RoleName, Value = item.RoleID.ToString() });
            }

            return finalmemberlist.memberList;

        }
        public SelectList GetSubCategory(int catID)
        {
            AICPDAL.UserProfileDAL DAL = new AICPDAL.UserProfileDAL();

            return DAL.GetSubCategory(catID);
        }
       

        //public List<SelectListItem> ()
        //{
        //    AICPDAL.UserProfileDAL DAL = new AICPDAL.UserProfileDAL();
        //    UserVM finalmemberlist = new UserVM();
        //    //  x.queList =  DAL.SecurityQuestionList();
        //    var memlist = DAL.memberTypeList();

        //    foreach (var item in memlist.ToList())
        //    {
        //        finalmemberlist.memberList.Add(new SelectListItem() { Text = item.RoleName, Value = item.RoleID.ToString() });
        //    }

        //    return finalmemberlist.memberList;




           
        //        var jobData = db.jobs.Where(x => x.jobname.Contains(keyword) && x.Location.Contains(location)).ToList();
        //        foreach (var item in jobData)
        //        {
        //            searchData.Add(new JobSearch() { JobName = item.jobname, Company = item.company, Location = item.Location });
        //        }
           
        //}


        public void CreateNewUser(AICPJOBPORTAL.ViewModel.UserVM UserInformation)
        {

            // string replyMessage = "Error occured While Creating the User";

            AICPDAL.UserProfileDAL DAL = new AICPDAL.UserProfileDAL();

            AICPDAL.userdetail objUserDetail = new AICPDAL.userdetail();
            AICPDAL.user objUser = new AICPDAL.user();

            PropertyCopier.Copy(UserInformation.objUserDetail, objUserDetail);
            PropertyCopier.Copy(UserInformation.objUserInitials, objUser);
            objUser.Password = UserInformation.Password;


            DAL.CreateNewUser(objUserDetail, objUser);

        }
        public AICPDAL.user FetchUserDataBAL(string uName, int quesid, int ques2id, int ques3id, string hintans1, string hintans2, string hintans3)
           {
            AICPDAL.UserProfileDAL DAL = new AICPDAL.UserProfileDAL();
            var userData = DAL.FetchUserData(uName, quesid, ques2id, ques3id, hintans1, hintans2, hintans3);
            return userData;
        }

        public void saveforgotpasswordattribute(string userName, int questionid, int question2id, int question3id, string hintanswer1, string hintanswer2, string hintanswer3)
        {


            AICPDAL.UserProfileDAL DAL = new AICPDAL.UserProfileDAL();
            DAL.saveforgotpasswordattribute(userName, questionid, question2id, question3id, hintanswer1, hintanswer2, hintanswer3);

        }
        public AICPDAL.userdetail FetchUserdetailsDataBAL(AICPDAL.user userData, int UserID)
        {


            AICPDAL.UserProfileDAL DAL = new AICPDAL.UserProfileDAL();
            var userDetailData = DAL.FetchUserdetailsData(userData, UserID);
            return userDetailData;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public AICPDAL.user RecoverUserIDBAL(int id)
        {
            AICPDAL.UserProfileDAL DAL = new AICPDAL.UserProfileDAL();
            var userData = DAL.RecoverData(id);
            return userData;
        }
        public AICPDAL.userdetail EditUserIDBAL(int userid)
        {
            AICPDAL.UserProfileDAL DAL = new UserProfileDAL();
            var editdata= DAL.EditReg(userid);
            return editdata;
        }
        public void saverecoverpasswordattribute(string password, int id)
        {
            AICPDAL.UserProfileDAL DAL = new AICPDAL.UserProfileDAL();

          
             DAL.RecoverDataattribute(password, id);
            //return reset; 
        }

        public void edituserprofileBAL(int id, string firstname, string lastname, string middlename, string emailid, string address1, string address2, string city, string state, string cntry)
        {
            AICPDAL.UserProfileDAL DAL = new AICPDAL.UserProfileDAL();


            DAL.editprofileDAL(  id,firstname, lastname, middlename, emailid, address1, address2,  city,  state,  cntry);
            //return reset; 
        }

        public class PropertyCopier
        {
            public static void Copy(object parent, object child)
            {
                var parentProperties = parent.GetType().GetProperties();
                var childProperties = child.GetType().GetProperties();
                foreach (var parentProperty in parentProperties)
                {
                    foreach (var childProperty in childProperties)
                    {
                        if (parentProperty.Name == childProperty.Name && parentProperty.PropertyType == childProperty.PropertyType)
                        {
                            childProperty.SetValue(child, parentProperty.GetValue(parent));
                            break;
                        }
                    }
                }
            }
        }

      
    }
}
