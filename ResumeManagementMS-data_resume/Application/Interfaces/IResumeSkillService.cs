﻿using Application.DTO.Request;
using Application.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IResumeSkillService
    {
        Task<SkillResponse> RegisterResumeSkill(ResumeSkillRequest request, Guid userid);
        Task<string> DeleteResumeSkill(int Id);
    }
}
