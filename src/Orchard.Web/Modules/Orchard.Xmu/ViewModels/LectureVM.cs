using Orchard.Xmu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.ViewModels
{
    public class LectureVM:XmContentVM
    {
        public string Lecturer { get; set; }
        public string LectureAddress { get; set; }
        public DateTime StartTime { get; set; }




        public static LectureVM FromLecturePart(LectureInfoPart part)
        {

            return new LectureVM
            {
                Id=part.Id,
                LectureAddress = part.LectureAddress,
                Lecturer = part.Lecturer,
                StartTime = part.StartTime,
                Title = part.Title,
                Text = part.Text,
                PublishedUtc = part.PublishedUtc,
                Author = part.Author,
                Editor = part.Editor,
                ViewCount = part.ViewCount
            };
        }

    }
}