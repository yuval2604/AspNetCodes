﻿using System;
using System.ComponentModel.DataAnnotations;

namespace RestApiCourceTurorial.Contract.V1.Requests
{
    public class userRegistrationRequest
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
