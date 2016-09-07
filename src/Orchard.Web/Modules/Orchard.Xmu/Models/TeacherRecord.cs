using Orchard.ContentManagement.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class TeacherRecord: ContentPartRecord
    {
        public virtual string Number { get; set; }//编号
        public virtual string Name { get; set; }    //姓名
        public virtual string Rank { get; set; }    //职称
        public virtual string Education { get; set; }   //学历
        public virtual string Job { get; set; }   //职务
        public virtual string Resfield { get; set; }//研究方向
        public virtual string Tecoffice { get; set; }   //所属科室
        public virtual string Office { get; set; }  //办公室
        public virtual string Telephone { get; set; }   //办公电话
        public virtual string Introduce { get; set; }   //简介
        public virtual string Department { get; set; }  //系别
        public virtual string Year { get; set; }   //出生年
        public virtual string Month { get; set; }   //出生月
        public virtual string Day { get; set; } //出生日
        public virtual DateTime? Birthday { get; set; }    //出生日期
        public virtual string Avatar { get; set; }  //照片路径
        public virtual string View { get; set; }    //学术观点
        public virtual string Concept { get; set; } //研究理念
        public virtual string Publication { get; set; } //主要著作
        public virtual string Dissertation { get; set; }    //论文
        public virtual string Course { get; set; }  //所授课程
        public virtual string Ptjob { get; set; } //社会兼职
        public virtual string Project { get; set; }//承担项目
        public virtual string Contact { get; set; } //联系方式 
        public virtual bool IsShow { get; set; }    //显示
    }
}