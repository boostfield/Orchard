using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Service.DataImport.Model
{
    public class OldTeacherInfo
    {
        public int id { get; set; }
        public string number { get; set; }//编号
        public string name { get; set; }    //姓名
        public string sex { get; set; } //性别    
        public string rank { get; set; }    //职称
        public string education { get; set; }   //学历
        public string job { get; set; }   //职务
        public string resfield { get; set; }//研究方向
        public string tecoffice { get; set; }   //所属科室
        public string office { get; set; }  //办公室
        public string telephone { get; set; }   //办公电话
        public string introduce { get; set; }   //简介
        public string department { get; set; }  //系别
        public string year { get; set; }   //出生年
        public string month { get; set; }   //出生月
        public string day { get; set; } //出生日
        //todo
        public DateTime? birthday { get; set; }    //出生日期
        public string avatar { get; set; }  //照片路径
        public string view { get; set; }    //学术观点
        public string concept { get; set; } //研究理念
        public string publication { get; set; } //主要著作
        public string dissertation { get; set; }    //论文
        public string course { get; set; }  //所授课程
        public string ptjop  { get; set; } //社会
        public string project { get; set; }//承担项目
        public string contact { get; set; } //联系方式 
        public bool isshow { get; set; }    //显示
    }
}