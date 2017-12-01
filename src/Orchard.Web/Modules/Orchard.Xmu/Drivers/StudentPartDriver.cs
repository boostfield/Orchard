using Orchard.ContentManagement.Drivers;
using Orchard.Data;
using Orchard.Xmu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.ContentManagement;

namespace Orchard.Xmu.Drivers
{
    public class StudentPartDriver: ContentPartDriver<StudentPart>
    {
        public StudentPartDriver()
        {
           
        }

        protected override DriverResult Editor(StudentPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);

        }


        protected override DriverResult Editor(StudentPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_StudentPart_Edit",
                         () => shapeHelper.EditorTemplate(
                             TemplateName: "Parts/StudentPart",
                              Model: part,
                              Prefix: Prefix));
        }
    }
}