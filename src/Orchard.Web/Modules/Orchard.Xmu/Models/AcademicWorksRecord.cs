using Orchard.ContentManagement.Records;
using Orchard.Data.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    /// <summary>
    /// 著作 
    /// </summary>
    public class AcademicWorksRecord: ContentPartRecord
    {
        public virtual string Tid { get; set; }
        public virtual string Title { get; set; }//著作名称
        public virtual string Author { get; set; }//作者姓名
        public virtual string Year { get; set; }//年度
        public virtual string Department { get; set; }  //系别
        public virtual string Publishunit { get; set; } //出版单位
        public virtual string Booknumber { get; set; }  //书号
        public virtual DateTime Publishdate { get; set; } //出版时间 
        public virtual string Booktype { get; set; }    //著作类别
        public virtual string WriterType { get; set; }   //合作者顺序
        public virtual int AllTextBumber { get; set; }//
        public virtual int FinishNumber { get; set; }   //要人完成字数
        public virtual string Author1 { get; set; } //作者1
        public virtual string TextNumber1 { get; set; } //参著字数1
        public virtual string Author2 { get; set; } //参著作者2
        public virtual string TextNumber2 { get; set; } //参著字数2
        public virtual string Author3 { get; set; } //参著作者3
        public virtual string TextNumber3 { get; set; } //参数字数3
        public virtual string Author4 { get; set; }
        public virtual string TextNumber4 { get; set; }
        public virtual string Author5 { get; set; }
        public virtual string TextNumber5 { get; set; }
        public virtual string Author6 { get; set; }
        public virtual string TextNumber6 { get; set; }
        public virtual string Author7 { get; set; }
        public virtual string TextNumber7 { get; set; }
        public virtual string Author8 { get; set; }
        public virtual string TextNumber8 { get; set; }
        public virtual string Author9 { get; set; }
        public virtual string TextNumber9 { get; set; }
        public virtual string Author10 { get; set; }
        public virtual string TextNumber10 { get; set; }
        public virtual int IsResult { get; set; }//是否项目成果
        public virtual string SourceName { get; set; }  //项目来源名称
        public virtual string ProjectName { get; set; } //项目
        [StringLengthMax]
        public virtual string Introduce { get; set; }   //内容简介
        [StringLengthMax]
        public virtual string Remarks { get; set; } //备注
        public virtual string Keyword { get; set; } //关键词
        [StringLengthMax]
        public virtual string Summary { get; set; } //摘要
        [StringLengthMax]
        public virtual string Text { get; set; }    //正文
        public virtual DateTime InputDate { get; set; }   //入库时间 
        public virtual int ClickNumber { get; set; }    //点击数
        public virtual DateTime RefreshDate { get; set; } //最后更新时间 
        public virtual string ResultType { get; set; }  //成果类别
        public virtual string Picture { get; set; } //图片 

        public virtual IList<CNTeacherPartRecord> RecordCNTeachers { get; set; }

        public AcademicWorksRecord()
        {
            RecordCNTeachers = new List<CNTeacherPartRecord>();

        }
    }
}