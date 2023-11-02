using Appraisal_System.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appraisal_System.Models
{
    public class UserAppraisalBases
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Sex { get; set; }
        public int BaseTypeId { get; set; }
        public string BaseType { get; set; }
        public int AppraisalBase { get; set; }
        public bool IsDel { get; set; }

        public static DataTable GetDtJoinAppraisal()
        {
            DataTable dt = SqlHelper.ExecuteTable("SELECT u.Id,u.UserName,u.Sex,u.BaseTypeId,u.IsDel,a.AppraisalBase,a.BaseType  FROM Users u LEFT JOIN AppraisalBases a ON u.BaseTypeId = a.Id");
            return dt;
        }

        public static List<UserAppraisalBases> GetListJoinAppraisal() {
            List<UserAppraisalBases> userAppraisalBases = new List<UserAppraisalBases>();
            DataTable dt = GetDtJoinAppraisal();
            foreach (DataRow dr in dt.Rows)
            {
                userAppraisalBases.Add(ToModel(dr));
            }
            return userAppraisalBases;
        }
        private static UserAppraisalBases ToModel(DataRow dr) {
            UserAppraisalBases userAppraisalBase = new UserAppraisalBases();
            userAppraisalBase.Id = (int)dr["Id"];
            userAppraisalBase.UserName = dr["UserName"].ToString();
            userAppraisalBase.Sex = dr["Sex"].ToString();
            userAppraisalBase.BaseTypeId = (int)dr["BaseTypeId"];
            userAppraisalBase.BaseType = dr["BaseType"].ToString();
            userAppraisalBase.AppraisalBase = (int)dr["AppraisalBase"];
            userAppraisalBase.IsDel = (bool)dr["IsDel"];
            return userAppraisalBase;
        }
    }
}
