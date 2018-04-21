using System;
using System.Collections.Generic;
using System.Text;

using SimpleFlow.WebFramework;
using SimpleFlow.Entity;

namespace GDMS.Platform.Business
{
    public class FlowERServiceBiz
    {

        public static string ApplyForm(string form_kind,int form_no, string form_package)
        {
            FormHeader formheader=FormHeaderBiz.GetFormHeader(form_kind,form_no);

            FormList formlist =FormListBiz.GetFormList(form_kind);

            SysSiteList sitelist=SysSiteListBiz.GetSiteList(formheader.SiteSerial);
    
            return SimpleFlow.WebFramework.FlowerService.ApplyForm(formlist.FlowerFormKind, form_package,sitelist.FlowerFormcradle);
        }


        public static void RecallForm(string form_kind, int form_no,
            string user_id, string reason)
        {
            FormHeader formheader=FormHeaderBiz.GetFormHeader(form_kind,form_no);

            FormList formlist =FormListBiz.GetFormList(form_kind);

            SysSiteList sitelist=SysSiteListBiz.GetSiteList(formheader.SiteSerial);

           SimpleFlow.WebFramework.FlowerService.RecallForm(formlist.FlowerFormKind,formheader.FlowerFormNo,
            user_id, reason, sitelist.FlowerFlowerapi);
        }

        public static string GetFormHeaderHTML(string form_kind,int form_no,string WidthType, string Width, string LogonRegion, bool IsAttachCss)
        {
            FormHeader formheader = FormHeaderBiz.GetFormHeader(form_kind, form_no);

            FormList formlist = FormListBiz.GetFormList(form_kind);

            SysSiteList sitelist = SysSiteListBiz.GetSiteList(formheader.SiteSerial);

            return SimpleFlow.WebFramework.FlowerService.GetFormHeaderHTML(formlist.FlowerFormKind, formheader.FlowerFormNo, WidthType, Width, LogonRegion, IsAttachCss, sitelist.FlowerFlowerapi);
        }


        public static string GetFormFooterHTML(string form_kind, int form_no, string WidthType, string Width, string LogonRegion, bool IsAttachCss,bool IsShowApproveList)
        {
            FormHeader formheader = FormHeaderBiz.GetFormHeader(form_kind, form_no);

            FormList formlist = FormListBiz.GetFormList(form_kind);

            SysSiteList sitelist = SysSiteListBiz.GetSiteList(formheader.SiteSerial);

            return SimpleFlow.WebFramework.FlowerService.GetFormFooterHTML(formlist.FlowerFormKind, formheader.FlowerFormNo, WidthType, Width, LogonRegion, IsAttachCss, IsShowApproveList, sitelist.FlowerFlowerapi);
        }


        public static void DeleteForm(string form_kind, int form_no, string user_id)
        {
            FormHeader formheader = FormHeaderBiz.GetFormHeader(form_kind, form_no);

            FormList formlist = FormListBiz.GetFormList(form_kind);

            SysSiteList sitelist = SysSiteListBiz.GetSiteList(formheader.SiteSerial);

            SimpleFlow.WebFramework.FlowerService.DeleteForm(formlist.FlowerFormKind, formheader.FlowerFormNo, user_id, sitelist.FlowerEngineservice);

        }
    }
}
