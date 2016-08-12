using Orchard.ContentManagement;
using Orchard.ContentManagement.Utilities;

namespace NGM.ContentViewCounter.Models {
    public class UserViewPart : ContentPart {


        private LazyField<int> _TotalView = new LazyField<int>();

        public LazyField<int> TotalViewField { get { return _TotalView; } }

        public int TotalViews {
            get
            {
                return _TotalView.Value;
            }
            set
            {

            }
        }
    }
}