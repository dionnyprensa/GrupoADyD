using System.Web.Optimization;

namespace GrupoADyD.Web.Mvc.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //JavaScript
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap3").Include(
                        "~/Scripts/bootstrap3/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap4").Include(
                        "~/Scripts/bootstrap4/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/metisMenu").Include(
                        "~/Scripts/metisMenu/metisMenu.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/raphael").Include(
                        "~/Scripts/raphaeljs/raphael.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/morris").Include(
                        "~/Scripts/morrisjs/morris.min.js",
                        "~/Scripts/morrisjs/morris-data.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                        "~/Scripts/app/sb-admin-2.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jQuery/jquery.validate.*"));

            bundles.Add(new ScriptBundle("~/bundles/sweetalert").Include(
                        "~/Scripts/sweetalert/sweetalert.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-{version}.js"));

            //Hojas de Estilos);
            bundles.Add(new StyleBundle("~/Content/bootstrap3").Include(
                        "~/Content/CSS/bootstrap3/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap4").Include(
                        "~/Content/CSS/bootstrap4/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/Content/metismenu").Include(
                        "~/Content/CSS/metismenu/metismenu.min.css"));

            bundles.Add(new StyleBundle("~/Content/site").Include(
                        "~/Content/CSS/site/sb-admin-2.css",
                        "~/Content/CSS/site/timeline.css"
                        ));

            bundles.Add(new StyleBundle("~/Content/morris").Include(
                        "~/Content/CSS/morrisjs/morris.min.css"));

            bundles.Add(new StyleBundle("~/Content/font-awesome").Include(
                        "~/Content/CSS/font-awesome/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/Content/sweetalert").Include(
                        "~/Content/CSS/sweetalert/sweetalert.min.css"));
        }
    }
}