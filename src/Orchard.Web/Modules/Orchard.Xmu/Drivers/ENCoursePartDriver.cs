using Orchard.ContentManagement.Drivers;
using Orchard.Xmu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.ContentManagement;

namespace Orchard.Xmu.Drivers
{
    public class ENCoursePartDriver:ContentPartDriver<ENCoursesPart>
    {
        public ENCoursePartDriver()
        {

        }


        protected override DriverResult Editor(ENCoursesPart part, IUpdateModel updater, dynamic shapeHelper)
        {



            return Editor(part, shapeHelper);
        }

        protected override DriverResult Editor(ENCoursesPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_ENCoursePart_Edit",
                        () => shapeHelper.EditorTemplate(
                            TemplateName: "Parts/ENCoursePart",
                             Model: part,
                             Prefix: Prefix));
        }
    }
}