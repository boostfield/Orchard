using Orchard.ContentManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class StudentPart: ContentPart<StudentRecord>
    {
        [DisplayName("学号")]
        public string StudentID
        {
            get
            {
                return Retrieve(i => i.StudentID);
            }
            set
            {
                Store(i => i.StudentID, value);
            }
        }

        [DisplayName("姓名")]
        public string Name
        {
            get
            {
                return Retrieve(i => i.Name);
            }
            set
            {
                Store(i => i.Name, value);
            }
        }


        [DisplayName("身份证")]
        public string IdentityID
        {
            get
            {
                return Retrieve(i => i.IdentityID);
            }
            set
            {
                Store(i => i.IdentityID, value);
            }
        }

        [DisplayName("性别")]
        public string Gender
        {
            get
            {
                return Retrieve(i => i.Gender);
            }
            set
            {
                Store(i => i.Gender, value);
            }
        }

        [DisplayName("出生年月日(格式为xxxx/xx/xx)")]
        public string Birthday
        {
            get
            {
                return Retrieve(i => i.Birthday);
            }
            set
            {
                Store(i => i.Birthday, value);
            }
        }

        [DisplayName("籍贯")]
        public string PlaceOfBirth
        {
            get
            {
                return Retrieve(i => i.PlaceOfBirth);
            }
            set
            {
                Store(i => i.PlaceOfBirth, value);
            }
        }


        [DisplayName("家庭住址")]
        public string Address
        {
            get
            {
                return Retrieve(i => i.Address);
            }
            set
            {
                Store(i => i.Address, value);
            }
        }


        [DisplayName("政治面貌")]
        public string PoliticalStatus
        {
            get
            {
                return Retrieve(i => i.PoliticalStatus);
            }
            set
            {
                Store(i => i.PoliticalStatus, value);
            }
        }

        [DisplayName("手机号")]
        public string TelNo
        {
            get
            {
                return Retrieve(i => i.TelNo);
            }
            set
            {
                Store(i => i.TelNo, value);
            }
        }

        [DisplayName("微信号")]
        public string WechatNo
        {
            get
            {
                return Retrieve(i => i.WechatNo);
            }
            set
            {
                Store(i => i.WechatNo, value);
            }
        }


        [DisplayName("QQ号")]
        public string QQNo
        {
            get
            {
                return Retrieve(i => i.QQNo);
            }
            set
            {
                Store(i => i.QQNo, value);
            }
        }

        [DisplayName("电子邮箱")]
        public string Email
        {
            get
            {
                return Retrieve(i => i.Email);
            }
            set
            {
                Store(i => i.Email, value);
            }
        }


        [DisplayName("类别（本科，硕士，博士，博士后）")]
        public string Grade
        {
            get
            {
                return Retrieve(i => i.Grade);
            }
            set
            {
                Store(i => i.Grade, value);
            }
        }
        [DisplayName("入学年份")]
        public string YearOfAdmission
        {
            get
            {
                return Retrieve(i => i.YearOfAdmission);
            }
            set
            {
                Store(i => i.YearOfAdmission, value);
            }
        }

        [DisplayName("宿舍地址")]
        public string DormitoryAddress
        {
            get
            {
                return Retrieve(i => i.DormitoryAddress);
            }
            set
            {
                Store(i => i.DormitoryAddress, value);
            }
        }

        [DisplayName("毕业去向")]
        public string AfterGraduation
        {
            get
            {
                return Retrieve(i => i.AfterGraduation);
            }
            set
            {
                Store(i => i.AfterGraduation, value);
            }
        }

    }
}