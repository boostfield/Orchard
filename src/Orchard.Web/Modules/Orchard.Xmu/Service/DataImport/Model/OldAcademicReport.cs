using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Service.DataImport.Model
{
    public class OldAcademicReport
    {
        public int id { get; set; }
        public string title { get; set; }   //标题
        public string type { get; set; } //分类 
        public string content { get; set; } //内容
        public string publishunit { get; set; } //发布单位
        public string publishdate { get; set; } //发布时间
        public string publisher { get; set; }//发布人
        public string reportdate { get; set; }  //报告时间 
        public string address { get; set; } //报告地点
        public string lastchangeer { get; set; }    //最后修改人
        public string lastchangedate { get; set; }  //最后修改时间
        public string speaker { get; set; } //主讲人
        public int clicknumber { get; set; }    //点击数

    }
}