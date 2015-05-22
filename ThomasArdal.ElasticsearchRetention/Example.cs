using System;

namespace ThomasArdal.ElasticsearchRetention
{
    public class Example
    {
        public Example()
        {
            IndexRetention
                .On("logstash-{0:yyyy.MM.dd}")
                .DeleteAfter(TimeSpan.FromDays(365))
                .Schedule.EveryMinute();
            IndexRetention
                .On("logstash-{0:yyyy.MM.dd}")
                .DeleteAfter(30.Seconds())
                .Schedule.EveryHour();
            IndexRetention
                .On("logstash-{0:yyyy.MM.dd}")
                .DeleteAfter(5.Minutes())
                .Schedule.EveryDay();
            IndexRetention
                .On("logstash-{0:yyyy.MM.dd}")
                .DeleteAfter(6.Hours())
                .Schedule.At(TimeSpan.FromHours(6));
            IndexRetention
                .On("logstash-{0:yyyy.MM.dd}")
                .DeleteAfter(30.Days())
                .Schedule.WithCronTrigger("djdjdjd");
        }
    }
}