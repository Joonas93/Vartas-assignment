using System.Web;
using System.Web.Optimization;

namespace VartasAssignment
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/otherscripts").Include(
                "~/Scripts/finnkino.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/bundles/UIFoundation").Include(
                "~/Scripts/foundation.js",
                "~/Scripts/what-input.js",
                "~/Scripts/jquery.js",
                "~/Scripts/app.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
<<<<<<< HEAD
                      "~/Content/foundation.css",
                      "~/Content/app.css"
                       ));
=======
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
>>>>>>> parent of debc9da... Tehtävä 1
        }
    }
}
