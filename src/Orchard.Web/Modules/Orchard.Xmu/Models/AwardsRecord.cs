using Orchard.ContentManagement.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{

    public class AwardsRecord:ContentPartRecord
    {
        public virtual string Tid { get; set; }
        public virtual string WinnerName { get; set; }  //获奖者姓名
        public virtual string AwardName { get; set; }  //获奖成果名称
        public virtual string Year { get; set; }    //年度
        public virtual string BelongDepartment { get; set; }//系别
        public virtual string AwardDepartment { get; set; } //颁奖部门
        public virtual DateTime AwardDate { get; set; }   //获奖时间 
        public virtual string AwardRank { get; set; }//获奖等级
        public virtual string AwardLevel { get; set; } //获奖级别
        public virtual string ResultProject { get; set; }   //成果项目
        public virtual string ResultForm { get; set; }  //成果形式
        public virtual string Author { get; set; }  //第几作者
        public virtual string Collaborator { get; set; }    //合作者
        public virtual string Codes { get; set; }   //代码 
        public virtual string Remarks { get; set; } //备注
        public virtual DateTime InputDate { get; set; }//入库时间
        public virtual int Clicknumber { get; set; }
        public virtual DateTime RefreshDate { get; set; }//最后更新时间
        public virtual string ResultType { get; set; }  //成果类别
    }
}