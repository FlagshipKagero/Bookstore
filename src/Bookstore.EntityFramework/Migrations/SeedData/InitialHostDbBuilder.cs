using Bookstore.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Bookstore.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly BookstoreDbContext _context;

        public InitialHostDbBuilder(BookstoreDbContext context)
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
