using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighwayToPeak.Models.Contracts;
using HighwayToPeak.Repositories.Contracts;

namespace HighwayToPeak.Repositories
{
    public class ClimberRepository : IRepository<IClimber>
    {
        private readonly List<IClimber> all;

        public ClimberRepository()
        {
            this.all = new List<IClimber>();
        }

        public IReadOnlyCollection<IClimber> All => all;
        public void Add(IClimber model)
        {
            this.all.Add(model);
        }

        public IClimber Get(string name)
        {
            return this.all.FirstOrDefault(n => n.Name == name);
        }
    }
}
