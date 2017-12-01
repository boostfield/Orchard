using Orchard.ContentManagement.Records;
using Orchard.Data.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class StudentRecord : ContentPartRecord
    {
        public virtual string StudentID { get; set; } //学号
        public virtual string Name { get; set; } //姓名
        public virtual string IdentityID { get; set; } //身份证

        public virtual string Gender { get; set; } //性别

        public virtual string Birthday { get; set; } //出生年月日

        [StringLengthMax]
        public virtual string PlaceOfBirth { get; set; } //籍贯

        [StringLengthMax]
        public virtual string Address { get; set; } //家庭住址

        public virtual string PoliticalStatus { get; set; } //政治面貌

        public virtual string TelNo { get; set; } //手机号

        public virtual string WechatNo { get; set; } //微信号


        public virtual string QQNo { get; set; } //QQ号

        public virtual string Email { get; set; } //Email邮箱

        public virtual string Grade { get; set; } //年级； 本科，硕士，博士，博士后

        public virtual string YearOfAdmission { get; set; } //入学年份

        [StringLengthMax]
        public virtual string DormitoryAddress { get; set; } //宿舍地址

        [StringLengthMax]
        public virtual string AfterGraduation { get; set; } //毕业去向
    }
}