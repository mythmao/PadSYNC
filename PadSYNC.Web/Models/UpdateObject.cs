using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataSYNC.Web.Models
{
    public class UpdateObject
    {
        public string TableName { get; set; }
        public int Count { get; set; }
        public string Data { get; set; }
        
    }
}