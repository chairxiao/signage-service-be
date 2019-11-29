using System.Linq;
using Microsoft.EntityFrameworkCore;
using Signage.Service.Programs.ProgramType;

namespace Signage.Service.EntityFrameworkCore.Seed.Programs.Program
{
    class ProgramTypeCreator
    {
  
        private readonly ServiceDbContext _context;

        public ProgramTypeCreator(ServiceDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateProgramConfig();
        }

        private void CreateProgramConfig()
        {
            var defaultProgramType = new ProgramType { Name = "请问请问·" };
            if (_context.ProgramTypes.IgnoreQueryFilters().Any(s => s.Name == defaultProgramType.Name))
            {
                return;
            }

            _context.ProgramTypes.Add(defaultProgramType);
            _context.SaveChanges();
        }
    }
}
