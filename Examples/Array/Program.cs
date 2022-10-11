﻿// See https://aka.ms/new-console-template for more information

// ************************
// ****** C# Arrays *******
// ************************

// An Array is a collection of similar types of data
// Suppose we need to record the age of 5 students. Instead of creating 5 separate variables, we can simply create an array

// 1. C# Array Declaration

// declare an array
int[] age;

// allocate memory for array
age = new int[5];

int[] num = new int[5];

// Array initializations in c#
//int[] numbers = {1, 2, 3, 4, 5};

// initializing array
age[0] = 24;
age[1] = 4;
age[2] = 6;
age[3] = 7;
age[4] = 8;

// Example C# Array

// Create an Array
int[] numbers = { 1, 2, 3 };

// access first element
Console.WriteLine("Element in first index: " + numbers[0]);

// access second element
Console.WriteLine("Element in second index: " + numbers[1]);

// access third number
Console.WriteLine("Element in third index: " + numbers[2]);

// 4. Change Array Elements
Console.WriteLine("Old value at index 0: " + numbers[0]);

numbers[0] = 11;
Console.WriteLine("New value at index 0: " + numbers[0]);

Console.ReadLine();
