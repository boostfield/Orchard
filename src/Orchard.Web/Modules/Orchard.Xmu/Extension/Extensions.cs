using Orchard.ContentManagement.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Http.ModelBinding;

namespace Orchard.Xmu.Extension
{
    public static class Extensions
    {
        private static readonly Regex regexChinese = new Regex(@"\p{IsCJKUnifiedIdeographs}");

        public static bool IsChinese(this char s)
        {
            return regexChinese.IsMatch(s.ToString());
        }

        public static string FlattenToErrStringList(this ModelStateDictionary ModelState)
        {
            return string.Join(",", ModelState.Values.SelectMany(v => v.Errors)
                .Select(x => x.ErrorMessage));
        }



        public static Tuple<IList<T>, IList<int>> Maintains<T>(IList<T> Sources, IList<int> NewIds) where T : ContentPartRecord
        {
            var ToExists = Sources.Where(i => NewIds.Contains(i.ContentItemRecord.Id)).ToList();
            var ToExistIds = ToExists.Select(j => j.Id).ToList();
            var ToDelete = Sources.Where(i => !ToExistIds.Contains(i.ContentItemRecord.Id)).ToList();
            var ToAdd = NewIds.Where(id => !ToExistIds.Contains(id)).ToList();



            return new Tuple<IList<T>, IList<int>>(
                    ToDelete,
                    ToAdd
                );
        }
    }
}