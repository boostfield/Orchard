using NGM.ContentViewCounter.Models;
using Orchard.Autoroute.Models;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Common.Models;
using Orchard.Core.Contents.Extensions;
using Orchard.Core.Title.Models;
using Orchard.Data.Migration;
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
                table=>
 
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

           .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("DateEditorSettings.ShowDateEditor", "false")));
            ContentDefinitionManager.AlterTypeDefinition(XmContentType.LectureInfo.ContentTypeName,
             cfg => cfg

           .WithPart(typeof(CommonPart).Name, builder => builder.WithSetting("DateEditorSettings.ShowDateEditor", "false")));
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
        
    }
}