using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project1
{
    class dbms
    {
        public void createTable(String tableName, List<Column> columns, String colName)
        {
            DataTable dt = new DataTable(tableName);
            dt.Clear();

            foreach (var i in columns)
            {
                Type temp = i.getType();
                //dt.Columns.Add(i.getName(), typeof();
            }
        }
    }
}
