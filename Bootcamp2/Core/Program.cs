using Bootcamp2.Application;
using Bootcamp2.Interfaces;
using Bootcamp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp2
{
    public class Program
    {
        int id;
        TB_M_Suppliers supplier = new TB_M_Suppliers();
        TB_M_Items item = new TB_M_Items();
        TB_M_Sell sell = new TB_M_Sell();
        TB_T_TransactionItems transactionItem = new TB_T_TransactionItems();
        
        static void Main(string[] args)
        {
            Program p = new Program();
            p.MenuTable();
            Console.Read();
        }

        public int MenuTable()
        {
            Program p = new Program();
            int menu;
                Console.WriteLine("=============== MENU ===============");
                Console.WriteLine("1. Supplier");
                Console.WriteLine("2. Item");
                Console.WriteLine("3. Sell");
                Console.WriteLine("4. Transaction");
                Console.WriteLine("====================================");
                Console.Write("Choose Table : ");
                menu = Convert.ToInt16(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        p.MenuSuppliers();
                        Console.Read();
                        break;
                    case 2:
                        p.MenuItems();
                        Console.Read();
                        break;
                    case 3:
                        p.MenuSell();
                        Console.Read();
                        break;
                    case 4:
                        p.MenuTransaction();
                        Console.Read();
                        break;
                    default:
                        Console.Write("The table not found");
                        break;
                }

            return menu;
        }

        public int MenuSuppliers()
        {
            int n;
            ISupplier iSupplier;
            iSupplier = new SupplierController();

            Console.WriteLine();
            Console.WriteLine("============== ACTION ==============");
            Console.WriteLine("1. View Data");
            Console.WriteLine("2. Insert");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("====================================");
            Console.Write("Choose an action : ");
            n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            switch (n)
                {
                    case 1:
                        iSupplier.Get();
                        Console.Read();
                        break;
                    case 2:
                        iSupplier.Insert(supplier);
                        Console.Read();
                        break;
                    case 3:
                        iSupplier.Update(id, supplier);
                        Console.Read();
                        break;
                    case 4:
                        iSupplier.DeleteSupplier(id);
                        Console.Read();
                        break;
                    default:
                        Console.Write("User input not found");
                        break;
                }
            return n;
        }

        public int MenuItems()
        {
            int n;
            IItem iItem;
            iItem = new ItemController();

            Console.WriteLine();
            Console.WriteLine("============== ACTION ==============");
            Console.WriteLine("1. View Data");
            Console.WriteLine("2. Insert");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("====================================");
            Console.Write("Choose an action : ");
            n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            switch (n)
            {
                case 1:
                    iItem.Get();
                    Console.Read();
                    break;
                case 2:
                    iItem.Insert(item);
                    Console.Read();
                    break;
                case 3:
                    iItem.Update(id, item);
                    Console.Read();
                    break;
                case 4:
                    iItem.DeleteItem(id);
                    Console.Read();
                    break;
                default:
                    Console.Write("User input not found");
                    break;
            }
            return n;
        }

        public int MenuSell()
        {
            int n;
            ISell iSell;
            iSell = new SellController();

            Console.WriteLine();
            Console.WriteLine("============== ACTION ==============");
            Console.WriteLine("1. View Data");
            Console.WriteLine("2. Insert");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("====================================");
            Console.Write("Choose an action : ");
            n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            switch (n)
            {
                case 1:
                    iSell.Get();
                    Console.Read();
                    break;
                case 2:
                    iSell.Insert(sell);
                    Console.Read();
                    break;
                case 3:
                    iSell.Update(id, sell);
                    Console.Read();
                    break;
                case 4:
                    iSell.DeleteSell(id);
                    Console.Read();
                    break;
                default:
                    Console.Write("User input not found");
                    break;
            }
            return n;
        }

        public int MenuTransaction()
        {
            int n;
            ITransactions iTransactions;
            iTransactions = new TransactionItemController();

            Console.WriteLine();
            Console.WriteLine("============== ACTION ==============");
            Console.WriteLine("1. View Data");
            Console.WriteLine("2. Insert");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("====================================");
            Console.Write("Choose an action : ");
            n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            switch (n)
            {
                case 1:
                    iTransactions.Get();
                    Console.Read();
                    break;
                case 2:
                    iTransactions.Insert(transactionItem);
                    Console.Read();
                    break;
                case 3:
                    iTransactions.Update(id, transactionItem);
                    Console.Read();
                    break;
                case 4:
                    iTransactions.DeleteTransactionItems(id);
                    Console.Read();
                    break;
                default:
                    Console.Write("User input not found");
                    break;
            }
            return n;
        }
    }
}
