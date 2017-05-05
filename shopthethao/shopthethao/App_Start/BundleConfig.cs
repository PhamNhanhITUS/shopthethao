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
                "~/Scripts/User/js/jquery.js",
                "~/Scripts/User/js/bootstrap.min.js",
                "~/Scripts/User/js/jquery.scrollUp.min.js",
                "~/Scripts/User/js/price-range.js",
                "~/Scripts/User/js/jquery.prettyPhoto.js",
                "~/Scripts/User/js/main.js",
                 "~/Scripts/User/js/npm.js"
                ));

            bundles.Add(new StyleBundle("~/Content/User/css").Include(
                      "~/Content/User/css/bootstrap.min.css",
                      "~/Content/User/css/font-awesome.min.css",
                      "~/Content/User/css/prettyPhoto.css",
                      "~/Content/User/css/price-range.css",
                      "~/Content/User/css/animate.css",
                      "~/Content/User/css/main.css",
                     "~/Content/User/css/responsive.css"));

            bundles.Add(new ScriptBundle("~/bundles/Admin/scripts").Include(
                         "~/Content/Admin/plugins/jQuery/jquery-2.2.3.min.js",
                        "~/Content/Admin/bootstrap/js/bootstrap.min.js",
                        "~/Content/Admin/plugins/morris/morris.min.js",
                        "~/Content/Admin/plugins/sparkline/jquery.sparkline.min.js",
                        "~/Content/Admin/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                        "~/Content/Admin/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
                        "~/Content/Admin/plugins/knob/jquery.knob.js",
                        "~/Content/Admin/plugins/daterangepicker/daterangepicker.js",
                        "~/Content/Admin/plugins/datepicker/bootstrap-datepicker.js",
                        "~/Content/Admin/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
                        "~/Content/Admin/plugins/slimScroll/jquery.slimscroll.min.js",
                        "~/Content/Admin/plugins/fastclick/fastclick.js",
                        "~/Content/Admin/dist/js/app.min.js",
                        "~/Content/Admin/dist/js/pages/dashboard.js"));

            bundles.Add(new StyleBundle("~/Content/Admin/css").Include(
                  "~/Content/Admin/bootstrap/css/bootstrap.min.css",
                  "~/Content/Admin/dist/css/AdminLTE.min.css",
                  "~/Content/Admin/dist/css/skins/_all-skins.min.css",
                  "~/Content/Admin/plugins/iCheck/flat/blue.css",
                  "~/Content/Admin/plugins/morris/morris.css",
                  "~/Content/Admin/plugins/jvectormap/jquery-jvectormap-1.2.2.css",
                  "~/Content/Admin/plugins/datepicker/datepicker3.css",
                  "~/Content/Admin/plugins/daterangepicker/daterangepicker.css",
                  "~/Content/Admin/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css" ));
        }
    }
}
