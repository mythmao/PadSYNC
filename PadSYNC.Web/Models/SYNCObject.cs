using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PadSYNC.Web.Models
{
    public class SYNCObject
    {
        public string Database { get; set; }
        public string TableName { get; set; }
        public List<string> Fields { get; set; }
        public Dictionary<string, string> DictOperator { get; set; }
        public Dictionary<string, object> DictFilter { get; set; }
        public byte[] LastModified { get; set; }
    }
}