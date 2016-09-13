using Orchard.ContentManagement;
using Orchard.ContentManagement.Utilities;
using System;

namespace NGM.ContentViewCounter.Models {
    public class UserViewPart : ContentPart<UserViewPartRecord> {

        public int ViewCount
        {
            get { var c = Retrieve(i => i.VCount);
                if (c == 0)
                {
                    Store(i => i.VCount,  new Random().Next(200, 400));

                }
                return Retrieve(i => i.VCount);
            }
            set { Store(i => i.VCount, value); }
        }


        /*
        private LazyField<int> _TotalView = new LazyField<int>();

        public LazyField<int> TotalViewField { get { return _TotalView; } }

        public int TotalViews {
            get
            {
                //return _TotalView.Value;
                return 1;
            }
            set
            {

            }
        }
        */
    }
}