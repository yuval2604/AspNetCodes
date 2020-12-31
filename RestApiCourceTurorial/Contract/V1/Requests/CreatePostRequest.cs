using System;
using System.Collections.Generic;

namespace RestApiCourceTurorial.Contract.V1.Requests
{
    public class CreatePostRequest
    {
        public string Name { get; set; }
        public IEnumerable<string> Tags { get; set; }
    }
}
