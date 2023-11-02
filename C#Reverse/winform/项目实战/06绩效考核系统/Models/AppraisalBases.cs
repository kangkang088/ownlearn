using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Models {
    public class AppraisalBases {
        public int Id { get; set; }
        public string BaseType { get; set; }
        public int AppraisalBase { get; set; }
        public bool IsDel { get; set; }

        public static List<AppraisalBases> ListAll() {
            List<AppraisalBases> appraisalBases = new List<AppraisalBases>();
            DataTable dataTable = SqlHelper.ExcuteTable("select* from AppraisalBases");
            foreach (DataRow row in dataTable.Rows) {
                 appraisalBases.Add(row.DataRowToModel<AppraisalBases>());
            }
            return appraisalBases;

        }
        public static int Update(AppraisalBases appraisalBases) {
            int rows = SqlHelper.ExcuteNonQuery("update AppraisalBases set @BaseType = BaseType,@AppraisalBase = AppraisalBase,@IsDel = IsDel where @Id = Id", new System.Data.SqlClient.SqlParameter("@BaseType", appraisalBases.BaseType),
                new System.Data.SqlClient.SqlParameter("@AppraisalBase", appraisalBases.AppraisalBase),
                new System.Data.SqlClient.SqlParameter("@IsDel", appraisalBases.IsDel),
                new System.Data.SqlClient.SqlParameter("@Id", appraisalBases.Id)
                );
            return rows;
        }
        //private static AppraisalBases ToModel(DataRow dr) { 
        //    AppraisalBases appraisalBases = new AppraisalBases();
        //    appraisalBases.Id = (int)dr["Id"];
        //    appraisalBases.BaseType = dr["BaseType"].ToString();
        //    appraisalBases.AppraisalBase = (int)dr["AppraisalBase"];
        //    appraisalBases.IsDel = (bool)dr["IsDel"];
        //    return appraisalBases;
        //}
    }
}
