using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.ViewModels
{
    public class ApiListResponse
    {
        public int TotalCount { get; set; }
        public object DataList { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}