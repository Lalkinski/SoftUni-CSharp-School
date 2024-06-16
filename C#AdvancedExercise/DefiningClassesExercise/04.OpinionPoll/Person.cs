namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        Dictionary<string, int> people = new Dictionary<string, int>();

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
}