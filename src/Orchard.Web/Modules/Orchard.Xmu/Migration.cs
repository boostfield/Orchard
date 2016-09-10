using NGM.ContentViewCounter.Models;
using Orchard.Autoroute.Models;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Common.Models;
using Orchard.Core.Contents.Extensions;
using Orchard.Core.Title.Models;
using Orchard.Data.Migration;
using Orchard.Tags.Models;
using Orchard.Xmu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu
{
    public class Migration : DataMigrationImpl
    {
        public int Create()
        {
            /*
            ContentDefinitionManager.AlterPartDefinition(XmContentType.InfomationType+"Part",
                    cfg =>
                    cfg.WithField(XmTaxonomyNames.CNInformation, b => b.OfType("TaxonomyField").WithDisplayName("信息类型"))
            );
             
            ContentDefinitionManager.AlterPartDefinition(typeof(InformationPart).Name, builder => builder
                .WithDescription("placement info part")                
                );
               
            ContentDefinitionManager.AlterTypeDefinition(XmContentType.InfomationType,
                cfg => cfg
          .DisplayedAs("中文门户资讯")
          .WithPart(typeof(TitlePart).Name)
          .WithPart(typeof(CommonPart).Name)
          .WithPart(typeof(BodyPart).Name)
          .WithPart(typeof(AutoroutePart).Name)
          .WithPart(typeof(InformationPart).Name)
          .WithPart(XmContentType.InfomationType + "Part")
          .Creatable()
          .Listable()
          .Draftable()
          );

            */


            ContentDefinitionManager.AlterPartDefinition(typeof(XmContentPart).Name,
                cfg =>
                cfg.WithField("image",
                         b => b.OfType("MediaLibraryPickerField")
                             .WithDisplayName("封面图")
                             )
                             .Attachable()
                             .WithDescription("厦门大学内容类型组成部分")

            );


            ContentDefinitionManager.AlterPartDefinition(typeof(LectureInfoPart).Name,
                 cfg =>
                 cfg.WithField("lecturer", b => b.OfType("TextField").WithDisplayName("主讲人"))
                 .WithField("lectureAddress", b => b.OfType("TextField").WithDisplayName("讲座地址"))
                 .WithField("startTime", b => b.OfType("DateTimeField").WithDisplayName("开始时间"))
             );

            ContentDefinitionManager.AlterTypeDefinition(XmContentType.LectureInfo.ContentTypeName,
             cfg => cfg
       .DisplayedAs(XmContentType.LectureInfo.ContentTypeDisplayName)
       .WithPart(typeof(TitlePart).Name)
           .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("OwnerEditorSettings.ShowOwnerEditor", "false"))
       .WithPart(typeof(BodyPart).Name)
       .WithPart(typeof(LectureInfoPart).Name)
       .WithPart(typeof(UserViewPart).Name, builder => builder.WithSetting("UserViewTypePartSettings.AllowAnonymousViews", "True"))
       .WithSetting("ListTitle", XmContentType.LectureInfo.ListTitle)
       .Creatable()
       .Draftable()
       .Securable()
       );


            foreach (var mapping in XmContentType.CNCMSMappings)
            {


                ContentDefinitionManager.AlterTypeDefinition(mapping.ContentTypeName,
                 cfg => cfg
           .DisplayedAs(mapping.ContentTypeDisplayName)
           .WithPart(typeof(TitlePart).Name)
           .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("OwnerEditorSettings.ShowOwnerEditor", "false"))
           .WithPart(typeof(BodyPart).Name)
           .WithPart(typeof(XmContentPart).Name)
           .WithPart(typeof(UserViewPart).Name, builder => builder.WithSetting("UserViewTypePartSettings.AllowAnonymousViews", "True"))
           .WithSetting("ListTitle", mapping.ListTitle)
           .Creatable()
           .Draftable()
           .Securable()
           );



            }


            foreach (var mapping in XmContentType.NinetyMappings)
            {

                ContentDefinitionManager.AlterTypeDefinition(mapping.ContentTypeName,
                 cfg => cfg
           .DisplayedAs(mapping.ContentTypeDisplayName)
           .WithPart(typeof(TitlePart).Name)
           .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("OwnerEditorSettings.ShowOwnerEditor", "false"))
           .WithPart(typeof(BodyPart).Name)
           .WithPart(typeof(College90CelebrationPart).Name)
           .WithPart(typeof(UserViewPart).Name, builder => builder.WithSetting("UserViewTypePartSettings.AllowAnonymousViews", "True"))
           .WithSetting("ListTitle", mapping.ListTitle)
           .Creatable()
           .Draftable()
           .Securable()
           );

            }

            ContentDefinitionManager.AlterPartDefinition(typeof(NinetyCelebrationDonationPart).Name,
                cfg =>
                cfg.WithField("donator", b => b.OfType("TextField").WithDisplayName("捐款人").WithSetting("TextFieldSettings.Required", "true"))
                .WithField("donationAmount", b => b.OfType("TextField").WithDisplayName("捐款金额").WithSetting("TextFieldSettings.Required", "true"))
                .WithField("donationTime", b => b.OfType("DateTimeField").WithDisplayName("捐款时间").WithSetting("DateTimeFieldSettings.Required", "true")
                .WithSetting("DateTimeFieldSettings.Display", "DateOnly"))
            );

            ContentDefinitionManager.AlterTypeDefinition(XmContentType.NinetyDonation.ContentTypeName,

                cfg => cfg
                .DisplayedAs(XmContentType.NinetyDonation.ContentTypeDisplayName)
                .WithPart(typeof(TitlePart).Name)
           .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("OwnerEditorSettings.ShowOwnerEditor", "false"))
                .WithPart(typeof(NinetyCelebrationDonationPart).Name)
                .WithPart(typeof(UserViewPart).Name, builder => builder.WithSetting("UserViewTypePartSettings.AllowAnonymousViews", "True"))
                .WithSetting("ListTitle", XmContentType.NinetyDonation.ListTitle)
                .Creatable()
                .Draftable()
                .Securable()
       );


            return 1;
        }


        public int UpdateFrom1()
        {


            ContentDefinitionManager.AlterPartDefinition(typeof(BannerPart).Name,
                cfg =>
                cfg.WithField("image",
                         b => b.OfType("MediaLibraryPickerField")
                             .WithDisplayName("选择图片")
                             .WithSetting("MediaLibraryPickerFieldSettings.Required", "true"))
                   .WithField("linkAddress",
                        b => b.OfType("LinkField")
                            .WithDisplayName("链接地址")
                            .WithSetting("LinkFieldSettings.Required", "true"))

            );

            ContentDefinitionManager.AlterTypeDefinition(XmContentType.CNBanner.ContentTypeName,

              cfg => cfg
              .DisplayedAs(XmContentType.CNBanner.ContentTypeDisplayName)
              .WithPart(typeof(TitlePart).Name)
              .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("OwnerEditorSettings.ShowOwnerEditor", "false"))
              .WithPart(typeof(BannerPart).Name)
              .WithSetting("ListTitle", XmContentType.CNBanner.ListTitle)
              .Creatable()
              .Draftable()
              .Securable()
              );

            return 2;
        }

        public int UpdateFrom2()
        {
            ContentDefinitionManager.AlterTypeDefinition(XmContentType.ENBanner.ContentTypeName,

             cfg => cfg
             .DisplayedAs(XmContentType.ENBanner.ContentTypeDisplayName)
             .WithPart(typeof(TitlePart).Name)
             .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("OwnerEditorSettings.ShowOwnerEditor", "false"))
             .WithPart(typeof(BannerPart).Name)
             .WithSetting("ListTitle", XmContentType.ENBanner.ListTitle)
             .Creatable()
             .Draftable()
             .Securable()
             );
            return 3;
        }

        public int UpdateFrom3()
        {
            foreach (var mapping in XmContentType.ENCMSMappings)
            {


                ContentDefinitionManager.AlterTypeDefinition(mapping.ContentTypeName,
                 cfg => cfg
           .DisplayedAs(mapping.ContentTypeDisplayName)
           .WithPart(typeof(TitlePart).Name)
           .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("OwnerEditorSettings.ShowOwnerEditor", "false"))
           .WithPart(typeof(BodyPart).Name)
           .WithPart(typeof(XmContentPart).Name)
           .WithPart(typeof(UserViewPart).Name, builder => builder.WithSetting("UserViewTypePartSettings.AllowAnonymousViews", "True"))
           .WithSetting("ListTitle", mapping.ListTitle)
           .Creatable()
           .Draftable()
           .Securable()
           );

            }


            return 4;
        }

        public int UpdateFrom4()
        {

            ContentDefinitionManager.AlterPartDefinition(typeof(ENSectionPart).Name,
              cfg =>
              cfg.WithField("image",
                       b => b.OfType("MediaLibraryPickerField")
                           .WithDisplayName("选择图片")
                           .WithSetting("MediaLibraryPickerFieldSettings.Required", "true"))
                 .WithField("linkAddress",
                      b => b.OfType("LinkField")
                          .WithDisplayName("链接地址")
                          .WithSetting("LinkFieldSettings.Required", "true"))
                 .WithField("orderWeight", b => b.OfType("NumericField")
                  .WithDisplayName("排序顺序(数字大的在前)")
                  .WithSetting("NumericFieldSettings.Required", "true"))

          );


            ContentDefinitionManager.AlterTypeDefinition(XmContentType.ENSection.ContentTypeName,

           cfg => cfg
           .DisplayedAs(XmContentType.ENSection.ContentTypeDisplayName)
           .WithPart(typeof(TitlePart).Name)
           .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("OwnerEditorSettings.ShowOwnerEditor", "false"))
           .WithPart(typeof(ENSectionPart).Name)
           .WithSetting("ListTitle", XmContentType.ENSection.ListTitle)
           .Creatable()
           .Draftable()
           .Securable()
           );

            return 5;
        }

        public int UpdateFrom5()
        {

            ContentDefinitionManager.AlterTypeDefinition(XmContentType.NinetyCelBanner.ContentTypeName,

            cfg => cfg
            .DisplayedAs(XmContentType.NinetyCelBanner.ContentTypeDisplayName)
            .WithPart(typeof(TitlePart).Name)
            .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("OwnerEditorSettings.ShowOwnerEditor", "false"))
            .WithPart(typeof(BannerPart).Name)
            .WithSetting("ListTitle", XmContentType.NinetyCelBanner.ListTitle)
            .Creatable()
            .Draftable()
            .Securable()
            );
            return 6;
        }

        public int UpdateFrom6()
        {

            ContentDefinitionManager.AlterPartDefinition(typeof(CelMatesPicPart).Name,
             cfg =>
             cfg.WithField("image",
                      b => b.OfType("MediaLibraryPickerField")
                          .WithDisplayName("选择图片")
                          .WithSetting("MediaLibraryPickerFieldSettings.Required", "true"))
                .WithField("linkAddress",
                     b => b.OfType("LinkField")
                         .WithDisplayName("链接地址")
                         .WithSetting("LinkFieldSettings.Required", "true"))
                .WithField("orderWeight", b => b.OfType("NumericField")
                 .WithDisplayName("排序顺序(数字大的在前)")
                 .WithSetting("NumericFieldSettings.Required", "true"))

         );


            ContentDefinitionManager.AlterTypeDefinition(XmContentType.NinetyCelMatesOldPic.ContentTypeName,

           cfg => cfg
           .DisplayedAs(XmContentType.NinetyCelMatesOldPic.ContentTypeDisplayName)
           .WithPart(typeof(TitlePart).Name)
           .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("OwnerEditorSettings.ShowOwnerEditor", "false"))
           .WithPart(typeof(CelMatesPicPart).Name)
           .WithSetting("ListTitle", XmContentType.NinetyCelMatesOldPic.ListTitle)
           .Creatable()
           .Draftable()
           .Securable()
           );
            return 7;
        }


        public int UpdateFrom7()
        {


            ContentDefinitionManager.AlterTypeDefinition(XmContentType.NinetyDonation.ContentTypeName,
                cfg => cfg
                .WithPart(typeof(BodyPart).Name)
            );
            foreach (var mapping in XmContentType.NinetyMappings)
            {

                ContentDefinitionManager.AlterTypeDefinition(mapping.ContentTypeName,
                 cfg => cfg
           .WithPart(typeof(XmContentPart).Name)
           );

            }
            return 8;
        }


        public int UpdateFrom8()
        {


            SchemaBuilder.CreateTable(typeof(TeacherCourseRelationRecord).Name,
        table => table
        .Column<int>("Id", c => c.PrimaryKey().Identity())
        .Column<int>("ENTeacherPartRecord_Id")
        .Column<int>("ENCoursesRecord_Id")
        );


            SchemaBuilder.CreateTable(typeof(ENCoursePartRecord).Name,
                table =>

                table.ContentPartRecord()
                .Column<string>("CourseName", col => col.WithLength(220))
            );


            SchemaBuilder.CreateTable(typeof(ENTeacherPartRecord).Name, table =>
                table.ContentPartRecord()
                .Column<string>("ENName", col => col.WithLength(45))
            );


            /*
            ContentDefinitionManager.AlterPartDefinition(typeof(ENTeacherPart).Name,
                 cfg =>
                 cfg.WithField("teacherTitle", b => b.OfType("TaxonomyField").WithDisplayName("职称"))
             );
             */
            ContentDefinitionManager.AlterTypeDefinition(XmContentType.ENTeacher.ContentTypeName,
             cfg => cfg
       .DisplayedAs(XmContentType.ENTeacher.ContentTypeDisplayName)
       .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("OwnerEditorSettings.ShowOwnerEditor", "false"))
       .WithPart(typeof(BodyPart).Name)
       .WithPart(typeof(ENTeacherPart).Name)
       .WithPart(typeof(UserViewPart).Name, builder => builder.WithSetting("UserViewTypePartSettings.AllowAnonymousViews", "True"))
       .WithSetting("ListTitle", XmContentType.ENTeacher.ListTitle)
       .Creatable()
       .Draftable()
       .Securable()
       );


            ContentDefinitionManager.AlterTypeDefinition(XmContentType.ENCourse.ContentTypeName,
             cfg => cfg
       .DisplayedAs(XmContentType.ENCourse.ContentTypeDisplayName)
       .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("OwnerEditorSettings.ShowOwnerEditor", "false"))
       .WithPart(typeof(BodyPart).Name)
       .WithPart(typeof(ENCoursePart).Name)
       .WithPart(typeof(UserViewPart).Name, builder => builder.WithSetting("UserViewTypePartSettings.AllowAnonymousViews", "True"))
       .WithSetting("ListTitle", XmContentType.ENCourse.ListTitle)
       .Creatable()
       .Draftable()
       .Securable()
       );


            return 9;
        }
        public int UpdateFrom9()
        {
            foreach (var mapping in XmContentType.ENCMSMappings)
            {
                ContentDefinitionManager.AlterTypeDefinition(mapping.ContentTypeName,
                 cfg => cfg
               .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("DateEditorSettings.ShowDateEditor", "true"))

               );
            }
            return 10;
        }
        public int UpdateFrom10()
        {
            ContentDefinitionManager.AlterTypeDefinition(XmContentType.LectureInfo.ContentTypeName,
             cfg => cfg

           .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("DateEditorSettings.ShowDateEditor", "true")));
            ContentDefinitionManager.AlterTypeDefinition(XmContentType.LectureInfo.ContentTypeName,
             cfg => cfg

           .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("DateEditorSettings.ShowDateEditor", "true")));
            foreach (var mapping in XmContentType.NinetyMappings)
            {
                ContentDefinitionManager.AlterTypeDefinition(mapping.ContentTypeName,
                 cfg => cfg
               .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("DateEditorSettings.ShowDateEditor", "true"))

               );
            }
            foreach (var mapping in XmContentType.CNCMSMappings)
            {
                ContentDefinitionManager.AlterTypeDefinition(mapping.ContentTypeName,
                 cfg => cfg
               .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("DateEditorSettings.ShowDateEditor", "true"))

               );
            }
            return 11;
        }

        public int UpdateFrom11()
        {

            SchemaBuilder.AlterTable(typeof(ENCoursePartRecord).Name,
                table =>
                table.AddColumn<string>("CourseNO")

             );


            SchemaBuilder.AlterTable(typeof(ENTeacherPartRecord).Name, table =>
            table.AddColumn<string>("SN")
             );

            return 12;
        }

        public int UpdateFrom12()
        {
            ContentDefinitionManager.AlterPartDefinition(typeof(ENTeacherPart).Name,
               cfg =>
               cfg.WithField("avatar",
                        b => b.OfType("MediaLibraryPickerField")
                            .WithDisplayName("头像")
                            )
                            .Attachable()

           );

            return 13;
        }
        //------------------- 20160906 ----------- release 英文网站

        public int UpdateFrom13()
        {

            ContentDefinitionManager.AlterPartDefinition(typeof(XmContentPart).Name,
               cfg =>
               cfg.WithField("istop",
                        b => b.OfType("BooleanField")
                            .WithDisplayName("置顶")
                            .WithSetting("BooleanFieldSettings.DefaultValue", "False")
                            )
           );

            return 14;
        }

        public int UpdateFrom14()
        {



            ContentDefinitionManager.AlterPartDefinition(typeof(CNNotifyPart).Name,
                cfg =>
                cfg.WithField("taxotype", b => b.OfType("TaxonomyField")
                            .WithDisplayName("新闻分类"))

            );

            ContentDefinitionManager.AlterTypeDefinition(XmContentType.CNNotify.ContentTypeName,
             cfg => cfg
       .DisplayedAs(XmContentType.CNNotify.ContentTypeDisplayName)
       .WithPart(typeof(TitlePart).Name)
       .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("OwnerEditorSettings.ShowOwnerEditor", "false"))
       .WithPart(typeof(BodyPart).Name)
       .WithPart(typeof(XmContentPart).Name)
       .WithPart(typeof(CNNotifyPart).Name)
       .WithPart(typeof(UserViewPart).Name, builder => builder.WithSetting("UserViewTypePartSettings.AllowAnonymousViews", "True"))
       .WithSetting("ListTitle", XmContentType.CNNotify.ListTitle)
       .Creatable()
       .Draftable()
       .Securable()
       );



            ContentDefinitionManager.AlterTypeDefinition(XmContentType.CNCop.ContentTypeName,
             cfg => cfg
       .DisplayedAs(XmContentType.CNCop.ContentTypeDisplayName)
       .WithPart(typeof(TitlePart).Name)
       .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("OwnerEditorSettings.ShowOwnerEditor", "false"))
       .WithPart(typeof(BodyPart).Name)
       .WithPart(typeof(XmContentPart).Name)
       .WithPart(typeof(CNCopPart).Name)
       .WithPart(typeof(UserViewPart).Name, builder => builder.WithSetting("UserViewTypePartSettings.AllowAnonymousViews", "True"))
       .WithSetting("ListTitle", XmContentType.CNCop.ListTitle)
       .Creatable()
       .Draftable()
       .Securable()
       );


            return 15;
        }


        public int UpdateFrom15()
        {


            ContentDefinitionManager.AlterPartDefinition(typeof(CNCollegeShowPart).Name,
                cfg =>
                cfg.WithField("image",
                         b => b.OfType("MediaLibraryPickerField")
                             .WithDisplayName("选择图片")
                             .WithSetting("MediaLibraryPickerFieldSettings.Required", "true"))
                   .WithField("linkAddress",
                        b => b.OfType("LinkField")
                            .WithDisplayName("链接地址")
                            .WithSetting("LinkFieldSettings.Required", "true"))
                   .WithField("subtitle", b => b.OfType("InputField")
                            .WithDisplayName("子标题")
                            .WithSetting("InputFieldSettings.Title", "子标题"))

            );

            ContentDefinitionManager.AlterTypeDefinition(XmContentType.CNCollegeShow.ContentTypeName,

              cfg => cfg
              .DisplayedAs(XmContentType.CNCollegeShow.ContentTypeDisplayName)
              .WithPart(typeof(TitlePart).Name)
              .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("OwnerEditorSettings.ShowOwnerEditor", "false"))
              .WithPart(typeof(CNCollegeShowPart).Name)
              .WithSetting("ListTitle", XmContentType.CNCollegeShow.ListTitle)
              .Creatable()
              .Draftable()
              .Securable()
              );

            return 16;
        }


        public int UpdateFrom16()
        {


            SchemaBuilder.CreateTable(typeof(CNTeacherAcademicPaperRelationRecord).Name,
        table => table
        .Column<int>("Id", c => c.PrimaryKey().Identity())
        .Column<int>("TeacherRecord_Id")
        .Column<int>("AcademicPaperRecord_Id")
        );

            SchemaBuilder.CreateTable(typeof(CNTeacherAcademicWorkRelationRecord).Name,
        table => table
        .Column<int>("Id", c => c.PrimaryKey().Identity())
        .Column<int>("TeacherRecord_Id")
        .Column<int>("AcademicWorksRecord_Id")
        );

            SchemaBuilder.CreateTable(typeof(CNTeacherAwardRelationRecord).Name,
        table => table
        .Column<int>("Id", c => c.PrimaryKey().Identity())
        .Column<int>("TeacherRecord_Id")
        .Column<int>("AwardsRecord_Id")
        );

            SchemaBuilder.CreateTable(typeof(CNTeacherProjectRelationRecord).Name,
        table => table
        .Column<int>("Id", c => c.PrimaryKey().Identity())
        .Column<int>("TeacherRecord_Id")
        .Column<int>("ProjectRecord_Id")
        );


            SchemaBuilder.CreateTable(typeof(CNTeacherPartRecord).Name, table =>
            table.ContentPartRecord()
           
            .Column<string>("Number")
            .Column<string>("Name")
            .Column<string>("Rank")
            .Column<string>("Education", c => c.Unlimited())
            .Column<string>("Job", c => c.WithLength(450))
            .Column<string>("Resfield", c => c.Unlimited())
            .Column<string>("Tecoffice", c => c.WithLength(450))
            .Column<string>("Office", c => c.WithLength(450))
            .Column<string>("Telephone")
            .Column<string>("Introduce", c => c.Unlimited())
            .Column<string>("Department", c => c.WithLength(450))
            .Column<string>("Year")
            .Column<string>("Month")
            .Column<string>("Day")
            .Column<DateTime>("Birthday")
            .Column<string>("Avatar", c => c.WithLength(450))
            .Column<string>("Perspective", c => c.Unlimited())
            .Column<string>("Concept", c => c.Unlimited())
            .Column<string>("Publication", c => c.Unlimited())
            .Column<string>("Dissertation", c => c.Unlimited())
            .Column<string>("Course", c => c.Unlimited())
            .Column<string>("Ptjob", c => c.Unlimited())
            .Column<string>("Project", c => c.Unlimited())
            .Column<string>("Contact",c=>c.WithLength(450))
            .Column<bool>("IsShow")
            );


            ContentDefinitionManager.AlterPartDefinition(typeof(CNTeacherPart).Name,
             cfg =>
             cfg.WithField("image",
             b => b.OfType("MediaLibraryPickerField")
                 .WithDisplayName("选择相关图片"))
            );

            ContentDefinitionManager.AlterTypeDefinition(XmContentType.CNTeacher.ContentTypeName,

              cfg => cfg
              .DisplayedAs(XmContentType.CNTeacher.ContentTypeDisplayName)
              .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("OwnerEditorSettings.ShowOwnerEditor", "false"))
              .WithPart(typeof(CNTeacherPart).Name)
              .WithPart(typeof(BodyPart).Name)
              .WithPart(typeof(UserViewPart).Name, builder => builder.WithSetting("UserViewTypePartSettings.AllowAnonymousViews", "True"))
              .WithSetting("ListTitle", XmContentType.CNTeacher.ListTitle)
              .Creatable()
              .Draftable()
              .Securable()
              );


            return 17;
        }

        public int UpdateFrom17()
        {

            SchemaBuilder.CreateTable(typeof(ProjectRecord).Name, table
          => table.ContentPartRecord()
          .Column<string>("Tid")
          .Column<string>("ProjectTitle")
          .Column<string>("Host")
          .Column<string>("Year")
          .Column<string>("Department")
          .Column<string>("Source")
          .Column<string>("Level")
          .Column<string>("SerialNumber")
          .Column<string>("Aidfunds")
          .Column<string>("Members")
          .Column<string>("Aidhost")
          .Column<string>("StartDate")
          .Column<string>("EndDate")
          .Column<string>("FinishDate")
          .Column<string>("AidSituation")
          .Column<string>("Remarks", c => c.Unlimited())
        //  .Column<DateTime>("Inputdate")
          .Column<int>("Clicknumber")
         // .Column<DateTime>("RefreshDate")
          .Column<string>("ResultType")
          .Column<string>("Member1")
          .Column<string>("Funds1")
          .Column<string>("Member2")
          .Column<string>("Funds2")
          .Column<string>("Member3")
          .Column<string>("Funds3")
          .Column<string>("Member4")
          .Column<string>("Funds4")
          .Column<string>("Member5")
          .Column<string>("Funds5")
          .Column<string>("Member6")
          .Column<string>("Funds6")
          .Column<string>("Member7")
          .Column<string>("Funds7")
          .Column<string>("Member8")
          .Column<string>("Funds8")
          .Column<string>("Member9")
          .Column<string>("Funds9")
          .Column<string>("Member10")
          .Column<string>("Funds10"));


            ContentDefinitionManager.AlterPartDefinition(typeof(ProjectPart).Name,
           cfg =>
           cfg.WithField("image",
           b => b.OfType("MediaLibraryPickerField")
               .WithDisplayName("选择相关图片"))
          );



            ContentDefinitionManager.AlterTypeDefinition(XmContentType.CNProject.ContentTypeName,

              cfg => cfg
              .DisplayedAs(XmContentType.CNProject.ContentTypeDisplayName)
              .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("OwnerEditorSettings.ShowOwnerEditor", "false"))
              .WithPart(typeof(ProjectPart).Name)
              .WithPart(typeof(BodyPart).Name)
              .WithPart(typeof(UserViewPart).Name, builder => builder.WithSetting("UserViewTypePartSettings.AllowAnonymousViews", "True"))
              .WithSetting("ListTitle", XmContentType.CNProject.ListTitle)
              .Creatable()
              .Draftable()
              .Securable()
              );

            return 18;
        }


        public int UpdateFrom18()
        {

            SchemaBuilder.CreateTable(typeof(AcademicPaperRecord).Name,
                      table =>
                      table.ContentPartRecord()
                      .Column<string>("Tid")
                      .Column<string>("Title")
                      .Column<string>("Author")
                      .Column<string>("Year")
                      .Column<string>("Department")
                      .Column<string>("Keyword")
                      .Column<string>("Summary", c => c.Unlimited())
                      .Column<string>("Text", c => c.Unlimited())
                      .Column<string>("ReleaseDate")
                      .Column<string>("Publication")
                      .Column<string>("Pid")
                      .Column<string>("Ptime")
                      .Column<string>("Plevel")
                      .Column<string>("Writertype")
                      .Column<int>("TextNumber")
                      .Column<string>("Remarks", c => c.Unlimited())
                      //.Column<DateTime>("InputDate")
                      .Column<int>("ClickNumber")
                      //.Column<DateTime>("RefreshDate")
                      .Column<bool>("IsShow")
                      .Column<string>("Achievement", c => c.Unlimited())
                      .Column<string>("ImportantJournal", c => c.Unlimited())
                      .Column<string>("RePrint")
                      .Column<string>("ResearchResult", c => c.Unlimited())

                      );

            ContentDefinitionManager.AlterPartDefinition(typeof(AcademicPaperPart).Name,
           cfg =>
           cfg.WithField("image",
           b => b.OfType("MediaLibraryPickerField")
               .WithDisplayName("选择相关图片"))
          );


            ContentDefinitionManager.AlterTypeDefinition(XmContentType.CNAcademicPaper.ContentTypeName,

              cfg => cfg
              .DisplayedAs(XmContentType.CNAcademicPaper.ContentTypeDisplayName)
              .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("OwnerEditorSettings.ShowOwnerEditor", "false"))
              .WithPart(typeof(AcademicPaperPart).Name)
              .WithPart(typeof(BodyPart).Name)
              .WithPart(typeof(UserViewPart).Name, builder => builder.WithSetting("UserViewTypePartSettings.AllowAnonymousViews", "True"))
              .WithSetting("ListTitle", XmContentType.CNAcademicPaper.ListTitle)
              .Creatable()
              .Draftable()
              .Securable()
              );


            return 19;
        }


        public int UpdateFrom19()
        {


            SchemaBuilder.CreateTable(typeof(AcademicWorksRecord).Name,
                table =>
                table.ContentPartRecord()
                .Column<string>("Tid")
                .Column<string>("Title")
                .Column<string>("Author")
                .Column<string>("Year")
                .Column<string>("Department")
                .Column<string>("Publishunit")
                .Column<string>("Booknumber")
                .Column<string>("Publishdate")
                .Column<string>("Booktype")
                .Column<string>("WriterType")
                .Column<int>("AllTextBumber")
                .Column<int>("FinishNumber")
                .Column<string>("Author1")
                .Column<int>("TextNumber1")
                .Column<string>("Author2")
                .Column<int>("TextNumber2")
                .Column<string>("Author3")
                .Column<int>("TextNumber3")
                .Column<string>("Author4")
                .Column<int>("TextNumber4")
                .Column<string>("Author5")
                .Column<int>("TextNumber5")
                .Column<string>("Author6")
                .Column<int>("TextNumber6")
                .Column<string>("Author7")
                .Column<int>("TextNumber7")
                .Column<string>("Author8")
                .Column<int>("TextNumber8")
                .Column<string>("Author9")
                .Column<int>("TextNumber9")
                .Column<string>("Author10")
                .Column<int>("TextNumber10")
                .Column<int>("IsResult")
                .Column<string>("SourceName")
                .Column<string>("ProjectName")
                .Column<string>("Introduce", c => c.Unlimited())
                .Column<string>("Remarks", c => c.Unlimited())
                .Column<string>("Keyword")
                .Column<string>("Summary", c => c.Unlimited())
                .Column<string>("Text", c => c.Unlimited())
               // .Column<DateTime>("InputDate")
                .Column<int>("ClickNumber")
                //.Column<DateTime>("RefreshDate")
                .Column<string>("ResultType")
                .Column<string>("Picture")

                );

            ContentDefinitionManager.AlterPartDefinition(typeof(AcademicWorksPart).Name,
             cfg =>
             cfg.WithField("image",
             b => b.OfType("MediaLibraryPickerField")
               .WithDisplayName("选择相关图片"))
            );

            ContentDefinitionManager.AlterTypeDefinition(XmContentType.CNAcademicWork.ContentTypeName,

              cfg => cfg
              .DisplayedAs(XmContentType.CNAcademicWork.ContentTypeDisplayName)
              .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("OwnerEditorSettings.ShowOwnerEditor", "false"))
              .WithPart(typeof(AcademicWorksPart).Name)
              .WithPart(typeof(BodyPart).Name)
              .WithPart(typeof(UserViewPart).Name, builder => builder.WithSetting("UserViewTypePartSettings.AllowAnonymousViews", "True"))
              .WithSetting("ListTitle", XmContentType.CNAcademicWork.ListTitle)
              .Creatable()
              .Draftable()
              .Securable()
              );

            return 20;
        }


        public int UpdateFrom20()
        {


            SchemaBuilder.CreateTable(typeof(AwardsRecord).Name, table =>
             table.ContentPartRecord()
             .Column<string>("Tid")
             .Column<string>("WinnerName")
             .Column<string>("AwardName")
             .Column<string>("Year")
             .Column<string>("BelongDepartment")
             .Column<string>("AwardDepartment")
             .Column<string>("AwardDate")
             .Column<string>("AwardRank")
             .Column<string>("AwardLevel")
             .Column<string>("ResultProject")
             .Column<string>("ResultForm")
             .Column<string>("Author")
             .Column<string>("Collaborator")
             .Column<string>("Codes")
             .Column<string>("Remarks", c => c.Unlimited())
             //.Column<DateTime>("InputDate")
             .Column<int>("Clicknumber")
             //.Column<DateTime>("RefreshDate")
             .Column<string>("ResultType")
            );



            ContentDefinitionManager.AlterPartDefinition(typeof(AwardsPart).Name,
             cfg =>
             cfg.WithField("image",
             b => b.OfType("MediaLibraryPickerField")
               .WithDisplayName("选择相关图片"))
            );


            ContentDefinitionManager.AlterTypeDefinition(XmContentType.CNAward.ContentTypeName,

              cfg => cfg
              .DisplayedAs(XmContentType.CNAward.ContentTypeDisplayName)
              .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("OwnerEditorSettings.ShowOwnerEditor", "false"))
              .WithPart(typeof(AwardsPart).Name)
              .WithPart(typeof(BodyPart).Name)
              .WithPart(typeof(UserViewPart).Name, builder => builder.WithSetting("UserViewTypePartSettings.AllowAnonymousViews", "True"))
              .WithSetting("ListTitle", XmContentType.CNAward.ListTitle)
              .Creatable()
              .Draftable()
              .Securable()
              );


            return 21;
        }


        public int UpdateFrom21()
        {
            ContentDefinitionManager.AlterPartDefinition(typeof(ScientificResearchCommonPart).Name,
              cfg =>
              cfg.WithField("istop",
                       b => b.OfType("BooleanField")
                           .WithDisplayName("置顶")
                           .WithSetting("BooleanFieldSettings.DefaultValue", "False")
                           )
             );

            ContentDefinitionManager.AlterTypeDefinition(XmContentType.CNProject.ContentTypeName,
                cfg => cfg.WithPart(typeof(ScientificResearchCommonPart).Name));

            ContentDefinitionManager.AlterTypeDefinition(XmContentType.CNAcademicPaper.ContentTypeName,
                cfg => cfg.WithPart(typeof(ScientificResearchCommonPart).Name));

            ContentDefinitionManager.AlterTypeDefinition(XmContentType.CNAcademicWork.ContentTypeName,
                cfg => cfg.WithPart(typeof(ScientificResearchCommonPart).Name));

            ContentDefinitionManager.AlterTypeDefinition(XmContentType.CNAward.ContentTypeName,
                cfg => cfg.WithPart(typeof(ScientificResearchCommonPart).Name));

            return 22;
        }
 
    }
}