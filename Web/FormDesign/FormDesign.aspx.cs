using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text.RegularExpressions;
using SimpleFlow.BusinessFacade;

public partial class FormDesign_FormDesign : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonCreate_Click(object sender, EventArgs e)
    {
        StreamReader sr = new StreamReader(FileTemplate.Value, System.Text.Encoding.Default);

        string text = sr.ReadToEnd();

        FormBiz.Make(text);

    }
}
