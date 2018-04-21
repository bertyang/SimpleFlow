/*****************************************************************************
** File Name: TreeNodeClickEventArgs.cs
** Copyright (C) 2006 BenQ Corporation. All rights reserved.
** Create date: Fri Nov 24 11:11:02 UTC+0800 2006
*******************************************************************************/
using System;

namespace SimpleFlow.WebControlLibrary
{
	public delegate void TreeNodeClickedEventHandler(object sender, TreeNodeClickEventArgs e);
	/// <summary>
	/// Summary description for TreeNodeClickEventArgs.
	/// </summary>
	public class TreeNodeClickEventArgs : EventArgs
	{
		private string m_CommandName;

		public TreeNodeClickEventArgs(string name)
		{
			//
			// TODO: Add constructor logic here
			//
			m_CommandName = name;
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
	}
}
