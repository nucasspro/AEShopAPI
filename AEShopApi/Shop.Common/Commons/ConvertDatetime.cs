using System;

namespace Shop.Common.Commons
{
    public class ConvertDatetime
    {
        public static string ConvertToTimeSpan(string time)
        {
            DateTime dateTime = DateTime.Parse(time).ToLocalTime();
            var dateTimeOffset = new DateTimeOffset(dateTime);
            return dateTimeOffset.ToUnixTimeSeconds().ToString();
        }

        public static int ConvertToTimeSpan(DateTime time)
        {
            var dateTimeOffset = new DateTimeOffset(time.ToLocalTime());
            return Convert.ToInt32(dateTimeOffset.ToUnixTimeSeconds());
        }

        public static DateTime UnixTimestampToDateTime(double unixTime)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateTime = dateTime.AddSeconds(unixTime).ToLocalTime();
            return dateTime;
        }
    }
}