namespace PH.Web.HashAdapters
{
    public class BCryptAlgorithmAdapter : HashAlgorithmAdapter
    {
        public override string Name => "BCrypt";

        public override string ComputeHash(string plainText)
        {
            return BCrypt.Net.BCrypt.HashPassword(plainText);
        }
    }
}