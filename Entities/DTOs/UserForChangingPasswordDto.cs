﻿using Core.Entities.Abstact;

namespace Entities.DTOs
{
    public class UserForChangingPasswordDto : IDto
    {
        public int Id { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
