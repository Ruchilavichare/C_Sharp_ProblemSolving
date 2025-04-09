# C# Problem Solving Examples - README

This project contains a collection of fundamental and advanced C# programming exercises, along with detailed explanations and clean code examples. Each section is aimed at improving your problem-solving skills in C#.

---

## Table of Contents
1. Reverse a String using Recursion
2. Reverse a Number
3. Find All Prime Numbers in a Range
4. Fibonacci Series using Recursion
5. Find the Median of an Unsorted Array
6. Check if a Number is a Power of Two
7. Bubble Sort
8. Pyramid Pattern Variations
9. Converting Nullable to Non-Nullable Types in C#

---

## 1. Reverse a String using Recursion
**Logic:**
- Peel off the first character and recursively reverse the rest of the string.
- Base case: return the string if its length is 0 or 1.

```csharp
string ReverseString(string str)
{
    if (str.Length <= 1)
        return str;
    return ReverseString(str.Substring(1)) + str[0];
}
```

---

## 2. Reverse a Number
**Logic:**
- Use a loop to extract each digit using modulus operator `%`.
- Append to result by multiplying the result by 10 and adding the digit.

```csharp
int ReverseNumber(int num)
{
    int reversed = 0;
    while (num > 0)
    {
        int digit = num % 10;
        reversed = reversed * 10 + digit;
        num /= 10;
    }
    return reversed;
}
```

---

## 3. Find All Prime Numbers in a Range
**Logic:**
- Iterate from 2 to n and check if each number has any divisors other than 1 and itself.

```csharp
bool IsPrime(int number)
{
    if (number <= 1) return false;
    for (int i = 2; i <= Math.Sqrt(number); i++)
        if (number % i == 0) return false;
    return true;
}
```

---

## 4. Fibonacci Series using Recursion
**Logic:**
- Each number is the sum of the two preceding ones.
- Base case: 0 and 1.

```csharp
int Fibonacci(int n)
{
    if (n <= 1) return n;
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}
```

---

## 5. Find the Median of an Unsorted Array
**Logic:**
- Sort the array and find the middle element(s).

```csharp
double FindMedian(int[] arr)
{
    Array.Sort(arr);
    int n = arr.Length;
    if (n % 2 == 1)
        return arr[n / 2];
    return (arr[n / 2 - 1] + arr[n / 2]) / 2.0;
}
```

---

## 6. Check if a Number is a Power of Two
**Logic:**
- A number is a power of two if it has only one bit set in binary.

```csharp
bool IsPowerOfTwo(int n)
{
    return n > 0 && (n & (n - 1)) == 0;
}
```

---

## 7. Bubble Sort
**Logic:**
- Repeatedly swap adjacent elements if they are in the wrong order.

```csharp
void BubbleSort(int[] arr)
{
    int n = arr.Length;
    for (int i = 0; i < n - 1; i++)
        for (int j = 0; j < n - i - 1; j++)
            if (arr[j] > arr[j + 1])
                (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
}
```

---

## 8. Pyramid Pattern Variations
Examples:

### a. Left Aligned
```
*
**
***
```

### b. Right Aligned
```
    *
   **
  ***
```

### c. Center Aligned Pyramid
```
    *
   * *
  * * *
```

### d. Inverted Pyramid
```
* * * * *
 * * * *
  * * *
   * *
    *
```

---

## 9. Converting Nullable to Non-Nullable Types in C#

### a. Null-Coalescing Operator
```csharp
int? a = null;
int b = a ?? 0;
```

### b. Using `.Value`
```csharp
if (a.HasValue)
    int b = a.Value;
```

### c. GetValueOrDefault()
```csharp
int b = a.GetValueOrDefault();
```

---

## 🚀 How to Use
- Clone this project
- Copy and run each code block in a C# environment like Visual Studio, Rider, or online compilers like dotnetfiddle.net

---

## 💡 Contributions
Want to add your own problems or enhancements? Feel free to submit a pull request!

---

## 📧 Contact
For any suggestions or questions, feel free to reach out.

Happy Coding! 🎯

