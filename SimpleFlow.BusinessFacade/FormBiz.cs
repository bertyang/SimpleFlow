using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

using SimpleFlow.Entity;
using SimpleFlow.DataAccess;

namespace SimpleFlow.BusinessFacade
{
    public static class FormBiz
    {
        public static List<FormInfo> GetAll()
        {
            return FormDataAccess.GetAll();
        }

        public static FormInfo GetForm(int formId)
        {
            return FormDataAccess.GetForm(formId);
        }


        public static void Make(string text)
        {
            string patternInput = "<input\\s*(id=\"?(?<id>\\w+)\"?)?\\s*(name=\"?(?<name>\\w+)\"?)?\\s*type=\"?text\"?\\s*/>|<input\\s*(id=\"?(?<id>\\w+)\"?)?\\s*(name=\"?(?<name>\\w+)\"?)?\\s*type=\"?text\"?\\s*>[\\s\\S]+?</input>";

            MatchCollection mc = Regex.Matches(text, patternInput, RegexOptions.IgnoreCase);

            for (int i = 0; i < mc.Count; i++)
            {
                string id = mc[i].Result("${id}");
                string name = mc[i].Result("${name}");

                if (!string.IsNullOrEmpty(id))
                {
                }
                else
                {
                }
            }

            string patternSelect = "<select\\s*(id=\"?(?<id>\\w+)\"?)?\\s*(name=\"?(?<name>\\w+)\"?)?\\s*>[\\s\\S]+?</select>";

            mc = Regex.Matches(text, patternSelect, RegexOptions.IgnoreCase);

            for (int i = 0; i < mc.Count; i++)
            {
                string id = mc[i].Result("${id}");
                string name = mc[i].Result("${name}");

                if (!string.IsNullOrEmpty(id))
                {
                }
                else
                {
                }
            }
        }
    }
}
