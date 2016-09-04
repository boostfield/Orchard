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
    public class ENTeacherPartDriver: ContentPartDriver<ENTeacherPart>
    {
        public ENTeacherPartDriver()
        {
           
        }

        protected override DriverResult Editor(ENTeacherPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            return Editor(part, shapeHelper);

        }


        protected override DriverResult Editor(ENTeacherPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_ENTeacherPart_Edit",
                         () => shapeHelper.EditorTemplate(
                             TemplateName: "Parts/ENTeacherPart",
                              Model: part,
                              Prefix: Prefix));
        }
    }
}