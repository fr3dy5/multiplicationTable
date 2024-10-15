int startRow;
int endRow;
int startCol;
int endCol;
string invalid;

//if vocarium checker has a different string, change this one not all four
invalid = "Invalid input, try again.";

Console.WriteLine("Enter starting value for rows: ");
int.TryParse(Console.ReadLine(), out startRow);
//one if no need for an else? if its right it works if not, invalid
if (!int.TryParse(Console.ReadLine(), out startRow)) {
    Console.WriteLine(invalid);
}
Console.WriteLine("Enter ending value for rows: ");
int.TryParse(Console.ReadLine(), out endRow);
if (!int.TryParse(Console.ReadLine(), out endRow)) {
    Console.WriteLine(invalid);
}
Console.WriteLine("Enter starting value for columns: ");
int.TryParse(Console.ReadLine(), out startCol);
if (!int.TryParse(Console.ReadLine(), out startCol)) {
    Console.WriteLine(invalid);
}
Console.WriteLine("Enter ending value for columns: ");
int.TryParse(Console.ReadLine(), out endCol);
if (!int.TryParse(Console.ReadLine(), out endCol)) {
    Console.WriteLine(invalid);
}


for (int i = startRow; i < endRow; i++) {
    for (int j = startCol; j < endCol; j++) {
        Console.Write(i*j);
    }

}