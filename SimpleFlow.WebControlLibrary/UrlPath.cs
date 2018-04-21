/*****************************************************************************
** Version 01.00.0000.0001
** File Name: DropDownListExtend.cs
** Copyright (C) 2006 BenQ Corporation. All rights reserved.
** Creator: 
** Create date: 11/01/2006
The following code are generated with decompile tool, don't modify it.
*******************************************************************************/
namespace SimpleFlow.WebControlLibrary
{
    using System;
    using System.Collections;
    using System.IO;
    using System.Text;
    using System.Web;

    public class UrlPath
    {
        private UrlPath()
        {
        }

        public static string AppendSlashToPathIfNeeded(string path)
        {
            if (path == null)
            {
                return null;
            }
            int num1 = path.Length;
            if ((num1 != 0) && (path[num1 - 1] != '/'))
            {
                path = path + '/';
            }
            return path;
        }

        public static string Combine(string basepath, string relative)
        {
            string text1;
            UrlPath.FailIfPhysicalPath(relative);
            if (UrlPath.IsRooted(relative))
            {
                text1 = relative;
                if ((text1 == null) || (text1.Length == 0))
                {
                    return string.Empty;
                }
            }
            else
            {
                string text2 = HttpRuntime.AppDomainAppVirtualPath;
                if ((relative.Length == 1) && (relative[0] == '~'))
                {
                    return text2;
                }
                if (((relative.Length >= 2) && (relative[0] == '~')) && ((relative[1] == '/') || (relative[1] == '\\')))
                {
                    if (text2.Length > 1)
                    {
                        text1 = text2 + "/" + relative.Substring(2);
                    }
                    else
                    {
                        text1 = "/" + relative.Substring(2);
                    }
                }
                else
                {
                    if ((basepath == null) || ((basepath.Length == 1) && (basepath[0] == '/')))
                    {
                        basepath = string.Empty;
                    }
                    text1 = basepath + "/" + relative;
                }
            }
            return UrlPath.Reduce(text1);
        }

        private static void FailIfPhysicalPath(string path)
        {
            if (((path != null) && (path.Length >= 4)) && ((path[1] == ':') || ((path[0] == '\\') && (path[1] == '\\'))))
            {
                throw new HttpException(FormatResourceString("Physical_path_not_allowed", path));
            }
        }

        public static string GetDirectory(string path)
        {
            if ((path == null) || (path.Length == 0))
            {
                throw new ArgumentException(FormatResourceString("Empty_path_has_no_directory"));
            }
            if (path[0] != '/')
            {
                throw new ArgumentException(FormatResourceString("Path_must_be_rooted"));
            }
            string text1 = path.Substring(0, path.LastIndexOf('/'));
            if (text1.Length == 0)
            {
                return "/";
            }
            return text1;
        }

        public static string GetDirectoryOrRootName(string path)
        {
            string text1 = Path.GetDirectoryName(path);
            if (text1 == null)
            {
                text1 = Path.GetPathRoot(path);
            }
            return text1;
        }

        public static string GetFileName(string path)
        {
            return Path.GetFileName(path);
        }

        public static bool IsAbsolutePhysicalPath(string path)
        {
            if ((path != null) && (path.Length >= 3))
            {
                if (path.StartsWith(@"\\"))
                {
                    return true;
                }
                if (char.IsLetter(path[0]) && (path[1] == ':'))
                {
                    return (path[2] == '\\');
                }
            }
            return false;
        }

        public static bool IsAppRelativePath(string path)
        {
            if (path.Length >= 1)
            {
                return (path[0] == '~');
            }
            return false;
        }

        public static bool IsRelativeUrl(string url)
        {
            if (url.IndexOf(":") != -1)
            {
                return false;
            }
            return !UrlPath.IsRooted(url);
        }

        public static bool IsRooted(string basepath)
        {
            if (((basepath != null) && (basepath.Length != 0)) && (basepath[0] != '/'))
            {
                return (basepath[0] == '\\');
            }
            return true;
        }

        public static bool IsValidVirtualPathWithoutProtocol(string path)
        {
            if (path == null)
            {
                return false;
            }
            if (path.IndexOf(":") != -1)
            {
                return false;
            }
            return true;
        }

        public static string MakeRelative(string from, string to)
        {
            Uri uri1 = new Uri("file://foo" + from);
            Uri uri2 = new Uri("file://foo" + to);
            string text1 = uri1.MakeRelativeUri(uri2).ToString();
            return (text1 + uri2.Query + uri2.Fragment);
        }

        public static string Reduce(string path)
        {
            string text1 = null;
            if (path != null)
            {
                int num1 = path.IndexOf('?');
                if (num1 >= 0)
                {
                    text1 = path.Substring(num1);
                    path = path.Substring(0, num1);
                }
            }
            int num2 = path.Length;
            path = path.Replace('\\', '/');
            int num3 = 0;
            while (true)
            {
                num3 = path.IndexOf('.', num3);
                if (num3 < 0)
                {
                    if (text1 == null)
                    {
                        return path;
                    }
                    return (path + text1);
                }
                if (((num3 == 0) || (path[num3 - 1] == '/')) && ((((num3 + 1) == num2) || (path[num3 + 1] == '/')) || ((path[num3 + 1] == '.') && (((num3 + 2) == num2) || (path[num3 + 2] == '/')))))
                {
                    break;
                }
                num3++;
            }
            ArrayList list1 = new ArrayList();
            StringBuilder builder1 = new StringBuilder();
            num3 = 0;
            while (true)
            {
                int num4 = num3;
                num3 = path.IndexOf('/', num4 + 1);
                if (num3 < 0)
                {
                    num3 = num2;
                }
                if ((((num3 - num4) <= 3) && ((num3 < 1) || (path[num3 - 1] == '.'))) && (((num4 + 1) >= num2) || (path[num4 + 1] == '.')))
                {
                    if ((num3 - num4) == 3)
                    {
                        if (list1.Count == 0)
                        {
                            throw new HttpException(FormatResourceString("Cannot_exit_up_top_directory"));
                        }
                        builder1.Length = (int) list1[list1.Count - 1];
                        list1.RemoveRange(list1.Count - 1, 1);
                    }
                }
                else
                {
                    list1.Add(builder1.Length);
                    builder1.Append(path, num4, num3 - num4);
                }
                if (num3 == num2)
                {
                    return (builder1.ToString() + text1);
                }
            }
        }


        private const char appRelativeCharacter = '~';
        private const string dummyProtocolAndServer = "file://foo";

		private static string FormatResourceString(string resource)
		{
			return resource;
		}

		private static string FormatResourceString(string resource1, string resoruce2)
		{
			return resource1 + " " + resoruce2;
		}
    }
}

