using System.Web;
using System.Web.Optimization;

namespace CQRSBetter.Website
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle(Links.Bundles.Scripts.jquery).Include(
                        Links.Bundles.Scripts.Assets.jquery_1_10_2_js));

            bundles.Add(new ScriptBundle(Links.Bundles.Scripts.jqueryval).Include(
                        Links.Scripts.jquery_validate_js,
                        Links.Scripts.jquery_validate_unobtrusive_js,
                        Links.Scripts.jquery_validate_vsdoc_js));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle(Links.Bundles.Scripts.modernizr).Include(
                        Links.Scripts.modernizr_2_6_2_js));

            bundles.Add(new ScriptBundle(Links.Bundles.Scripts.bootstrap).Include(
                      Links.Scripts.bootstrap_js,
                      Links.Scripts.respond_js));

            bundles.Add(new StyleBundle(Links.Bundles.Content.css).Include(
                      Links.Content.bootstrap_css,
                      Links.Content.Site_css));
        }
    }
}

namespace Links
{
    public static partial class Bundles
    {
        public static partial class Scripts
        {
            public static readonly string jquery = "~/scripts/jquery";
            public static readonly string jqueryval = "~/scripts/jqueryval";
            public static readonly string modernizr = "~/bundles/modernizr";
            public static readonly string bootstrap = "~/bundles/bootstrap";
        }
        public static partial class Content
        {
            public static readonly string css = "~/content/css";
        }
    }
}
