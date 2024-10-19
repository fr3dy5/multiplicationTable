using System;

int startRow;
int endRow;
int startCol;
int endCol;
string invalid;

//if vocarium checker has a different string, change this one not all four
invalid = "Invalid input, try again.";

Console.WriteLine("Enter starting value for rows: ");
//one if no need for an else? if its right it works if not, invalid
if (!int.TryParse(Console.ReadLine(), out startRow)) {
    Console.WriteLine(invalid);
}
Console.WriteLine("Enter ending value for rows: ");
if (!int.TryParse(Console.ReadLine(), out endRow)) {
    Console.WriteLine(invalid);
}
Console.WriteLine("Enter starting value for columns: ");
if (!int.TryParse(Console.ReadLine(), out startCol)) {
    Console.WriteLine(invalid);
}
Console.WriteLine("Enter ending value for columns: ");
if (!int.TryParse(Console.ReadLine(), out endCol)) {
    Console.WriteLine(invalid);
}

//code math only works with equal numbers on each axis, table spacing only works with up to 2 digit numbers
Console.Write(" ");
for (int j = startRow; j <= endRow; j++) {
    Console.Write($"{j, 3}");
}
Console.WriteLine();

for (int i = startCol; i <= endCol; i++) {
    Console.Write($"{i, 1}");
    for (int j = startCol; j <= endCol; j++) {
        Console.Write($"{i*j, 3}");
    }
    Console.WriteLine();
}