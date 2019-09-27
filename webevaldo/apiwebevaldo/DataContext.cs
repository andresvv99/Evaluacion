
namespace apiwebevaldo
{
    using System.Data.Entity;

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {
                
        }

        public System.Data.Entity.DbSet<apiwebevaldo.Models.Student> Students { get; set; }
    }
}