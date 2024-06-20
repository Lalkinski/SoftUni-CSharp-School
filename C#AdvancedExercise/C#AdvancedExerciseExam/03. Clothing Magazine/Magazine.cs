using System.Text;

namespace ClothesMagazine
{
    public class Magazine
    {
        public Magazine(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            Clothes = new List<Cloth>();
        }

        public string Type { get; set; }
        public int Capacity { get; set; }
        public List<Cloth> Clothes { get; set; }


        public void AddCloth(Cloth cloth)
        {
            if (this.Clothes.Count < this.Capacity)
            {
                this.Clothes.Add(cloth);
            }
        }

        public bool RemoveCloth(string color)
        {
            Cloth clothToRemove = this.Clothes.FirstOrDefault(c => c.Color == color);
            if (clothToRemove != null)
            {
                this.Clothes.Remove(clothToRemove);
                return true;
            }
            return false;
        }

        public Cloth GetSmallestCloth()
        {
            return this.Clothes.OrderBy(c => c.Size).FirstOrDefault();
        }

        public Cloth GetCloth(string color)
        {
            return this.Clothes.FirstOrDefault(c => c.Color == color);
        }

        public int GetClothCount()
        {
            return this.Clothes.Count;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Type} magazine contains:");

            foreach(var item in Clothes)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
