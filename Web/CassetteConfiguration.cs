using Cassette;
using Cassette.HtmlTemplates;
using Cassette.Scripts;
using Cassette.Stylesheets;

namespace ClientSideMvc.Web
{
    public class CassetteConfiguration : IConfiguration<BundleCollection>
    {
        public void Configure(BundleCollection bundles)
        {
            bundles.AddPerSubDirectory<ScriptBundle>("Client");
            bundles.AddPerSubDirectory<StylesheetBundle>("Client");
            bundles.AddPerSubDirectory<HtmlTemplateBundle>("Client");
        }
    }
}