// See https://aka.ms/new-console-template for more information

//!
//?
//*

//Console.WriteLine("Hello, World!");
//Console.BackgroundColor = ConsoleColor.Green;
// using System.Collections;

// Console.WriteLine("Congratulations");
// Console.WriteLine(" ");
// Console.WriteLine("You Wrote your first lines of Code");
// Console.WriteLine("This is the first line.");
// Console.WriteLine("This is the second line.");
// Console.WriteLine('b');
// Console.WriteLine("123");
// Console.WriteLine(123);

// Console.WriteLine("true");
// Console.WriteLine(true);

// Random random = new();
// for (int i=0; i<10;i++){
//     int roll = random.Next(1, 100);
//     Console.Write(roll);
// }
//  Console.WriteLine();

// Console.WriteLine(new Random().Next(1, 100));

// int firstValue = 500;
// int secondValue = 600;
// int largerValue;

// largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);

// Console.WriteLine(Math.Max(1000, 50000));

// int[] tirada= new int[10];

// for (int i=0; i< 3; i++) {
//     tirada[i] = new Random().Next(1, 100);
//     Console.WriteLine($"Tirada {i}: {tirada[i]}");
//     if( tirada.Contains(i)) {}
// }

// Console.WriteLine("Suma: " + tirada.Sum());


// Random random2 = new Random();
// int daysUntilExpiration = random2.Next(12);
// //int discountPercentage = 0;

// // Your code goes here
// Console.WriteLine("Random .:" + daysUntilExpiration);
// if (daysUntilExpiration <= 10 && daysUntilExpiration > 5) {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }else if(daysUntilExpiration <= 5){
//     Console.Write($"Your subscription expires in {daysUntilExpiration} days.");
//     Console.WriteLine("Renew now and save 10%!");
// }

// var continua = true;
// while(continua){
//     int daysUntilExpiration2 = random2.Next(12);
//     Console.Clear(); 
//     switch (daysUntilExpiration2){
//         case int n when n > 5:
//             Console.WriteLine("ghjgjh");
//             break;
//         default:
//             break;
//     }   

//     var tecla = Console.ReadKey();
//     if(tecla.KeyChar == 'x'){
//         continua = false;
//     }
// }

// string[] pedidos = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
// foreach(string p in pedidos) {
//     if(p.StartsWith("B")) {
//         Console.WriteLine("" + p);
//     }
// }

// int subject = 4;
// int numberStudents = 4; 
// string[] students = ["Pepe", "Juan","Pedro", "alberto"];
// int[][] notas = new int[numberStudents][];
// int nota = 0;
// var students2 = new string[numberStudents+1];
// students2 = (string[])students.Clone();

// for (int i = 0; i < students.Length; i++) {
//    for (int x = 0; x < 4; x++) {
//         Console.Write($"Notas de alumno {students[i]} Subject {x}.: ");
//         if (int.TryParse(Console.ReadLine(), out nota)){
//             notas[i][x] = nota;
//         }

//    }

// }
// int numberStudents = 4; 
// string[] students = ["Pepe", "Juan","Pedro", "alberto"];
// //int[][] notas = new int[numberStudents][];

// //Initialize the jagged array
// int[][] notas = new int[students.Length][];
// for (int i = 0; i < students.Length; i++) {
//     notas[i] = new int[4]; // Assuming 4 subjects per student
// }

// for (int i = 0; i < students.Length; i++) {
//     Console.WriteLine($"Processing grades for student {students[i]}");

//     for (int x = 0; x < 4; x++) {
//         bool isValidInput = false;
//         int parsedNota = 0;

//         while (!isValidInput) {
//             Console.Write($"Enter grade for Subject {x + 1} (0-100): ");
//             string nota = Console.ReadLine()!;

//             // Try to parse the input
//             if (int.TryParse(nota, out parsedNota) && parsedNota >= 0 && parsedNota <= 100) {
//                 isValidInput = true;
//             } else {
//                 Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
//             }
//         }

//         notas[i][x] = parsedNota; // Store the valid grade
//     }
// }

//while(true){Console.WriteLine( new Random().Next(1,3) < 2 ? "Cruz" : "Cara" );Console.ReadKey();};

// string permission = "Admin|Manager";
// int level = 55;

// Console.WriteLine(permission.Contains("Admin")?level<55 ? "Admin no se que" : "Manager nose que": "User nose cuantos");

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// var sum=0.0;

// var message="";
// foreach (var value in values){
//     if (double.TryParse(value, out double val)){
//         sum+=val;
//     }else{
//         message+=value;
//     }

// }
// Console.WriteLine(message);
// Console.WriteLine(sum);

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
//Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
//Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
//Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


// int value1 = 11;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// The Convert class is best for converting the fractional decimal numbers into whole integer numbers
// Convert.ToInt32() rounds up the way you would expect.
//int result1 = Convert.ToInt32(value1 / value2);
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// decimal result2 = value2 / (decimal)value3;
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// float result3 = value3 / value1;
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0]}");
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"After: {pallets[0]}");

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet.GetType().Name}");
// }

// string pangram = "The quick brown fox jumps over the lazy dog";

// // Step 1
// string[] message = pangram.Split(' ');

// //Step 2
// string[] newMessage = new string[message.Length];

// // Step 3
// for (int i = 0; i < message.Length; i++)
// {
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new string(letters);
// }

// //Step 4
// string result = String.Join(" ", newMessage);
// Console.WriteLine(result);

// using System.Globalization;
// CultureInfo.CurrentCulture = new CultureInfo("es-ES");

// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N8} units");

// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");

// string input = "Pad this";
// string input2 = "Pad this hkjkh jh";
//  Console.WriteLine(input.PadRight(20, '-'));
//   Console.WriteLine(input2.PadRight(20, '-'));


// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// Console.WriteLine($"Dear {customerName},");
// Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
// Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
// Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";



// comparisonMessage = currentProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10, '-');
// comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20, '-');

// comparisonMessage += "\n";
// comparisonMessage += newProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10, '-');
// comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20, '-');

// Console.WriteLine(comparisonMessage);

// string comparisonMessage2 = (currentProduct + currentReturn.ToString("P2").PadLeft(10, '-') + "\n");
// comparisonMessage2 += ($"{newReturn.ToString("P2").PadLeft(20, '-')}");
// Console.WriteLine(comparisonMessage2);

// string message = "Help (find) the {opening symbols}";
// Console.WriteLine($"Searching THIS Message: {message}");
// char[] openSymbols = { '[', '{', '(' };
// int startPosition = 5;
// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");

// string data = "12345John Smith          5000  3  ";
// data = data.Remove(5, 20);
// Console.WriteLine(data);

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

// Extract the "quantity"
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
int quantityEnd= input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

// Set output to input, replacing the trademark symbol with the registered trademark symbol
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);

// Remove the opening <div> tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);