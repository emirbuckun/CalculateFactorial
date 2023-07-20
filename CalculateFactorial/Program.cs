namespace CalculateFactorial
{
  internal class Program
  {
    private static void Main()
    {
      try
      {
        Console.WriteLine("Enter number input: ");
        string? input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input))
        {
          if (int.TryParse(input, out int number))
            Console.WriteLine(FindFactorial(number));
          else
            throw new Exception("Exception during string to int parse operation!");
        }
        else throw new Exception("Incorrect input exception!");
      }
      catch (FormatException ex)
      {
        Console.WriteLine("Format exception: " + ex.Message);
      }
      catch (OverflowException ex)
      {
        Console.WriteLine("Overflow exception: " + ex.Message);
      }
      catch (OutOfMemoryException ex)
      {
        Console.WriteLine("OutOfMemoryException exception: " + ex.Message);
      }
      catch (TimeoutException ex)
      {
        Console.WriteLine("TimeoutException exception: " + ex.Message);
      }
      catch (Exception ex)
      {
        Console.WriteLine("Exception: " + ex.Message);
      }
    }

    private static int FindFactorial(int number)
    {
      if (number < 0) throw new ArgumentException("Number must be positive!");

      int factorial = 1;
      for (int i = 1; i <= number; i++)
      {
        checked
        {
          factorial *= i;
        }
      }
      return factorial;
    }
  }
}