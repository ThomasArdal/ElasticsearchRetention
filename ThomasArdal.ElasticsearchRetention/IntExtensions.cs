using System;

namespace ThomasArdal.ElasticsearchRetention
{
    public static class IntExtensions
    {
        public static TimeSpan Seconds(this int t)
        {
            return TimeSpan.FromSeconds(t);
        }
         
        public static TimeSpan Minutes(this int t)
        {
            return TimeSpan.FromMinutes(t);
        }
         
        public static TimeSpan Hours(this int t)
        {
            return TimeSpan.FromHours(t);
        }
         
        public static TimeSpan Days(this int t)
        {
            return TimeSpan.FromDays(t);
        }
    }
}