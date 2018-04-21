using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Text;

using SimpleFlow.Entity;
using SimpleFlow.BusinessFacade;

namespace GDMSNew.Presentation
{
	/// <summary>
	/// ��¼ҳ��
	/// </summary>
	public partial class LogOn : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
			
			if(!this.IsPostBack)
			{
				bool isNTAuthenticated = HttpContext.Current.User.Identity.IsAuthenticated;
				string userNTAccount = HttpContext.Current.User.Identity.Name.Trim(); //get user NT account

                //if (isNTAuthenticated && userNTAccount.IndexOf("\\") > 0 || (Request.Cookies["CorpComm_UserInfo"] != null))
                //{
                //    Response.Redirect("Default.aspx");
                //}

                // UserBiz biz = new UserBiz();
				
			}
		}

		#region Web ������������ɵĴ���
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: �õ����� ASP.NET Web ���������������ġ�
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{    

			// ButtonSubmit.Click += new EventHandler(ButtonSubmit_Click);
		}
		#endregion
		      				


        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            Session.Contents.Clear();
            Session.Clear();

            Response.Redirect("~/Default.aspx");
        }


        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxUserName.Text))
            {
                ScriptHelper.AjaxAlertFocus(this.ButtonLogin,
                    "Please input user name.", this.TextBoxUserName);
                return;
            }
            if (string.IsNullOrEmpty(TextBoxPassword.Text))
            {
                ScriptHelper.AjaxAlertFocus(this.ButtonLogin,
                    "Please input password.", this.TextBoxPassword);
                return;
            }


            // UserBiz biz = new UserBiz();
            SysUserInfo user = UserBiz.Login(TextBoxUserName.Text, TextBoxPassword.Text);
            if (user != null)
            {
                this.Session["user"] = user;
                Response.Redirect("~/HomePage.aspx");

                // ScriptHelper.AjaxAlert(this.ButtonLogin, "Login Ok.");
                return;
            }
            else
            {
                ScriptHelper.AjaxAlertSelect(this.ButtonLogin, 
                    "User name or password error.",
                    this.TextBoxUserName);
                return;
            }
            
        }
    }
}
