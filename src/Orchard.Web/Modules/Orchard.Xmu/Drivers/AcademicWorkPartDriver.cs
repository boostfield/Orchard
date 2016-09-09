using Orchard.ContentManagement.Drivers;
using Orchard.Xmu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.ContentManagement;

namespace Orchard.Xmu.Drivers
{
    public class AcademicWorkPartDriver: ContentPartDriver<AcademicWorksPart>
    {
        protected override DriverResult Editor(AcademicWorksPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }

        protected override DriverResult Editor(AcademicWorksPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_AcademicWorkPart_Edit",
                         () => shapeHelper.EditorTemplate(
                             TemplateName: "Parts/AcademicWorkPart",
                              Model: part,
                              Prefix: Prefix));
        }
    }
}