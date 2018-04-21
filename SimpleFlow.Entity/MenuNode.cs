using System;
using System.Collections.Generic;
using System.Text;


namespace SimpleFlow.Entity
{
    public class MenuNode
    {
        private SysMenu m_menu = null;

        public SysMenu SysMenu
        {
            get { return m_menu; }
        }

        public MenuNode(SysMenu menu)
        {
            m_menu = menu;
        }

        private List<MenuNode> m_nodes = new List<MenuNode>();

        public List<MenuNode> Nodes
        {
            get { return m_nodes; }
        }
    }
}
