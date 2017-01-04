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
        private readonly IOrchardServices _orchardServices;

        public CNTeacherPartDriver(IOrchardServices orchardServices)
        {
            _orchardServices = orchardServices;

        }

        protected override DriverResult Editor(CNTeacherPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            /*
            var oldawards = part.Record.RecordAwards;
            var oldworks = part.Record.RecordAcademicWorks;
            var oldpapers = part.Record.RecordAcademicPapers;
            var oldproject = part.Record.RecordProjects;
            */
            updater.TryUpdateModel(part, Prefix, null, null);
            /*
            if (part.AwardIds == null)
            {
                part.AwardIds = new List<string>();
            }

            if(part.WorkIds == null)
            {
                part.WorkIds = new List<string>();
            }

            if(part.PaperIds == null)
            {
                part.PaperIds = new List<string>();
            }

            if(part.ProjectIds==null)
            {
                part.ProjectIds = new List<string>();
            }

            //获奖成果
            var awardMaintained = Extension.Extensions.Maintains(oldawards, part.AwardIds.Select(i => int.Parse(i)).ToList());

            foreach (var award in awardMaintained.Item1)
            {
                part.Record.RecordAwards.Remove(award);
            }

            foreach (var id in awardMaintained.Item2)
            {
                var awardPart = _orchardServices.ContentManager.Get<AwardsPart>(id, VersionOptions.Latest);
                if (awardPart != null)
                {
                    part.Record.RecordAwards.Add(awardPart.Record);
                }
            }

            //著作
            var workMaintained = Extension.Extensions.Maintains(oldworks, part.WorkIds.Select(i => int.Parse(i)).ToList());

            foreach (var work in workMaintained.Item1)
            {
                part.Record.RecordAcademicWorks.Remove(work);
            }

            foreach (var id in workMaintained.Item2)
            {
                var workPart = _orchardServices.ContentManager.Get<AcademicWorksPart>(id, VersionOptions.Latest);
                if (workPart != null)
                {
                    part.Record.RecordAcademicWorks.Add(workPart.Record);
                }
            }

            //论文
            var paperMaintained = Extension.Extensions.Maintains(oldpapers, part.PaperIds.Select(i => int.Parse(i)).ToList());
            foreach (var paper in paperMaintained.Item1)
            {
                part.Record.RecordAcademicPapers.Remove(paper);
            }

            foreach (var id in paperMaintained.Item2)
            {
                var paperPart = _orchardServices.ContentManager.Get<AcademicPaperPart>(id, VersionOptions.Latest);
                if (paperPart != null)
                {
                    part.Record.RecordAcademicPapers.Add(paperPart.Record);
                }
            }
            //承担课题
            var projectMaintained = Extension.Extensions.Maintains(oldproject, part.ProjectIds.Select(i => int.Parse(i)).ToList());

            foreach (var project in projectMaintained.Item1)
            {
                part.Record.RecordProjects.Remove(project);
            }

            foreach (var id in projectMaintained.Item2)
            {
                var projectPart = _orchardServices.ContentManager.Get<ProjectPart>(id, VersionOptions.Latest);
                if (projectPart != null)
                {
                    part.Record.RecordProjects.Add(projectPart.Record);
                }
            }
            */

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