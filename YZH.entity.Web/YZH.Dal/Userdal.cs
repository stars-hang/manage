using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZH.Dal
{
    public class Userdal
    {
        public static List<UserS> sel()
        {
            Model1 db = new Model1();
            List<UserS> list = db.UserS.ToList();
            return list;
        }

        public static int ins(UserS use)
        {
            Model1 db = new Model1();
            db.UserS.Add(use);
            return db.SaveChanges();
        }

        public static List<CG_Mbwt> sele()
        {
            Model1 db = new Model1();
            return db.CG_Mbwt.ToList();
        }
    }
}
