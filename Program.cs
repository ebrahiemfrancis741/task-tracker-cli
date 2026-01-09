
namespace TaskTracker
{
  class Program
  {
    static void Main(string[] args)
    {
      string filePath = @"./data.json";
      FileStream data = File.Open(filePath, FileMode.OpenOrCreate);

      if (File.Exists(filePath))
      {
        Console.WriteLine("Data loaded successfully.");
      }
      else
      {
        Console.WriteLine("Could not open or create file '{0}'", filePath);
      }
    }

  }
}