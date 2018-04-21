using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data
;
using SimpleFlow.BusinessFacade;
using SimpleFlow.Entity;


public partial class FlowDesign_Condition : BasePage
{
    public String ConditionId
    {
        get
        {
            object o = ViewState["ConditionId"];
            return (o == null) ? String.Empty : (string)o;
        }

        set
        {
            ViewState["ConditionId"] = value;
        }
    }

    public int FormId
    {
        get
        {
            object o = ViewState["FormId"];
            return (o == null) ? 0 : (int)o;
        }

        set
        {
            ViewState["FormId"] = value;
        }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ConditionId = Request.QueryString["ConditionId"];
            FormId = Convert.ToInt32(Request.QueryString["FormId"]);
            BindData();
        }
    }

    private void BindData()
    {
        //Bind GridViewCondition
        GridViewCondition.DataSource = FormFlowBiz.GetConditionSubList(ConditionId).OrderBy(cs => cs.CreateTime);
        GridViewCondition.DataBind();

        //display RadioButtonListJoin 
        if (GridViewCondition.Rows.Count == 0)
        {
            RadioButtonListJoin.Enabled = false;
            RadioButtonListJoin.SelectedIndex = -1;
        }
        else
        {
            RadioButtonListJoin.SelectedIndex = 0;
            RadioButtonListJoin.Enabled = true;
        }

        //Bind DropDownListField
        DataTable dt = CommonBiz.GetColumns(string.Format("tb_{0}",FormId));

        DropDownListField.DataSource = dt;
        DropDownListField.DataTextField = "name";
        DropDownListField.DataValueField = "name";
        DropDownListField.DataBind();
    }


    protected void GridViewCondition_RowEditing(Object sender, GridViewEditEventArgs e)
    {

        GridViewCondition.EditIndex = e.NewEditIndex;
        BindData();

        //Field
        DropDownList DropDownListField = (DropDownList)GridViewCondition.Rows[e.NewEditIndex].FindControl("DropDownListField");
        Label LabelField = (Label)GridViewCondition.Rows[e.NewEditIndex].FindControl("LabelField");

        DataTable dt = CommonBiz.GetColumns(string.Format("tb_{0}", FormId));

        DropDownListField.DataSource = dt;
        DropDownListField.DataTextField = "name";
        DropDownListField.DataValueField = "name";
        DropDownListField.DataBind();

        MatchDropByValue(DropDownListField, LabelField.Text);

        //Operator
        DropDownList DropDownListOperator = (DropDownList)GridViewCondition.Rows[e.NewEditIndex].FindControl("DropDownListOperator");
        Label LabelOperator = (Label)GridViewCondition.Rows[e.NewEditIndex].FindControl("LabelOperator");
        MatchDropByValue(DropDownListOperator, LabelOperator.Text);


    }

    protected void GridViewCondition_CancelingEdit(Object sender, GridViewCancelEditEventArgs e)
    {
        GridViewCondition.EditIndex = -1;
        BindData();
    }

    protected void GridViewCondition_OnRowUpdating(Object sender, GridViewUpdateEventArgs e)
    {
        DropDownList DropDownListField = (DropDownList)GridViewCondition.Rows[e.RowIndex].FindControl("DropDownListField");
        DropDownList DropDownListOperator = (DropDownList)GridViewCondition.Rows[e.RowIndex].FindControl("DropDownListOperator");
        TextBox TextBoxValue = (TextBox)GridViewCondition.Rows[e.RowIndex].FindControl("TextBoxValue");
        Label LabelCreateTime = (Label)GridViewCondition.Rows[e.RowIndex].FindControl("LabelCreateTime");

        ConditionSubInfo cs = new ConditionSubInfo();
        cs.ConditionSubId = GridViewCondition.DataKeys[e.RowIndex].Value.ToString();
        cs.ConditionSubField = DropDownListField.SelectedValue;
        cs.ConditionSubOperator = DropDownListOperator.SelectedValue;
        cs.ConditionSubValue = TextBoxValue.Text.Trim();
        cs.ConditionId = ConditionId;
        cs.CreateTime = Convert.ToDateTime(LabelCreateTime.Text);

        FormFlowBiz.UpdateConditionSub(cs);

        GridViewCondition.EditIndex = -1;
        BindData();
    }

    protected void Add_Click(object sender, EventArgs e)
    {
        ConditionSubInfo cs = new ConditionSubInfo();
        cs.ConditionSubId = Guid.NewGuid().ToString("D").ToUpper();
        cs.ConditionSubField = DropDownListField.SelectedValue;
        cs.ConditionSubOperator = DropDownListOperator.SelectedValue;
        cs.ConditionSubValue = TextBoxValue.Text.Trim();
        cs.ConditionId = ConditionId;
        cs.CreateTime = DateTime.Now;

        FormFlowBiz.AddConditionSub(cs);

        BindData();
    }

    protected void GridViewCondition_OnRowDeleting(Object sender, GridViewDeleteEventArgs e)
    {
        string conditionSubId = GridViewCondition.DataKeys[e.RowIndex].Value.ToString();

        FormFlowBiz.DelConditionSub(conditionSubId);

        BindData();
    }

    private void MatchDropByValue(ListControl p_dropList, string p_strValue)
    {
        p_dropList.SelectedIndex = p_dropList.Items.IndexOf(p_dropList.Items.FindByValue(p_strValue));
    }

    protected void RadioButtonListJoin_SelectedIndexChanged(object sender, EventArgs e)
    {
        ConditionInfo condition=FormFlowBiz.GetCondition(ConditionId);
        condition.ConditionJoin = RadioButtonListJoin.SelectedValue;
        FormFlowBiz.UpdateCondition(condition);
    }
}
