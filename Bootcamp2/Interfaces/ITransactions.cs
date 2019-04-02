using Bootcamp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp2.Interfaces
{
    public interface ITransactions
    {
        List<TB_T_TransactionItems> Get();
        //Supplier Get(int id);
        bool Insert(TB_T_TransactionItems transaction);
        bool Update(int id, TB_T_TransactionItems transaction);
        bool DeleteTransactionItems(int id);
    }
}
