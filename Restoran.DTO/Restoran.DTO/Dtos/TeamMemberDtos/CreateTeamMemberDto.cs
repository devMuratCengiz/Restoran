﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.DTO.Dtos.TeamMemberDtos
{
    public class CreateTeamMemberDto
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }
}