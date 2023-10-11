using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDAL;
using MyEntity;

namespace MyBLL
{
    public class ProfessionBLL
    {
        ProfessionInfoDAL dAL = new ProfessionInfoDAL();
        #region 新增
        public int Add(ProfessionInfoEntity professionInfoEntity)
        {
            return dAL.Add(professionInfoEntity);
        }
        #endregion
        #region 删除
        public int Delete(int id)
        {
            return dAL.Delete(id);
        }
        #endregion
        #region 修改
        public int Update(ProfessionInfoEntity professionInfoEntity)
        {
           return dAL.Update(professionInfoEntity);
        }
        #endregion
        #region 列表（所有行）
        public List<ProfessionInfoEntity> List()
        {
            return dAL.List();
        }
        #endregion
        #region 详情(某一行)
        public ProfessionInfoEntity Detail(int id)
        {
            return dAL.Detail(id);
        }
        #endregion
    }
}
