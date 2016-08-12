using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class LectureInfoPart:BaseContentPart
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
    }
}