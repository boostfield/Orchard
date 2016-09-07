using Orchard.ContentManagement.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    /// <summary>
    /// 论文
    /// </summary>
    public class AcademicPaperRecord:ContentPartRecord
    {
        public virtual string Tid { get; set; }
        public virtual string Title { get; set; }//论文题目
        public virtual string Author { get; set; }//作者姓名
        public virtual string Year { get; set; }    //年度
        public virtual string Department { get; set; }//系别
        public virtual string Keyword { get; set; }//关键字
        public virtual string Summary { get; set; }//摘要
        public virtual string Text { get; set; } //正文
        public virtual DateTime ReleaseDate { get; set; }//发表时间
        public virtual string Publication { get; set; }//刊物名称
        public virtual string Pid { get; set; }//刊号
        public virtual string Ptime { get; set; }//刊物期别
        public virtual string Plevel { get; set; }  //刊物级别
        public virtual string Writertype { get; set; }//合作者顺序
        public virtual int TextNumber { get; set; }//字数
        public virtual string Remarks { get; set; }//备注
        public virtual DateTime InputDate { get; set; }//入库时间 
        public virtual int ClickNumber { get; set; }//点击数
        public virtual DateTime RefreshDate { get; set; }//最后更新时间
        public virtual bool IsShow { get; set; }//是否显示
        public virtual string Achievement { get; set; }//成果类别
        public virtual string ImportantJournal { get; set; }//重要期刊
        public virtual string RePrint { get; set; }//被转载
        public virtual string ResearchResult { get; set; }//何项研究成果

        public virtual IList<TeacherRecord> RecordCNTeachers { get; set; }

        public AcademicPaperRecord()
        {
            RecordCNTeachers = new List<TeacherRecord>();

        }
    }
}