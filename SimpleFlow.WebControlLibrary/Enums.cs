/*****************************************************************************
** File Name: Enums.cs
** Copyright (C) 2006 BenQ Corporation. All rights reserved.
** Create date: Fri Nov 24 10:29:03 UTC+0800 2006
*******************************************************************************/
using System;

namespace SimpleFlow.WebControlLibrary
{
	public enum NodeType
	{
		Link,
		Text,
		Splitter,
	}

    public struct Valid
    {
        public const string YES = "Y";
        public const string NO = "N";
    }

    public struct ButtonMove
    {
        public const int UP = 1;
        public const int DOWN = 2;
    }

}
