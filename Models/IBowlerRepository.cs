using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission13.Models
{
    public interface IBowlerRepository
    {
        IQueryable<Bowler> Bowler { get; }

        public void SaveProject(Bowler B);
        public void CreateProject(Bowler B);
        public void DeleteProject(Bowler B);
    }
}
