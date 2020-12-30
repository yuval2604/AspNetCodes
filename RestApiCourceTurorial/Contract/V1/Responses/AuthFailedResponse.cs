using System;
using System.Collections;
using System.Collections.Generic;

namespace RestApiCourceTurorial.Contract.V1.Responses
{
    public class AuthFailedResponse
    {
        public IEnumerable<string> Errors { get; set; }
    }
}
