using Orchard.UI.Resources;

namespace Orchard.Xmu {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();
            manifest.DefineScript("NewsMarquee").SetUrl("jquery.newsTicker.min.js").SetDependencies("jQuery");
            manifest.DefineScript("Sly").SetUrl("sly.min.js").SetDependencies("jQuery");
        }
    }
}
