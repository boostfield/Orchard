using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Service.DataImport.Model
{
    public class OldPaper
    {
        public int id { get; set; }
        public string tid { get; set; }
        public string title { get; set; }   //论文题目
        public string author { get; set; }  //作者姓名
        public string year { get; set; }    //年度
        public string department { get; set; }//系别
        public string keyword { get; set; } //关键字
        public string summary { get; set; } //摘要
        public string text { get; set; }    //正文
        //todo
        public DateTime releasedate { get; set; }//发表时间
        public string publication { get; set; }//刊物名称
        public string pid { get; set; }//刊号
        public string ptime { get; set; }//刊物期别
        public string plevel { get; set; }//刊物级别
        public string writetype { get; set; }   //合作者顺序
        public int textnumber { get; set; }//字数
        public string remarks { get; set; }//备注
        //todo
        public DateTime inputdate  { get; set; }//入库时间 
        public int clicknumber { get; set; }    //点击数
        //todo
        public DateTime refreshdate { get; set; }//最后更新时间
        public bool isshow { get; set; }//是否显示
        public string achievement { get; set; } //成果类别
        public string imptjournal { get; set; }//重要期刊
        public string reprint { get; set; } //被转载
        public string researchresult { get; set; }//何项研究成果

    }
}