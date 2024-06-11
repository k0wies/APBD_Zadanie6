using Microsoft.EntityFrameworkCore;

namespace APBD_Zadanie6.Models
{
    public class Context : DbContext
    {
        public Context() { }

        public Context(DbContextOptions<Context> options) : base(options) { }




    }
}
