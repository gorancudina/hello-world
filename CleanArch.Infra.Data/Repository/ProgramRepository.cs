using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
    public class ProgramRepository : IProgramRepository
    {
        private UniversityDBContext _ctx;

        public ProgramRepository(UniversityDBContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Program> GetPrograms()
        {
            return _ctx.Programs;
        }
    }
}
