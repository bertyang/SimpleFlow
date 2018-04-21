/*****************************************************************************
** File Name: DateTimeHelper.cs
** Copyright (C) 2006 BenQ Corporation. All rights reserved.
** Create date: Thu Nov 9 11:05:55 UTC+0800 2006
*******************************************************************************/
using System;
using System.Globalization;
using System.Configuration;


namespace SimpleFlow.WebControlLibrary
{
	/// <summary>
	/// Summary description for DateTimeHelper.
	/// </summary>
	//internal sealed class DateTimeHelper
    public class DateTimeHelper
	{
		/// <summary>
		/// Meanless date for the system, normally means use hasn't set this value yet
		/// </summary>
		public static readonly DateTime MeanlessDate = new DateTime(1900, 1, 1);
		public static readonly DateTime MaxDate = new DateTime(9999, 12, 31);
		private static readonly string m_DatePattern;
		private static readonly string m_LongDatePattern;
		private static char m_DateSeperator;

		static DateTimeHelper()
		{
			try
			{
				m_DatePattern = ConfigurationManager.AppSettings["DatePattern"];
				if (m_DatePattern == null || m_DatePattern.Length == 0)
				{
					m_DatePattern = "yyyy/MM/dd";
				}
                m_LongDatePattern = ConfigurationManager.AppSettings["LongDatePattern"];
				if (m_DatePattern == null || m_DatePattern.Length == 0)
				{
					m_LongDatePattern = "yyyy/MM/dd HH:mm";
				}
			}
			catch
			{
				m_DatePattern = "yyyy/MM/dd";
				m_LongDatePattern = "yyyy/MM/dd HH:mm";
			}
			finally
			{
				m_DateSeperator = ParseSeperator(m_DatePattern);
			}
		}

		/// <summary>
		/// Converts datetime to formatted string
		/// </summary>
		/// <param name="date">Date to be converted</param>
		/// <returns>Converted string</returns>
		public static string FormatDate(DateTime date)
		{
			if (date == MeanlessDate)
			{
				return string.Empty;
			}
			DateTimeFormatInfo dateFormat = new DateTimeFormatInfo();
			dateFormat.LongDatePattern = m_DatePattern;
			dateFormat.ShortDatePattern = m_DatePattern;
			return date.ToString(m_DatePattern, dateFormat);
		}

		/// <summary>
		/// Converts datetime to formatted string
		/// </summary>
		/// <param name="date">Date to be converted</param>
		/// <returns>Converted string</returns>
		public static string FormatLongDate(DateTime date)
		{
			if (date == MeanlessDate)
			{
				return string.Empty;
			}
			DateTimeFormatInfo dateFormat = new DateTimeFormatInfo();
			dateFormat.LongDatePattern = m_LongDatePattern;
			dateFormat.ShortDatePattern = m_LongDatePattern;
			return date.ToString(m_LongDatePattern, dateFormat);
		}

		/// <summary>
		/// format datetime to string format "yyyyMMdd", such as file name
		/// </summary>
		/// <param name="date"></param>
		/// <returns></returns>
		public static string FormatToFileName(DateTime date)
		{
			return date.ToString("yyyyMMddHHmmss");
		}

		/// <summary>
		/// format today's datetime to string format "yyyyMMdd"
		/// </summary>
		/// <returns></returns>
		public static string FormatToFileName()
		{
			DateTime date = System.DateTime.Now;
			return FormatToFileName(date);
		}

		/// <summary>
		/// format string datetime
		/// </summary>
		/// <param name="date">date</param>
		/// <returns></returns>
		public static DateTime Parse(string date)
		{
			System.Globalization.DateTimeFormatInfo formatInfo = new System.Globalization.DateTimeFormatInfo();
			formatInfo.ShortDatePattern = m_DatePattern;
			DateTime parseTime;
			try
			{
				parseTime = DateTime.Parse(date, formatInfo);
			}
			catch
			{
				parseTime = MeanlessDate;
			}

			return parseTime;
		}

		public static string DatePattern
		{
			get
			{
				return m_DatePattern;
			}
		}

		public static char DateSeperator
		{
			get
			{
				return m_DateSeperator;
			}
		}

		/// <summary>
		/// If the date time add months large than 9999-12-31, then it will catch an exception.
		/// so, when occur an exception then return the Date '9999-12-31'.
		/// </summary>
		/// <param name="original">time to be added</param>
		/// <param name="months">added months count</param>
		/// <returns>Correct month</returns>
		public static DateTime AddMonths(DateTime original, int months)
		{
			DateTime added;
			try 
			{
				added = original.AddMonths(months);
			}
			catch
			{
				// Because the MaxValue will return hour, minite and second,
				// So when the datebase exist such record '9999-12-31', it will select this record,
				// But we don't want this record.
//				added = DateTime.MaxValue;
				added = MaxDate;
			}
			return added;
		}

		/// <summary>
		/// Get the last day DateTime of the month of parameter original.
		/// such as: Input:2007-2-5, it will return 2007-2-28.
		/// </summary>
		/// <param name="original">parameter datetime</param>
		/// <returns>the last day of the input parameter's month</returns>
		public static DateTime GetLastDateOfMonth(DateTime original)
		{
			DateTime last;
			try
			{
				last = original.AddMonths(1).AddDays(-1);
			}
			catch
			{
				// Because the MaxValue will return hour, minite and second,
				// So when the datebase exist such record '9999-12-31', it will select this record,
				// But normally we don't want this record.
//				last = DateTime.MaxValue;
				last = MaxDate;
			}
			return last;
		}

		/// <summary>
		/// Get the seperator of datetime format.
		/// </summary>
		/// <param name="pattern"></param>
		/// <returns>char seperator</returns>
		private static char ParseSeperator(string pattern)
		{
			char[] charactors = pattern.ToCharArray();
			char seperator = '/';
			foreach(char c in charactors)
			{
				if (char.IsLetter(c) == false)
				{
					seperator = c;
					break;
				}
			}
			return seperator;
		}

		/// <summary>
		/// Judge datetime whether is Max Date which define as '9999-12-31'.
		/// </summary>
		/// <param name="toCompare">Datetime to be compared</param>
		/// <returns>true or false</returns>
		public static bool IsMaxDate(DateTime toCompare)
		{
			return (toCompare.Year == MaxDate.Year 
				&& toCompare.Month == MaxDate.Month 
				&& toCompare.Day == MaxDate.Day);
		}
	}
}
