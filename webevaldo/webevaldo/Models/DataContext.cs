

namespace webevaldo.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {


        }

        public System.Data.Entity.DbSet<webevaldo.Models.Student> Students { get; set; }
    }
}