using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEntity;

namespace MyDAL
{
    public class ProfessionInfoDAL
    {
        #region 新增
        public int Add(ProfessionInfoEntity professionInfoEntity)
        {
            string sql = "insert into ProfessionInfo(ProfessionName) values(@ProfessionName)";
            DBHelper.PrepareSql(sql);
            DBHelper.SetParameter("ProfessionName", professionInfoEntity.ProfessionName);
            return DBHelper.ExecNonQuery();
        }
        #endregion
        #region 删除
        public int Delete(int id)
        {
            string sql = "delete from ProfessionInfo where ProfessionID = @ProfessionID";
            DBHelper.PrepareSql(sql);
            DBHelper.SetParameter("ProfessionID", id);
            return DBHelper.ExecNonQuery();
        }
        #endregion
        #region 修改
        public int Update(ProfessionInfoEntity professionInfoEntity)
        {
            string sql = "update ProfessionInfo set ProfessionName = @ProfessionName where ProfessionID = @ProfessionID";
            DBHelper.PrepareSql(sql);
            DBHelper.SetParameter("ProfessionName", professionInfoEntity.ProfessionInfoID);
            DBHelper.SetParameter("ProfessionID", professionInfoEntity.ProfessionInfoID);
            return DBHelper.ExecNonQuery();
        }
        #endregion
        #region 列表（所有行）
        public List<ProfessionInfoEntity> List() 
        {
            string sql = "select* from ProfessionInfo";
            DBHelper.PrepareSql(sql);
            DataTable dataTable = new DataTable();
            dataTable = DBHelper.ExecQuery();
            List<ProfessionInfoEntity> list = new List<ProfessionInfoEntity>();
            foreach (DataRow item in dataTable.Rows) 
            {
                ProfessionInfoEntity entity = new ProfessionInfoEntity();
                entity.ProfessionInfoID = int.Parse(item["ProfessionID"].ToString());
                entity.ProfessionName = item["ProfessionName"].ToString();
                list.Add(entity);
            }
            return list;
        }
        #endregion
        #region 详情(某一行)
        public ProfessionInfoEntity Detail(int id) 
        {
            string sql = "select* from ProfessionInfo where ProfessionID = @ProfessionID";
            DBHelper.PrepareSql(sql);
            DBHelper.SetParameter("ProfessionID", id);
            DataTable dataTable = new DataTable();
            dataTable = DBHelper.ExecQuery();
            if (dataTable.Rows.Count == 0)            
                return null; 
            ProfessionInfoEntity entity = new ProfessionInfoEntity();
            entity.ProfessionInfoID = int.Parse(dataTable.Rows[0]["ProfessionID"].ToString());
            entity.ProfessionName = dataTable.Rows[0]["ProfessionName"].ToString();
            return entity;
        }
        #endregion
    }
}
