using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Service.DataImport.Model
{
    public class OldProject
    {
        public int id { get; set; }
        public string tid { get; set; }
        public string projecttitle { get; set; }//课题名称
        public string host { get; set; }//主持人
        public string year { get; set; }//年度
        public string department { get; set; }//系别
        public string source { get; set; }//课题来源
        public string level { get; set; }//课题级别
        public string serialnumber { get; set; }//课题编号
        public string aidfunds { get; set; }//资助经费
        public string group { get; set; }//课题组成员
        public string aidhost { get; set; }//主持人经费
        public DateTime startdate  { get; set; }//课题期限起期
        public DateTime enddate { get; set; }//课题期限止期
        public DateTime finishdate { get; set; }//结题日期"
        public string aidsituation { get; set; }//经费聘用情况
        public string remarks { get; set; }//备注
        public DateTime inputdate { get; set; }//入库时间
        public int clicknumber { get; set; }
        public DateTime refreshdate { get; set; }//最后更新时间
        public string resulttype { get; set; }//成果类别
        public string member1 { get; set; } //成员1
        public string textnumber1 { get; set; }//成员1经费
        public string member2 { get; set; }
        public string textnumber2 { get; set; }
        public string member3 { get; set; }
        public string textnumber3 { get; set; }
        public string member4 { get; set; }
        public string textnumber4{ get; set; }
        public string member5 { get; set; }
        public string textnumber5 { get; set; }
        public string member6 { get; set; }
        public string textnumber6 { get; set; }
        public string member7 { get; set; }
        public string textnumber7 { get; set; }
        public string member8 { get; set; }
        public string textnumber8 { get; set; }
        public string member9 { get; set; }
        public string textnumber9 { get; set; }
        public string member10 { get; set; }
        public string textnumber10 { get; set; }

    }
}