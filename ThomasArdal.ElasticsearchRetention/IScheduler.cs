using System;

namespace ThomasArdal.ElasticsearchRetention
{
    public interface IScheduler
    {
        void EveryMinute();
        void EveryHour();
        void EveryDay();
        void At(TimeSpan fromHours);
        void WithCronTrigger(string trigger);
    }

    class Scheduler : IScheduler
    {
        private readonly string _namePattern;
        private readonly TimeSpan _timeSpan;

        public Scheduler(string namePattern, TimeSpan timeSpan)
        {
            _namePattern = namePattern;
            _timeSpan = timeSpan;
        }

        public void EveryMinute()
        {
            throw new NotImplementedException();
        }

        public void EveryHour()
        {
            throw new NotImplementedException();
        }

        public void EveryDay()
        {
            throw new NotImplementedException();
        }

        public void At(TimeSpan fromHours)
        {
            throw new NotImplementedException();
        }

        public void WithCronTrigger(string trigger)
        {
            throw new NotImplementedException();
        }
    }
}