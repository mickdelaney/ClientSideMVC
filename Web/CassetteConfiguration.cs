using System.IO;
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
            var topLevelOnly = new FileSearch { SearchOption = SearchOption.TopDirectoryOnly };

            bundles.AddPerIndividualFile<ScriptBundle>("Client", topLevelOnly);
            bundles.Add<ScriptBundle>("Client/Vendor");
            bundles.Add<ScriptBundle>("Client/App");
            

            bundles.AddPerSubDirectory<StylesheetBundle>("Client");
            bundles.AddPerSubDirectory<HtmlTemplateBundle>("Client");
        }
    }
}