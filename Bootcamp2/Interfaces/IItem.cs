﻿using Bootcamp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp2
{
    public interface IItem
    {
        List<TB_M_Items> Get();
        //Supplier Get(int id);
        bool Insert(TB_M_Items item);
        bool Update(int id, TB_M_Items item);
        bool DeleteItem(int id);
    }
}
