using System.Web;
using System.Web.Optimization;

namespace T1908EOnlineCourse
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/bundles/quirk-css").Include(
                        "~/Content/quirk/Hover/hover.css",
                        "~/Content/quirk/fontawesome/css/font-awesome.css",
                        "~/Content/quirk/weather-icons/css/weather-icons.css",
                        "~/Content/quirk/ionicons/css/ionicons.css",
                        "~/Content/quirk/jquery-toggles/toggles-full.css",
                        "~/Content/quirk/morrisjs/morris.css",
                        "~/Content/quirk/quirk.css"
                        ));
            bundles.Add(new ScriptBundle("~/bundles/quirk-js").Include(
                      "~/Content/quirk/modernizr/modernizr.js",
                      "~/Content/quirk/jquery/jquery.js",
                      "~/Content/quirk/jquery-ui/jquery-ui.js",
                      "~/Content/quirk/bootstrap/js/bootstrap.js",
                      "~/Content/quirk/jquery-toggles/toggles.js",
                      "~/Content/quirk/morrisjs/morris.js",
                      "~/Content/quirk/raphael/raphael.js",
                      "~/Content/quirk/flot/jquery.flot.js",
                      "~/Content/quirk/flot/jquery.flot.resize.js",
                      "~/Content/quirk/flot-spline/jquery.flot.spline.js",
                      "~/Content/quirk/jquery-knob/jquery.knob.js",
                      "~/Content/quirk/quirk.js"
                      ));
        }
    }
}
