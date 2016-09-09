using Orchard.ContentManagement.Drivers;
using Orchard.Xmu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.ContentManagement;

namespace Orchard.Xmu.Drivers
{
    public class AwardPartDriver: ContentPartDriver<AwardsPart>
    {
        protected override DriverResult Editor(AwardsPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }

        protected override DriverResult Editor(AwardsPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_AwardPart_Edit",
                         () => shapeHelper.EditorTemplate(
                             TemplateName: "Parts/AwardPart",
                              Model: part,
                              Prefix: Prefix));
        }
    }
}