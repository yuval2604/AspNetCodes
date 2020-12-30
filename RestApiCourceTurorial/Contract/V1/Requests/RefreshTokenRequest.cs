using System;
namespace RestApiCourceTurorial.Contract.V1.Requests
{
    public class RefreshTokenRequest
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
