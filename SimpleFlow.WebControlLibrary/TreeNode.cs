/*****************************************************************************
** File Name: TreeNode.cs
** Copyright (C) 2006 BenQ Corporation. All rights reserved.
** Create date: Fri Nov 24 09:06:35 UTC+0800 2006
*******************************************************************************/
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleFlow.WebControlLibrary
{
	/// <summary>
	/// Summary description for TreeNode.
	/// </summary>
	public class TreeNode : WebControl, IStateManager
	{
		private TreeNodeCollection m_Nodes = new TreeNodeCollection();

		#region ctor.
		public TreeNode()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public TreeNode(string text)
		{
			Text = text;
		}

		public TreeNode(string text, string url)
		{
			Text = text;
			Url = url;
		}
		#endregion

		#region properties
		[ 
		PersistenceMode(PersistenceMode.Attribute),
		NotifyParentProperty(true),
		]
		public string Name
		{
			get
			{
				object name = ViewState["Name"];
				return (name == null ? string.Empty : name.ToString());
			}
			set
			{
				ViewState["Name"] = value;
				ViewState.SetItemDirty("Name", true);
			}
		}

		[ 
		PersistenceMode(PersistenceMode.Attribute),
		NotifyParentProperty(true),
		]
		public string NodeID
		{
			get
			{
				object nodeID = ViewState["NodeID"];
				return (nodeID == null ? string.Empty : nodeID.ToString());
			}
			set
			{
				ViewState["NodeID"] = value;
				ViewState.SetItemDirty("NodeID", true);
			}
		}

		[ 
		PersistenceMode(PersistenceMode.Attribute),
		NotifyParentProperty(true),
		]
		public string Text
		{
			get
			{
				object text = ViewState["Text"];
				return (text == null ? string.Empty : text.ToString());
			}
			set
			{
				ViewState["Text"] = value;
				ViewState.SetItemDirty("Text", true);
			}
		}

		[ 
		PersistenceMode(PersistenceMode.Attribute),
		NotifyParentProperty(true),
		]
		public string Url
		{
			get
			{
				object url = ViewState["Url"];
				return (url == null ? string.Empty : url.ToString());
			}
			set
			{
				ViewState["Url"] = value;
				ViewState.SetItemDirty("Url", true);
			}
		}

		[ 
		PersistenceMode(PersistenceMode.Attribute),
		NotifyParentProperty(true),
		]
		public string Target
		{
			get
			{
				object target = ViewState["Target"];
				return (target == null ? "_self" : target.ToString());
			}
			set
			{
				ViewState["Target"] = value;
				ViewState.SetItemDirty("Target", true);
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
				object mouseOverCss = ViewState["MouseOverCss"];
				return (mouseOverCss == null ? string.Empty : mouseOverCss.ToString());
			}
			set
			{
				ViewState["MouseOverCss"] = value;
				ViewState.SetItemDirty("MouseOverCss", true);
			}
		}

		[ 
		PersistenceMode(PersistenceMode.Attribute),
		NotifyParentProperty(true),
		]
		public string SelectedCss
		{
			get
			{
				object mouseOverCss = ViewState["SelectedCss"];
				return (mouseOverCss == null ? string.Empty : mouseOverCss.ToString());
			}
			set
			{
				ViewState["SelectedCss"] = value;
				ViewState.SetItemDirty("SelectedCss", true);
			}
		}

		[ 
		PersistenceMode(PersistenceMode.Attribute),
		NotifyParentProperty(true),
		]
		public bool Collapsed
		{
			get
			{
				object collapsed = ViewState["Collapsed"];
				return (collapsed == null ? true : bool.Parse(collapsed.ToString()));
			}
			set
			{
				ViewState["Collapsed"] = value;
				ViewState.SetItemDirty("Collapsed", true);
			}
		}

		[ 
		PersistenceMode(PersistenceMode.Attribute),
		NotifyParentProperty(true),
		]
		public bool Selected
		{
			get
			{
				object selected = ViewState["Selected"];
				return (selected == null ? false : bool.Parse(selected.ToString()));
			}
			set
			{
				ViewState["Selected"] = value;
				ViewState.SetItemDirty("Selected", true);
			}
		}

		[ 
		PersistenceMode(PersistenceMode.Attribute),
		NotifyParentProperty(true),
		]
		public NodeType NodeType
		{
			get
			{
				object nodeType = ViewState["NodeType"];
				return (nodeType == null ? NodeType.Link : ((NodeType)Enum.Parse(typeof(NodeType), nodeType.ToString())));
			}
			set
			{
				ViewState["NodeType"] = value;
				ViewState.SetItemDirty("NodeType", true);
			}
		}

		/// <summary>
		/// addtional property for the using of NavigaorTag
		/// </summary>
		[ 
		PersistenceMode(PersistenceMode.Attribute),
		NotifyParentProperty(true),
		]
		public object Value
		{
			get
			{
				return ViewState["Value"];
			}
			set
			{
				ViewState["Value"] = value;
				ViewState.SetItemDirty("Value", true);
			}
		}

		[ 
		PersistenceMode(PersistenceMode.Attribute),
		DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
		NotifyParentProperty(true),
		]
		public TreeNodeCollection Nodes
		{
			get
			{
				if (base.IsTrackingViewState)
				{
					((IStateManager)m_Nodes).TrackViewState();
				}

				return this.m_Nodes;
			}
		}

		[ 
		PersistenceMode(PersistenceMode.Attribute),
		NotifyParentProperty(true),
		]
		public override string CssClass
		{
			get
			{
				object css = ViewState["CssClass"];
				return (css == null ? string.Empty : css.ToString());
			}
			set
			{
				ViewState["CssClass"] = value;
				ViewState.SetItemDirty("CssClass", true);
			}
		}
		#endregion

		#region IStateManager Members
		bool IStateManager.IsTrackingViewState
		{
			get 
			{
				return base.IsTrackingViewState;
			}
		}

		void IStateManager.TrackViewState()
		{
			// TODO:  Add TreeNode.TrackViewState implementation
			base.TrackViewState();
			if (m_Nodes != null)
			{
				((IStateManager)m_Nodes).TrackViewState();
			}
		}

		object IStateManager.SaveViewState()
		{
			// TODO:  Add TreeNode.SaveViewState implementation
			object baseState = ((IStateManager) this.ViewState).SaveViewState();
			object nodesState = ((IStateManager) this.m_Nodes).SaveViewState();
			if (baseState == null && nodesState == null)
			{
				return null;
			}
			else
			{
				return new Triplet(baseState, nodesState);
			}
		}

		void IStateManager.LoadViewState(object state)
		{
			// TODO:  Add TreeNode.LoadViewState implementation
			if (state != null)
			{
				Triplet t = (Triplet)state;
				if (t.First != null)
				{
					((IStateManager) this.ViewState).LoadViewState(t.First);
				}
				if (t.Second != null)
				{
					((IStateManager) this.m_Nodes).LoadViewState(t.Second);
				}
			}
		}

		#endregion
	}
}
