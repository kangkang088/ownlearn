using System.Collections.Generic;
using System.Data;
using Utility;
namespace Models {
    public class UserAppraisalBases {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Sex { get; set; }
        public int BaseTypeId { get; set; }
        public string BaseType { get; set; }
        public int AppraisalBase { get; set; }
        public bool IsDel { get; set; }
        public static List<UserAppraisalBases> GetListJoinAppraisal() {
            DataTable appraisal = SqlHelper.ExcuteTable("select u.Id,u.UserName,u.Sex,u.BaseTypeId,u.IsDel,a.AppraisalBase,a.BaseType from Users u left join AppraisalBases a on u.BaseTypeId = a.Id");
            List<UserAppraisalBases> userAppraisalBases = new List<UserAppraisalBases>();
            foreach (DataRow dataRow in appraisal.Rows) { 
                userAppraisalBases.Add(dataRow.DataRowToModel<UserAppraisalBases>());
            }
            return userAppraisalBases;
        }
        //private static UserAppraisalBases ToModel(DataRow dr) { 
        //    UserAppraisalBases userAppraisalBases = new UserAppraisalBases();
        //    userAppraisalBases.Id = (int)dr["Id"];
        //    userAppraisalBases.UserName = dr["UserName"].ToString();
        //    userAppraisalBases.Sex = dr["Sex"].ToString();
        //    userAppraisalBases.BaseTypeId = (int)dr["BaseTypeId"];
        //    userAppraisalBases.BaseType = dr["BaseType"].ToString();
        //    userAppraisalBases.AppraisalBase = (int)dr["AppraisalBase"];
        //    userAppraisalBases.IsDel = (bool)dr["IsDel"];
        //    return userAppraisalBases;
        //}
    }
}
