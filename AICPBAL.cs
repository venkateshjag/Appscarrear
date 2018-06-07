using System.Collections.Generic;
using System.Web.Mvc;

namespace AICPBAL
{
    public class AICPJOBPORTALBAL
    {
        public List<SelectListItem> GetMemberList()
        {
            AICPDAL.AICPDAL DAL = new AICPDAL.AICPDAL();  // created reference for DAL 

          return  DAL.memberList();
            
        }
        public void GetLoginDetails(string loginName, string pwd)
        {
            AICPDAL.AICPDAL DAL = new AICPDAL.AICPDAL();
            DAL.GetLoginDetails(loginName,pwd);
        }

        public List<SelectListItem> GetqueList()
        {
            AICPDAL.AICPDAL DAL = new AICPDAL.AICPDAL();
            return DAL.queList();
        }
        //public List<SelectListItem> GetindustryList()
        //{
        //    AICPDAL.AICPDAL DAL = new AICPDAL.AICPDAL();
        //    return DAL.queList();
        //}
      
    }
}
