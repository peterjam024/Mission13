using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission13.Models
{
    public class EFBowlerRepository : IBowlerRepository
    {

        private BowlerRepositoryContext context { get; set; }
        public EFBowlerRepository(BowlerRepositoryContext temp)
        {
            context = temp;
        }
        public IQueryable<Bowler> Bowler => context.Bowler;

        public void SaveProject(Bowler B)
        {
            context.SaveChanges();
        }

        public void CreateProject(Bowler B)
        {
            context.Add(B);
            context.SaveChanges();
        }

        public void DeleteProject(Bowler B)
        {
            context.Remove(B);
            context.SaveChanges();
        }
    }
}
