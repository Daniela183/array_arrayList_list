﻿//aula 109
Console.WriteLine("Array Multidimensional II\n");

//Acessando arrays bidimensional com laço for e foreach
Console.WriteLine("Acessando array bidimensional");
int[,] n = {
             { 11, 22, 33 },    //n[0,0] n[0,1] n[0,2]
             { 44, 55, 66 },    //n[1,0] n[1,1] n[1,2]   n[3,3] -> n[i,j]
             { 77, 88, 99 }     //n[2,0] n[2,1] n[2,2] 
           };

Console.WriteLine("\n---Laço FOR---");
for (int i = 0; i < n.GetLength(0); i++)
{
    for (int j = 0; j < n.GetLength(1); j++)
    {
        Console.Write($"{n[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("\n---Laço FOREACH---"); //Não usa indice
foreach (var x in n)
{
    Console.Write($"{x} ");
}

Console.ReadKey();