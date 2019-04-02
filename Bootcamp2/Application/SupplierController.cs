using Bootcamp2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp2
{
    public class SupplierController : Validation, ISupplier
    {
        MyContext myContext = new MyContext();
        bool status = false;
        int Id;
        string Name;

        //show list data tabel TB_M_Suppliers
        public List<TB_M_Suppliers> Get()
        {
            var get = myContext.TB_M_Suppliers.Where(x => x.IsDelete == false).ToList();
            foreach (var list in get)
            {
                Console.WriteLine("ID" + "\t :" + list.Id);
                Console.WriteLine("Name" + "\t :" + list.Name);
                Console.WriteLine();
            }
            return get;
        }

        public TB_M_Suppliers Get(int id)
        {
            var get = myContext.TB_M_Suppliers.Find(id);
            return get;
        }

        //Method Insert new data supplier
        public bool Insert(TB_M_Suppliers supplier)
        {
            Console.Write("Insert Supplier Name : ");
            Name = Console.ReadLine();
            supplier.Name = Name;
            myContext.TB_M_Suppliers.Add(supplier);
            var result = myContext.SaveChanges();
            return validation(result);

            Console.Read();
        }

        //Method Update data supplier
        public bool Update(int id, TB_M_Suppliers supplier)
        {
            //throw new NotImplementedException();
            Console.Write("Insert the Id : ");
            id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Suppliers.Find(id);
            if (get != null)
            {
                Console.Write("Insert new supplier name : ");
                Name = Console.ReadLine();
                get.Name = Name;
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

        //Method soft delete data supplier
        public bool DeleteSupplier(int id)
        {
            //throw new NotImplementedException();
            Console.Write("Insert Your Id : ");
            Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Suppliers.Find(Id);
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
