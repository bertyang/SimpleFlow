using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.ComponentModel;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Controls_ListBoxSelect : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    #region 绑定数据源

    private object m_DataSource;

    public object DataSource
    {
        get
        {
            return m_DataSource;
        }
        set
        {
            if (((value != null) && !(value is IListSource)) && !(value is IEnumerable))
            {
                throw new ArgumentException("Invalid DataSource Type");
            }
            m_DataSource = value;
        }
    }

    public string DataMember
    {
        get
        {
            object obj = this.ViewState["DataMember"];
            if (obj != null)
            {
                return (string)obj;
            }
            return string.Empty;
        }
        set
        {
            this.ViewState["DataMember"] = value;
        }
    }

    public string DataTextField
    {
        get
        {
            object obj = this.ViewState["DataTextField"];
            if (obj != null)
            {
                return (string)obj;
            }
            return string.Empty;
        }
        set
        {
            this.ViewState["DataTextField"] = value;
        }
    }

    public string DataValueField
    {
        get
        {
            object obj = this.ViewState["DataValueField"];
            if (obj != null)
            {
                return (string)obj;
            }
            return string.Empty;
        }
        set
        {
            this.ViewState["DataValueField"] = value;
        }
    }

    public override void DataBind()
    {
        ListBoxLeft.Items.Clear();
        ListBoxRight.Items.Clear();
        ListBoxLeft.DataSource = DataSource;
        ListBoxLeft.DataTextField = DataTextField;
        ListBoxLeft.DataValueField = DataValueField;
        ListBoxLeft.DataBind();
        base.DataBind();
    }
    #endregion

    #region 辅助方法

    protected override void OnPreRender(EventArgs e)
    {
        FaceInit();
        base.OnPreRender(e);
    }

    private void FaceInit()
    {
        ImageButtonArrowRight.Attributes["onclick"] = "return MoveRight()";
        ImageButtonArrowLeft.Attributes["onclick"] = "return MoveLeft()";
        ImageButtonArrowRightAll.Attributes["onclick"] = "return MoveRightAll()";
        ImageButtonArrowLeftAll.Attributes["onclick"] = "return MoveLeftAll()";
        ListBoxLeft.Attributes["ondblclick"] = "return MoveRight();";
        ListBoxRight.Attributes["ondblclick"] = "return MoveLeft();";
    }

    public string[] SelectedValues
    {
        get
        {
            if (TextBoxSynOrder.Text.Length == 0) return new string[] { };
            return TextBoxSynOrder.Text.Split(',');
        }
        set
        {
            TextBoxSynOrder.Text = string.Join(",", value);
            SynList();
        }
    }

    /// <summary>
    /// 获得已选的Hashtable列表
    /// </summary>
    /// <returns></returns>
    public ListItemCollection SelectedItems
    {
        get
        {
            SynList();
            return ListBoxRight.Items;
        }
    }

    /// <summary>
    /// 获得没有被选的Hashtable列表
    /// </summary>
    /// <returns></returns>
    public ListItemCollection UnSelectedItems
    {
        get
        {
            SynList();
            return ListBoxLeft.Items;
        }
    }

    public ListBox LeftList
    {
        get
        {
            return ListBoxLeft;
        }
    }

    public ListBox RightList
    {
        get
        {
            return ListBoxRight;
        }
    }

    public string TitleLeft
    {
        set
        {
            LabelUnSelectTitle.Text = value;
        }
        get
        {
            return LabelUnSelectTitle.Text;
        }
    }

    public string TitleRight
    {
        set
        {
            LabelSelectTitle.Text = value;
        }
        get
        {
            return LabelSelectTitle.Text;
        }
    }

    private void SynList()
    {
        ArrayList arrayValue = new ArrayList(TextBoxSynOrder.Text.Split(','));
        ListItemCollection itemCollection = new ListItemCollection();
        itemCollection.AddRange((ListItem[])new ArrayList(ListBoxLeft.Items).ToArray(typeof(ListItem)));
        itemCollection.AddRange((ListItem[])new ArrayList(ListBoxRight.Items).ToArray(typeof(ListItem)));

        ListBoxLeft.Items.Clear();
        ListBoxRight.Items.Clear();
        for (int i = 0; i < arrayValue.Count; i++)
        {
            ListItem item = itemCollection.FindByValue(arrayValue[i].ToString());
            if (item != null)
            {
                ListBoxRight.Items.Add(item);
                itemCollection.Remove(item);
            }
        }
        ListBoxLeft.Items.AddRange((ListItem[])new ArrayList(itemCollection).ToArray(typeof(ListItem)));
    }

    private void SynValue()
    {
        ArrayList arrayValue = new ArrayList();
        for (int i = 0; i < ListBoxRight.Items.Count; i++)
        {
            arrayValue.Add(ListBoxRight.Items[i].Value);
        }
        TextBoxSynOrder.Text = string.Join(",", (string[])arrayValue.ToArray(typeof(string)));
        TextBoxOrigOrder.Text = TextBoxSynOrder.Text;
    }

    #endregion
}
