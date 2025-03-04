// See https://aka.ms/new-console-template for more information
using PhoneKeyPad;

Console.WriteLine("Hello, World!");

string input = "33#";

string output = PhoneProcessor.OldPhonePad(input);
Console.WriteLine(output);