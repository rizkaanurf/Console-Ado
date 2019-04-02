using Bootcamp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp2
{
    public interface ISupplier
    {
        List<TB_M_Suppliers> Get();
        //Supplier Get(int id);
        bool Insert(TB_M_Suppliers supplier);
        bool Update(int id, TB_M_Suppliers supplier);
        bool DeleteSupplier(int id);
    }
}
