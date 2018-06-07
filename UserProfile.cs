using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AICPDAL;

namespace AICPBAL
{
    public class UserProfile
    {
        public bool SaveUserRegistration(userdetail objUserDetail, user objUser)
        {
            try
            {
                using (aicpdataEntities db = new aicpdataEntities())
                {
                    db.users.Add(objUser);
                    db.SaveChanges();
                    int userID = objUser.UserID;

                    objUserDetail.UserID = userID;
                    db.userdetails.Add(objUserDetail);
                    db.SaveChanges();
                    //return RedirectToAction("Index", "Home");
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
