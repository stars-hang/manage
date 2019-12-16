using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HPIT.FL;

namespace HPIT.FL
{
    public class FlowerDAL1
    {
        public List<xinxi> Select()
        {
            Model1 model = new Model1();
            return model.xinxi.ToList();
            
        }


        public int add(xinxi xx)
        {
            Model1 ww = new Model1();
            ww.xinxi.Add(xx);
            return ww.SaveChanges();
        }

    }
}
