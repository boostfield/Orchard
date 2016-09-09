using Orchard.ContentManagement.Drivers;
using Orchard.Xmu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.ContentManagement;

namespace Orchard.Xmu.Drivers
{
    public class ProjectPartDriver: ContentPartDriver<ProjectPart>
    {
        protected override DriverResult Editor(ProjectPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }


        protected override DriverResult Editor(ProjectPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_ProjectPart_Edit",
                         () => shapeHelper.EditorTemplate(
                             TemplateName: "Parts/ProjectPart",
                              Model: part,
                              Prefix: Prefix));
        }
    }
}