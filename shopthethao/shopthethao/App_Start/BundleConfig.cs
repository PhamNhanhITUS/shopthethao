using System.Web;
using System.Web.Optimization;

namespace shopthethao
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/Scripts/jquery.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/jquery.scrollUp.min.js",
                "~/Scripts/price-range.js",
                "~/Scripts/jquery.prettyPhoto.js",
                "~/Scripts/main.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/prettyPhoto.css",
                      "~/Content/price-range.css",
                      "~/Content/animate.css",
                      "~/Content/main.css",
                     "~/Content/responsive.css"));
        }
    }
}
