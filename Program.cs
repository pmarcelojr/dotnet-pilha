﻿using System;

namespace dotnet_pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            var pilha = new Pilha();
            pilha.Empilha(1);
            pilha.Empilha(10);
            pilha.Empilha(100);
            Console.WriteLine(pilha.Desempilha());
            Console.WriteLine(pilha.Desempilha());
            Console.WriteLine(pilha.Desempilha());
            Console.WriteLine(pilha.Desempilha());
        }
    }
}
