using HPIT.Data.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZH.Dal
{
    public class comfendal
    {
        public static comfendal Instance = new comfendal();

        public Model1 model { get; set; }

        public comfendal()
        {
            this.model = new Model1();
        }

        public object GetPageData(SearchModel<CG_Commodity> search, out int count)
        {
            GetPageListParameter<CG_Commodity, int> parameter = new GetPageListParameter<CG_Commodity, int>();
            parameter.isAsc = true;
            parameter.orderByLambda = t => t.ComID;
            parameter.pageIndex = search.PageIndex;
            parameter.pageSize = search.PageSize;
            parameter.whereLambda = t => t.ComID != 0;
            Model1 Instance = new Model1();
            DBBaseService baseService = new DBBaseService(Instance);
            List<CG_Commodity> list = baseService.GetSimplePagedData<CG_Commodity, int>(parameter, out count);
            return list;
        }

    }
}
