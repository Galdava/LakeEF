

using System;
using System.Data.Entity;
using System.Linq;
namespace LakesEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var data = new LakesContext())
            {
                var lakes = from l in data.Lakes
                            where l.Country == "USA"
                            select l;
                foreach (Lakes l in lakes)
                {
                    Console.WriteLine(l.Name);
                }
            }
        }
    }

    public partial class LakesContext : DbContext
    {
        public LakesContext() : base("name=LakesContext")
        {

        }
        public DbSet<Lakes> Lakes { get; set; }
     
    }
    public partial class Lakes
    {
        public int LakeId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public decimal Area { get; set; }
    }
}
