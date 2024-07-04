﻿using System.ComponentModel.DataAnnotations;

namespace JwtAuthAspNet8WebAPI.Data.Dto
{
    public class UpdatePermissionDto
    {
        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }

    }
}
