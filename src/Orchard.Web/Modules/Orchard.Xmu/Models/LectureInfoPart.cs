using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class LectureInfoPart:XmContentPart
    {
        public string Lecturer
        {
            get
            {
                dynamic content = (dynamic)this.ContentItem;
                var v =  content.LectureInfoPart.lecturer.Value;

                return v;
            }

            set
            {
                dynamic content = (dynamic)this.ContentItem;
                content.LectureInfoPart.lecturer.Value = value;

            }
        }
        [DisplayName("讲座地点")]
        public string LectureAddress
        {
            get
            {
                dynamic content = (dynamic)this.ContentItem;
                return content.LectureInfoPart.lectureAddress.Value;
            }
            set
            {
                dynamic content = (dynamic)this.ContentItem;
                content.LectureInfoPart.lectureAddress.Value = value;

            }
        }


        public DateTime StartTime
        {
            get
            {
                dynamic content = (dynamic)this.ContentItem;
                return content.LectureInfoPart.startTime.DateTime;
            }
            set
            {
                dynamic content = (dynamic)this.ContentItem;
                content.LectureInfoPart.startTime.DateTime = value;

            }
        }

        public string LectureType
        {
            get
            {
                dynamic content = (dynamic)this.ContentItem;
                var r =  content.LectureInfoPart.lectureType.Value;
                if(string.IsNullOrEmpty(r))
                {
                    return "学术讲座";
                } 
                else
                {
                    return r;
                }
            }

            set
            {
                dynamic content = (dynamic)this.ContentItem;
                content.LectureInfoPart.lectureType.Value = value;

            }

        }

    }
}