
namespace CostumeList
{
    public class CustomList
    {
        private const int InitialCapacity = 2;
        private int[] items;

        int couter = 0;
        public void Add(int value)
        {
            this.items[couter++] = value;
        }
    }
}