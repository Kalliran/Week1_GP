﻿/************************************************************************************************************
 * Name: Michael Corleone
 * Date: 6/13/2024
 * Assignment CIS214 Week 1 GP - Display Text
 *
 * Main application (program) class.
 * In this application we will print a line of text using WriteLine
 * and print a line of formatted text using Write
*/
public class DisplayText
{
  static void Main(string[] args)
  {
    //Print a line of text to the console using WriteLine
    Console.WriteLine("Hello, Michael Corleone! Welcome to C# Programming!");

    //Print a blank line using WriteLine
    Console.WriteLine();

    //Print a line of formatted text to the console using Write
    //Formatting explanation is as follows:
    // \n - print a newline character at that position
    // {0:D} - print the first paramter after the format string's value
    //   in decimal format - the paramters following the format string
    //   are 0-indexed; 0 is the first, 1 is the second, etc.
    // {1:F2} - print the second paramter after the format string's value
    //   as a floating point number with 2 decimal places
    // {2:F2} - print the third parameter after the format string's value
    //   as a floating point number with 2 decimal places
    //The order of the elements in the format definition matches the
    //order of the parameters in the Write function call. The format of
    //the call is basically:
    //  Write("format string", param0, param1, ...);
    Console.Write("A string followed by a newline.\n" +
      "A String following the newline.\n" +
      "Decimal (integer) value: {0:D}\n" +
      "Floating point number 3.1415 to 2 decimals: {1:F2}\n" +
      "Floating point number 1.199 to 2 decimals (rounded): {2:F2}\n",
      4, 3.1415, 1.199);
  }
}