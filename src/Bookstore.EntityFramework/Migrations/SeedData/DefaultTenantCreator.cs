using System.Linq;
using Bookstore.EntityFramework;
using Bookstore.MultiTenancy;

namespace Bookstore.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly BookstoreDbContext _context;

        public DefaultTenantCreator(BookstoreDbContext context)
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
