using Orchard.ContentManagement.Drivers;
using Orchard.Xmu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.ContentManagement;

namespace Orchard.Xmu.Drivers
{
    public class AcademicPaperPartDriver: ContentPartDriver<AcademicPaperPart>
    {
        protected override DriverResult Editor(AcademicPaperPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }


        protected override DriverResult Editor(AcademicPaperPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_AcademicPaperPart_Edit",
                         () => shapeHelper.EditorTemplate(
                             TemplateName: "Parts/AcademicPaperPart",
                              Model: part,
                              Prefix: Prefix));
        }
    }
}