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

            return 1;
        }



        public int UpdateFrom1()
        {

            return 2;
        }

        public int UpdateFrom2()
        {
        
            return 3;
        }

        public int UpdateFrom3()
        {

            return 4;

        }

        public int UpdateFrom4()
        {

       
            return 5;

        }

        public int UpdateFrom5()
        {


            ContentDefinitionManager.AlterTypeDefinition(XmContentType.StudentInfo.ContentTypeName,
             cfg => cfg
       .DisplayedAs(XmContentType.StudentInfo.ContentTypeDisplayName)
       .WithPart(typeof(TitlePart).Name)
       .WithPart(typeof(CommonPart).Name)
       .WithPart(typeof(BodyPart).Name)
       .WithPart(typeof(StudentInfoPart).Name)
       .WithPart(typeof(UserViewPart).Name)
       .Creatable()
       .Draftable()
       .Securable()
       );
            return 6;

        }

        public int UpdateFrom6()
        {


            ContentDefinitionManager.AlterTypeDefinition(XmContentType.PublicPartyCollegeAffairs.ContentTypeName,
             cfg => cfg
       .DisplayedAs(XmContentType.PublicPartyCollegeAffairs.ContentTypeDisplayName)
       .WithPart(typeof(TitlePart).Name)
       .WithPart(typeof(CommonPart).Name)
       .WithPart(typeof(BodyPart).Name)
       .WithPart(typeof(PublicPartyCollegeAffairsPart).Name)
       .WithPart(typeof(UserViewPart).Name)
       .Creatable()
       .Draftable()
       .Securable()
       );
            return 7;

        }


        public int UpdateFrom7()
        {


            ContentDefinitionManager.AlterTypeDefinition(XmContentType.RecruitInfo.ContentTypeName,
             cfg => cfg
       .DisplayedAs(XmContentType.RecruitInfo.ContentTypeDisplayName)
       .WithPart(typeof(TitlePart).Name)
       .WithPart(typeof(CommonPart).Name)
       .WithPart(typeof(BodyPart).Name)
       .WithPart(typeof(RecruitInfoPart).Name)
       .WithPart(typeof(UserViewPart).Name)

       .Creatable()
       .Draftable()
       .Securable()
       );
            return 8;

        }


        public int UpdateFrom8()
        {
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
       .WithPart(typeof(CommonPart).Name)
       .WithPart(typeof(BodyPart).Name)
       .WithPart(typeof(LectureInfoPart).Name)
       .WithPart(typeof(UserViewPart).Name)

       .Creatable()
       .Draftable()
       .Securable()
       );

            return 9;
        }

        public int UpdateFrom9()
        {


            ContentDefinitionManager.AlterTypeDefinition(XmContentType.AcademicNews.ContentTypeName,
             cfg => cfg
       .DisplayedAs(XmContentType.AcademicNews.ContentTypeDisplayName)
       .WithPart(typeof(TitlePart).Name)
       .WithPart(typeof(CommonPart).Name)
       .WithPart(typeof(BodyPart).Name)
       .WithPart(typeof(AcademicNewsPart).Name)
              .WithPart(typeof(UserViewPart).Name)

       .Creatable()
       .Draftable()
       .Securable()
       );

            return 10;
        }

        public int UpdateFrom10()
        {
            foreach (var mapping in XmContentType.ENCMSMappings)
            {


                ContentDefinitionManager.AlterTypeDefinition(mapping.ContentTypeName,
                 cfg => cfg
           .DisplayedAs(mapping.ContentTypeDisplayName)
           .WithPart(typeof(TitlePart).Name)
           .WithPart(typeof(CommonPart).Name)
           .WithPart(typeof(BodyPart).Name)
           .WithPart(typeof(XmContentPart).Name)
                  .WithPart(typeof(UserViewPart).Name)

           .Creatable()
           .Draftable()
           .Securable()
           );



            }

            return 11;
        }


        public int UpdateFrom11()
        {
            foreach (var mapping in XmContentType.NinetyMappings)
            {

                ContentDefinitionManager.AlterTypeDefinition(mapping.ContentTypeName,
                 cfg => cfg
           .DisplayedAs(mapping.ContentTypeDisplayName)
           .WithPart(typeof(TitlePart).Name)
           .WithPart(typeof(CommonPart).Name)
           .WithPart(typeof(BodyPart).Name)
           .WithPart(typeof(College90CelebrationPart).Name)
           .WithPart(typeof(UserViewPart).Name)
           .Creatable()
           .Draftable()
           .Securable()
           );

            }

            ContentDefinitionManager.AlterPartDefinition(typeof(NinetyCelebrationDonationPart).Name,
                cfg =>
                cfg.WithField("donator", b => b.OfType("TextField").WithDisplayName("捐款人").WithSetting("TextFieldSettings.Required","true"))
                .WithField("donationAmount", b => b.OfType("TextField").WithDisplayName("捐款金额").WithSetting("TextFieldSettings.Required", "true"))
                .WithField("donationTime", b => b.OfType("DateTimeField").WithDisplayName("捐款时间").WithSetting("DateTimeFieldSettings.Required", "true")
                .WithSetting("DateTimeFieldSettings.Display", "DateOnly"))
            );

            ContentDefinitionManager.AlterTypeDefinition(XmContentType.NinetyDonation.ContentTypeName,
            
                cfg => cfg
                .DisplayedAs(XmContentType.NinetyDonation.ContentTypeDisplayName)
                .WithPart(typeof(TitlePart).Name)
                .WithPart(typeof(CommonPart).Name)
                .WithPart(typeof(NinetyCelebrationDonationPart).Name)
                .WithPart(typeof(UserViewPart).Name)
                .Creatable()
                .Draftable()
                .Securable()
       );




            return 12;
        }


    }
}