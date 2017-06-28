using System.Web.Routing;
//using Nop.Core.Plugins;
//using Nop.Services.Common;

namespace Nop.Plugin.Misc.PluginExample
{
    public class MiscPlugin // : BasePlugin, IMiscPlugin
    {
        public void GetConfigurationRoute(out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "Configure";
            controllerName = "Configuration";
            routeValues = new RouteValueDictionary { { "Namespaces", "Nop.Plugin.Misc.PluginExample.Controllers" }, { "area", null } };
        }
    }
}
