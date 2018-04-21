using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFlow.WebControlLibrary
{
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

        public PageIndexChangeEventArgs(int size, int index, int count)
            : base()
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
            set 
            { 
                m_count = value;
            }
        }
    }



    public delegate void PageIndexChangeEventHandler(object sender, PageIndexChangeEventArgs e);



    [System.ComponentModel.DefaultEvent("PageIndexChange")]
    [ToolboxData("<{0}:GridPagerControl runat=server></{0}:GridPagerControl>")]
    public class GridPagerControl : System.Web.UI.WebControls.WebControl
    {
        public GridPagerControl()
            : base(HtmlTextWriterTag.Table)
        {
            this.EnsureChildControls();
        }

        private Label label_page_size;
        private Label label_page_count;
        private Label label_page_index;

        private TextBox textbox_page_size;
        private TextBox textbox_page_count;
        private TextBox textbox_page_index;

        private ImageButton button_first;
        private ImageButton button_prev;
        private ImageButton button_next;
        private ImageButton button_last;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected override void CreateChildControls()
        {
            if (!this.ChildControlsCreated)
            {
                // base.CreateChildControls();
                this.label_page_count = new Label();
                this.label_page_count.ID = "label_page_count";
                this.label_page_count.Text = "page count";
  
                this.label_page_index = new Label();
                this.label_page_index.ID = "label_page_index";
                this.label_page_index.Text = "page index";

                this.label_page_size = new Label();
                this.label_page_size.ID = "label_page_size";
                this.label_page_size.Text = "page size";

                this.textbox_page_count = new TextBox();
                this.textbox_page_count.ID = "textbox_page_count";
                this.textbox_page_count.Text = "0";
                this.textbox_page_count.Width = Unit.Pixel(30);
                this.textbox_page_count.ReadOnly = true;

                this.textbox_page_index = new TextBox();
                this.textbox_page_index.ID = "textbox_page_index";
                this.textbox_page_index.Text = "1";
                this.textbox_page_index.Width = Unit.Pixel(30);
                this.textbox_page_index.MaxLength = 4;
                this.textbox_page_index.Attributes.Add("onkeydown", "javascript:return onlyNum();");
                this.textbox_page_index.Attributes.Add("style", "ime-mode:Disabled");

                this.textbox_page_size = new TextBox();
                this.textbox_page_size.ID = "textbox_page_size";
                this.textbox_page_size.Text = "10";
                this.textbox_page_size.Width = Unit.Pixel(30);
                this.textbox_page_size.MaxLength = 2;
                this.textbox_page_size.Attributes.Add("onkeydown", "javascript:return onlyNum();");
                this.textbox_page_size.Attributes.Add("style", "ime-mode:Disabled");

                this.button_first = new ImageButton();
                this.button_first.ID = "button_first";
                this.button_first.ImageUrl = "Images/Icon_first.gif";
                this.button_first.Click += new ImageClickEventHandler(this.button_first_Click);

                this.button_prev = new ImageButton();
                this.button_prev.ID = "button_prev";
                this.button_prev.ImageUrl = "Images/Icon_previous.gif";
                this.button_prev.Click += new ImageClickEventHandler(this.button_prev_Click);

                this.button_next = new ImageButton();
                this.button_next.ID = "button_next";
                this.button_next.ImageUrl = "Images/Icon_next.gif";
                this.button_next.Click += new ImageClickEventHandler(this.button_next_Click);

                this.button_last = new ImageButton();
                this.button_last.ID = "button_last";
                this.button_last.ImageUrl = "Images/Icon_last.gif";
                this.button_last.Click += new ImageClickEventHandler(this.button_last_Click);

                HtmlTableRow row = new HtmlTableRow();
                HtmlTableCell cell = new HtmlTableCell();
                this.Controls.Add(row);
                row.Controls.Add(cell);

                cell.Controls.Add(this.label_page_size);
                cell.Controls.Add(this.CreateNewLiteral());
                cell.Controls.Add(this.textbox_page_size);
                cell.Controls.Add(this.CreateNewLiteral());

                cell.Controls.Add(this.label_page_index);
                cell.Controls.Add(this.CreateNewLiteral());
                cell.Controls.Add(this.textbox_page_index);
                cell.Controls.Add(this.CreateNewLiteral());

                cell.Controls.Add(this.label_page_count);
                cell.Controls.Add(this.CreateNewLiteral());
                cell.Controls.Add(this.textbox_page_count);
                cell.Controls.Add(this.CreateNewLiteral());

                cell.Controls.Add(this.button_first);
                cell.Controls.Add(this.CreateNewLiteral());
                cell.Controls.Add(this.button_prev);
                cell.Controls.Add(this.CreateNewLiteral());
                cell.Controls.Add(this.button_next);
                cell.Controls.Add(this.CreateNewLiteral());
                cell.Controls.Add(this.button_last);
                cell.Controls.Add(this.CreateNewLiteral());

                this.ChildControlsCreated = true;
            }

        }

        private Literal CreateNewLiteral()
        {
            Literal obj = new Literal();
            obj.Text = " ";
            return obj;
        }


        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            this.Attributes.Add("cellpadding", "0");
            this.Attributes.Add("cellspacing", "0");
            this.Attributes.Add("border", "0");

            if (this.PageIndex > this.PageCount)
            {
                this.PageIndex = this.PageCount;
            }

            this.button_first.Enabled = this.PageIndex > 1;
            this.button_prev.Enabled = this.PageIndex > 1;
            this.button_next.Enabled = this.PageIndex < this.PageCount;
            this.button_last.Enabled = this.PageIndex < this.PageCount;            

            
        }

        

        public int PageCount
        {
            get
            {
                return int.Parse(this.textbox_page_count.Text);
            }
            set
            {
                this.textbox_page_count.Text = value.ToString(); 
            }
        }

        public int PageSize
        {
            get
            {
                if (IsNullOrTrimedEmpty(this.textbox_page_size.Text) || this.textbox_page_size.Text=="0" )
                {
                    this.textbox_page_size.Text = "10";

                    return 10;
                }
                else
                {
                    return int.Parse(this.textbox_page_size.Text);
                }
            }
            set
            {
                this.textbox_page_size.Text = value.ToString(); 
            }
        }


        public int PageIndex
        {
            get
            {
                if (IsNullOrTrimedEmpty(this.textbox_page_index.Text))
                {
                    return 1;
                }
                else
                {
                    return int.Parse(this.textbox_page_index.Text);
                }
            }
            set
            {
                this.textbox_page_index.Text = value.ToString();
            }
        }

        public bool IsNullOrTrimedEmpty(string s)
        {
            if (s == null)
            {
                return true;
            }
            if (s.Length == 0)
            {
                return true;
            }
            if (s.Trim().Length == 0)
            {
                return true;
            }
            return false;
        }

        private static readonly object EventPageIndexChange = null;
        // private PageIndexChangeEventHandler m_pageIndexChangeHandler = null;

        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.Description("页索引变化的事件")]
        [System.ComponentModel.EditorBrowsable(EditorBrowsableState.Always)]
        public event PageIndexChangeEventHandler PageIndexChange
        {
            add
            {
                base.Events.AddHandler(EventPageIndexChange, value);
            }
            remove
            {
                base.Events.RemoveHandler(EventPageIndexChange, value);
            }
        }


        //public PageIndexChangeEventHandler PageIndexChange
        //{
        //    get
        //    {
        //        return m_pageIndexChangeHandler;
        //    }
        //    set
        //    {
        //        m_pageIndexChangeHandler = value;
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


        protected void button_prev_Click(object sender, ImageClickEventArgs e)
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

        protected void button_next_Click(object sender, ImageClickEventArgs e)
        {
            this.PageIndex += 1;
            PageIndexChangeEventArgs _e = new PageIndexChangeEventArgs(this.PageSize, this.PageIndex, this.PageCount);
            this.OnPageIndexChange(_e);
            this.PageIndex = _e.PageIndex;
            this.PageCount = _e.PageCount;
        }

        protected void button_first_Click(object sender, ImageClickEventArgs e)
        {
            this.PageIndex = 1;
            PageIndexChangeEventArgs _e = new PageIndexChangeEventArgs(this.PageSize, this.PageIndex, this.PageCount);
            this.OnPageIndexChange(_e);
            this.PageIndex = _e.PageIndex;
            this.PageCount = _e.PageCount;
        }

        protected void button_last_Click(object sender, ImageClickEventArgs e)
        {
            this.PageIndex = this.PageCount;
            PageIndexChangeEventArgs _e = new PageIndexChangeEventArgs(this.PageSize, this.PageIndex, this.PageCount);
            this.OnPageIndexChange(_e);
            this.PageIndex = _e.PageIndex;
            this.PageCount = _e.PageCount;
        }
    }
}
