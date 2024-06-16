/*
7IK9Yo0h
9NoBUajQ
Ce8vwPmE
SVQXQCbc
tSzE5t0p
PARTY
9NoBUajQ
Ce8vwPmE
SVQXQCbc
END */
class Program
{
    static void Main()
    {
        HashSet<string> vipGuest = new HashSet<string>();
        HashSet<string> regularGuests = new HashSet<string>();

        string input;
        while((input = Console.ReadLine()) != "PARTY")
        {
            if (char.IsDigit(input[0]))
            {
                vipGuest.Add(input);
            }
            else
            {
                regularGuests.Add(input);
            }
        }

        while((input = Console.ReadLine()) != "END")
        {
            if(vipGuest.Contains(input))
            {
                vipGuest.Remove(input);
            }
            else if(regularGuests.Contains(input))
            {
                regularGuests.Remove(input);
            }
        }

        Console.WriteLine(vipGuest.Count + regularGuests.Count);

        foreach(var guest in vipGuest)
        {
            Console.WriteLine(guest);
        }

        foreach(var guest in regularGuests)
        {
            Console.WriteLine(guest);
        }
    }
}

