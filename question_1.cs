class Program {
    static void Main () {

        string? userInputName = Console.ReadLine();
        string? userInputAge = Console.ReadLine();
        

       // Console.WriteLine("Hello, "+ userInputName + " ! " + "You are " + userInputAge + " year");
        Console.WriteLine ( $"Hello, {userInputName} {userInputAge}");

        for ( int i = userInputName.Length-1; i>=0; i--)
        {
        Console.Write(userInputName[i]);
        }
    }
}