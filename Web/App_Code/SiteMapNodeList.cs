using System;
using System.Collections.Generic;
using System.Text;


public class SiteMapNodeList : List<SiteMapNode>
{
    public void Add(string text, string url)
    {
        this.Add(new SiteMapNode(text, url));
    }
}

