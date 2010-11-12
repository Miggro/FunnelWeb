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
    public partial class UploadController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected UploadController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Index() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Index);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Upload() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Upload);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult CreateDirectory() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.CreateDirectory);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Move() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Move);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Delete() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Delete);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Render() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Render);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public UploadController Actions { get { return FunnelWebMvc.Upload; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Upload";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string Index = "Index";
            public readonly string Upload = "Upload";
            public readonly string CreateDirectory = "CreateDirectory";
            public readonly string Move = "Move";
            public readonly string Delete = "Delete";
            public readonly string Render = "Render";
        }


        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string Index = "~/Views/Upload/Index.aspx";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_UploadController: UploadController {
        public T4MVC_UploadController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult Index(string path) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Index);
            callInfo.RouteValueDictionary.Add("path", path);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Upload(string path, FunnelWeb.Web.Application.Upload upload) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Upload);
            callInfo.RouteValueDictionary.Add("path", path);
            callInfo.RouteValueDictionary.Add("upload", upload);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult CreateDirectory(string path, string name) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.CreateDirectory);
            callInfo.RouteValueDictionary.Add("path", path);
            callInfo.RouteValueDictionary.Add("name", name);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Move(string path, string oldPath, string newPath) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Move);
            callInfo.RouteValueDictionary.Add("path", path);
            callInfo.RouteValueDictionary.Add("oldPath", oldPath);
            callInfo.RouteValueDictionary.Add("newPath", newPath);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Delete(string path, string filePath) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Delete);
            callInfo.RouteValueDictionary.Add("path", path);
            callInfo.RouteValueDictionary.Add("filePath", filePath);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Render(string path) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Render);
            callInfo.RouteValueDictionary.Add("path", path);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
