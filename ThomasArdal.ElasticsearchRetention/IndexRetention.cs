namespace ThomasArdal.ElasticsearchRetention
{
    public class IndexRetention
    {
        public static IIndexRetentionOn On(string namePattern)
        {
            return new IndexRetentionOn(namePattern);
        }
    }
}
