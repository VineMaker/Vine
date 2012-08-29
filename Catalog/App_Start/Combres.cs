[assembly: WebActivator.PreApplicationStartMethod(typeof(Catalog.App_Start.Combres), "PreStart")]
namespace Catalog.App_Start {
	using System.Web.Routing;
	using global::Combres;
	
    public static class Combres {
        public static void PreStart() {
            RouteTable.Routes.AddCombresRoute("Combres");
        }
    }
}