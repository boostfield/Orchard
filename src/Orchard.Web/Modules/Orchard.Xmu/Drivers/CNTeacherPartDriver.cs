using Orchard.ContentManagement.Drivers;
using Orchard.Xmu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.ContentManagement;

namespace Orchard.Xmu.Drivers
{
    public class CNTeacherPartDriver : ContentPartDriver<CNTeacherPart>
    {
        protected override DriverResult Editor(CNTeacherPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
        protected override DriverResult Editor(CNTeacherPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_CNTeacherPart_Edit",
                         () => shapeHelper.EditorTemplate(
                             TemplateName: "Parts/CNTeacherPart",
                              Model: part,
                              Prefix: Prefix));

        }
    }
}