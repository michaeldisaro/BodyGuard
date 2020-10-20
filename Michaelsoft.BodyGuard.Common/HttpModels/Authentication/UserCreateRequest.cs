﻿using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Michaelsoft.BodyGuard.Common.HttpModels.Authentication
{
    public class UserCreateRequest
    {

        [Required]
        [JsonRequired]
        public string EmailAddress { get; set; }

        [Required]
        [JsonRequired]
        public string Password { get; set; }

        public dynamic UserData { get; set; }

    }
}