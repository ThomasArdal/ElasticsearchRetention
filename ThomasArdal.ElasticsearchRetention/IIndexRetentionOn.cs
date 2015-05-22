using System;

namespace ThomasArdal.ElasticsearchRetention
{
    public interface IIndexRetentionOn
    {
        IDeleteAfter DeleteAfter(TimeSpan timeSpan);
    }

    class IndexRetentionOn : IIndexRetentionOn
    {
        private readonly string _namePattern;

        public IndexRetentionOn(string namePattern)
        {
            _namePattern = namePattern;
        }

        public IDeleteAfter DeleteAfter(TimeSpan timeSpan)
        {
            return new DeleteAfter(_namePattern, timeSpan);
        }
    }
}