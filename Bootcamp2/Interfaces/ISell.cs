using Bootcamp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp2.Interfaces
{
    public interface ISell
    {
        List<TB_M_Sell> Get();
        //Supplier Get(int id);
        bool Insert(TB_M_Sell sell);
        bool Update(int id, TB_M_Sell sell);
       bool DeleteSell(int id);
    }
}
