using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Service.DataImport.Model
{
    public class OldReward
    {
        public int id { get; set; }
        public string tid { get; set; }
        public string winnername { get; set; }  //获奖者姓名
        public string resultname { get; set; }  //获奖成果名称
        public string year { get; set; }    //年度
        public string belongdepartment { get; set; }//系别
        public string awarddepartment { get; set; } //颁奖部门
        public DateTime windate { get; set; }   //获奖时间 
        public string winlevel1 { get; set; }//获奖等级
        public string winlevel2 { get; set; } //获奖级别
        public string resultproject { get; set; }   //成果项目
        public string resultform { get; set; }  //成果形式
        public string author { get; set; }  //第几作者
        public string collaborator { get; set; }    //合作者
        public string codes { get; set; }   //代码 
        public string remarks { get; set; } //备注
        public DateTime inputdate { get; set; }//入库时间
        public int clicknumber { get; set; }
        public DateTime refreshdate { get; set; }//最后更新时间
        public string resulttype { get; set; }  //成果类别



    }
}