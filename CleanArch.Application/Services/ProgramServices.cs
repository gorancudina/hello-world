using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Services
{
    public class ProgramService :IProgramServices
    {
        private IProgramRepository _programRepository;

        public ProgramService(IProgramRepository programRepository)
        {
            _programRepository = programRepository;
        }
       

        public ProgramViewModel GetPrograms()
        {
            return new ProgramViewModel
            {
                Programs = _programRepository.GetPrograms()
            };
        }
    }
}
