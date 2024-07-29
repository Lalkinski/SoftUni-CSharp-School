using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighwayToPeak.Models.Contracts;
using HighwayToPeak.Utilities.Messages;

namespace HighwayToPeak.Models
{
    public abstract class Climber : IClimber
    {
        private string name;
        private int stamina;
        private readonly List<string> conqueredPeaks;

        public Climber(string name, int stamina)
        {
            this.Name = name;
            this.Stamina = stamina;
            this.conqueredPeaks = new List<string>();
        }

        public int Stamina
        {
            get => stamina;
            protected set
            {
                if (value > 10)
                {
                    stamina = 10;
                }
                else if (value < 0)
                {
                    stamina = 0;
                }
                else
                {
                    stamina = value;
                }
            }
        }


        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.ClimberNameNullOrWhiteSpace);
                }
                name = value;
            }
        }

        public IReadOnlyCollection<string> ConqueredPeaks => conqueredPeaks;
        public void Climb(IPeak peak)
        {
            if (!conqueredPeaks.Contains(peak.Name))
            {
                this.conqueredPeaks.Add(peak.Name);
            }

            switch (peak.DifficultyLevel)
            {
                case "Extreme":
                    this.stamina = 6;
                    break;
                case "Hard":
                    this.stamina = 4;  
                    break;
                case "Moderate":
                    this.stamina = 2;
                    break;
            }
        }

        public abstract void Rest(int daysCount);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.GetType().Name} - Name: {Name}, Stamina: {Stamina}");

            if (conqueredPeaks.Count == 0)
            {
                sb.AppendLine($"Peaks conquered: no peaks conquered");
            }
            else
            {
                sb.AppendLine($"Peaks conquered: {conqueredPeaks.Count}");
            }

            return sb.ToString().Trim();
        }
    }
}
