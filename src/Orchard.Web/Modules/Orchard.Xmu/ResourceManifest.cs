using Orchard.UI.Resources;

namespace Orchard.Xmu {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();
            manifest.DefineScript("NewsMarquee").SetUrl("jquery.newsTicker.min.js").SetDependencies("jQuery");
            manifest.DefineScript("Sly").SetUrl("sly.min.js").SetDependencies("jQuery");
            manifest.DefineStyle("Select2").SetUrl("select2.min.css");
            manifest.DefineScript("Select2").SetUrl("select2.min.js").SetDependencies("jQuery");
            manifest.DefineScript("Select2Full").SetUrl("select2.full.min.js").SetDependencies("Select2");
            manifest.DefineScript("Course").SetUrl("course.js").SetDependencies("Select2Full");
        }
    }
}
