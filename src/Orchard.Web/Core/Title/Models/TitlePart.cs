using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Aspects;

namespace Orchard.Core.Title.Models {
    public class TitlePart : ContentPart<TitlePartRecord>, ITitleAspect {
        public string Title {
            get { return Retrieve(x => x.Title) ?? string.Empty; }
            set { Store(x => x.Title, value!=null ? value : string.Empty); }
        }
    }
}