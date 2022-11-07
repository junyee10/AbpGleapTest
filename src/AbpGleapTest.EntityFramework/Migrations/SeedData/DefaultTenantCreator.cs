using System.Linq;
using AbpGleapTest.EntityFramework;
using AbpGleapTest.MultiTenancy;

namespace AbpGleapTest.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly AbpGleapTestDbContext _context;

        public DefaultTenantCreator(AbpGleapTestDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
