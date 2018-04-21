using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

using SimpleFlow.BusinessRules;
using SimpleFlow.BusinessFacade;
using SimpleFlow.DBFramework.SQLServer;
using SimpleFlow.SystemFramework;
using SimpleFlow.Entity;

public partial class TestApply : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Apply_Click(object sender, EventArgs e)
    {

        SysUserInfo curr_user = this.GetCurrentUserInfo();

        int formNo=SaveForm();

        if (formNo > 0)
        {
            if (ApplyForm(curr_user, formNo))
            {
                Response.Write("Success");
                return;
            }        
        }

        Response.Write("Faile");       
       
    }

    private int SaveForm()
    {
        string sql = "insert simpleflowdata.dbo.tb_1 (amount,leader,manager) values ({0},'{1}','{2}') ";
        
        sql = string.Format(sql, Convert.ToInt32(TextBoxMoney.Text), TextBoxLeader.Text, TextBoxManager.Text);

        using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
        {
            conn.Open();

            try
            {
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    SqlHelper.ExecuteNonQuery(trans, CommandType.Text, sql);

                    Object obj = SqlHelper.ExecuteScalar(trans, CommandType.Text, "select max(form_no) from simpleflowdata.dbo.tb_1");

                    trans.Commit();

                    return (int)obj;
                }
                catch(Exception e)
                {
                    trans.Rollback();
                    return 0;
                }

            }
            finally
            {
                conn.Close();
            }
        }

    }

    private bool ApplyForm(SysUserInfo user, int formNo)
    {

        return EngineBiz.ApplyForm(1, formNo, user.UserId);

    }
}
