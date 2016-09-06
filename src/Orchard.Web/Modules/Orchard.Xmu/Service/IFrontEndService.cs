using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;
using Orchard.Xmu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchard.Xmu.Service
{
    public interface IFrontEndService: IDependency
    {
        IList<ContentItem> LatestContentOfType(string contentTypeName, int count = 5);
        IList<ContentItem> TopContentsOfType(string contentTypeName);
    }
}
