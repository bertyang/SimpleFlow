/*****************************************************************************
** File Name: TreeNodeCollection.cs
** Copyright (C) 2006 BenQ Corporation. All rights reserved.
** Create date: Fri Nov 24 10:33:42 UTC+0800 2006
*******************************************************************************/
using System;
using System.Web;
using System.ComponentModel;
using System.Collections;
using System.Web.UI;

namespace SimpleFlow.WebControlLibrary
{
	/// <summary>
	/// Summary description for TreeNodeCollection.
	/// </summary>
	public class TreeNodeCollection : ICollection, IStateManager
	{
		#region Private Member Variables
		// private member variables
		private ArrayList m_Nodes = new ArrayList();
		private bool isTrackingViewState = false;
		#endregion

		#region ICollection Implementation

		public virtual int Add(TreeNode node)
		{
			int result = m_Nodes.Add(node);
			return result;
		}

		public virtual int Add(string text)
		{
			int result = m_Nodes.Add(new TreeNode(text));
			return result;
		}

		public virtual int Add(string text, string url)
		{
			int result = m_Nodes.Add(new TreeNode(text, url));
			return result;
		}

		/// <summary>
		/// Clears out the entire TreeNodeCollection.
		/// </summary>
		public virtual void Clear()
		{
			m_Nodes.Clear();
		}

		/// <summary>
		/// Determines if a particular TreeNode exists within the collection.
		/// </summary>
		/// <param name="node">The TreeNode instance to check for.</param>
		/// <returns>A Boolean - true if the TreeNode is in the collection, false otherwise.</returns>
		public virtual bool Contains(TreeNode node)
		{
			return m_Nodes.Contains(node);
		}

		/// <summary>
		/// get the tree node by node id 
		/// </summary>
		/// <param name="nodeID">identity node id</param>
		/// <returns>tree node</returns>
		public virtual TreeNode RetrieveNode(string nodeID)
		{
			string trim = nodeID.Trim().ToLower();
			foreach (TreeNode node in this)
			{
				if (node.NodeID.Trim().ToLower() == trim) 
				{
					return node;
				}
			}
			return null;
		}

		/// <summary>
		/// Returns the ordinal index of a TreeNode, if it exists; if the node does not exist,
		/// -1 is returned.
		/// </summary>
		/// <param name="node">The TreeNode to search for.</param>
		/// <returns>The ordinal position of the node in the collection.</returns>
		public virtual int IndexOf(TreeNode node)
		{
			return m_Nodes.IndexOf(node);
		}

		/// <summary>
		/// Inserts a TreeNode instance at a particular location in the collection.
		/// </summary>
		/// <param name="index">The ordinal location to insert the node.</param>
		/// <param name="node">The TreeNode to insert.</param>
		public virtual void Insert(int index, TreeNode node)
		{
			m_Nodes.Insert(index, node);
		}

		/// <summary>
		/// Removes a specified TreeNode from the collection.
		/// </summary>
		/// <param name="node">The TreeNode instance to remove.</param>
		public void Remove(TreeNode node)
		{
			m_Nodes.Remove(node);
		}

		/// <summary>
		/// Removes a TreeNode from a particular ordinal position in the collection.
		/// </summary>
		/// <param name="index">The ordinal position of the TreeNode to remove.</param>
		public void RemoveAt(int index)
		{
			m_Nodes.RemoveAt(index);
		}

		/// <summary>
		/// Copies the contents of the TreeNode to an array.
		/// </summary>
		/// <param name="array"></param>
		/// <param name="index"></param>
		public void CopyTo(Array array, int index)
		{
			m_Nodes.CopyTo(array, index);
		}

		/// <summary>
		/// Gets an Enumerator for enumerating through the collection.
		/// </summary>
		/// <returns></returns>
		public IEnumerator GetEnumerator()
		{
			return m_Nodes.GetEnumerator();
		}
		#endregion
        
		#region IStateManager Interface
		/// <summary>
		/// Indicates that changes to the view state should be tracked.  Calls TrackViewState()
		/// for each TreeNode in the collection.
		/// </summary>
		void IStateManager.TrackViewState()
		{
			this.isTrackingViewState = true;
			foreach(TreeNode node in this.m_Nodes)
				((IStateManager) node).TrackViewState();
		}

		/// <summary>
		/// Saves the view state in an object array.  Each node in the collection has its
		/// SaveViewState() method called.  This array is then returned, representing the
		/// state of the TreeNodeCollection.
		/// </summary>
		/// <returns>An object array.</returns>
		object IStateManager.SaveViewState()
		{
			bool isAllNulls = true;
			object [] state = new object[this.m_Nodes.Count];
			for (int i = 0; i < this.m_Nodes.Count; i++)
			{
				// Save each node's viewstate...
				state[i] = ((IStateManager) this.m_Nodes[i]).SaveViewState();
				if (state[i] != null)
					isAllNulls = false;
			}

			// If all items returned null, simply return a null rather than the object array
			if (isAllNulls)
				return null;
			else
				return state;
		}

		/// <summary>
		/// Iterate through the object array passed in.  For each element in the object array
		/// passed-in, a new TreeNode instance is created, added to the collection, and populated
		/// by calling LoadViewState().
		/// </summary>
		/// <param name="savedState">The object array returned by the SaveViewState() method in
		/// the previous page visit.</param>
		void IStateManager.LoadViewState(object savedState)
		{
			if (savedState != null)
			{
				object [] state = (object[]) savedState;

				// Create an ArrayList of the precise size
				m_Nodes = new ArrayList(state.Length);

				for (int i = 0; i < state.Length; i++)
				{
					TreeNode mi = new TreeNode();		// create TreeNode
					((IStateManager) mi).TrackViewState();	// Indicate that it needs to track its view state

					// Add the TreeNode to the collection
					m_Nodes.Add(mi);

					if (state[i] != null)
					{
						// Load its state via LoadViewState()
						((IStateManager) m_Nodes[i]).LoadViewState(state[i]);
					}
				}
			}
		}
		#endregion

		#region TreeNodeCollection Properties
		/// <summary>
		/// Returns the number of elements in the TreeNodeCollection.
		/// </summary>
		/// <value>The actual number of elements contained in the <see cref="TreeNodeCollection"/>.</value>
		[ Browsable(false) ]
		public virtual int Count
		{
			get
			{
				return m_Nodes.Count;
			}
		}


		/// <summary>
		/// Gets a value indicating whether access to the <see cref="TreeNodeCollection"/> is synchronized (thread-safe).
		/// </summary>
		[ Browsable(false) ]
		public virtual bool IsSynchronized
		{
			get
			{
				return m_Nodes.IsSynchronized;
			}
		}


		/// <summary>
		/// Gets an object that can be used to synchrnoize access to the <see cref="TreeNodeCollection"/>.
		/// </summary>
		[ Browsable(false) ]
		public virtual object SyncRoot
		{
			get
			{
				return m_Nodes.SyncRoot;
			}
		}


		/// <summary>
		/// Gets the <see cref="TreeNode"/> at a specified ordinal index.
		/// </summary>
		/// <remarks>Allows read-only access to the <see cref="TreeNodeCollection"/>'s elements by index.
		/// For example, myMenuCollection[4] would return the fifth <see cref="TreeNode"/> instance.</remarks>
		public virtual TreeNode this[int index]
		{
			get
			{
				return (TreeNode) m_Nodes[index];
			}
		}


		/// <summary>
		/// Gets the <see cref="TreeNode"/> with a specified <see cref="Name"/>.
		/// </summary>
		/// <remarks>The <see cref="TreeNode"/> class has a <see cref="Name"/> property that allows for items
		/// to be indexed by name.<p />For example, myMenuCollection["Contact"] would return the 
		/// <see cref="TreeNode"/> instance with the <see cref="Name"/> "Contact", or <b>null</b> if no such
		/// TreeNode existed in the TreeNodeCollection.</remarks>
		public virtual TreeNode this[string name]
		{
			get
			{
				foreach(TreeNode node in m_Nodes)
				{
					if (node.Name == name)
						return node;
				}
				return null;
			}
		}


		/// <summary>
		/// A required property since TreeNodeCollection implements IStateManager.  This
		/// property simply indicates if the TreeNodeCollection is tracking its view state or not.
		/// </summary>
		bool IStateManager.IsTrackingViewState
		{
			get 
			{ 
				return this.isTrackingViewState; 
			}
		}
		#endregion
	}
}
