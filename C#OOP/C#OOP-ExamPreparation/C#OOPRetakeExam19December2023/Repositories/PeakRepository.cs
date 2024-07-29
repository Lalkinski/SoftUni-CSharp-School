﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighwayToPeak.Models.Contracts;
using HighwayToPeak.Repositories.Contracts;

namespace HighwayToPeak.Repositories
{
    public class PeakRepository : IRepository<IPeak>
    {
        private readonly List<IPeak> all;

        public PeakRepository()
        {
            all = new List<IPeak>();
        }

        public IReadOnlyCollection<IPeak> All => all;
        public void Add(IPeak model)
        {
            all.Add(model);
        }

        public IPeak Get(string name)
        {
            return this.all.FirstOrDefault(n => n.Name == name);
        }
    }
}
