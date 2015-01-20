using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PadSYNC.Model
{
    public class TableObject
    {
        public string TableName { get; set; }
        public int BranchID { get; set; }
        public int SchoolID { get; set; }
        public byte[] LastModified { get; set; }
        /// <summary>
        /// 针对MySQL使用
        /// </summary>
        public string LastModifiedDate { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int CurPage { get; set; }
        public int PageSize { get; set; }
    }
}
