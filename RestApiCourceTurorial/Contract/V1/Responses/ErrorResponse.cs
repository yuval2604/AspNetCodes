using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Internal;

namespace RestApiCourceTurorial.Contracts.V1.Responses
{
    public class ErrorResponse
    {
        public ErrorResponse(){}

        public ErrorResponse(ErrorModel error)
        {
            Errors.Add(error);
        }
        
        public List<ErrorModel> Errors { get; set; } = new List<ErrorModel>();
        
        
    }
}