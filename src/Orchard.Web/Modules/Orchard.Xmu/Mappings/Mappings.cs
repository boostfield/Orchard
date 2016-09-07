using Orchard.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.Utility;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using Orchard.Xmu.Models;

namespace Orchard.Xmu.Mappings
{
    public class Mappings : ISessionConfigurationEvents
    {
        public void Building(global::NHibernate.Cfg.Configuration cfg)
        {

        }

        public void ComputingHash(Hash hash)
        {

        }

        public void Created(global::FluentNHibernate.Cfg.FluentConfiguration cfg, global::FluentNHibernate.Automapping.AutoPersistenceModel defaultModel)
        {
            defaultModel.Override<ENTeacherPartRecord>(x=>
            {
                x.HasManyToMany(y => y.RecordCourses)
                .Cascade.All().Inverse()
                .ParentKeyColumn("ENTeacherPartRecord_Id")
                .ChildKeyColumn("ENCoursesRecord_Id")
                .Table("Orchard_Xmu_TeacherCourseRelationRecord");
            });

            defaultModel.Override<ENCoursePartRecord>(x =>
            {
                x.HasManyToMany(y => y.RecordTeachers)
                .Cascade.All()
                .ParentKeyColumn("ENCoursesRecord_Id")
                .ChildKeyColumn("ENTeacherPartRecord_Id")
                .Table("Orchard_Xmu_TeacherCourseRelationRecord");
            });



            defaultModel.Override<TeacherRecord>(x =>
            {
                x.HasManyToMany(y => y.RecordProjects)
                .Cascade.All().Inverse()
                .ParentKeyColumn("TeacherRecord_Id")
                .ChildKeyColumn("EProjectRecord_Id")
                .Table("Orchard_Xmu_CNTeacherProjectRelationRecord");
            });


            defaultModel.Override<ProjectRecord>(x =>
            {
                x.HasManyToMany(y => y.RecordCNTeachers)
                .Cascade.All()
                .ChildKeyColumn("TeacherRecord_Id")
                .ParentKeyColumn("EProjectRecord_Id")
                .Table("Orchard_Xmu_CNTeacherProjectRelationRecord");
            });

            
            defaultModel.Override<TeacherRecord>(x =>
            {
                x.HasManyToMany(y => y.RecordAwards)
                .Cascade.All().Inverse()
                .ParentKeyColumn("TeacherRecord_Id")
                .ChildKeyColumn("AwardsRecord_Id")
                .Table("Orchard_Xmu_CNTeacherAwardRelationRecord");
            });


            defaultModel.Override<AwardsRecord>(x =>
            {
                x.HasManyToMany(y => y.RecordCNTeachers)
                .Cascade.All()
                .ChildKeyColumn("TeacherRecord_Id")
                .ParentKeyColumn("AwardsRecord_Id")
                .Table("Orchard_Xmu_CNTeacherAwardRelationRecord");
            });



            defaultModel.Override<TeacherRecord>(x =>
            {
                x.HasManyToMany(y => y.RecordAcademicPapers)
                .Cascade.All().Inverse()
                .ParentKeyColumn("TeacherRecord_Id")
                .ChildKeyColumn("AcademicPaperRecord_Id")
                .Table("Orchard_Xmu_CNTeacherAcademicPaperRelationRecord");
            });


            defaultModel.Override<AcademicPaperRecord>(x =>
            {
                x.HasManyToMany(y => y.RecordCNTeachers)
                .Cascade.All()
                .ChildKeyColumn("TeacherRecord_Id")
                .ParentKeyColumn("AcademicPaperRecord_Id")
                .Table("Orchard_Xmu_CNTeacherAcademicPaperRelationRecord");
            });




            defaultModel.Override<TeacherRecord>(x =>
            {
                x.HasManyToMany(y => y.RecordAcademicWorks)
                .Cascade.All().Inverse()
                .ParentKeyColumn("TeacherRecord_Id")
                .ChildKeyColumn("AcademicWorksRecord_Id")
                .Table("Orchard_Xmu_CNTeacherAcademicWorkRelationRecord");
            });


            defaultModel.Override<AcademicWorksRecord>(x =>
            {
                x.HasManyToMany(y => y.RecordCNTeachers)
                .Cascade.All()
                .ChildKeyColumn("TeacherRecord_Id")
                .ParentKeyColumn("AcademicWorksRecord_Id_Id")
                .Table("Orchard_Xmu_CNTeacherAcademicWorkRelationRecord");
            });

        }

        public void Finished(global::NHibernate.Cfg.Configuration cfg)
        {

        }

        public void Prepared(global::FluentNHibernate.Cfg.FluentConfiguration cfg)
        {

        }
    }
}