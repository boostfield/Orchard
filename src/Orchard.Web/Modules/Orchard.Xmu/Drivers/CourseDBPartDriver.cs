using Orchard.ContentManagement.Drivers;
using Orchard.Xmu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.ContentManagement;

namespace Orchard.Xmu.Drivers
{
    public class CourseDBPartDriver: ContentPartDriver<CourseDBRecordPart>
    {
        protected override DriverResult Editor(CourseDBRecordPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }

        protected override DriverResult Editor(CourseDBRecordPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_CourseDBPart_Edit",
                                  () => shapeHelper.EditorTemplate(
                                      TemplateName: "Parts/CourseDBPart",
                                       Model: part,
                                       Prefix: Prefix));
        }
    }
}