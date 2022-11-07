using AbpGleapTest.EntityFramework;
using EntityFramework.DynamicFilters;

namespace AbpGleapTest.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly AbpGleapTestDbContext _context;

        public InitialHostDbBuilder(AbpGleapTestDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
