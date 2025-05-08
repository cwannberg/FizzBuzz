# FizzBuzz in C#

This is a simple implementation of the classic **FizzBuzz** problem in C#, designed for console-based input and output. It takes three integers as input and prints numbers from 1 to `n`, replacing multiples of `x` with `"Fizz"`, multiples of `y` with `"Buzz"`, and multiples of both with `"FizzBuzz"`.

## How it works

The program reads a single line of input from the console with three space-separated integers: **x y n**

It then prints numbers from 1 to `n` with the following rules:

- If a number is divisible by both `x` and `y`, print `"FizzBuzz"`
- If it's divisible only by `x`, print `"Fizz"`
- If it's divisible only by `y`, print `"Buzz"`
- Otherwise, print the number itself

## Example

**Input:**

2 3 7

**Output:**
```text
Fizz
Buzz
Fizz
5
FizzBuzz
7
```

## How to run the program

Compile and run the program using the following commands:

```bash
dotnet run
