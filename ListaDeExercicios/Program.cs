﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Program
    {
        static void Main(string[] args)
        {

            int op = 1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("Lista de Exercícios\n");
                Console.WriteLine("Escolha o número de uma opção a baixo:\n");
                Console.WriteLine("1- Exercícios de 1 a 5");
                Console.WriteLine("2- Exercícios de 6 a 10");
                Console.WriteLine("3- Exercícios de 11 a 15 ");
                Console.WriteLine("4- Exercícios de 16 a 20");
                Console.WriteLine("0 - Sair");
                op = int.Parse(Console.ReadLine());


                if (op == 0)
                {
                    break; //Opção "0" usada para fechar o programga
                }
                else if (op == 1)
                {
                    Submenu1(); //Submenu com os exercícios 1, 2, 3, 4 e 5.
                }
                else if (op == 2)
                {
                    Submenu2(); //Submenu com os exercícios 6, 7, 8, 9 e 10.
                } 
                else if (op == 3)
                {
                    Submenu3(); //Submenu com os exercícios 11, 12, 13, 14 e 15.
                }
                else if (op == 4)
                {
                    Submenu4(); //Submenu com os exercícios 16, 17, 18, 19 e 20.
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                    Console.ReadKey();
                }
            } //Menu principal, com acesso para os submenus 1, 2, 3, e 4.

        }

        //Métodos dos SubMenus
        
        private static void Submenu1() //Submenu para os exercícios 1, 2, 3, 4 e 5.
        {
            int op = 1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("Lista de Exercícios, escolha uma opção a baixo:\n");
                Console.WriteLine("1- Exercício 1 - Soma dois números.");
                Console.WriteLine("2- Exercício 2 - Calcula a media de 4 números.");
                Console.WriteLine("3- Exercício 3 - Verificar se um número é primo.");
                Console.WriteLine("4- Exercício 4 - Converter temperatura de Celsius para Fahrenheit.");
                Console.WriteLine("5- Exercício 5 - Invertendo uma string");
                Console.WriteLine("0 - Voltar ao menu anterior");
                op = int.Parse(Console.ReadLine());


                if (op == 0)
                {
                    break; //Opção "0" usada para voltar ao primeiro menu
                }
                else if (op == 1) //Chamada para Exercício 1
                {
                    Exercicio1();
                }
                else if (op == 2) //Chamada para Exercício 2
                {
                    Exercicio2();
                }
                else if (op == 3) //Chamada para Exercício 3
                {
                    Exercicio3();
                }
                else if (op == 4) //Chamada para Exercício 4
                {
                    Exercicio4();
                }
                else if (op == 5) //Chamada para Exercício 5
                {
                    Exercicio5();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                    Console.ReadKey();
                }
            }
        }
        
        private static void Submenu2() //Submenu para os exercícios 6, 7, 8, 9 e 10.
        {
            int op = 1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("Lista de Exercícios, escolha uma opção a baixo:\n");
                Console.WriteLine("1- Exercício 6 - Calculadora simples com operações básicas(+, -, *, /).");
                Console.WriteLine("2- Exercício 7 - Validor de CPF.");
                Console.WriteLine("3- Exercício 8 - Contador de palavras em uma frase.");
                Console.WriteLine("4- Exercício 9 - Soma de digitos de um número.");
                Console.WriteLine("5- Exercício 10 - Ordenando um array de números.");
                Console.WriteLine("0 - Voltar ao menu anterior");
                op = int.Parse(Console.ReadLine());


                if (op == 0)
                {
                    break;
                }
                else if (op == 1) //Chamada para Exercício 6
                {
                    Exercicio6();
                }
                else if (op == 2) //Chamada para Exercício 7
                {
                    Exercicio7();
                }
                else if (op == 3) //Chamada para Exercício 8
                {
                    Exercicio8();
                }
                else if (op == 4) //Chamada para Exercício 9
                {
                    Exercicio9();
                }
                else if (op == 5) //Chamada para Exercício 10
                {
                    Exercicio10();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                    Console.ReadKey();
                }
            }
        }

        private static void Submenu3() //Submenu para os exercícios 11, 12, 13, 14 e 15.
        {
            int op = 1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("Lista de Exercícios, escolha uma opção a baixo:");
                Console.WriteLine("1- Exercício 11 - Calculando a área de um triangulo.");
                Console.WriteLine("2- Exercício 12 - Verificando se um ano é bissexto");
                Console.WriteLine("3- Exercício 13 - Encontrando o maior elemento de um array.");
                Console.WriteLine("4- Exercício 14 - verificando se uma palavra é um palindromo.");
                Console.WriteLine("5- Exercício 15 - Verificando de um valor é positivo ou negativo.");
                Console.WriteLine("0 - Voltar ao menu anterior");
                op = int.Parse(Console.ReadLine());


                if (op == 0)
                {
                    break;
                }
                else if (op == 1) //Chamada para Exercício 11
                {
                    Exercicio11();
                }
                else if (op == 2) //Chamada para Exercício 12
                {
                    Exercicio12();
                }
                else if (op == 3) //Chamada para Exercício 13
                {
                    Exercicio13();
                }
                else if (op == 4) //Chamada para Exercício 14
                {
                    Exercicio14();
                }
                else if (op == 5) //Chamada para Exercício 15
                {
                    Exercicio15();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                    Console.ReadKey();
                }
            }
        }

        private static void Submenu4() //Submenu para os exercícios 16, 17, 18, 19 e 20.
        {
            int op = 1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("Lista de Exercícios, escolha uma opção a baixo:");
                Console.WriteLine("1- Exercício 16 - Calculando o fatorial de um número.");
                Console.WriteLine("2- Exercício 17 - Verificando se um numero é multiplo de outro.");
                Console.WriteLine("3- Exercício 18 - Contando quantas vezes um determinado caractere aparece em uma palavra.");
                Console.WriteLine("4- Exercício 19 - Ordenando os elementos de uma matriz.");
                Console.WriteLine("5- Exercício 20 - Validando um email.");
                Console.WriteLine("0 - Voltar ao menu anterior");
                op = int.Parse(Console.ReadLine());


                if (op == 0)
                {
                    break;
                }
                else if (op == 1) //Chamada para Exercício 16
                {
                    Exercicio16();
                }
                else if (op == 2) //Chamada para Exercício 17
                {
                    Exercicio17();
                }
                else if (op == 3) //Chamada para Exercício 18
                {
                    Exercicio18();
                }
                else if (op == 4) //Chamada para Exercício 19
                {
                    Exercicio19();
                }
                else if (op == 5) //Chamada para Exercício 20
                {
                    Exercicio20();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                    Console.ReadKey();
                }
            }
        }

        //Métodos dos exercícios

        private static void Exercicio1() //**Exercício 1: Fazer um programa que some dois numeros.
        {
            Console.Clear();
            Console.WriteLine("Exercício 1: Fazer um programa que some dois numeros\n");

            Console.WriteLine("Digite um número:");
            int soma1 =int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite outro número:");
            int soma2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"{soma1} + {soma2}  = " + (soma1 + soma2));

            Console.WriteLine("\n(Precione qualquer tecla para voltar ao menu!)");
            Console.ReadKey();
        }
        
        private static void Exercicio2() //**Exercício 2: Criar um programa que calcule a média de um conjunto de números.
        {
            //Média com 4 números escolhidos pela pessoa
            
            Console.Clear();
            Console.WriteLine("Exercício 2: Criar um programa que calcule a média de um conjunto de (4) números\n");

            Console.WriteLine("Digite um número:");
            int nMedia1 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite outro número:");
            int nMedia2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite outro número:");
            int nMedia3 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite outro número:");
            int nMedia4 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"A média de: {nMedia1} {nMedia2} {nMedia3} {nMedia4}" + "\n");
            Console.WriteLine((nMedia1 + nMedia2 + nMedia3 + nMedia4)/4 + "\n");

            Console.WriteLine("\n(Precione qualquer tecla para voltar ao menu!)");
            Console.ReadKey();
        }

        private static void Exercicio3() //**Exercício 3: Implementar uma função para verificar se um número é primo.
        {
            Console.Clear();
            Console.WriteLine("Exercício 3: Implementar uma função para verificar se um número é primo.\n");


            int numDiv = 1;
            int div = 1;
            Console.WriteLine("Digite um número:");
            int nPrimo = int.Parse(Console.ReadLine());

            if (nPrimo < 2)
            {
                Console.WriteLine("Esse número de ser maior que 2\n");
            }
            else if (nPrimo == 2)
            {
                Console.WriteLine($"O número {nPrimo} é primo.\n");
            }
            else if (nPrimo % 2 == 0)
            {
                Console.WriteLine($"O número {nPrimo} NÂO é primo.\n");
            }
            else
            {
                while (div <= nPrimo)
                {
                    if (nPrimo % div == 0)
                    {
                        numDiv++;
                    }
                    div += 2;
                }
                if (nPrimo > 2)
                {
                    Console.WriteLine($"O número {nPrimo} NÂO é primo.\n");
                }
                else
                {
                    Console.WriteLine($"O número {nPrimo} é primo.\n");
                }
            }

            Console.WriteLine("\n(Precione qualquer tecla para voltar ao menu!)");
            Console.ReadKey();
        }

        private static void Exercicio4() //**Exercício 4: Escrever um programa para converter uma temperatura de Celsius para Fahrenheit.
        {
            Console.Clear();
            Console.WriteLine("Exercício 4: Escrever um programa para converter uma temperatura de Celsius para Fahrenheit.\n");

            Console.WriteLine("Digite uma temperatura em Celsius:");
            //double tempCelsius = int.Parse(Console.ReadLine());
            double tempCelsius = double.Parse(Console.ReadLine());
            double formulaFahrenheit = (tempCelsius * 1.8 + 32);

            Console.WriteLine();

            Console.WriteLine($"A temepratura {tempCelsius} em Fahrenheit é: {formulaFahrenheit}");

            Console.WriteLine("\n(Precione qualquer tecla para voltar ao menu!)");
            Console.ReadKey();
        }

        private static void Exercicio5() //**Exercício 5: Criar um programa que inverta uma string.
        {
            Console.Clear();
            Console.WriteLine("Exercício 5: Criar um programa que inverta uma string.\n");

            Console.WriteLine("Escreva uma palavra.\n");
            string palavra = Console.ReadLine();

            for (int i = 0; i < palavra.Length; i++)
            {
                Console.Write(palavra[palavra.Length - i - 1]);
            }

            Console.WriteLine();
            Console.WriteLine("\n(Precione qualquer tecla para voltar ao menu!)");
            Console.ReadKey();
        }

        private static void Exercicio6() //**Exercício 6: Construir uma calculadora simples com as operações básicas(+,-,*,/).
        {
            Console.Clear();
            Console.WriteLine("Exercício 6: Construir uma calculadora simples com as operações básicas(+,-,*,/).\n");

            int op = 1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma das operações a baixo:\n");
                Console.WriteLine("1- Soma. (+)");
                Console.WriteLine("2- Subtração. (-)");
                Console.WriteLine("3- Multiplicação. (*)");
                Console.WriteLine("4- Divisão. (/)");
                Console.WriteLine("0 - Voltar ao menu anterior");
                op = int.Parse(Console.ReadLine());


                if (op == 0)
                {
                    break;
                }
                else if (op == 1) //Chamada para operação de soma
                {
                    Console.Clear();
                    Console.WriteLine("Operação de soma!\n");

                    Console.WriteLine("Digite um número:");
                    int soma1 = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    Console.WriteLine("Digite outro número:");
                    int soma2 = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine($"{soma1} + {soma2}  = " + (soma1 + soma2));

                    Console.WriteLine("\n(Precione qualquer tecla para voltar ao menu!)");
                    Console.ReadKey();
                }
                else if (op == 2) //Chamada para operação de subtração
                {
                    Console.Clear();
                    Console.WriteLine("Operação de subtração!\n");

                    Console.WriteLine("Digite um número:");
                    int subtracao1 = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    Console.WriteLine("Digite outro número:");
                    int subtracao2 = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine($"{subtracao1} - {subtracao2}  = " + (subtracao1 - subtracao2));

                    Console.WriteLine("\n(Precione qualquer tecla para voltar ao menu!)");
                    Console.ReadKey();
                }
                else if (op == 3) //Chamada para operação de multiplicação
                {
                    Console.Clear();
                    Console.WriteLine("Operação de multiplicação!\n");

                    Console.WriteLine("Digite um número:");
                    int multi1 = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    Console.WriteLine("Digite outro número:");
                    int multi2 = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine($"{multi1} * {multi2}  = " + (multi1 * multi2));

                    Console.WriteLine("\n(Precione qualquer tecla para voltar ao menu!)");
                    Console.ReadKey();
                }
                else if (op == 4) //Chamada para operação de divisão
                {
                    Console.Clear();
                    Console.WriteLine("Operação de divisão!\n");

                    Console.WriteLine("Digite um número:");
                    double div1 = double.Parse(Console.ReadLine());

                    Console.WriteLine();

                    Console.WriteLine("Digite outro número:");
                    double div2 = double.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine($"{div1} / {div2}  = " + (div1 / div2));

                    Console.WriteLine("\n(Precione qualquer tecla para voltar ao menu!)");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("\n(Precione qualquer tecla para voltar ao menu!)");
            Console.ReadKey();
        }

        private static void Exercicio7() //?*Exercício 7: Implementar um programa que valide um CPF.
        {
            Console.Clear();
            Console.WriteLine("Exercício 7: Implementar um programa que valide um CPF.\n");

            Console.WriteLine("Escreva um cpf sem traço, pontos e barra.\n");
            string cpf = Console.ReadLine();
            bool cpfValido = ValidarCPF(cpf);

            if (cpfValido)
            {
                Console.WriteLine("CPF válido!");
            }

            else
            {
                Console.WriteLine("CPF inválido!");
            }
        

            bool ValidarCPF(string numCpf)
            {
                numCpf = new string(numCpf.Where(char.IsDigit).ToArray());

                if (numCpf.Length != 11)
                {
                    return false;
                }

                if (numCpf.Distinct().Count() == 1)
                {
                    return false;
                }

                else
                {
                    return true;
                }
            }

            Console.WriteLine("\n(Precione qualquer tecla para voltar ao menu!)");
            Console.ReadKey();
        }

        private static void Exercicio8() //**Exercício 8: Escrever um programa que conte quantas palavras há em uma frase.
        {
            Console.Clear();
            Console.WriteLine("Exercício 8: Escrever um programa que conte quantas palavras há em uma frase.\n");

            Console.WriteLine("Escreva uma frase.\n");
            string frase = Console.ReadLine();

            int numeroPalavras = frase.Split(' ').Length;

            Console.WriteLine($"\nA frase tem: {numeroPalavras} palavras");

            Console.WriteLine("\n(Precione qualquer tecla para voltar ao menu!)");
            Console.ReadKey();
        }

        private static void Exercicio9() //**Exercício 9: Criar uma função que retorne a soma dos digitos de um número.
        {
            Console.Clear();
            Console.WriteLine("Exercício 9: Criar uma função que retorne a soma dos digitos de um número.\n");

            Console.WriteLine("Digite um número.\n");

            int num = int.Parse(Console.ReadLine());

            int DigSoma(int numero)
            {
                int soma = 0;
                foreach (char digito in numero.ToString())
                {
                    soma += int.Parse(digito.ToString());
                }
                return soma;
            }

            int resultDigSoma = DigSoma(num);

            Console.WriteLine($"A soma dos digitos do número é: {resultDigSoma}");

            Console.WriteLine("\n(Precione qualquer tecla para voltar ao menu!)");
            Console.ReadKey();
        }

        private static void Exercicio10() //**Exercício 10: Implementar um programa que ordene um array de números.
        {
            Console.Clear();
            Console.WriteLine("Exercício 10: Implementar um programa que ordene um array de números.\n");

            Console.WriteLine("Escrava 5 números entre -100 e 100");

            Console.WriteLine("\nPrimeiro número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSegundo número:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nTerceiro número:");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nQuarto número:");
            int num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nQuinto número:");
            int num5 = int.Parse(Console.ReadLine());

            int[] numeros = { num1, num2, num3, num4, num5 };
            Array.Sort(numeros);

            Console.WriteLine("\nA ordem crescente dos números é:\n");

            foreach (int elemento in numeros)
            {
                Console.Write($" {elemento}");
            }

            Console.WriteLine("\n(Precione qualquer tecla para voltar ao menu!)");
            Console.ReadKey();
        }

        private static void Exercicio11() //**Exercício 11: Construir um programa que calcule a área de um triangulo.
        {
            Console.Clear();
            Console.WriteLine("Exercício 11: Construir um programa que calcule a área de um triangulo.\n");

            Console.WriteLine("Digite o valor do comprimento da base do triagulo:");
            int baseTriangulo = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o valor da altura do triagulo:");
            int alturaTriangulo = int.Parse(Console.ReadLine());

            decimal areaTriangulo = baseTriangulo * alturaTriangulo / 2;

            Console.WriteLine();
            
            Console.WriteLine($"A área do triângulo é = {areaTriangulo}");

            Console.WriteLine("\n(Precione qualquer tecla para voltar ao menu!)");
            Console.ReadKey();
        }

        private static void Exercicio12() //**Exercício 12: Escrever um código que verifique se um ano é bissexto.
        {
            Console.Clear();
            Console.WriteLine("Exercício 12: Escrever um código que verifique se um ano é bissexto.\n");

            Console.WriteLine("Escreva um ano.\n");
            int ano = int.Parse(Console.ReadLine());
            bool anoBissexto = DateTime.IsLeapYear(ano);

            if (anoBissexto == true)
            {
                Console.WriteLine($"O ano {ano} é bissexto.\n");
            }
            else
            {
                Console.WriteLine($"O ano {ano} não é bissexto.\n");
            }

            Console.WriteLine("\n(Precione qualquer tecla para voltar ao menu!)");
            Console.ReadKey();
        }

        private static void Exercicio13() //**Exercício 13: Implementar um programa que encontre o maior elemento de um array.
        {
            Console.Clear();
            Console.WriteLine("Exercício 13: Implementar um programa que encontre o maior elemento (Número) de um array.\n");

            Console.WriteLine("Escrava 5 números entre -100 e 100");

            Console.WriteLine("\nPrimeiro número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSegundo número:");
            int num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("\nTerceiro número:");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nQuarto número:");
            int num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nQuinto número:");
            int num5 = int.Parse(Console.ReadLine());

            int[] numeros = { num1, num2, num3, num4, num5 };
            int maiorNumero = numeros.Max();

            Console.WriteLine($"\nO maior número é: {maiorNumero}");

            Console.WriteLine("\n(Precione qualquer tecla para voltar ao menu!)");
            Console.ReadKey();
        }

        private static void Exercicio14() //**Exercício 14: Criar uma função que verifique se uma palavra é um palindromo.
        {
            Console.Clear();
            Console.WriteLine("Exercício 14: Criar uma função que verifique se uma palavra é um palindromo.\n");

            Console.WriteLine("Escreva uma palavra.\n");
            string palavra = Console.ReadLine();

            string palavraInvertida = new string(palavra.Reverse().ToArray());

            Console.WriteLine($"Texto Normal   : {palavra}");
            Console.WriteLine($"Texto Invertido: {palavraInvertida}\n");

            string palavraMinuscula = palavra.ToLower();

            string palavraInvertidaMinuscula = new string(palavraMinuscula.Reverse().ToArray());

            if (palavraMinuscula == palavraInvertidaMinuscula)
            {
                Console.WriteLine($"A palavra: {palavra}, é um palindromo");
            }
            else
            {
                Console.WriteLine($"A palavra: {palavra}, não é um palindromo");
            }

            Console.WriteLine("\n(Precione qualquer tecla para voltar ao menu!)");
            Console.ReadKey();
        }

        private static void Exercicio15() //**Exercício 15: Construir um programa que solicite ao usuario um valor e informe se é positivo ou negativo.
        {
            Console.Clear();
            Console.WriteLine("Exercício 15: Construir um programa que solicite ao usuario um valor e informe se é positivo ou negativo.\n");

            Console.WriteLine("Escrava um número entre -100 até 100\n");

            int num = int.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine($"\nO número {num} é maior que 0, portanto é positivo");
            }
            else if (num == 0)
            {
                Console.WriteLine($"\nO número {num} é 0, portanto não é positivo nem negativo, mas sim neutro");
            }            
            else
            {
                Console.WriteLine($"\nO número {num} é menor que 0, portanto é negativo");
            };

            Console.WriteLine("\n(Precione qualquer tecla para voltar ao menu!)");
            Console.ReadKey();
        }

        private static void Exercicio16() //**Exercício 16: Escrever um código que calcule o fatorial de um número.
        {
            Console.Clear();
            Console.WriteLine("Exercício 16: Escrever um código que calcule o fatorial de um número.\n");

            Console.WriteLine("Escreva um numero.\n");
            int num = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = 1; i <= num; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine($"\nO fatorial de {num} é: {fatorial}");

            Console.WriteLine("\n(Precione qualquer tecla para voltar ao menu!)");
            Console.ReadKey();
        }

        private static void Exercicio17() //**Exercício 17: Implementar um programa que verifique se um numero é multiplo de outro.
        {
            Console.Clear();
            Console.WriteLine("Exercício 17: Implementar um programa que verifique se um numero é multiplo de outro.\n");

            Console.WriteLine("Escrava um número\n");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escrava outro número\n");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 % num2 == 0)
            {
                Console.WriteLine($"\nO número {num1} é multiplo de {num2}");
            }
            else
            {
                Console.WriteLine($"\nO número {num1} não é multiplo de {num2}");
            };

            Console.WriteLine("\n(Precione qualquer tecla para voltar ao menu!)");
            Console.ReadKey();
        }

        private static void Exercicio18() //**Exercício 18: Criar uma função que conte quantas vezes um determinado caractere aparece em uma string.
        {
            Console.Clear();
            Console.WriteLine("Exercício 18: Criar uma função que conte quantas vezes um determinado caractere aparece em uma string.\n");

            int ContarCaractere(string texto, char caractere)
            {
                return texto.Count(c => c == caractere);
            }

            Console.WriteLine("Escreva uma frase:");
            string meuTexto = Console.ReadLine();

            Console.WriteLine("\nEscreva uma letra:");
            char meuCaractere = char.Parse(Console.ReadLine());

            int quantidade = ContarCaractere(meuTexto, meuCaractere);

            Console.WriteLine($"\nO caractere: {meuCaractere} aparece: {quantidade} vezes na frase.");

            Console.WriteLine("\n(Precione qualquer tecla para voltar ao menu!)");
            Console.ReadKey();
        }

        private static void Exercicio19() //**Exercício 19: Construir um programa que ordene os elementos de uma matriz.
        {
            Console.Clear();
            Console.WriteLine("Exercício 19: Construir um programa que ordene os elementos (Números) de uma matriz.\n");

            Console.WriteLine("Escrava 5 números entre -100 e 100");

            Console.WriteLine("\nPrimeiro número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSegundo número:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nTerceiro número:");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nQuarto número:");
            int num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nQuinto número:");
            int num5 = int.Parse(Console.ReadLine());

            int[] matriz = { num1, num2, num3, num4, num5 };
            Array.Sort(matriz);

            Console.WriteLine("\nA ordem crescente dos números é:\n");

            foreach (int elemento in matriz)
            {
                Console.Write($" {elemento}");
            }

            Console.WriteLine("\n\n(Precione qualquer tecla para voltar ao menu!)");
            Console.ReadKey();
        }

        private static void Exercicio20() //**Exercício 20: Escrever um código que valide um email.
        {
            Console.Clear();
            Console.WriteLine("Exercício 20: Escrever um código que valide um email.\n");

            Console.WriteLine("Escreva um email:\n");
            string email = Console.ReadLine();
            bool emailValido = ValidarEmail(email);

            if (emailValido)
            {
                Console.WriteLine($"\nO email: {email}, é válido!");
            }
            else
            {
                Console.WriteLine($"\nO email: {email}, não é válido!");
            }

            bool ValidarEmail(string emailValid)
            {
                string emailPadrao = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                return System.Text.RegularExpressions.Regex.IsMatch(emailValid, emailPadrao);
            }

            Console.WriteLine("\n(Precione qualquer tecla para voltar ao menu!)");
            Console.ReadKey();
        }



    }
}