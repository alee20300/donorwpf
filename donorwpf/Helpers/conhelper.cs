using System.Configuration;

namespace donorwpf.Helpers
{
    public static class ConHelper
    {
        
        public static string ConVal( string name)
        {

            return ConfigurationManager.ConnectionStrings[name].ConnectionString;

        }

    }
}
