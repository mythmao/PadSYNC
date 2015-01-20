using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PadSYNC.Model
{
    public interface ITableObject
    {
        string GetTableData(TableObject table);
        int GetTotalCount(TableObject table);
        void UpdateTable(string tableName, string data);
    }
}
