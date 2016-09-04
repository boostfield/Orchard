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
        private readonly IOrchardServices _orchardServices;

        public ENCoursePartDriver(IOrchardServices orchardServices)
        {
            _orchardServices = orchardServices;

        }


        protected override DriverResult Editor(ENCoursesPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            var oldTeachers = part.Record.RecordTeachers;
            updater.TryUpdateModel(part, Prefix, null, null);
            if(part.TeacherIds==null )
            {
                part.TeacherIds = new List<string>();
            }

            var teacherMaintained = Extension.Extensions.Maintains(oldTeachers, part.TeacherIds.Select(i => int.Parse(i)).ToList());

            foreach(var teacher in teacherMaintained.Item1)
            {
                part.Record.RecordTeachers.Remove(teacher);
            }

            foreach(var id in teacherMaintained.Item2)
            {
                var teacherPart = _orchardServices.ContentManager.Get<ENTeacherPart>(id, VersionOptions.Latest);
                if(teacherPart!=null)
                {
                    part.Record.RecordTeachers.Add(teacherPart.Record);
                }
            }

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