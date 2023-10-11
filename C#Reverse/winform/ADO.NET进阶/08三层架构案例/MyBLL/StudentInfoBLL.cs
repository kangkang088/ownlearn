using MyDAL;
using MyEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBLL
{
    public class StudentInfoBLL
    {
        StudentInfoDAL dAL = new StudentInfoDAL();
        #region 新增
        public int Add(StudentInfoEntity studentInfoEntity)
        {
            return dAL.Add(studentInfoEntity);
        }
        #endregion
        #region 删除
        public int Delete(string id)
        {
            return dAL.Delete(id);
        }
        #endregion
        #region 修改
        public int Update(StudentInfoEntity studentInfoEntity)
        {
            return dAL.Update(studentInfoEntity);
        }
        #endregion
        #region 列表（所有行）
        public List<StudentInfoEntity> List()
        {
            return dAL.List();
        }
        //根据条件搜索
        public List<StudentInfoEntity> Search(StudentInfoEntity studentInfoEntity)
        {
            return dAL.Search(studentInfoEntity);
        }
        #endregion
        #region 详情(某一行)
        public StudentInfoEntity Detail(string id)
        {
            return dAL.Detail(id);
        }
        #endregion
    }
}
