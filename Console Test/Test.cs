using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;
using static Console_Test.Program;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Console_Test
{
    class Program
    {
        #region Oops
        #region Objects and Classes
        //public class Car
        //{
        //    public string Model { get; set; }
        //    public int Year { get; set; }

        //    public void Drive()
        //    {
        //        Console.WriteLine("Driving the car...");
        //    }
        //}
        //static void Main()
        //{
        //    // Creating an object
        //    Car myCar = new Car();
        //    myCar.Model = "Toyota";
        //    myCar.Year = 2020;
        //    myCar.Drive();


        //    Console.WriteLine(myCar.Model);
        //    Console.WriteLine(myCar.Year);
        //    // Keep the console open
        //    Console.ReadLine();
        //}

        #endregion

        #region Encapsulation  ==  Access Modifiers
        //Encapsulation is the concept of bundling data (variables) and methods (functions) that operate on the data into a single unit,
        //i.e., a class, and restricting access to certain details of the class from the outside world.
        //This is done using access modifiers like public, private, protected, etc.

        //static void Main()
        //{
        //    BankAccount myAccount = new BankAccount(1000m);

        //    myAccount.GetBalance();
        //    myAccount.Deposit(250m);
        //    myAccount.Withdraw(100m);
        //    myAccount.Withdraw(1200m);
        //    myAccount.GetBalance();

        //    Console.ReadLine();
        //}
        //public class BankAccount
        //{
        //    private decimal balance;

        //    public BankAccount(decimal initialBalance)
        //    {
        //        balance = initialBalance;
        //    }

        //    public decimal GetBalance()
        //    {
        //        return balance;
        //    }

        //    public void Deposit(decimal amount)
        //    {
        //        balance += amount;
        //        Console.WriteLine(balance);
        //    }

        //    public void Withdraw(decimal amount)
        //    {
        //        balance -= amount;
        //        Console.WriteLine(balance);
        //    }
        //}
        #endregion

        #region Inheritance
        //Inheritance allows one class (child class) to inherit the properties and methods of another class (parent class).
        //It promotes code reuse.

        //public class Vehicle
        //{
        //    public string Brand { get; set; }

        //    public void Start()
        //    {
        //        Console.WriteLine("Vehicle starting...");
        //    }
        //}

        //public class Motorcycle : Vehicle
        //{
        //    public void Rev()
        //    {
        //        Console.WriteLine("Revving the motorcycle!");
        //    }
        //}
        //static void Main()
        //{
        //    Motorcycle myBike = new Motorcycle();
        //    myBike.Brand = "Harley";
        //    myBike.Start();
        //    myBike.Rev();
        //}
        #endregion

        #region Polymorphism

        //Polymorphism allows methods to do different things based on the object it is acting upon.
        //Method Overriding: Redefining a base class method in a derived class.
        //Compile-time polymorphism is method overloading.
        //Run-time polymorphism is implemented through method overriding

        //public class Animal
        //{
        //    public virtual void Speak()
        //    {
        //        Console.WriteLine("Animal speaks");
        //    }
        //}
        //public class Dog : Animal
        //{
        //    public override void Speak()
        //    {
        //        Console.WriteLine("Bark");
        //    }
        //}
        //public static void Main()
        //{
        //    Animal myDog = new Dog();
        //    myDog.Speak();
        //}

        ////Method Overloading: Same method name but different parameters.

        //public class MathOperations
        //{
        //    public int Add(int a, int b)
        //    {
        //        return a + b;
        //    }
        //    public double Add(double a, double b)
        //    {
        //        return a + b;
        //    }
        //}

        #endregion

        #region Abstraction
        //Abstraction is the concept of hiding the complex implementation details and showing only the essential features.
        //public abstract class Shape
        //{
        //    public abstract double Area();
        //    public void Dog()
        //    {
        //        Console.WriteLine("Dog is Barking");
        //    }
        //}

        //public class Rectangle : Shape
        //{
        //    public double Width { get; set; }
        //    public double Height { get; set; }

        //    public override double Area()
        //    {
        //        return Width * Height;
        //    }
        //}

        #endregion

        #region Interfaces
        //Interfaces define a contract that classes can implement.
        //public interface IAnimal
        //{
        //    void Speak();
        //}

        //public class Cat : IAnimal
        //{
        //    public void Speak()
        //    {
        //        Console.WriteLine("Meow");
        //    }
        //}

        #endregion

        #endregion

        #region Reverse a String
        //static void Main()
        //{
        //    //string input = "Yakub";
        //    Console.Write("Enter a string to reverse: ");
        //    string input = Console.ReadLine();
        //    string reversed = ReverseString(input);
        //    Console.WriteLine(reversed);
        //}

        //static string ReverseString(string str)
        //{
        //    StringBuilder reversedString = new StringBuilder();

        //    for (int i = str.Length - 1; i >= 0; i--)
        //    {
        //        reversedString.Append(str[i]);
        //    }

        //    return reversedString.ToString();
        //}
        #endregion

        #region reverse number
        //public static void Main()
        //{
        //    int a = 12345;
        //    Console.WriteLine(a);
        //    int reversenumber = reverseNumber(a);
        //    Console.WriteLine(reversenumber);
        //}
        //public static int reverseNumber(int number)
        //{
        //    int reversednum = 0;
        //    while (number > 0)
        //    {
        //        int digit = number % 10;
        //        reversednum = (reversednum * 10 + digit);
        //        number /= 10;
        //    }
        //    return reversednum;
        //}
        #endregion

        #region Find middle letter of string
        //static void Main()
        //{
        //    string input = "example";
        //    char? middleChar = GetMiddleCharacter(input);

        //    if (middleChar.HasValue)
        //    { Console.WriteLine($"The middle character is: {middleChar.Value}"); }
        //    else { Console.WriteLine("The string is empty."); }
        //}

        //static char? GetMiddleCharacter(string str)
        //{
        //    if (string.IsNullOrEmpty(str)) { return null; }

        //    int length = str.Length;
        //    int middleIndex = length / 2;

        //    return length % 2 == 0 ? str[middleIndex - 1] : str[middleIndex];
        //}
        #endregion

        #region Distinct Array
        //static void Main()
        //{
        //    int[] numbers = { 1, 1, 1, 1, 1, 2, 3, 4, 5, 6 };

        //    int[] distinctArray = new int[numbers.Length];
        //    int distinctCount = 0;

        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        bool isDistinct = true;

        //        for (int j = 0; j < distinctCount; j++)
        //        {
        //            if (numbers[i] == distinctArray[j])
        //            {
        //                isDistinct = false;
        //                break;
        //            }
        //        }

        //        if (isDistinct)
        //        {
        //            distinctArray[distinctCount] = numbers[i];
        //            distinctCount++;
        //        }
        //    }

        //    Console.WriteLine("Distinct elements:");
        //    for (int i = 0; i < distinctCount; i++)

        //    {
        //        Console.Write(distinctArray[i] + " ");
        //    }
        //}
        #endregion

        #region DSA

        #region Arrays
        //Arrays: A collection of elements identified by an index.

        //int[] numbers = { 1, 2, 3, 4, 5 };

        #endregion

        #region Lists
        //Lists: A dynamic array that can grow and shrink.In C#, we use List<T>.

        //List<int> numbersList = new List<int> { 1, 2, 3, 4, 5 };
        #endregion

        #region Stack
        //A stack follows the Last-In-First-Out(LIFO) principle.The following code shows how to create a stack, push items onto it, and pop an item off.
        //static void Main()
        //{
        //    // Create a stack of integers
        //    Stack<int> stack = new Stack<int>();

        //    // Push items onto the stack
        //    stack.Push(1);
        //    stack.Push(2);
        //    stack.Push(3);

        //    Console.WriteLine("Items in stack:");

        //    // Peek at the top item
        //    Console.WriteLine($"Top item (peek): {stack.Peek()}");

        //    // Pop items off the stack
        //    while (stack.Count > 0)
        //    {
        //        Console.WriteLine($"Popped item: {stack.Pop()}");
        //    }
        //}

        //This is for testing
        //public override void Stack(int a)
        //{
        //    Queue<string> q = new Queue<string>();
        //    string[] m = { "a", "b", "c", "d" };
        //    for (int i = 0; i < a; i++)
        //    {
        //        q.Enqueue(m[i]);
        //    }
        //    Console.WriteLine("q is printing below");
        //    foreach (string i in q)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    //int pop = q.Dequeue();
        //    //Console.WriteLine("Pop is printing below");
        //    //Console.WriteLine(pop);
        //    //Console.WriteLine("q is printing after pop below");
        //    //foreach (int i in q)
        //    //{
        //    //    Console.WriteLine(i);
        //    //}
        //    Console.ReadLine();
        //}
        //public virtual void Stack(int a)
        //{
        //    Stack<int> stack = new Stack<int>();
        //    for (int i = 0; i < a; i++)
        //    {
        //        stack.Push(i);
        //    }
        //    Console.WriteLine("Stack is printing below");
        //    foreach (int i in stack)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    int pop = stack.Pop();
        //    Console.WriteLine("Pop is printing below");
        //    Console.WriteLine(pop);
        //    Console.WriteLine("Stack is printing after pop below");
        //    foreach (int i in stack)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    Console.ReadLine();
        //}


        //class UndoStack
        //{
        //    private Stack<string> actions;

        //    public UndoStack()
        //    {
        //        actions = new Stack<string>();
        //    }

        //    public void PerformAction(string action)
        //    {
        //        actions.Push(action);
        //        Console.WriteLine($"Action performed: {action}");
        //    }

        //    public void Undo()
        //    {
        //        if (actions.Count > 0)
        //        {
        //            string lastAction = actions.Pop();
        //            Console.WriteLine($"Undid action: {lastAction}");
        //        }
        //        else
        //        {
        //            Console.WriteLine("No actions to undo.");
        //        }
        //    }

        //    static void Main(string[] args)
        //    {
        //        UndoStack undoStack = new UndoStack();
        //        undoStack.PerformAction("Typed 'Hello'");
        //        undoStack.PerformAction("Typed 'World'");
        //        undoStack.Undo(); // Should undo 'World'
        //        undoStack.Undo(); // Should undo 'Hello'
        //        undoStack.Undo(); // No actions left to undo
        //    }
        //}
        #endregion

        #region Queue
        //A queue follows the First-In-First-Out(FIFO) principle.The following code demonstrates how to create a queue, enqueue items, and dequeue an item.

        //static void Main(string[] args)
        //{
        //    // Create a queue of integers
        //    Queue<int> queue = new Queue<int>();

        //    // Enqueue items into the queue
        //    queue.Enqueue(1);
        //    queue.Enqueue(2);
        //    queue.Enqueue(3);

        //    Console.WriteLine("Items in queue:");

        //    // Peek at the front item
        //    Console.WriteLine($"Front item (peek): {queue.Peek()}");

        //    // Dequeue items from the queue
        //    while (queue.Count > 0)
        //    {
        //        Console.WriteLine($"Dequeued item: {queue.Dequeue()}");
        //    }
        //}
        #endregion

        #region Linked List

        //public class Node
        //{
        //    public static Node Head;
        //    public int Data;
        //    public Node Next;

        //    public Node(int data)
        //    {
        //        Data = data;
        //        Next = null;
        //    }
        //}

        //public class LinkedList 
        //{


        //    public void Add(int data)
        //    {

        //        if (Node.Head == null)
        //        {
        //            Node newNode = new Node(data);
        //            Node.Head = newNode;                   
        //        }
        //        else
        //        {
        //            Node newNode = new Node(data);
        //            Node.Head.Next= newNode;
        //        }
        //    }

        //    public void PrintList()
        //    {
        //        Node current = Node.Head;
        //        while (current != null)
        //        {
        //            Console.Write(current.Data + " ");
        //            current = current.Next;
        //        }

        //    }
        //}
        //static void Main()
        //{
        //    LinkedList list = new LinkedList();
        //    list.Add(1);
        //    list.Add(2);
        //    list.Add(3);

        //    Console.WriteLine("Linked List elements:");
        //    list.PrintList();
        //}

        #endregion

        #region Array: Linear Search
        //static void Main()
        //{
        //    int[] arr = { 10, 20, 30, 40, 50 };
        //    int target = 60;
        //    int index = LinearSearch(arr, target);
        //    Console.WriteLine(index != -1 ? $"Element found at index {index}" : "Element not found");
        //}

        //static int LinearSearch(int[] arr, int target)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] == target)
        //            return i;
        //    }
        //    return -1;
        //}
        #endregion

        #region Array: Bubble Sort
        //static void Main()
        //{
        //    int[] arr = { 5, 1, 4, 2, 8 };
        //    BubbleSort(arr);
        //    Console.WriteLine("Sorted Array:");
        //    foreach (var item in arr)
        //    {
        //        Console.Write(item + " ");
        //    }
        //}

        //static void BubbleSort(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length - 1; i++)
        //    {
        //        for (int j = 0; j < arr.Length - 1 - i; j++)
        //        {
        //            if (arr[j] > arr[j + 1])
        //            {
        //                int temp = arr[j];
        //                arr[j] = arr[j + 1];
        //                arr[j + 1] = temp;
        //            }
        //        }
        //    }
        //}
        #endregion

        #region Binary Search
        //static void Main()
        //{
        //    int[] arr = { 10, 20, 30, 40, 50 };
        //    int target = 30;
        //    int index = BinarySearch(arr, target);
        //    Console.WriteLine(index != -1 ? $"Element found at index {index}" : "Element not found");
        //}

        //static int BinarySearch(int[] arr, int target)
        //{
        //    int left = 0, right = arr.Length - 1;

        //    while (left <= right)
        //    {
        //        int mid = left + (right - left) / 2;

        //        if (arr[mid] == target)
        //            return mid;
        //        else if (arr[mid] < target)
        //            left = mid + 1;
        //        else
        //            right = mid - 1;
        //    }

        //    return -1;
        //}
        #endregion

        #region Merge Sort
        //static void Main()
        //{
        //    int[] arr = { 38, 27, 43, 3, 9, 82, 10 };
        //    MergeSort(arr, 0, arr.Length - 1);
        //    Console.WriteLine("Sorted Array:");
        //    foreach (var item in arr)
        //    {
        //        Console.Write(item + " ");
        //    }
        //}

        //static void MergeSort(int[] arr, int left, int right)
        //{
        //    if (left < right)
        //    {
        //        int middle = left + (right - left) / 2;

        //        MergeSort(arr, left, middle);
        //        MergeSort(arr, middle + 1, right);

        //        Merge(arr, left, middle, right);
        //    }
        //}

        //static void Merge(int[] arr, int left, int middle, int right)
        //{
        //    int n1 = middle - left + 1;
        //    int n2 = right - middle;

        //    int[] leftArray = new int[n1];
        //    int[] rightArray = new int[n2];

        //    for (int i = 0; i < n1; i++)
        //        leftArray[i] = arr[left + i];
        //    for (int j = 0; j < n2; j++)
        //        rightArray[j] = arr[middle + 1 + j];

        //    int k = left, i1 = 0, i2 = 0;

        //    while (i1 < n1 && i2 < n2)
        //    {
        //        if (leftArray[i1] <= rightArray[i2])
        //        {
        //            arr[k] = leftArray[i1];
        //            i1++;
        //        }
        //        else
        //        {
        //            arr[k] = rightArray[i2];
        //            i2++;
        //        }
        //        k++;
        //    }

        //    while (i1 < n1)
        //    {
        //        arr[k] = leftArray[i1];
        //        i1++;
        //        k++;
        //    }

        //    while (i2 < n2)
        //    {
        //        arr[k] = rightArray[i2];
        //        i2++;
        //        k++;
        //    }
        //}
        #endregion

        #endregion

        #region Fibonacci Series

        ////Fibonacci Series up to 10 terms:
        ////0 1 1 2 3 5 8 13 21 34
        //static void Main()
        //{
        //    int n = 10;  // Number of terms in the Fibonacci series
        //    Console.WriteLine($"Fibonacci Series up to {n} terms:");

        //    // Print the Fibonacci series up to the nth term
        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.Write(Fibonacci(i) + " ");
        //    }
        //}

        //// Recursive function to return the nth Fibonacci number
        //static int Fibonacci(int n)
        //{
        //    // Base case: the first and second Fibonacci numbers are 0 and 1 respectively
        //    if (n <= 1)
        //    {
        //        return n;
        //    }
        //    else
        //    {
        //        // Recursive case: Fibonacci(n) = Fibonacci(n-1) + Fibonacci(n-2)
        //        return Fibonacci(n - 1) + Fibonacci(n - 2);
        //    }
        //}
        #endregion

        #region Palindrome Number
        //public class Solution1
        //{
        //    public bool IsPalindrome(int x)
        //    {
        //        int r = 0, c = x;
        //        while (c > 0)
        //        {
        //            r = r * 10 + c % 10;
        //            c /= 10;
        //        }
        //        return r == x;
        //    }
        //}
        #endregion

        #region Palindrome String
        //static void Main()
        //{
        //    Console.Write("Enter a string: ");
        //    string input = Console.ReadLine();

        //    // Check if the input string is a palindrome
        //    if (IsPalindrome(input))
        //    {
        //        Console.WriteLine($"{input} is a palindrome.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{input} is not a palindrome.");
        //    }
        //}

        //// Function to check if a string is a palindrome
        //static bool IsPalindrome(string str)
        //{
        //    int left = 0;
        //    int right = str.Length - 1;

        //    // Compare characters from both ends of the string
        //    while (left < right)
        //    {
        //        // If characters don't match, it's not a palindrome
        //        if (str[left] != str[right])
        //        {
        //            return false;
        //        }
        //        left++;
        //        right--;
        //    }
        //    return true;  // If all characters match, it's a palindrome
        //}
        #endregion

        #region Prime Number Check
        //static void Main()
        //{
        //    int number = 29;  // Number to check if it's prime
        //    bool isPrime = IsPrime(number);  // Call the IsPrime function
        //    Console.WriteLine(isPrime ? "Prime Number" : "Not Prime Number");  // Output the result
        //}

        //static bool IsPrime(int num)
        //{
        //    if (num <= 1)  // Numbers less than or equal to 1 are not prime
        //    {
        //        return false;
        //    }

        //    for (int i = 2; i <= Math.Sqrt(num); i++)  // Check divisibility up to the square root of num
        //    {
        //        if (num % i == 0)  // If num is divisible by i, it's not a prime number
        //        {
        //            return false;  // Return false if a divisor is found
        //        }
        //    }
        //    return true;  // Return true if no divisors are found, meaning the number is prime
        //}
        #endregion

        #region Factorial
        //static void Main()
        //{
        //    int number = 5;  // Number to calculate factorial
        //    int result = Factorial(number);  // Call the Factorial function
        //    Console.WriteLine("Factorial of " + number + " is: " + result);  // Output the result
        //}

        //static int Factorial(int num)
        //{
        //    if (num == 0 || num == 1)  // Base case: 0! = 1 and 1! = 1
        //    {
        //        return 1;
        //    }

        //    return num * Factorial(num - 1);  // Recursive case: num * (num-1)!
        //}
        #endregion

        #region Armstrong Number
        ////What is an Armstrong Number?
        ////An Armstrong number(also known as a Narcissistic number or Pluperfect Digital Invariant) is a number that is equal to the sum of its own digits, each raised to the power of the number of digits.

        ////For example:
        ////153 is an Armstrong number because:
        ////1^3 +5^3 +3^3 =153

        ////9474 is also an Armstrong number because:
        ////9^4 +4^4 +7^4 +4^4 =9474

        ////Whereas 123 is not an Armstrong number because:
        ////1^3 +2^3 +3^3 =1+8+27=36, and that is not equal to 123.

        //static void Main()
        //{
        //    int number = 153;  // Number to check if it's an Armstrong number
        //    bool isArmstrong = IsArmstrong(number);  // Call the IsArmstrong function
        //    Console.WriteLine(isArmstrong ? "Armstrong Number" : "Not Armstrong Number");  // Output the result
        //}

        //static bool IsArmstrong(int num)
        //{
        //    int sum = 0;
        //    int originalNumber = num;
        //    int digitsCount = num.ToString().Length;  // Count the number of digits in the number

        //    // Loop through each digit of the number
        //    while (num > 0)
        //    {
        //        int digit = num % 10;  // Get the last digit
        //        sum += (int)Math.Pow(digit, digitsCount);  // Add the digit raised to the power of the number of digits
        //        num /= 10;  // Remove the last digit
        //    }

        //    return sum == originalNumber;  // If sum of powered digits equals original number, it's an Armstrong number
        //}
        #endregion

        #region Sum of Digits of a Number
        //static void Main()
        //{
        //    int number = 1234;  // Number to calculate the sum of digits
        //    int sum = SumOfDigits(number);
        //    Console.WriteLine($"Sum of digits of {number} is: {sum}");
        //}

        //static int SumOfDigits(int num)
        //{
        //    int sum = 0;
        //    while (num > 0)
        //    {
        //        sum += num % 10;  // Add last digit to sum
        //        num /= 10;  // Remove last digit
        //    }
        //    return sum;
        //}
        #endregion

        #region Matrix

        #region Matrix Addition
        //static void Main()
        //{
        //    // Define two matrices
        //    int[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6 } };
        //    int[,] matrix2 = { { 7, 8, 9 }, { 10, 11, 12 } };

        //    // Get the result of matrix addition
        //    int[,] result = MatrixAddition(matrix1, matrix2);

        //    // Print the result
        //    Console.WriteLine("Result of Matrix Addition:");
        //    PrintMatrix(result);
        //}

        //static int[,] MatrixAddition(int[,] mat1, int[,] mat2)
        //{
        //    int rows = mat1.GetLength(0);
        //    int cols = mat1.GetLength(1);
        //    int[,] sum = new int[rows, cols];

        //    // Perform element-wise addition
        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < cols; j++)
        //        {
        //            sum[i, j] = mat1[i, j] + mat2[i, j];
        //        }
        //    }
        //    return sum;
        //}

        //// Function to print the matrix
        //static void PrintMatrix(int[,] matrix)
        //{
        //    int rows = matrix.GetLength(0);
        //    int cols = matrix.GetLength(1);

        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < cols; j++)
        //        {
        //            Console.Write(matrix[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
        #endregion

        #region Matrix Multiplication
        //static void Main()
        //{
        //    // Define two matrices
        //    int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        //    int[,] matrix2 = { { 5, 6 }, { 7, 8 } };

        //    // Get the result of matrix multiplication
        //    int[,] result = MatrixMultiplication(matrix1, matrix2);

        //    // Print the result
        //    Console.WriteLine("Result of Matrix Multiplication:");
        //    PrintMatrix(result);
        //}

        //static int[,] MatrixMultiplication(int[,] mat1, int[,] mat2)
        //{
        //    int rows1 = mat1.GetLength(0);
        //    int cols1 = mat1.GetLength(1);
        //    int rows2 = mat2.GetLength(0);
        //    int cols2 = mat2.GetLength(1);

        //    if (cols1 != rows2)
        //    {
        //        throw new Exception("Matrix multiplication is not possible. Columns of the first matrix must equal rows of the second matrix.");
        //    }

        //    int[,] result = new int[rows1, cols2];

        //    // Perform matrix multiplication
        //    for (int i = 0; i < rows1; i++)
        //    {
        //        for (int j = 0; j < cols2; j++)
        //        {
        //            result[i, j] = 0;
        //            for (int k = 0; k < cols1; k++)
        //            {
        //                result[i, j] += mat1[i, k] * mat2[k, j];
        //            }
        //        }
        //    }
        //    return result;
        //}

        //// Function to print the matrix
        //static void PrintMatrix(int[,] matrix)
        //{
        //    int rows = matrix.GetLength(0);
        //    int cols = matrix.GetLength(1);

        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < cols; j++)
        //        {
        //            Console.Write(matrix[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
        #endregion

        #region Matrix Transpose
        //static void Main()
        //{
        //    // Define a matrix
        //    int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };

        //    // Get the transpose of the matrix
        //    int[,] result = TransposeMatrix(matrix);

        //    // Print the result
        //    Console.WriteLine("Transpose of the Matrix:");
        //    PrintMatrix(result);
        //}

        //static int[,] TransposeMatrix(int[,] mat)
        //{
        //    int rows = mat.GetLength(0);
        //    int cols = mat.GetLength(1);
        //    int[,] transpose = new int[cols, rows];

        //    // Swap rows and columns to get the transpose
        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < cols; j++)
        //        {
        //            transpose[j, i] = mat[i, j];
        //        }
        //    }
        //    return transpose;
        //}

        //// Function to print the matrix
        //static void PrintMatrix(int[,] matrix)
        //{
        //    int rows = matrix.GetLength(0);
        //    int cols = matrix.GetLength(1);

        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < cols; j++)
        //        {
        //            Console.Write(matrix[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
        #endregion

        #region Print a 2x2 Matrix
        //static void Main()
        //{
        //    // Define a 2x2 matrix
        //    int[,] matrix = { { 1, 2 }, { 3, 4 } };

        //    // Print the matrix
        //    PrintMatrix(matrix);
        //}

        //static void PrintMatrix(int[,] matrix)
        //{
        //    int rows = matrix.GetLength(0);  // Get the number of rows
        //    int cols = matrix.GetLength(1);  // Get the number of columns

        //    // Loop through the matrix and print each element
        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < cols; j++)
        //        {
        //            Console.Write(matrix[i, j] + " "); // Print each element
        //        }
        //        Console.WriteLine(); // Move to the next line after each row
        //    }
        //}
        #endregion

        #endregion

        #region "abc38gh89" separate number from this string
        //static void Main()
        //{
        //    string input = "abc38gh89";

        //    string numbers = Regex.Replace(input, @"\D", "");

        //    Console.WriteLine(numbers);
        //}

        //static void Main()
        //{
        //    string input = "abc38gh89";

        //    char[] charArray = input.ToCharArray();

        //    string numbers = "";

        //    foreach (char ch in charArray)
        //    {
        //        if (char.IsDigit(ch))
        //        {
        //            numbers += ch;
        //        }
        //    }
        //    Console.WriteLine(numbers);
        //}
        #endregion

        #region Move all the zeroes to one side of array and ones to right side of array

        //static void Main()
        //{
        //    int[] arr = { 1, 0, 1, 0, 1, 0, 0, 1, 0 };

        //    MoveZeroesAndOnes(arr);

        //    Console.WriteLine("Modified array: ");
        //    foreach (int num in arr)
        //    {
        //        Console.Write(num + " ");
        //    }
        //}

        //static void MoveZeroesAndOnes(int[] arr)
        //{
        //    int left = 0;  // Pointer for left side (zeroes)
        //    int right = arr.Length - 1;  // Pointer for right side (ones)

        //    while (left < right)
        //    {
        //        // Move left pointer until we find a 1
        //        while (arr[left] == 0 && left < right)
        //        {
        //            left++;
        //        }

        //        // Move right pointer until we find a 0
        //        while (arr[right] == 1 && left < right)
        //        {
        //            right--;
        //        }

        //        // If left pointer is less than right pointer, swap elements
        //        if (left < right)
        //        {
        //            // Swap 0 and 1
        //            int temp = arr[left];
        //            arr[left] = arr[right];
        //            arr[right] = temp;

        //            // Move both pointers
        //            left++;
        //            right--;
        //        }
        //    }
        //}
        #endregion

        #region Anagrams

        //class AnagramChecker
        //{
        //    // Method to check if two strings are anagrams
        //    static bool AreAnagrams(string str1, string str2)
        //    {
        //        // If the lengths are different, they can't be anagrams
        //        if (str1.Length != str2.Length)
        //        {
        //            return false;
        //        }

        //        // Create an array to count the frequency of each character (assuming ASCII)
        //        int[] counts = new int[256]; // Assuming ASCII characters

        //        // Traverse both strings and count the frequency of each character
        //        for (int i = 0; i < str1.Length; i++)
        //        {
        //            counts[str1[i]]++; // Increment count for character in str1
        //            counts[str2[i]]--; // Decrement count for character in str2
        //        }

        //        // If all counts are zero, the strings are anagrams
        //        foreach (var count in counts)
        //        {
        //            if (count != 0)
        //            {
        //                return false;
        //            }
        //        }

        //        return true;
        //    }

        //    static void Main(string[] args)
        //    {
        //        // Example strings to check
        //        string str1 = "listen";
        //        string str2 = "silent";

        //        // Check if the two strings are anagrams
        //        if (AreAnagrams(str1, str2))
        //        {
        //            Console.WriteLine($"{str1} and {str2} are anagrams.");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{str1} and {str2} are not anagrams.");
        //        }
        //    }
        //}

        //public bool Anagram()
        //{
        //    // Convert both strings to lowercase to ignore case sensitivity
        //    string s = "Listen".ToLower();  // s = "listen"
        //    string t = "Silent".ToLower();  // t = "silent"

        //    // If lengths differ, they can't be anagrams
        //    if (s.Length != t.Length)       // s.Length = 6, t.Length = 6 → equal → continue
        //        return false;

        //    // Create frequency array for 26 lowercase English letters
        //    int[] freq = new int[26];       // freq[0] = 'a', freq[1] = 'b', ..., freq[25] = 'z'
        //                                    // Initially all values are 0

        //    // Loop through both strings to update frequency counts
        //    for (int i = 0; i < s.Length; i++)  // i from 0 to 5
        //    {
        //        freq[s[i] - 'a']++;         // Increment count for char from s
        //        freq[t[i] - 'a']--;         // Decrement count for char from t

        //        // Example at i = 0:
        //        // s[0] = 'l' → freq['l' - 'a']++ → freq[11]++
        //        // t[0] = 's' → freq['s' - 'a']-- → freq[18]--
        //    }

        //    // After loop: if strings are anagrams, all freq[] elements should be 0
        //    foreach (int count in freq)
        //    {
        //        if (count != 0)             // If any count is not zero → not an anagram
        //            return false;
        //    }

        //    // All character counts matched → strings are anagrams
        //    return true;                    // Output: true
        //}

        class AnagramChecker
        {
            static void Main(string[] args)
            {
                string str1 = "listen";
                string str2 = "silent";

                // Call static method with two strings
                if (Anagram(str1, str2))
                {
                    Console.WriteLine($"{str1} and {str2} are anagrams.");
                }
                else
                {
                    Console.WriteLine($"{str1} and {str2} are not anagrams.");
                }
            }

            public static bool Anagram(string s, string t)
            {
                s = s.ToLower();
                t = t.ToLower();

                if (s.Length != t.Length)
                    return false;

                int[] freq = new int[26];

                for (int i = 0; i < s.Length; i++)
                {
                    freq[s[i] - 'a']++;
                    freq[t[i] - 'a']--;
                }

                foreach (int count in freq)
                {
                    if (count != 0)
                        return false;
                }

                return true;
            }
        }


        #endregion

        #region Two Sum
        //Input: nums = [2, 7, 11, 15], target = 9
        //Output: [0, 1]
        //Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
        //public class Solution
        //{
        //    public int[] TwoSum(int[] nums, int target)
        //    {
        //        for (int i = 0; i < nums.Length; i++)
        //        {
        //            for (int j = i + 1; j < nums.Length; j++)
        //            {
        //                if (nums[j] == target - nums[i])
        //                {
        //                    return new int[] { i, j };
        //                }
        //            }
        //        }
        //        // Return an empty array if no solution is found
        //        return new int[] { };
        //    }
        //}
        #endregion

        #region  Using DSA

        #region reverse the order of a string
        // write a c# program to reverse the order of a string? 
        //class Program1
        //{
        //    static void Main(string[] args)
        //    {
        //        string str = "Yakub";
        //        //string str = Console.ReadLine();
        //        string rev = ""; // Initialize rev
        //        int length = str.Length;

        //        while (length > 0)
        //        {
        //            rev += str[length - 1];// Append the last character
        //            length--; // Decrease the length
        //        }
        //        Console.WriteLine(rev); // Print the reversed string
        //    }
        //}
        #endregion

        #region count the occurrence of each character in a string
        //// how to count the occurrence of each character in a string?

        //public class Demo
        //{
        //    public static void Main()
        //    {
        //        string str = "Website";

        //        Console.WriteLine("String: " + str);

        //        while (str.Length > 0)
        //        {
        //            Console.Write(str[0] + " = ");
        //            int cal = 0;

        //            for (int j = 0; j < str.Length; j++)
        //            {
        //                if (str[0] == str[j])
        //                {
        //                    cal++;
        //                }
        //            }

        //            Console.WriteLine(cal);
        //            str = str.Replace(str[0].ToString(), string.Empty);
        //        }
        //        Console.ReadLine();
        //    }
        //}
        #endregion

        #region  find the third largest integer
        //// write a c# program to find the third largest integer?
        //class GFG
        //{
        //    static void thirdLargest(int arr[], int arr_size)
        //    {
        //        /* There should be atleast three elements */
        //        if (arr_size < 3)
        //        {
        //            System.out.printf(" Invalid Input ");
        //            return;
        //        }

        //        // Find first largest element 
        //        int first = arr[0];
        //        for (int i = 1; i < arr_size; i++)
        //            if (arr[i] > first)
        //                first = arr[i];

        //        // Find second largest element 
        //        int second = Integer.MIN_VALUE;
        //        for (int i = 0; i < arr_size; i++)
        //            if (arr[i] > second && arr[i] < first)
        //                second = arr[i];

        //        // Find third largest element 
        //        int third = Integer.MIN_VALUE;
        //        for (int i = 0; i < arr_size; i++)
        //            if (arr[i] > third && arr[i] < second)
        //                third = arr[i];

        //        System.out.printf("The third Largest " + "element is %d\n", third);
        //    }
        //    public static void main(String[] args)
        //    {
        //        int arr[] = {12, 13, 1, 10, 34, 16};
        //        int n = arr.length;
        //        thirdLargest(arr, n);
        //    }
        //} 


        //class Program8
        //{
        //    static void Main()
        //    {
        //        int[] arr = { 12, 13, 1, 10, 34, 16 };
        //        int thirdLargest = FindThirdLargest(arr);
        //        Console.WriteLine(thirdLargest != int.MinValue
        //            ? $"The third largest element is {thirdLargest}"
        //            : "Invalid input (less than three elements)");
        //    }

        //    static int FindThirdLargest(int[] arr)
        //    {
        //        if (arr.Length < 3)
        //            return int.MinValue;

        //        int first = int.MinValue, second = int.MinValue, third = int.MinValue;

        //        foreach (var num in arr)
        //        {
        //            if (num > first)
        //            {
        //                third = second;
        //                second = first;
        //                first = num;
        //            }
        //            else if (num > second && num < first)
        //            {
        //                third = second;
        //                second = num;
        //            }
        //            else if (num > third && num < second)
        //            {
        //                third = num;
        //            }
        //        }

        //        return third;
        //    }
        //}
        #endregion

        #region list all the sub strings in a string?
        #region Version1
        //// write a c# programto split a file to multiple files of each 1000 lines?
        //// Write a c# program to list all the sub strings in a string?
        //public class GFG
        //{
        //    // Function to print all sub  strings 
        //    static void subString(string str, int n)
        //    {
        //        // Pick starting point 
        //        for (int len = 1; len <= n; len++)
        //        {
        //            // Pick ending point 
        //            for (int i = 0; i <= n - len; i++)
        //            {
        //                // Print characters from current starting point to current ending point.  
        //                int j = i + len - 1;

        //                for (int k = i; k <= j; k++)
        //                    Console.Write(str[k]);

        //                Console.WriteLine();
        //            }
        //        }
        //    }
        //    static public void Main()
        //    {
        //        string str = "abc";
        //        subString(str, str.Length);
        //    }
        //}
        #endregion
        #region Version 2
        //class Program5
        //{
        //    static void Main()
        //    {
        //        string str = "abc";
        //        PrintSubstrings(str);
        //    }

        //    static void PrintSubstrings(string str)
        //    {
        //        int n = str.Length;

        //        for (int i = 0; i < n; i++)
        //        {
        //            for (int j = i + 1; j <= n; j++)
        //            {
        //                Console.WriteLine(str.Substring(i, j - i));
        //            }
        //        }
        //    }
        //}
        #endregion
        //class Program3 list all the sub strings in a string?
        //{
        //    static void Main()
        //    {
        //        string str = "abc";
        //        PrintSubstrings(str);
        //    }

        //    static void PrintSubstrings(string str)
        //    {
        //        int n = str.Length;

        //        for (int i = 0; i < n; i++)
        //        {
        //            for (int j = i; j < n; j++)
        //            {
        //                for (int k = i; k <= j; k++)
        //                {
        //                    Console.Write(str[k]);
        //                }
        //                Console.WriteLine();
        //            }
        //        }
        //    }
        //}

        #endregion
        #endregion

        #region sort a string array in ascending order
        ////write a c# program to sort a string array in ascending order?
        //public class Exercise11
        //{
        //    public static void Main()
        //    {
        //        string str;
        //        char[] arr1;
        //        char ch;
        //        int i, j, l;
        //        Console.Write("\n\nSort a string array in ascending order :\n");
        //        Console.Write("--------------------------------------------\n");
        //        Console.Write("Input the string : ");
        //        str = Console.ReadLine();
        //        l = str.Length;
        //        arr1 = str.ToCharArray(0, l);

        //        for (i = 1; i < l; i++)
        //            for (j = 0; j < l - i; j++)

        //                if (arr1[j] > arr1[j + 1])
        //                {
        //                    ch = arr1[j];
        //                    arr1[j] = arr1[j + 1];
        //                    arr1[j + 1] = ch;
        //                }
        //        Console.Write("After sorting the string appears like : \n");
        //        foreach (char c in arr1)
        //        {
        //            ch = c;
        //            Console.Write("{0} ", ch);
        //        }
        //        Console.WriteLine("\n");
        //    }
        //} 
        #endregion

        #region Sorts words alphabetically Yakub Gugulothu == gugulothu yakub
        ////write a c# program to Sorts words alphabetically Yakub Gugulothu == gugulothu yakub
        //class Program2
        //{
        //    static void Main(string[] args)
        //    {
        //        //string sentence = string.Empty;
        //        string sentence = Console.ReadLine();
        //        string[] sent = sentence.Split(' ');
        //        //to be sorted alphabetically
        //        var x = from k in sent orderby k select k;
        //        foreach (string s in x)
        //        {
        //            Console.WriteLine(s.ToLower());
        //        }
        //        Console.ReadLine();
        //    }
        //}
        #endregion

        #region Fibanocci series
        // Fibanocci series  0 1 1 2 3 5 8 13 21 34
        //public class FibonacciExample
        //{
        //    public static void Main(string[] args)
        //    {
        //        int n1 = 0, n2 = 1, n3, i, number;
        //        Console.Write("Enter the number of elements: ");
        //        number = int.Parse(Console.ReadLine());
        //        Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
        //        for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
        //        {
        //            n3 = n1 + n2;
        //            Console.Write(n3 + " ");
        //            n1 = n2;
        //            n2 = n3;
        //        }
        //    }
        //}
        #endregion

        #region prime number program
        //// prime number program
        //public class PrimeNumberExample
        //{
        //    public static void Main(string[] args)
        //    {z
        //        //int n, i, m = 0,
        //        int flag = 0;
        //        Console.Write("Enter the Number to check Prime: ");
        //        int n = int.Parse(Console.ReadLine());
        //        int m = n / 2;
        //        for (int i = 2; i <= m; i++)
        //        {
        //            if (n % i == 0)
        //            {
        //                Console.Write("Number is not Prime.");
        //                flag = 1;
        //                break;
        //            }
        //        }
        //        if (flag == 0)
        //            Console.Write("Number is Prime.");
        //    }
        //}
        #endregion

        #region palindrome of given number
        //// palindrome of given number 121
        //public class PalindromeExample
        //{
        //    public static void Main(string[] args)
        //    {
        //        int n, r, sum = 0, temp;
        //        Console.Write("Enter the Number: ");
        //        n = int.Parse(Console.ReadLine());
        //        temp = n;
        //        while (n > 0)
        //        {
        //            r = n % 10;
        //            sum = (sum * 10) + r;
        //            n = n / 10;
        //        }
        //        if (temp == sum)
        //            Console.Write("Number is Palindrome.");
        //        else
        //            Console.Write("Number is not Palindrome");
        //    }
        //} 
        #endregion

        #region factorial of a given number
        //// factorial of a given number
        //public class FactorialExample
        //{
        //    public static void Main(string[] args)
        //    {
        //        int i, fact = 1, number;
        //        Console.Write("Enter any Number: ");
        //        number = int.Parse(Console.ReadLine());
        //        for (i = 1; i <= number; i++)
        //        {
        //            fact = fact * i;
        //        }
        //        Console.Write("Factorial of " + number + " is: " + fact);
        //    }
        //} 
        #endregion

        #region Amstrong number
        //Amsttrong number 153 is an Armstrong number because: 1^3 +5^3 +3^3 =153
        //public class ArmstrongExample
        //{
        //    public static void Main(string[] args)
        //    {
        //        int n, r, sum = 0, temp;
        //        Console.Write("Enter the Number= ");
        //        n = int.Parse(Console.ReadLine());
        //        temp = n;
        //        while (n > 0)
        //        {
        //            r = n % 10;
        //            sum = sum + (r * r * r);
        //            n = n / 10;
        //        }
        //        if (temp == sum)
        //            Console.Write("Armstrong Number.");
        //        else
        //            Console.Write("Not Armstrong Number.");
        //    }
        //} 
        #endregion

        #region sum of the given numbers
        //// sum of the given numbers
        //public class SumExample
        //{
        //    public static void Main(string[] args)
        //    {
        //        int n, sum = 0, m;
        //        Console.Write("Enter a number: ");
        //        n = int.Parse(Console.ReadLine());
        //        while (n > 0)
        //        {
        //            m = n % 10;
        //            sum = sum + m;
        //            n = n / 10;
        //        }
        //        Console.Write("Sum is= " + sum);
        //    }
        //} 
        #endregion

        #region Reverse of a number
        //// Reverse of a number
        //public class ReverseExample
        //{
        //    public static void Main(string[] args)
        //    {
        //        int n, reverse = 0, rem;
        //        Console.Write("Enter a number: ");
        //        n = int.Parse(Console.ReadLine());
        //        while (n != 0)
        //        {
        //            rem = n % 10;
        //            reverse = reverse * 10 + rem;
        //            n /= 10;
        //        }
        //        Console.Write("Reversed Number: " + reverse);
        //    }
        //} 
        #endregion

        #region convert decimal to binary
        //// convert decimal to binary
        //public class ConversionExample
        //{
        //    public static void Main(string[] args)
        //    {
        //        int n, i;
        //        int[] a = new int[10];
        //        Console.Write("Enter the number to convert: ");
        //        n = int.Parse(Console.ReadLine());
        //        for (i = 0; n > 0; i++)
        //        {
        //            a[i] = n % 2;
        //            n = n / 2;
        //        }
        //        Console.Write("Binary of the given number= ");
        //        for (i = i - 1; i >= 0; i--)
        //        {
        //            Console.Write(a[i]);
        //        }
        //    }
        //} 
        #endregion

        #region print alphabet triangle
        //// print alphabet triangle
        //public class PrintExample
        //{
        //    public static void Main(string[] args)
        //    {
        //        char ch = 'A';
        //        int i, j, k, m;
        //        for (i = 1; i <= 5; i++)
        //        {
        //            for (j = 5; j >= i; j--)
        //                Console.Write(" ");
        //            for (k = 1; k <= i; k++)
        //                Console.Write(ch++);
        //            ch--;
        //            for (m = 1; m < i; m++)
        //                Console.Write(--ch);
        //            Console.Write("\n");
        //            ch = 'A';
        //        }
        //    }
        //} 
        #endregion

        #region print numbers in triangle
        //// print numbers in triangle
        //public class PrintExample
        //{
        //    public static void Main(string[] args)
        //    {
        //        int i, j, k, l, n;
        //        Console.Write("Enter the Range=");
        //        n = int.Parse(Console.ReadLine());
        //        for (i = 1; i <= n; i++)
        //        {
        //            for (j = 1; j <= n - i; j++)
        //            {
        //                Console.Write(" ");
        //            }
        //            for (k = 1; k <= i; k++)
        //            {
        //                Console.Write(k);
        //            }
        //            for (l = i - 1; l >= 1; l--)
        //            {
        //                Console.Write(l);
        //            }
        //            Console.Write("\n");
        //        }
        //    }
        //} 
        #endregion

        #region pascal triangle using arrays 
        ////pascal triangle using arrays 
        //class Pascal
        //{
        //    public static void Main()
        //    {
        //        int[,] arr = new int[8, 8];
        //        Console.WriteLine("Pascal Triangle : ");
        //        for (int i = 0; i < 5; i++)
        //        {
        //            for (int k = 5; k > i; k--)
        //            {
        //                Console.Write(" ");
        //            }

        //            for (int j = 0; j < i; j++)
        //            {
        //                if (j == 0 || i == j)
        //                {
        //                    arr[i, j] = 1;
        //                }
        //                else
        //                {
        //                    arr[i, j] = arr[i - 1, j] + arr[i - 1, j - 1];
        //                }
        //                Console.Write(arr[i, j] + " ");
        //            }
        //            Console.ReadLine();
        //        }
        //    }
        //} 
        #endregion

        //#endregion



    }
}

