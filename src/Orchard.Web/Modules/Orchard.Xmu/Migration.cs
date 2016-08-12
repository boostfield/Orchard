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
 
    
            //学院新闻
           ContentDefinitionManager.AlterTypeDefinition(XmContentType.CollegeNews.ContentTypeName,
                cfg => cfg
          .DisplayedAs(XmContentType.CollegeNews.ContentTypeDisplayName)
          .WithPart(typeof(TitlePart).Name)
          .WithPart(typeof(CommonPart).Name)
          .WithPart(typeof(BodyPart).Name)
          .WithPart(typeof(CollegeNewsPart).Name)
          .WithPart(typeof(UserViewPart).Name)
          .Creatable()
          .Draftable()
          .Securable()
          );

            return 2;
        }

        public int UpdateFrom2()
        {
            ContentDefinitionManager.AlterTypeDefinition(XmContentType.CollegeAffairsNotify.ContentTypeName,
             cfg => cfg
       .DisplayedAs(XmContentType.CollegeAffairsNotify.ContentTypeDisplayName)
       .WithPart(typeof(TitlePart).Name)
       .WithPart(typeof(CommonPart).Name)
       .WithPart(typeof(BodyPart).Name)
       .WithPart(typeof(CollegeAffairsNotifyPart).Name)
       .WithPart(typeof(UserViewPart).Name)
       .Creatable()
       .Draftable()
       .Securable()
       );
            return 3;
        }

        public int UpdateFrom3()
        {

            ContentDefinitionManager.AlterTypeDefinition(XmContentType.UndergraduateAffairs.ContentTypeName,
             cfg => cfg
       .DisplayedAs(XmContentType.UndergraduateAffairs.ContentTypeDisplayName)
       .WithPart(typeof(TitlePart).Name)
       .WithPart(typeof(CommonPart).Name)
       .WithPart(typeof(BodyPart).Name)
       .WithPart(typeof(UndergraduateAffairsPart).Name)
       .WithPart(typeof(UserViewPart).Name)
       .Creatable()
       .Draftable()
       .Securable()
       );
            return 4;

        }

        public int UpdateFrom4()
        {

            ContentDefinitionManager.AlterTypeDefinition(XmContentType.GraduateAffairs.ContentTypeName,
             cfg => cfg
       .DisplayedAs(XmContentType.GraduateAffairs.ContentTypeDisplayName)
       .WithPart(typeof(TitlePart).Name)
       .WithPart(typeof(CommonPart).Name)
       .WithPart(typeof(BodyPart).Name)
       .WithPart(typeof(GraduateAffairsPart).Name)
       .WithPart(typeof(UserViewPart).Name)
       .Creatable()
       .Draftable()
       .Securable()
       );
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
       .WithPart(typeof(StudentInfoPart).Name)
       .WithPart(typeof(PublicPartyCollegeAffairsPart).Name)
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
       .WithPart(typeof(StudentInfoPart).Name)
       .WithPart(typeof(RecruitInfoPart).Name)
       .Creatable()
       .Draftable()
       .Securable()
       );
            return 8;

        }
    }
}