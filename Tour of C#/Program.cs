public class PatternMatching
{
    // Pattern Matching allows us to take data and make decisions based on its characteristicts 
    // via expressions:
    public static bool Or(bool left, bool right) =>
    (left, right) switch
    {
        (true, true) => true,
        (true, false) => true,
        (false, true) => true,
        (false, false) => false,
    };

    public static bool And(bool left, bool right) =>
        (left, right) switch
        {
            (true, true) => true,
            (true, false) => false,
            (false, true) => false,
            (false, false) => false,
        };
    public static bool Xor(bool left, bool right) =>
        (left, right) switch
        {
            (true, true) => false,
            (true, false) => true,
            (false, true) => true,
            (false, false) => false,
        };

    public static bool ReducedAnd(bool left, bool right) =>
    (left, right) switch
    {
        (true, true) => true,
        (_, _) => false, // catch-all short-hand using _'s 
    };
}

// Above, (value value) is called a tuple, which is a data structure defined by 
// an ordered, fixed-length sequence of values. 


public class Program
{
    public static void Main()
    {
        // Collection expressions
        int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        List<string> names = ["Alice", "Bob", "Charlie", "David"];

        IEnumerable<int> moreNumbers = [.. numbers, 11, 12, 13]; // spread syntax
        IEnumerable<string> empty = [];

        // Index and range expressions
        string second = names[1]; // 0-based index
        string last = names[^1]; // ^1 is the last element, ^ indicates from the end; ^0 is one past the end
        int[] smallNumbers = numbers[0..5]; // 0 to 4

        // LINQ - Language integrated query
        // provides a common pattern-based syntax to query or transform any collection of data.
        var biggerThan5 = from num in numbers
                          where num > 5
                          select num;
        int[] biggerThan5Arr = [.. biggerThan5]; // convert to array
    }
}