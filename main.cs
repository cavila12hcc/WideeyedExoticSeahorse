using System;

class Program {
  static void Main (string[] args) {
    const double CentiPerInch = 2.54;
    double inches;
    Console.Write("Enter a number of inches: ");
    inches = Convert.ToDouble(Console.ReadLine());
    double centimeters = inches * CentiPerInch;
    Console.WriteLine("{0} inches is {1} centimeters", inches, centimeters);
  }
}