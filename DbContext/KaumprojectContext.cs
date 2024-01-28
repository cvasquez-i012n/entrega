using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Kalumproject.DbContext
{

    public class KalumprojectContext : IdentityDbContext
    {
        public KalumprojectContext(DbContextOptions<KalumprojectContext> options) : base(options)
        {

        }
    }
}