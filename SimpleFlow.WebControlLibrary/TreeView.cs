using System;
using System.Web.UI;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.ComponentModel;
using System.Text;

namespace SimpleFlow.WebControlLibrary
{
	/// <summary>
	/// Summary description for WebCustomControl1.
	/// </summary>
	[
	DefaultProperty("ID"),
	ToolboxData("<{0}:TreeView runat=server></{0}:TreeView>"),
	ParseChildren(true),
	PersistChildren(false),
	]
	public class TreeView : System.Web.UI.WebControls.WebControl, INamingContainer, IPostBackEventHandler	
	{
		private const int MARGIN_BASE = 15;
		private const int LEVEL_INCREASE = MARGIN_BASE;

		private TreeNodeCollection m_Nodes = new TreeNodeCollection();
		private StringBuilder m_EllapsedNodeID = new StringBuilder();

		#region properties
		[
		Browsable(false),
		]
		public TreeNodeCollection Nodes
		{
			get
			{				
				if (this.IsTrackingViewState)
					((IStateManager)m_Nodes).TrackViewState();

				return this.m_Nodes;
			}
		}

		[ 
		PersistenceMode(PersistenceMode.Attribute),
		NotifyParentProperty(true),
		]
		public int MarginBase
		{
			get
			{
				object marginBase = ViewState["MarginBase"];
				int margin = MARGIN_BASE;
				if (marginBase != null)
				{
					try
					{
						margin = int.Parse(marginBase.ToString());
					}
					catch{}
				}
				return margin;
			}
			set
			{
				ViewState["MarginBase"] = value;
				ViewState.SetItemDirty("MarginBase", true);
			}
		}

		[ 
		PersistenceMode(PersistenceMode.Attribute),
		NotifyParentProperty(true),
		]
		public int LevelIncrease
		{
			get
			{
				object marginBase = ViewState["LevelIncrease"];
				int margin = LEVEL_INCREASE;
				if (marginBase != null)
				{
					try
					{
						margin = int.Parse(marginBase.ToString());
					}
					catch{}
				}
				return margin;
			}
			set
			{
				ViewState["LevelIncrease"] = value;
				ViewState.SetItemDirty("LevelIncrease", true);
			}
		}

		[ 
		PersistenceMode(PersistenceMode.Attribute),
		NotifyParentProperty(true),
		]
		public string DefaultCss
		{
			get
			{
				object treeNodeCss = ViewState["DefaultCss"];
				return (treeNodeCss == null ? string.Empty : treeNodeCss.ToString());
			}
			set
			{
				ViewState["DefaultCss"] = value;
				ViewState.SetItemDirty("DefaultCss", true);
			}
		}

		[ 
		PersistenceMode(PersistenceMode.Attribute),
		NotifyParentProperty(true),
		]
		public string MouseOverCss
		{
			get
			{
				object treeNodeCss = ViewState["MouseOverCss"];
				return (treeNodeCss == null ? string.Empty : treeNodeCss.ToString());
			}
			set
			{
				ViewState["MouseOverCss"] = value;
				ViewState.SetItemDirty("MouseOverCss", true);
			}
		}
		#endregion


		#region overrided drawing methods
		/// <summary>
		/// Render this control to the output parameter specified.
		/// </summary>
		/// <param name="output"> The HTML writer to write out to </param>
		protected override void Render(HtmlTextWriter output)
		{
			if (Page != null)
			{
				Page.VerifyRenderingInServerForm(this);
			}
			base.RenderChildren(output);
		}

		protected override void CreateChildControls()
		{
			for (int i = 0; i < this.m_Nodes.Count; i++)
			{
				BuildTreeNodeID(this.m_Nodes[i], this.ClientID, i);
			}
			BuildTreeView();
		}

		protected override void OnPreRender(EventArgs e)
		{
			base.OnPreRender (e);
			RegistClientScript();
			RegistEllapsedNodeArray();
		}

		#endregion

		

		#region TreeView/Node build methods
		protected virtual void BuildTreeView()
		{
			HtmlGenericControl treePanel = new HtmlGenericControl("Div");
			this.Controls.Add(treePanel);
			treePanel.Attributes.Add("class", this.CssClass);
			BuildTreeNode(treePanel, m_Nodes, 0);
		}

		protected virtual void BuildTreeNode(HtmlGenericControl parentPanel, TreeNodeCollection nodes, int level)
		{
			foreach(TreeNode treeNode in nodes)
			{
				HtmlGenericControl nodeDiv = new HtmlGenericControl("Div");
				nodeDiv.Attributes.Add("id", treeNode.NodeID);
                HtmlGenericControl textControl = BuildText(treeNode.Text, level);
				nodeDiv.Controls.Add(textControl);
				parentPanel.Controls.Add(nodeDiv);
				string temp_tool_tip = treeNode.ToolTip;
                if (temp_tool_tip != null && temp_tool_tip.Length > 0)
				{
                    nodeDiv.Attributes.Add("title", temp_tool_tip);
				}

                /*
                string temp_class = string.Empty;
				if (treeNode.Selected)
				{
                    temp_class = PreferredProperty(this.DefaultCss, treeNode.CssClass, treeNode.SelectedCss);
				}
				else
				{
                    temp_class = PreferredProperty(this.DefaultCss, treeNode.CssClass);
				}
                if (temp_class.Length > 0)
				{
                    nodeDiv.Attributes.Add("class", temp_class);
                    nodeDiv.Attributes.Add("onmouseout", "this.className = '" + temp_class + "';");
				}

				string temp_mouse_over_css = PreferredProperty(this.MouseOverCss, treeNode.MouseOverCss);
                if (temp_mouse_over_css.Length > 0)
				{
                    nodeDiv.Attributes.Add("onmouseover", "this.className = '" + temp_mouse_over_css + "';");
				}
                */

                if (treeNode.Selected)
                {
                    if (level == 0)
                    {
                        nodeDiv.Attributes.Add("class", "Main_MenuItem_Selected_Css");
                        nodeDiv.Attributes.Add("onmouseover", "this.className = 'Main_MenuItem_Selected_Css';");
                        nodeDiv.Attributes.Add("onmouseout", "this.className = 'Main_MenuItem_Selected_Css';");
                    }
                    else
                    {
                        nodeDiv.Attributes.Add("class", "Sub_MenuItem_Selected_Css");
                        nodeDiv.Attributes.Add("onmouseover", "this.className = 'Sub_MenuItem_Selected_Css';");
                        nodeDiv.Attributes.Add("onmouseout", "this.className = 'Sub_MenuItem_Selected_Css';");

                        nodeDiv.Style.Add("padding-left", 
                            string.Format("{0}:px", level * 20));
                    }
                }
                else
                {
                    if (level == 0)
                    {
                        nodeDiv.Attributes.Add("class", "Main_MenuItem_Div_Css");
                        nodeDiv.Attributes.Add("onmouseover", "this.className = 'Main_MenuItem_Div_MouseOver_Css';");
                        nodeDiv.Attributes.Add("onmouseout", "this.className = 'Main_MenuItem_Div_Css';");
                    }
                    else
                    {
                        nodeDiv.Attributes.Add("class", "Sub_MenuItem_Div_Css");
                        nodeDiv.Attributes.Add("onmouseover", "this.className = 'Sub_MenuItem_Div_MouseOver_Css';");
                        nodeDiv.Attributes.Add("onmouseout", "this.className = 'Sub_MenuItem_Div_Css';");

                        nodeDiv.Style.Add("padding-left", 
                            string.Format("{0}:px", level * 20));
                    }
                }

				if (treeNode.Nodes.Count <= 0)
				{
					if (treeNode.NodeType == NodeType.Link)
					{
						//textControl.Attributes.Add("onclick", string.Format("window.open('{0}', '{1}');", HttpUtility.UrlPathEncode(treeNode.Url), treeNode.Target));
						textControl.Attributes.Add("onclick", string.Format("location.href = '{0}';", HttpUtility.UrlPathEncode(treeNode.Url)));
					}
					if (treeNode.Selected)
					{
						DisplayNode(nodeDiv);
					}
				}
				else
				{
					HtmlGenericControl childNodesDiv = new HtmlGenericControl("Div");
					childNodesDiv.Style.Add("display", "block");
					if (treeNode.Collapsed == false)
					{
						m_EllapsedNodeID.AppendFormat(",\"{0}\"", childNodesDiv);
					}
					string childPanelID = string.Format("{0}-l{1}", treeNode.NodeID, level);
					childNodesDiv.Attributes.Add("id", childPanelID);
					nodeDiv.Attributes.Add("onclick", string.Format("EllapseTreeNode('{0}');", childPanelID));
					parentPanel.Controls.Add(childNodesDiv);
					BuildTreeNode(childNodesDiv, treeNode.Nodes, level + 1);
				}
			}
		}


        private bool m_WrapText = true;

        /// <summary>
        /// ÊÇ·ñÔÊÐí×Ö·û´®»»ÐÐ¡£
        /// </summary>
        public bool WrapText
        {
            get { return m_WrapText; }
            set { m_WrapText = value; }
        }

        private HtmlGenericControl BuildText(string text, int level)
		{
            // Label lable = new Label();
            HtmlGenericControl lable = new HtmlGenericControl("span");
            if (m_WrapText)
            {
                //HtmlGenericControl noBr = new HtmlGenericControl("span");
                //noBr.InnerText = text;
                //if (level == 0)
                //{
                //    noBr.Attributes.Add("class", "Main_MenuItem_Span_Css");
                //}
                //else
                //{
                //    noBr.Attributes.Add("class", "Sub_MenuItem_Span_Css");
                //}

                //lable.Style.Add("margin-left", string.Format("{0}px", MarginBase + level * LevelIncrease));
                //lable.Style.Add("width", "100%");
                //lable.Style.Add("overflow", "hidden");
                //lable.Style.Add("text-Overflow", "ellipsis");
                //lable.Controls.Add(noBr);


                lable.InnerText = text; //.Page.Server.HtmlEncode(text);
                if (level == 0)
                {
                    lable.Attributes.Add("class", "Main_MenuItem_Span_Css");
                }
                else
                {
                    lable.Attributes.Add("class", "Sub_MenuItem_Span_Css");
                }

                //lable.Style.Add("margin-left", string.Format("{0}px", MarginBase + level * LevelIncrease));
                //lable.Style.Add("width", "100%");
                //lable.Style.Add("overflow", "hidden");
                //lable.Style.Add("text-Overflow", "ellipsis");
                // lable.Controls.Add(lable);
            }
            else
            {
                HtmlGenericControl noBr = new HtmlGenericControl("nobr");
                noBr.InnerText = text; //  this.Page.Server.HtmlEncode(text);
                lable.Style.Add("margin-left", string.Format("{0}px", MarginBase + level * LevelIncrease));
                lable.Style.Add("width", "100%");
                lable.Style.Add("overflow", "hidden");
                lable.Style.Add("text-Overflow", "ellipsis");
                lable.Controls.Add(noBr);
            }

			return lable;
		}

		protected virtual void BuildTreeNodeID(TreeNode node, string parentID, int indexValue)
		{
			node.NodeID = parentID + "-n" + indexValue.ToString("d3");	
			if (node.Nodes.Count > 0)
			{
				for (int i = 0; i < node.Nodes.Count; i++)
				{
					BuildTreeNodeID(node.Nodes[i], node.NodeID + "-sn", i);	
				}
			}
		}
		private string PreferredProperty(string defaultProperty, string nodeProperty, string selectedProperty)
		{
			string property = (selectedProperty.Length == 0 ? nodeProperty : selectedProperty);
			property = (property.Length == 0 ? defaultProperty : property);
			return property;
		}

		private string PreferredProperty(string defaultProperty, string nodeProperty)
		{
			return (nodeProperty.Length == 0 ? defaultProperty : nodeProperty);
		}

		private void DisplayNode(HtmlGenericControl node)
		{
			HtmlGenericControl parent = node.Parent as HtmlGenericControl;
			while (parent != null  && parent != node && parent.TagName.ToLower() == "div")
			{
				parent.Style.Remove("display");
				parent.Style.Add("display", "block");
				parent = parent.Parent as HtmlGenericControl;
			}
		}
		#endregion

		#region TreeNodeClick Event
		public event TreeNodeClickedEventHandler TreeNodeClick;

		protected virtual void OnTreeNodeClick(TreeNodeClickEventArgs e)
		{
			if (TreeNodeClick != null)
			{
				TreeNodeClick(this, e);
			}
		}
		#endregion

		#region IPostBackEventHandler Members

		public void RaisePostBackEvent(string eventArgument)
		{
			// TODO:  Add TreeView.RaisePostBackEvent implementation
			OnTreeNodeClick(new TreeNodeClickEventArgs(eventArgument));
		}

		#endregion

		#region overrided statebug methods
		protected override object SaveViewState()
		{
			Object [] state = new object[2];
			state[0] = base.SaveViewState();
			state[1] = ((IStateManager) this.m_Nodes).SaveViewState();
			return state;
		}

		protected override void LoadViewState(object savedState)
		{
			object [] state = null;
			if (savedState != null)
			{
				state = (object[]) savedState;
				base.LoadViewState(state[0]);
				((IStateManager) this.m_Nodes).LoadViewState(state[1]);
			}			
		}

		protected override void TrackViewState()
		{
			base.TrackViewState ();
			if (this.m_Nodes != null)
			{
				((IStateManager)m_Nodes).TrackViewState();
			}
		}
		#endregion

		#region HelpScripts
		private void RegistClientScript()
		{
			ScriptRegister("TreeView", "TreeView.js");
		}

		private void RegistEllapsedNodeArray()
		{
			if (m_EllapsedNodeID.Length > 0)
			{
				string nodes = m_EllapsedNodeID.ToString();
				nodes = string.Format("new Array({0})", nodes.Remove(0, 1));
				const string SCRIPT = @"
<script language=""javascript"">
	CollapseTreeView({0});
</script>
				";
				if (this.Page.ClientScript.IsStartupScriptRegistered(this.ClientID + "_Startup") == false)
				{
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), this.ClientID + "_Startup", string.Format(SCRIPT, nodes));
				}
			}
		}

		private void ScriptRegister(string key, string resoruceName)
		{
            if (this.Page.ClientScript.IsClientScriptBlockRegistered(key) == false)
            {
                string script = string.Format(@"<script type=""text/javascript"" src=""{0}""></script>",
                    AssemblyResourceHandler.GetWebResourceUrl(typeof(TextBox),
                    string.Format("SimpleFlow.WebControlLibrary.Resources.Javascript.{0}", resoruceName), string.Empty));
                this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), key, script);
            }
		}
		#endregion
	}
}
