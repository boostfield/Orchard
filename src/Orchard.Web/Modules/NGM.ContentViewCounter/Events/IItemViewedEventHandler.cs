using Orchard.ContentManagement;
using Orchard.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NGM.ContentViewCounter.Events
{
    public interface IItemViewedEventHandler: IEventHandler
    {
        void ContentItemViewed(ContentItem item);

    }
}