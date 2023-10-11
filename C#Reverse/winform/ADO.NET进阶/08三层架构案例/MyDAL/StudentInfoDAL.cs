using MyEntity;
using System.Collections.Generic;
using System.Data;

namespace MyDAL
{
    public class StudentInfoDAL
    {
        #region 新增
        public int Add(StudentInfoEntity studentInfoEntity)
        {
            string sql = "insert into StudentInfo(StuID,StuName,StuAge,StuSex,StuHobby,ProfessionID)\r\nvalues(@StuID,@StuName,@StuAge,@StuSex,@StuHobby,@ProfessionID)";
            DBHelper.PrepareSql(sql);
            DBHelper.SetParameter("StuID", studentInfoEntity.StuID);
            DBHelper.SetParameter("StuName", studentInfoEntity.StuName);
            DBHelper.SetParameter("StuAge", studentInfoEntity.StuAge);
            DBHelper.SetParameter("StuSex", studentInfoEntity.StuSex);
            DBHelper.SetParameter("StuHobby", studentInfoEntity.StuHobby);
            DBHelper.SetParameter("ProfessionID", studentInfoEntity.ProfessionID);
            return DBHelper.ExecNonQuery();
        }
        #endregion
        #region 删除
        public int Delete(string id)
        {
            string sql = "delete from StudentInfo where StuID = @StuID";
            DBHelper.PrepareSql(sql);
            DBHelper.SetParameter("StuID", id);
            return DBHelper.ExecNonQuery();
        }
        #endregion
        #region 修改
        public int Update(StudentInfoEntity studentInfoEntity)
        {
            string sql = "update StudentInfo set StuName = @StuName,StuAge = @StuAge,StuSex = @StuSex,StuHobby = @StuHobby,ProfessionID = @ProfessionID where StuID = @StuID";
            DBHelper.PrepareSql(sql);
            DBHelper.SetParameter("StuName", studentInfoEntity.StuName);
            DBHelper.SetParameter("StuAge", studentInfoEntity.StuAge);
            DBHelper.SetParameter("StuSex", studentInfoEntity.StuSex);
            DBHelper.SetParameter("StuHobby", studentInfoEntity.StuHobby);
            DBHelper.SetParameter("ProfessionID", studentInfoEntity.ProfessionID);
            DBHelper.SetParameter("StuID", studentInfoEntity.StuID);
            return DBHelper.ExecNonQuery();
        }
        #endregion
        #region 列表（所有行）
        public List<StudentInfoEntity> List()
        {
            string sql = "select* from StudentInfo";
            DBHelper.PrepareSql(sql);
            DataTable dataTable = new DataTable();
            dataTable = DBHelper.ExecQuery();
            List<StudentInfoEntity> list = new List<StudentInfoEntity>();
            foreach (DataRow item in dataTable.Rows)
            {
                StudentInfoEntity entity = new StudentInfoEntity();
                entity.StuID = item["StuID"].ToString();
                entity.StuName = item["StuName"].ToString();
                entity.StuAge = int.Parse(item["StuAge"].ToString());
                entity.StuSex = item["StuSex"].ToString();
                entity.StuHobby = item["StuHobby"].ToString();
                entity.ProfessionID = int.Parse(item["ProfessionID"].ToString());
                list.Add(entity);
            }
            return list;
        }
        //根据条件搜索
        public List<StudentInfoEntity> Search(StudentInfoEntity studentInfoEntity)
        {
            string sql = "select* from StudentInfo inner join ProfessionInfo on StudentInfo.ProfessionID = ProfessionInfo.ProfessionID where 1 = 1";
            if (studentInfoEntity.ProfessionID != 0)
                sql += "and StudentInfo.ProfessionID = " + studentInfoEntity.ProfessionID;
            if (!studentInfoEntity.StuName.Equals(""))
                sql += "and StuName like '%" + studentInfoEntity.StuName + "%'";
            DBHelper.PrepareSql(sql);
            DataTable dataTable = new DataTable();
            dataTable = DBHelper.ExecQuery();
            List<StudentInfoEntity> list = new List<StudentInfoEntity>();
            foreach (DataRow item in dataTable.Rows)
            {
                StudentInfoEntity entity = new StudentInfoEntity();
                entity.StuID = item["StuID"].ToString();
                entity.StuName = item["StuName"].ToString();
                entity.StuAge = int.Parse(item["StuAge"].ToString());
                entity.StuSex = item["StuSex"].ToString();
                entity.StuHobby = item["StuHobby"].ToString();
                entity.ProfessionID = int.Parse(item["ProfessionID"].ToString());
                entity.ProfessionName = item["ProfessionName"].ToString();
                list.Add(entity);
            }
            return list;
        }
        #endregion
        #region 详情(某一行)
        public StudentInfoEntity Detail(string id)
        {
            string sql = "select* from StudentInfo where StuID = @StuID";
            DBHelper.PrepareSql(sql);
            DBHelper.SetParameter("StuID", id);
            DataTable dataTable = new DataTable();
            dataTable = DBHelper.ExecQuery();
            if (dataTable.Rows.Count == 0)
                return null;
            StudentInfoEntity entity = new StudentInfoEntity();
            entity.StuID = dataTable.Rows[0]["StuID"].ToString();
            entity.StuName = dataTable.Rows[0]["StuName"].ToString();
            entity.StuAge = int.Parse(dataTable.Rows[0]["StuAge"].ToString());
            entity.StuSex = dataTable.Rows[0]["StuSex"].ToString();
            entity.StuHobby = dataTable.Rows[0]["StuHobby"].ToString();
            entity.ProfessionID = int.Parse(dataTable.Rows[0]["ProfessionID"].ToString());
            return entity;
        }
        #endregion
    }
}
