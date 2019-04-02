using System;
using Bootcamp2.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp2
{
    public class ItemController : Validation, IItem
    {
        MyContext myContext = new MyContext();
        bool status = false;
        string Name;
        int Supplier_id, Price, Stock;

        public List<TB_M_Items> Get()
        {
            //throw new NotImplementedException();
            var get = myContext.TB_M_Items.Where(x => x.IsDelete == false).ToList();
            foreach (var list in get)
            {
                Console.WriteLine("ID" + "\t \t :" + list.Id);
                Console.WriteLine("Name" + "\t \t :" + list.Name);
                Console.WriteLine("Price" + "\t \t :" + list.Price);
                Console.WriteLine("Stock" + "\t \t :" + list.Stock);
                Console.WriteLine("Supplier ID" + "\t :" + list.TB_M_Supplier_Id);
                Console.WriteLine();
            }
            return get;
        }

        public bool Insert(TB_M_Items item)
        {
            //throw new NotImplementedException();
            Console.Write("Insert Name Item : ");
            Name = Console.ReadLine();

            Console.Write("Insert Price : ");
            Price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert Stock : ");
            Stock = Convert.ToInt16(Console.ReadLine());

            Console.Write("Insert Supplier ID : ");
            Supplier_id = Convert.ToInt16(Console.ReadLine());
            var getSupplierId = myContext.TB_M_Suppliers.Find(Supplier_id);
            if(getSupplierId != null)
            {
                item.Name = Name;
                item.Price = Price;
                item.Stock = Stock;
                item.TB_M_Suppliers = getSupplierId;
                myContext.TB_M_Items.Add(item);
                var result = myContext.SaveChanges();
                return validation(result);
            }
            else
            {
                Console.Write("Supplier ID Not Found");
                return status;
            }
            Console.Read();
        }

        public bool Update(int id, TB_M_Items item)
        {
            //throw new NotImplementedException();
            Console.Write("Insert Item Id : ");
            id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Items.Find(id);
            if (get != null)
            {
                Console.Write("Insert New Name Item : ");
                Name = Console.ReadLine();
                get.Name = Name;
                
                Console.Write("Insert Price : ");
                Price = Convert.ToInt16(Console.ReadLine());
                item.Price = Price;

                Console.Write("Insert Stock : ");
                Stock = Convert.ToInt16(Console.ReadLine());
                item.Stock = Stock;

                Console.Write("Insert Supplier ID : ");
                Supplier_id = Convert.ToInt16(Console.ReadLine());
                var getSupplierId = myContext.TB_M_Suppliers.Find(Supplier_id);
                if (getSupplierId != null)
                {
                    item.Name = Name;
                    item.Price = Price;
                    item.Stock = Stock;
                    item.TB_M_Suppliers = getSupplierId;
                    myContext.TB_M_Items.Add(item);
                    var result = myContext.SaveChanges();
                    return validation(result);
                }
                else
                {
                    Console.Write("Supplier ID Not Found");
                    return status;
                }
            }
            else
            {
                Console.Write("No Data Found");
            }
            return status;
            Console.Read();
        }

        public bool DeleteItem(int id)
        {
            //throw new NotImplementedException();
            Console.Write("Insert Your Id : ");
            id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Items.Find(id);
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
    }
}
