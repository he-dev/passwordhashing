namespace PH.Web.HashAdapters
{
    public abstract class HashAlgorithmAdapter
    {
        public abstract string Name { get; }
        public abstract string ComputeHash(string plainText);
    }
}