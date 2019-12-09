using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZH.Dal
{
    public class Commdal
    {
        /// <summary>
        /// 全部查询
        /// </summary>
        /// <returns></returns>
        public static List<CG_Commodity> sel()
        {
            Model1 db = new Model1();
            List<CG_Commodity> list = db.CG_Commodity.ToList();
            return list;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="com"></param>
        /// <returns></returns>
        public static int ins(CG_Commodity com)
        {
            Model1 db = new Model1();
            db.CG_Commodity.Add(com);
            return db.SaveChanges();
        }
            /// <summary>
            /// 根据ID查询
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
        public static CG_Commodity selid(int id)
        {
            Model1 db = new Model1();
            return db.CG_Commodity.FirstOrDefault(q => q.ComID == id);
         
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="com"></param>
        /// <returns></returns>
        public static int up(CG_Commodity com)
        {
            Model1 db = new Model1();
            db.Entry(com).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
