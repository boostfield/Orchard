using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Service.DataImport.Model
{
    public class OldWorks
    {
        public int id { get; set; }
        public string tid { get; set; }
        public string title { get; set; }//著作名称
        public string author { get; set; }//作者姓名
        public string year { get; set; }//年度
        public string department { get; set; }  //系别
        public string publishunit { get; set; } //出版单位
        public string booknumber { get; set; }  //书号
        public string publishdate { get; set; } //出版时间 
        public string booktype { get; set; }    //著作类别
        public string writetype { get; set; }   //合作者顺序
        public int alltextnumber { get; set; }//
        public int finishnumber { get; set; }   //要人完成字数
        public string author1 { get; set; } //作者1
        public string textnumber1 { get; set; } //参著字数1
        public string author2 { get; set; } //参著作者2
        public string textnumber2 { get; set; } //参著字数2
        public string author3 { get; set; } //参著作者3
        public string textnumber3 { get; set; } //参数字数3
        public string author4 { get; set; }
        public string textnumber4 { get; set; }
        public string author5 { get; set; }
        public string textnumber5 { get; set; }
        public string author6 { get; set; }
        public string textnumber6 { get; set; }
        public string author7 { get; set; }
        public string textnumber7 { get; set; }
        public string author8 { get; set; }
        public string textnumber8 { get; set; }
        public string author9 { get; set; }
        public string textnumber9 { get; set; }
        public string author10 { get; set; }
        public string textnumber10 { get; set; }
        public int isresult { get; set; }//是否项目成果
        public string sourcename { get; set; }  //项目来源名称
        public string projectname { get; set; } //项目
        public string introduce { get; set; }   //内容简介
        public string remarks { get; set; } //备注
        public string keyword { get; set; } //关键词
        public string summary { get; set; } //摘要
        public string text { get; set; }    //正文
        public string inputdate { get; set; }   //入库时间 
        public int clicknumber { get; set; }    //点击数
        public string refreshdate { get; set; } //最后更新时间 
        public string resulttype { get; set; }  //成果类别
        public string picture { get; set; } //图片 

    }
}