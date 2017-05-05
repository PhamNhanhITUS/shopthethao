using System.Web;
using System.Web.Optimization;

namespace shopthethao
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/User/scripts").Include(
                "~/Scripts/User/jquery.js",
                "~/Scripts/User/bootstrap.min.js",
                "~/Scripts/User/jquery.scrollUp.min.js",
                "~/Scripts/User/price-range.js",
                "~/Scripts/User/jquery.prettyPhoto.js",
                "~/Scripts/User/main.js"));
            bundles.Add(new StyleBundle("~/Content/User/css").Include(
                      "~/Content/User/bootstrap.min.css",
                      "~/Content/User/font-awesome.min.css",
                      "~/Content/User/prettyPhoto.css",
                      "~/Content/User/price-range.css",
                      "~/Content/User/animate.css",
                      "~/Content/User/main.css",
                     "~/Content/User/responsive.css"));
        }
    }
}
