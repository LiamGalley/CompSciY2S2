namespace AppDevNotes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void DictionaryExample()
        {
            Dictionary<String, int> map = new Dictionary<string, int>();
            map["One"] = 1;
            map["Two"] = 2;
            map["Three"] = 3;
            map["Four"] = 4;

            foreach (string key in map.Keys)
                Console.WriteLine($"Map Key = {key}, with Map Value = {map[key]}.");

            // ====================================================================================================
            // Will throw an expection due to the given key not being within the dictionary.
            // Console.WriteLine(map["This key is invalid."]);
            // ====================================================================================================

            if (map.TryGetValue("This key does not exist", out int value))
                Console.WriteLine($"Value is: {value}");
            else
                Console.WriteLine($"This key does not exist.");
        }
    }
}