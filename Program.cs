
namespace OperatorsAndControlFlow
{
    class Program
    {
        static void Main()
        {
            // Task 1 

            int points = 10;

            points += 5;
            points *= 2;

            Console.WriteLine($"Final points: {points}");

            bool atLeast25 = points >= 25;
            Console.WriteLine($"At least 25 points: {atLeast25}");

            int afterPost = points++;
            Console.WriteLine($"points++ returned {afterPost}; points is now {points}");

            int afterPre = ++points;
            Console.WriteLine($"++points returned {afterPre}; points is now {points}");

            Console.WriteLine("------------------- Task 1 COMPLETED----------------- ");



            //  Task 2 
              
               
// ---- Task 2 ----

int marks = 72;
int attendance = 80;

// Determine the student's grade
string grade = "";

if (marks >= 80)
{
    grade = "A";
}
else if (marks >= 65)
{
    grade = "B";
}
else if (marks >= 50)
{
    grade = "C";
}
else
{
    grade = "Fail";
}

// Check pass eligibility
bool isEligible = marks >= 50 && attendance >= 75;

Console.WriteLine($"Marks: {marks}, Attendance: {attendance}");
Console.WriteLine($"Grade: {grade}");
Console.WriteLine($"Pass eligible: {isEligible}");

 Console.WriteLine("------------------- Task 2 COMPLETED----------------- ");




            

                  
     //  Task 3 //
int choice = 2;  // Test with 1, 3 and 9

Console.WriteLine("Library Menu");
Console.WriteLine("1. Borrow   2. Return   3. Renew");
Console.WriteLine($"Selected choice: {choice}");

// Switch statement
switch (choice)
{
    case 1:
        Console.WriteLine("You selected Borrow.");
        break;

    case 2:
        Console.WriteLine("You selected Return.");
        break;

    case 3:
        Console.WriteLine("You selected Renew.");
        break;

    default:
        Console.WriteLine("Invalid choice.");
        break;
}

// Nullable string
string? userName = null;

// Null-coalescing operator (??)
string displayName = userName ?? "Karina";
Console.WriteLine($"Display name: {displayName}");

// Null-coalescing assignment operator (??=)
userName ??= "karina";
Console.WriteLine($"userName after ??=: {userName}");

Console.WriteLine("------------------- Task 3 COMPLETED----------------- ");







            // ---- Task 4 ----


        
// ---- Task 4 ----

// TODO 1: Create an array for Monday to Friday
int[] dailyAttendance = { 20, 22, 21, 24, 23 };
int total = 0;

// TODO 2: foreach loop
Console.WriteLine("Daily attendance:");

foreach (int present in dailyAttendance)
{
    Console.WriteLine($"  {present}");
    total += present;
}

Console.WriteLine($"Total attendance: {total}");

// TODO 3: for loop
for (int i = 0; i < dailyAttendance.Length; i++)
{
    Console.WriteLine($"Day {i + 1}: {dailyAttendance[i]}");
}

// TODO 4: while loop
int countdown = 3;

while (countdown >= 1)
{
    Console.WriteLine(countdown);
    countdown--;
}

// TODO 5: do-while loop
bool runAgain = false;

do
{
    Console.WriteLine("Attendance recorded");
}
while (runAgain);

Console.WriteLine("------------------- Task 4 COMPLETED -----------------");


 

            // ---- Task 5 ----



// ---- Task 5 ----

// TODO 1: Nested for loops
int seatCount = 0;

for (int row = 1; row <= 3; row++)
{
    for (int seat = 1; seat <= 4; seat++)
    {
        Console.WriteLine($"Row {row} - Seat {seat}");
        seatCount++;
    }
}

Console.WriteLine($"Total seats: {seatCount}");

// TODO 2: Continue and break
Console.Write("Loop values: ");

for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        continue;
    }

    if (i == 8)
    {
        break;
    }

    Console.Write($"{i} ");
}

Console.WriteLine();

Console.WriteLine("------------------- Task 5 COMPLETED -----------------");


            



// ---- Task 6 ----

// Get input from the user
Console.Write("Enter the first integer: ");
string firstInput = Console.ReadLine() ?? "";

Console.Write("Enter the second integer: ");
string secondInput = Console.ReadLine() ?? "";

try
{
    // Convert string inputs into integers
    int first = int.Parse(firstInput);
    int second = int.Parse(secondInput);

    // Perform division
    int result = first / second;

    Console.WriteLine($"Result: {result}");
}
catch (FormatException)
{
    Console.WriteLine("Error: please enter whole numbers only.");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Error: cannot divide by zero.");
}
finally
{
    Console.WriteLine("Calculation complete");
}

Console.WriteLine("------------------- Task 6 COMPLETED -----------------");



        }
    }
}
