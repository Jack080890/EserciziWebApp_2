// See https://aka.ms/new-console-template for more information
using ArrayManagement_2;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;



Console.WriteLine("Esercizio ArrayManagement");



int[] numeri = [10, 8, 4, 65, 22, 9];
int fromIndex = 0;
int toIndex = numeri.Length - 1;

int indexOfMin = ArraySorter.FindIndexOfMin(numeri, fromIndex, toIndex);



Console.WriteLine($"L' indice del valore più piccolo di numeri[] è {indexOfMin}");
Console.WriteLine(ArraySorter.SwapElements(numeri, 0, 3));
Console.WriteLine(ArraySorter.SortArray(numeri));












