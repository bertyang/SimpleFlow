/***************************************************************************************
 ** File Name: SystemMenuList.cs
 ** Copyrith (C) 2006 BenQ Corporation. All rights reserved.
 ** Creator:  HI2/Jerry Jiang
 ** Create date: 11/04/2006
 ** Modifier:
 ** Modify date:
 ** Description: SystemMenuList集合类定义
 ***************************************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

using SimpleFlow.SystemFramework;


/// <summary>
/// Summary description for SystemMenuList.
/// </summary>
public class SystemMenuList : List<IMenuItem>
{
    internal class SystemMenuCompare : IComparer<IMenuItem>
    {
        public int Compare(IMenuItem x, IMenuItem y)
        {
            return x.DisplayOrder - y.DisplayOrder;
        }

    }


    /// <summary>
    /// sort
    /// </summary>
    public void SortByDisplayOrder()
    {
        // this.InnerList.Sort(new SystemMenuCompare());
        this.Sort(new SystemMenuCompare());
    }


    /// <summary>
    /// Filter
    /// </summary>
    /// <param name="parentID">parentID </param>
    /// <returns>SystemMenuList </returns>
    public SystemMenuList Filter(string parentID)
    {
        SystemMenuList menuList = new SystemMenuList();
        foreach (IMenuItem menu in this)
        {
            if (menu.ParentId.Trim() == parentID.Trim())
            {
                menuList.Add(menu);
            }
        }
        return menuList;
    }
}
