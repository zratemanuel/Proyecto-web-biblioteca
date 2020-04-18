using System.Web;
using System.Web.Optimization;

namespace biblioteca
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquerymin").Include(
                        "~/Scripts/jquery-{version}.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryuimin").Include(
                     "~/Scripts/jqueryui/jquery-ui.min.js"));

            bundles.Add(new StyleBundle("~/bundles/jqueryuicss").Include(
                   "~/Scripts/jqueryui/jquery-ui.min.css"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/datetimepicker").Include(
                     "~/Scripts/bootstrap-datepicker/js/bootstrap-datepicker.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/datepickeres").Include(
                    "~/Scripts/bootstrap-datepicker/locales/bootstrap-datepicker.es.min.js"));

            bundles.Add(new StyleBundle("~/bundles/datetimepickercss").Include(
                    "~/Scripts/bootstrap-datepicker/css/bootstrap-datepicker.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/momentjs").Include(
                     "~/Scripts/moment.js/moment.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquerymasked").Include(
               "~/Scripts/jquery.maskedinput/jquery.maskedinput.min.js"));

        }
    }
}
