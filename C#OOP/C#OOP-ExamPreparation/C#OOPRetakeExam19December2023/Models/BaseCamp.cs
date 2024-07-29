using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighwayToPeak.Models.Contracts;

namespace HighwayToPeak.Models
{
    public class BaseCamp : IBaseCamp
    {
        private List<string> residents;

        public BaseCamp()
        {
            residents = new List<string>();
        }

        public IReadOnlyCollection<string> Residents => residents.AsReadOnly();
        public void ArriveAtCamp(string climberName)
        {
            this.residents.Add(climberName);
            this.residents = residents.OrderBy(x => x).ToList();
        }

        public void LeaveCamp(string climberName)
        {
            this.residents.Remove(climberName);
        }
    }
}
