using System;
using System.Collections.Generic;
using System.Text;


public class SiteMapNode
{
    private string m_text;
    private string m_url;

    public string Text
    {
        get { return m_text; }
        set { m_text = value; }
    }

    public string URL
    {
        get { return m_url; }
        set { m_url = value; }
    }

    public SiteMapNode(string text, string url)
    {
        m_text = text;
        m_url = url;
    }
}

