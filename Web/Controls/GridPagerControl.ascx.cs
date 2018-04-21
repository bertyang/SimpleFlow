using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.ComponentModel;




public class PageIndexChangeEventArgs : EventArgs        
{
    private int m_index;
    private int m_size;
    private int m_count;

    public PageIndexChangeEventArgs(int size, int index, int count) : base()
    {
        m_index = index;
        m_size = size;
        m_count = count;
    }

    /// <summary>
    /// 获取页索引
    /// </summary>
    public int PageIndex
    {
        get { return m_index; }
        set { m_index = value; }
    }


    /// <summary>
    /// 获取页的大小
    /// </summary>
    public int PageSize
    {
        get { return m_size; }
    }


    /// <summary>
    /// 获取总页数
    /// </summary>
    public int PageCount
    {
        get { return m_count; }
        set { m_count = value; }
    }
}



public delegate void PageIndexChangeEventHandler (object sender,  PageIndexChangeEventArgs e);



[System.ComponentModel.DefaultEvent("PageIndexChange")]
[System.ComponentModel.EditorBrowsable(EditorBrowsableState.Always)]
public partial class Controls_GridPagerControl : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
        this.textbox_page_size.Text = this.PageSize.ToString();
        this.textbox_page_count.Text = this.PageCount.ToString();
        this.textbox_page_index.Text = this.PageIndex.ToString();
    }


    public int PageCount
    {
        get
        {
            if (this.ViewState["page_count"] == null)
            {
                this.ViewState["page_count"] = 0;
            }
            return (int)this.ViewState["page_count"];
        }
        set
        {
            this.ViewState["page_count"] = value;
        }
    }

    public int PageSize
    {
        get
        {
            if (this.ViewState["page_size"] == null)
            {
                this.ViewState["page_size"] = 10;
            }
            return (int)this.ViewState["page_size"];
        }
        set
        {
            this.ViewState["page_size"] = value;
        }
    }


    public int PageIndex
    {
        get
        {
            if (this.ViewState["page_index"] == null)
            {
                this.ViewState["page_index"] = 1;
            }
            return (int)this.ViewState["page_index"];
        }
        set
        {
            this.ViewState["page_index"] = value;
        }
    }



    private static readonly object EventPageIndexChange = new object();
    private PageIndexChangeEventHandler m_pageIndexChangeHandler = null;

    [System.ComponentModel.Browsable(true)]
    [System.ComponentModel.Description("页索引变化的事件")]
    [System.ComponentModel.EditorBrowsable(EditorBrowsableState.Always)]
    public PageIndexChangeEventHandler PageIndexChange
    {
        get
        {
            return m_pageIndexChangeHandler;
        }
        set
        {
            m_pageIndexChangeHandler = value; 
        }
    }
    //public event PageIndexChangeEventHandler PageIndexChange
    //{
    //    add
    //    {
    //        base.Events.AddHandler(EventPageIndexChange, value);
    //    }
    //    remove
    //    {
    //        base.Events.RemoveHandler(EventPageIndexChange, value);
    //    }
    //}


    protected virtual void OnPageIndexChange(PageIndexChangeEventArgs e)
    {
        PageIndexChangeEventHandler handler = (PageIndexChangeEventHandler)base.Events[EventPageIndexChange];
        if (handler != null)
        {
            handler(this, e);
        }
    }


    protected void button_prev_Click(object sender, EventArgs e)
    {
        if (this.PageIndex > 1)
        {
            this.PageIndex -= 1;
            PageIndexChangeEventArgs _e = new PageIndexChangeEventArgs(this.PageSize, this.PageIndex, this.PageCount);
            this.OnPageIndexChange(_e);
            this.PageIndex = _e.PageIndex;
            this.PageCount = _e.PageCount;
        }
    }

    protected void button_next_Click(object sender, EventArgs e)
    {
        this.PageIndex += 1;
        PageIndexChangeEventArgs _e = new PageIndexChangeEventArgs(this.PageSize, this.PageIndex, this.PageCount);
        this.OnPageIndexChange(_e);
        this.PageIndex = _e.PageIndex;
        this.PageCount = _e.PageCount;
    }

    protected void button_first_Click(object sender, EventArgs e)
    {
        this.PageIndex = 1;
        PageIndexChangeEventArgs _e = new PageIndexChangeEventArgs(this.PageSize, this.PageIndex, this.PageCount);
        this.OnPageIndexChange(_e);
        this.PageIndex = _e.PageIndex;
        this.PageCount = _e.PageCount;
    }

    protected void button_last_Click(object sender, EventArgs e)
    {
        this.PageIndex = this.PageCount;
        PageIndexChangeEventArgs _e = new PageIndexChangeEventArgs(this.PageSize, this.PageIndex, this.PageCount);
        this.OnPageIndexChange(_e);
        this.PageIndex = _e.PageIndex;
        this.PageCount = _e.PageCount;
    }
}

