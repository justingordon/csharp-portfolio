﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstonTech.Common.Extensions
{
    public static class Extensions
    {
        /// <summary>
        /// Attempts to convert string to valid DateTime. If failed, returns DateTime.MinValue.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static DateTime ToDate(this string s)
        {
            DateTime dateTime;

            if (DateTime.TryParse(s, out dateTime))
                return dateTime;
            else
                return DateTime.MinValue;
        }
        /// <summary>
        /// Attempts to convert string to valid Integer. If failed, return 0.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int ToInt(this string s)
        {
            int intValue = 0;

            if (int.TryParse(s, out intValue))
                return intValue;
            else
                return 0;
        }

        /// <summary>
        /// Elapseds the time.
        /// </summary>
        /// <param name="datetime">The datetime.</param>
        /// <returns>TimeSpan</returns>
        public static TimeSpan Elapsed(this DateTime datetime)
        {
            return DateTime.Now - datetime;
        }

    }
}
