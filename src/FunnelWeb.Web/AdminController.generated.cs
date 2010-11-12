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
    public partial class AdminController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected AdminController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult CreateFeed() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.CreateFeed);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult DeleteFeed() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.DeleteFeed);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult DeleteRedirect() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.DeleteRedirect);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult CreateRedirect() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.CreateRedirect);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult UpdateSettings() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.UpdateSettings);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult DeleteComment() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.DeleteComment);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult DeletePingback() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.DeletePingback);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult ToggleSpam() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.ToggleSpam);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult TogglePingbackSpam() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.TogglePingbackSpam);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public Features.Admin.AdminController Actions { get { return FunnelWebMvc.Admin; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Admin";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string Index = "Index";
            public readonly string CreateFeed = "CreateFeed";
            public readonly string DeleteFeed = "DeleteFeed";
            public readonly string DeleteRedirect = "DeleteRedirect";
            public readonly string CreateRedirect = "CreateRedirect";
            public readonly string UpdateSettings = "UpdateSettings";
            public readonly string DeleteComment = "DeleteComment";
            public readonly string DeleteAllSpam = "DeleteAllSpam";
            public readonly string DeletePingback = "DeletePingback";
            public readonly string ToggleSpam = "ToggleSpam";
            public readonly string TogglePingbackSpam = "TogglePingbackSpam";
        }


        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string Index = "~/Views/Admin/Index.aspx";
            static readonly _Scripts s_Scripts = new _Scripts();
            public _Scripts Scripts { get { return s_Scripts; } }
            public partial class _Scripts{
                public readonly string Admin = "~/Views/Admin/Scripts/Admin.js";
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_AdminController: Features.Admin.AdminController {
        public T4MVC_AdminController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult Index() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Index);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult CreateFeed(string name, string title) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.CreateFeed);
            callInfo.RouteValueDictionary.Add("name", name);
            callInfo.RouteValueDictionary.Add("title", title);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult DeleteFeed(int feedId) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.DeleteFeed);
            callInfo.RouteValueDictionary.Add("feedId", feedId);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult DeleteRedirect(int redirectId) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.DeleteRedirect);
            callInfo.RouteValueDictionary.Add("redirectId", redirectId);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult CreateRedirect(string from, string to) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.CreateRedirect);
            callInfo.RouteValueDictionary.Add("from", from);
            callInfo.RouteValueDictionary.Add("to", to);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult UpdateSettings(System.Collections.Generic.Dictionary<string,string> settings) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.UpdateSettings);
            callInfo.RouteValueDictionary.Add("settings", settings);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult DeleteComment(int comment) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.DeleteComment);
            callInfo.RouteValueDictionary.Add("comment", comment);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult DeleteAllSpam() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.DeleteAllSpam);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult DeletePingback(int pingback) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.DeletePingback);
            callInfo.RouteValueDictionary.Add("pingback", pingback);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ToggleSpam(int comment) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ToggleSpam);
            callInfo.RouteValueDictionary.Add("comment", comment);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult TogglePingbackSpam(int pingback) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.TogglePingbackSpam);
            callInfo.RouteValueDictionary.Add("pingback", pingback);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
