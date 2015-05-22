using System;

namespace ThomasArdal.ElasticsearchRetention
{
    public interface IDeleteAfter
    {
        IScheduler Schedule { get; }
    }

    class DeleteAfter : IDeleteAfter
    {
        public DeleteAfter(string namePattern, TimeSpan timeSpan)
        {
            Schedule = new Scheduler(namePattern, timeSpan);
        }

        public IScheduler Schedule { get; private set; }
    }
}