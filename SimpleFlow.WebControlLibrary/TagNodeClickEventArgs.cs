/*****************************************************************************
** File Name: TagNodeClickEventArgs.cs
** Copyright (C) 2006 BenQ Corporation. All rights reserved.
** Create date: Wed Mar 21 16:09:48 UTC+0800 2007
*******************************************************************************/
using System;

namespace SimpleFlow.WebControlLibrary
{
	public delegate void TagNodeClickEventHandler(object sender, TagNodeClickEventArgs e);

	/// <summary>
	/// Summary description for TagNodeClickEventArgs.
	/// </summary>
	public class TagNodeClickEventArgs : EventArgs
	{
		private TreeNode m_Node = null;
		private string m_CommandName = string.Empty;

		public TagNodeClickEventArgs(TreeNode node, string commandName)
		{
			this.m_Node = node;
			this.m_CommandName = commandName;
		}

		/// <summary>
		/// Readonly access to commandName parameter of EventArgs class
		/// </summary>
		public string CommandName
		{
			get
			{
				return m_CommandName;
			}
		}

		/// <summary>
		/// Readonly access to node parameter of EventArgs class
		/// </summary>
		public TreeNode Node
		{
			get
			{
				return m_Node;
			}
		}
	}
}
