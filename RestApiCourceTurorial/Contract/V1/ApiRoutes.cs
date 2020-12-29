using System;
namespace RestApiCourceTurorial.Contract
{
    public class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const  string Base = Root+"/"+Version;


       public static class Posts
        {
            public const string GetAll = Base+"/post";
            
        }
    }
}
