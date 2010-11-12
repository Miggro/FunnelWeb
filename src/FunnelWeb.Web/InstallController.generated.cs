// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Web.Mvc;

namespace FunnelWeb.Web {
    public partial class InstallController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected InstallController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Test() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Test);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public InstallController Actions { get { return FunnelWebMvc.Install; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Install";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string Index = "Index";
            public readonly string Test = "test";
            public readonly string Upgrade = "Upgrade";
        }


        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string Index = "~/Views/Install/Index.aspx";
            public readonly string UpgradeReport = "~/Views/Install/UpgradeReport.aspx";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_InstallController: InstallController {
        public T4MVC_InstallController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult Index() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Index);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Test(string connectionString) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Test);
            callInfo.RouteValueDictionary.Add("connectionString", connectionString);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Upgrade() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Upgrade);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
