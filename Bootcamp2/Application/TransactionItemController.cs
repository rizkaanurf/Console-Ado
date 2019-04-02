using Bootcamp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bootcamp2.Models;
using System.Data.Entity;

namespace Bootcamp2.Application
{
    class TransactionItemController : Validation, ITransactions
    {
        MyContext myContext = new MyContext();
        bool status = false;
        int Id, quantity, item_id, sell_id;
        string date;

        public bool DeleteTransactionItems(int id)
        {
            Console.Write("Insert Your Id : ");
            Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_T_TransactionItems.Find(Id);
            if (get != null)
            {
                get.IsDelete = true;
                myContext.Entry(get).State = EntityState.Modified;
                var result = myContext.SaveChanges();
                return validation(result);
            }
            else
            {
                Console.Write("No Data Found");
            }
            return status;
            Console.Read();
        }

        public List<TB_T_TransactionItems> Get()
        {
            var get = myContext.TB_T_TransactionItems.ToList();
            foreach (var list in get)
            {
                Console.WriteLine("ID" + "\t \t :" + list.Id);
                Console.WriteLine("Quantity" + "\t \t :" + list.Quantity);
                Console.WriteLine("ID Item" + "\t \t :" + list.TB_M_Items_Id);
                Console.WriteLine("ID Transaction" + "\t \t :" + list.TB_M_Sell_Id);
                Console.WriteLine();
            }
            return get;
        }

        public bool Insert(TB_T_TransactionItems transaction)
        {
            Console.Write("Insert Quantity : ");
            quantity = Convert.ToInt16(Console.ReadLine());
            transaction.Quantity = quantity;

            Console.Write("Insert Item ID : ");
            item_id = Convert.ToInt16(Console.ReadLine());
            var getItemId = myContext.TB_M_Items.Find(item_id);
            transaction.TB_M_Items = getItemId;

            Console.Write("Insert Sell ID : ");
            sell_id = Convert.ToInt16(Console.ReadLine());
            var getSellId = myContext.TB_M_Sell.Find(sell_id);
            transaction.TB_M_Sell = getSellId;

            myContext.TB_T_TransactionItems.Add(transaction);
            var result = myContext.SaveChanges();
            return validation(result);

            Console.Read();
        }

        public bool Update(int id, TB_T_TransactionItems transaction)
        {
            Console.Write("Insert Item Id : ");
            Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_T_TransactionItems.Find(Id);
            if (get != null)
            {
                Console.Write("Insert New Quantity : ");
                quantity = Convert.ToInt16(Console.ReadLine());
                get.Quantity = quantity;

                Console.Write("Insert Item ID : ");
                item_id = Convert.ToInt16(Console.ReadLine());
                var getItemId = myContext.TB_M_Items.Find(item_id);
                transaction.TB_M_Items = getItemId;

                Console.Write("Insert Sell ID : ");
                sell_id = Convert.ToInt16(Console.ReadLine());
                var getSellId = myContext.TB_M_Sell.Find(sell_id);
                transaction.TB_M_Sell = getSellId;

                myContext.Entry(get).State = EntityState.Modified;
                var result = myContext.SaveChanges();
                return validation(result);
            }
            else
            {
                Console.Write("No Data Found");
            }
            return status;
            Console.Read();
        }
    }
}
