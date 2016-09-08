using Orchard.ContentManagement.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class ProjectRecord:ContentPartRecord
    {
        public virtual string Tid { get; set; }
        public virtual string ProjectTitle { get; set; }//课题名称
        public virtual string Host { get; set; }//主持人
        public virtual string Year { get; set; }//年度
        public virtual string Department { get; set; }//系别
        public virtual string Source { get; set; }//课题来源
        public virtual string Level { get; set; }//课题级别
        public virtual string SerialNumber { get; set; }//课题编号
        public virtual string Aidfunds { get; set; }//资助经费
        public virtual string Group { get; set; }//课题组成员
        public virtual string Aidhost { get; set; }//主持人经费
        public virtual DateTime StartDate { get; set; }//课题期限起期
        public virtual DateTime EndDate { get; set; }//课题期限止期
        public virtual DateTime FinishDate { get; set; }//结题日期"
        public virtual string AidSituation { get; set; }//经费聘用情况
        public virtual string Remarks { get; set; }//备注
        public virtual DateTime Inputdate { get; set; }//入库时间
        public virtual int Clicknumber { get; set; }
        public virtual DateTime RefreshDate { get; set; }//最后更新时间
        public virtual string ResultType { get; set; }//成果类别
        public virtual string Member1 { get; set; } //成员1
        public virtual string Funds1 { get; set; }//成员1经费
        public virtual string Member2 { get; set; }
        public virtual string Funds2 { get; set; }
        public virtual string Member3 { get; set; }
        public virtual string Funds3 { get; set; }
        public virtual string Member4 { get; set; }
        public virtual string Funds4 { get; set; }
        public virtual string Member5 { get; set; }
        public virtual string Funds5 { get; set; }
        public virtual string Member6 { get; set; }
        public virtual string Funds6 { get; set; }
        public virtual string Member7 { get; set; }
        public virtual string Funds7 { get; set; }
        public virtual string Member8 { get; set; }
        public virtual string Funds8 { get; set; }
        public virtual string Member9 { get; set; }
        public virtual string Funds9 { get; set; }
        public virtual string Member10 { get; set; }
        public virtual string Funds10 { get; set; }
        public virtual IList<CNTeacherPartRecord> RecordCNTeachers { get; set; }

        public ProjectRecord()
        {
            RecordCNTeachers = new List<CNTeacherPartRecord>();

        }

    }
}