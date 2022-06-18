using System;

namespace MyNewApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}

using System;

namespace MyNewApp
{
  class Program
  {
    static void Main(string[] args)
    {
      string value = "Microsoft Learn";
      string reversedValue = Reverse(value);
      Console.WriteLine($"Secret message: {reversedValue}");
    }

    static string Reverse(string message)
    {
      char[] letters = message.ToCharArray();
      Array.Reverse(letters);
      return new string(letters);
    }
  }
}

using System;

namespace MyNewApp
{
  class Program
  {
    static void Main(string[] args)
    {
      string value = "Microsoft Learn";
      string reversedValue = Utility.Reverse(value);
      Console.WriteLine($"Secret message: {reversedValue}");
    }
  }

  class Utility
  {
    public static string Reverse(string message)
    {
      char[] letters = message.ToCharArray();
      Array.Reverse(letters);
      return new string(letters);
    }
  }
}

using System;

namespace MyNewApp
{
  class Program
  {
    static void Main(string[] args)
    {
      string value = "Microsoft Learn";
      string reversedValue = MyNewApp.Utilities.Utility.Reverse(value);
      Console.WriteLine($"Secret message: {reversedValue}");
    }
  }
}

namespace MyNewApp.Utilities
{
  class Utility
  {
    public static string Reverse(string message)
    {
      char[] letters = message.ToCharArray();
      Array.Reverse(letters);
      return new string(letters);
    }
  }
}

using System;
using MyNewApp.Utilities;

namespace MyNewApp
{
  class Program
  {
    static void Main(string[] args)
    {
      string value = "Microsoft Learn";
      string reversedValue = Utility.Reverse(value);
      Console.WriteLine($"Secret message: {reversedValue}");
    }
  }
}

namespace MyNewApp.Utilities
{
  class Utility
  {
    public static string Reverse(string message)
    {
      char[] letters = message.ToCharArray();
      Array.Reverse(letters);
      return new string(letters);
    }
  }
}