using Bootcamp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bootcamp2.Models;

namespace Bootcamp2.Application
{
    public class SellController : ISell
    {
        MyContext myContext = new MyContext();
        bool status = false;

        public bool DeleteSell(int id)
        {
            throw new NotImplementedException();
        }

        public List<TB_M_Sell> Get()
        {
            var get = myContext.TB_M_Sell.Where(x => x.IsDelete == false).ToList();
            foreach (var list in get)
            {
                Console.WriteLine("ID" + "\t \t :" + list.Id);
                Console.WriteLine("Order Date" + "\t \t :" + list.OrderDate);
                Console.WriteLine();
            }
            return get;
        }

        public bool Insert(TB_M_Sell sell)
        {
            myContext.TB_M_Sell.Add(sell);
            return status;
        }

        public bool Update(int id, TB_M_Sell sell)
        {
            throw new NotImplementedException();
        }
    }
}
