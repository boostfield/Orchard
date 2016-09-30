using Orchard.Xmu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.ViewModels
{
    public class XmContentVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime? PublishedUtc { get; set; }
        public DateTime? CreatedUtc { get; set; }
        public string Author { get; set; }
        public string Editor { get; set; }
        public int ViewCount { get; set; }

        public string ImageAddress { get; set; }

        public static XmContentVM FromXmContentPart(XmContentPart part)
        {
            return new XmContentVM
            {
                Id = part.Id,
                Title = part.Title,
                Text = part.Text,
                PublishedUtc = part.PublishedUtc,
                Author = part.Author,
                Editor = part.Editor,
                ViewCount = part.ViewCount,
                CreatedUtc = part.CreatedUtc,
                ImageAddress = part.ImageAddress
            };
        }
    }
}