using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MyExpenses.Data
{
    interface ISqlCrud
    {
        DataTable ReadAllData(string SelectSql);
        void Add(string InsertSql);
        void Delete(string DeleteSql);
        void Update(string UpdateSql);
    }
}
