///*
//5
//Tom is going!
//Annie is going!
//Tom is going!
//Garry is going!
//Jerry is going!

//4
//Allie is going!
//George is going!
//John is not going!
//George is not going!
// */

//namespace _03._House_Party
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());

//            List<string> peopleAddedInList = new List<string>();

//            for (int i = 0; i < n; i++)
//            {
//                string name = Console.ReadLine();

//                string[] sentences = name.Split().ToArray();

//                for (int j = 0; j < peopleAddedInList.Count; j++)
//                {
//                    if (sentences[0] == peopleAddedInList[j])
//                    {
//                        Console.WriteLine($"{sentences[0]} is already in the list!");
//                        break;
//                    }

//                }

//                if (sentences[2] == "going!")
//                {
//                    peopleAddedInList.Add(sentences[0]);

//                }
//                else if (sentences[2] == "not") 
//                {
//                    Console.WriteLine($"{sentences[0]} is not int the list!");
//                    peopleAddedInList.Remove(sentences[0]);
//                }
//            }

//            for (int i = 0; i < peopleAddedInList.Count; i++)
//            {
//                for (int j = 1; j < peopleAddedInList.Count; j++)
//                {
//                    if (peopleAddedInList[i] == peopleAddedInList[j])
//                    {
//                        peopleAddedInList.RemoveAt(j);
//                        break;
//                    }
//                }
//                break;
//            }

//            for (int i = 0;i < peopleAddedInList.Count; i++)
//            {
//                Console.Write(string.Join(" ", peopleAddedInList[i]));
//                Console.WriteLine();
//            }
//        }
//    }
//}

/*
4
Allie is going!
George is going!
John is not going!
George is not going!
*/

internal class Program
{
    static void Main()
    {
        int guestsCount = int.Parse(Console.ReadLine());
        List<string> guestList = new List<string>();

        for (int i = 0; i < guestsCount; i++)
        {
            string[] arguments = Console.ReadLine().Split();
            string name = arguments[0];

            if (arguments[2] == "going!")
            {
                AddGuest(guestList, name);
            }
            else if (arguments[2] == "not")
            {
                RemoveGuest(guestList, name);
            }
        }

        Console.WriteLine(string.Join("\n", guestList));
    }

    private static void AddGuest(List<string> guestList, string name)
    {
        if (guestList.FindIndex(x => x == name) == -1)
        {
            guestList.Add(name);
        }
        else
        {
            Console.WriteLine($"{name} is already in the list!");
        }
    }

    private static void RemoveGuest(List<string> guestList, string name)
    {
        if (guestList.FindIndex(x => x == name) == -1)
        {
            Console.WriteLine($"{name} is not in the list!");
        }
        else
        {
            guestList.Remove(name);
        }
    }
}
