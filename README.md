# cylance
Repository for interview test code

To execute console app:

In Visual Studio, load Program.cs from ConsoleApp1 and execute, or after compilation execute the ConsoleApp1.exe file in the ConsoleApp1\bin\Debug folder.

To execute via imported DLL or project:

DLL:  Import ConsoleApp2\ClassLibrary1\bin\Debug into your solution
Project: Import ClassLibrary1 into your solution

Purpose:

This application prints numbers from 1 to 100 (default) or any user selected upper end value.  The multiples of 3 and 5 (default) are replaced with the words "Fizz" and "Buzz" (default) or any such user selected values.

Tests:

Several unit tests have been included to show how one might test this application using fluent assertions and NUnit.  To execute, simply load the UnitTests project and execute the tests within.
