/***************************************************************************************
 ** File Name: MenuItem.cs
 ** Copyrith (C) 2006 BenQ Corporation. All rights reserved.
 ** Creator:  HI2/Jerry Jiang
 ** Create date: 11/04/2006
 ** Modifier:
 ** Modify date:
 ** Description: MenuItem¿‡∂®“Â
 ***************************************************************************************/
using System;
using System.Data;

namespace SimpleFlow.SystemFramework
{

    ///<summary>
    ///Warning: this class code is automaticaly created by QCoder,  Version=3.5.0.0
    ///Base on QDataDriver:3.0.1.2
    ///
    ///Function :
    ///Author :
    ///Created Date :2006-11-1
    ///</summary>
    public interface IMenuItem // : IComparable<IMenuItem>
    {
        
        /// <summary>
        /// Menuid
        /// </summary>
        string MenuId { get; set;  }


        string MenuName { get; set; }

        /// <summary>
        /// Parent
        /// </summary>
        string ParentId { get; set;  }
        
        /// <summary>
        /// Display Order
        /// </summary>
        int DisplayOrder { get; set;  }
        

        /// <summary>
        /// Linkurl
        /// </summary>
        string Url { get; set;  }
        

        ///// <summary>
        ///// Resourceid
        ///// </summary>
        //string Resourceid { get; }
        
        ///// <summary>
        ///// Culture
        ///// </summary>
        //string Culture { get; }
        
        ///// <summary>
        /////  Content
        ///// </summary>
        //string Content { get; }

        
    }

}