﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestApiCourceTurorial.Contract;
using RestApiCourceTurorial.Contract.V1.Requests;
using RestApiCourceTurorial.Contract.V1.Responses;
using RestApiCourceTurorial.Services;

namespace RestApiCourceTurorial.Controllers.V1
{
    public class IdentityController : Controller
    {

        private readonly IIdentityService _IdentityService;
        

        public IdentityController(IIdentityService IdentityService)
        {
            _IdentityService = IdentityService;
        }
        [HttpPost(ApiRoutes.Identity.Register)]
        public async Task<IActionResult> Register ([FromBody] userRegistrationRequest request )
        {
           
             if (!ModelState.IsValid)
            {
                return BadRequest(new AuthFailedResponse
                {
                    Errors = ModelState.Values.SelectMany(x => x.Errors.Select(xx => xx.ErrorMessage))
                });
            }

            var authResponse = await _IdentityService.RegisterAsync(request.Email, request.Password);

            if (!authResponse.Success)
            {
                return BadRequest(new AuthFailedResponse
                {
                    Errors = authResponse.Errors
                });
            }
            return Ok(new AuthSuccessResponse {
                   Token= authResponse.Token
            });
        }



        [HttpPost(ApiRoutes.Identity.Login)]
        public async Task<IActionResult> Login([FromBody] UserLoginRequest request)
        {
            var authResponse = await _IdentityService.LoginAsync(request.Email, request.Password);

            if (!authResponse.Success)
            {
                return BadRequest(new AuthFailedResponse
                {
                    Errors = authResponse.Errors
                });
            }

            return Ok(new AuthSuccessResponse
            {
                Token = authResponse.Token
               
            });
        }
    }
}
