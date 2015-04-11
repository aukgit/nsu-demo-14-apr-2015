using System.Web;
using System.Web.Optimization;

namespace NSUDemo {
    public class BundleConfig {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/wow.min.js",
                      "~/Scripts/toastr.min.js",
                      "~/Scripts/owl.carousel.min.js",
                      "~/Scripts/moment.min.js",
                      "~/Scripts/greenshock/TweenMax.js",
                      "~/Scripts/Custom.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/bootstrap.css",
                        "~/Content/css/site.css",
                        "~/Content/css/less-imports.css",
                        "~/Content/css/animate.min.css",
                        "~/Content/css/font-awesome.min.css",
                        "~/Content/css/color-fonts.css",
                        "~/Content/css/override-mvc.css",
                        "~/Content/css/front-developer.css",
                        "~/Content/css/utilities.css"
                                        ));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;
        }
    }
}
