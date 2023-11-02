using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Models {
    public class Users {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Sex { get; set; }
        public int BaseTypeId { get; set; }
        public bool IsDel { get; set; }
        public static List<Users> ListAll() {
            List<Users> appraisalBases = new List<Users>();
            DataTable dataTable = SqlHelper.ExcuteTable("select u.Id,u.Password,u.BaseTypeId,u.UserName,u.Sex,u.IsDel from Users u");
            foreach (DataRow row in dataTable.Rows) {
                appraisalBases.Add(row.DataRowToModel<Users>());
            }
            return appraisalBases;
        }
        public static int Insert(Users users) {
            int rows = SqlHelper.ExcuteNonQuery("insert into Users(UserName,Password,Sex,BaseTypeId,IsDel) values(@UserName,@Password,@Sex,@BaseTypeId,@IsDel)", new System.Data.SqlClient.SqlParameter("@UserName", users.UserName),
                new System.Data.SqlClient.SqlParameter("@Password", users.Password),
                new System.Data.SqlClient.SqlParameter("@Sex", users.Sex),
                new System.Data.SqlClient.SqlParameter("@BaseTypeId", users.BaseTypeId),
                new System.Data.SqlClient.SqlParameter("@IsDel", users.IsDel)
                );
            return rows;
        }
        public static int Update(Users users) {
            int rows = SqlHelper.ExcuteNonQuery("update Users set @UserName = UserName,@Password = Password,@Sex = Sex,@BaseTypeId = BaseTypeId,@IsDel = IsDel where @Id = Id", new System.Data.SqlClient.SqlParameter("@UserName", users.UserName),
                new System.Data.SqlClient.SqlParameter("@Password", users.Password),
                new System.Data.SqlClient.SqlParameter("@Sex", users.Sex),
                new System.Data.SqlClient.SqlParameter("@BaseTypeId", users.BaseTypeId),
                new System.Data.SqlClient.SqlParameter("@IsDel", users.IsDel),
                new System.Data.SqlClient.SqlParameter("@Id", users.Id)
                );
            return rows;
        }
    }
}
