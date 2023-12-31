﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using TaskOne.Implementation;

namespace TaskOne.Controllers
{
    [Route("api")]
    [ApiController]
    public class InfoController : ControllerBase
    {
        [HttpGet("get_info")]
        public IActionResult GetInfo(string slack_name, string track)
        {
            if (RequestValidator.IsNullOrEmpty(slack_name) || RequestValidator.IsNullOrEmpty(track))
            {
                var errorResponse = new
                {
                    error = "Invalid request. Both 'slack_name' and 'track' parameters are required."
                };

                return BadRequest(errorResponse);
            }

           
            if (!RequestValidator.IsValidSlackName(slack_name, "martinmatics"))
            {
                var errorResponse = new
                {
                    error = "Invalid 'slack_name' parameter. Please provide a valid Slack name."
                };

                return BadRequest(errorResponse);
            }

     
            if (!RequestValidator.IsValidTrack(track))
            {
                var errorResponse = new
                {
                    error = "Invalid 'track' parameter. Please provide a valid track."
                };

                return BadRequest(errorResponse);
            }

            var jsonResponse = new
            {
                SlackName = "Martinmatics",
                CurrentDay = DateTime.UtcNow.ToString("dddd", CultureInfo.InvariantCulture),
                UtcTime = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"),
                Track = "backend",
                GithubFileUrl = "https://github.com/martinmatics100/HNGx-Repo/blob/main/TaskOne/TaskOne.sln",
                GithubRepoUrl = "https://github.com/martinmatics100/HNGx-Repo.git",
                status_code = 200
            };

                return Ok(jsonResponse);
        }
    }
}
