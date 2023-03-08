using System;
using System.Linq;

namespace ListaLinguagem_1
{

    internal class Program
    {
        static int Menu()
        {
            int resp;
            Console.WriteLine("Entre com um número de acordo com o exercício.\n");
            Console.WriteLine("Entre com o 0 para encerrar.\n");     resp = 0;
            Console.WriteLine("Exercicio 01 - Length");              resp = 1;
            Console.WriteLine("Exercicio 02 - ToCharArray");         resp = 2;
            Console.WriteLine("Exercicio 03 - Trim");                resp = 3;
            Console.WriteLine("Exercicio 04 - SubString");           resp = 4;
            Console.WriteLine("Exercicio 05 - Split");               resp = 5;
            Console.WriteLine("Exercicio 06 - Contains");            resp = 6;
            Console.WriteLine("Exercicio 07 - EndsWith");            resp = 7;
            Console.WriteLine("Exercicio 08 - Equals");              resp = 8;
            Console.WriteLine("Exercicio 09 - Gettype");             resp = 9;
            Console.WriteLine("Exercicio 10 - IndexOf");             resp = 10;
            Console.WriteLine("Exercicio 11 - Empty");               resp = 11;
            Console.WriteLine("Exercicio 12 - Insert");              resp = 12;
            Console.WriteLine("Exercicio 13 - LastIndexOf");         resp = 13;
            Console.WriteLine("Exercicio 14 - Remove");              resp = 14;
            Console.WriteLine("Exercicio 15 - Replace");             resp = 15;
            Console.WriteLine("Exercicio 16 - StartsWith");          resp = 16;
            Console.WriteLine("Exercicio 17 - ToLower");             resp = 17;
            Console.WriteLine("Exercicio 18 - ToUpper");             resp = 18;
            Console.WriteLine("Exercicio 19 - ToString\n");          resp = 19;

            resp = int.Parse(Console.ReadLine());

            return resp;
        }
        static void Exe01()
        {
            //A Length propriedade retorna o número de Char objetos nesta instância,
            //não o número de caracteres Unicode.
            //O motivo é que um caractere Unicode pode ser representado por mais de um Char. 

            string palavra =  " ";
            Console.WriteLine("Entre com qualquer palavra", palavra);
            palavra = Console.ReadLine();
            Console.WriteLine("1) A palavra digitada foi '{0}' tem {1} caracter", palavra,palavra.Length);

            int length = palavra.Length;
            Console.ReadLine();
        

        }

        static void Exe02()
        {
            //ToCharArray
            //Copia os caracteres em uma subcadeia de caracteres especificada nesta
            //instância para uma matriz de caracteres Unicode

            string palavra = " ";
            Console.WriteLine("Entre com qualquer palavra", palavra); palavra = Console.ReadLine();
            char[] chars = palavra.ToCharArray();
            Console.WriteLine("Original string: {0}", palavra);
            Console.WriteLine("Character array:");
            for (int ctr = 0; ctr < chars.Length; ctr++)
            {
                Console.WriteLine("   {0}: {1}", ctr, chars[ctr]);
            }
            Console.ReadLine();


        }

        static void Exe03()
        {
            // Trim
            //Retorna uma nova cadeia de caracteres na qual
            //todas as ocorrências à esquerda e à direita de
            //um conjunto de caracteres especificados da cadeia
            //de caracteres atual são removidas.

            char[] charsToTrim = { '*', ' ', '\'' };
            string banner = "*** Boa Aula ***";
            string result = banner.Trim(charsToTrim);
            Console.WriteLine("Trimmed\n   {0}\nto\n   '{1}'", banner, result);
            Console.ReadLine();


        }

        static void Exe04()
        {
            // Recupera uma subcadeia de caracteres desta instância.
            // A subcadeia de caracteres começa em uma posição de caractere especificado
            // e continua até o final da cadeia de caracteres.   
            string[] info = { "Nome: Ariane", "Estado: SP.",
                   "Numero: 315", "Localização: Campos do Jordão", "Genero: F"};
            int found = 0;

            Console.WriteLine("Informações :");
            foreach (string s in info)
                Console.WriteLine(s);

            Console.WriteLine("\nAs infomações inceridas foram:");
            foreach (string s in info)
            {
                found = s.IndexOf(": ");
                Console.WriteLine("   {0}", s.Substring(found + 2));
            }
            Console.ReadLine();
        }

        static void Exe05()
        {
            //Split
            //Retorna uma matriz de cadeia de caracteres que contém
            //as subcadeias de caracteres nesta instância delimitadas por
            //elementos de uma cadeia de caracteres especificada ou da matriz de caracteres Unicode.

            string s = "Você ganha um pouco. Você perde algus";

            string[] subs = s.Split(' ');

            foreach (var sub in subs)
            {
                Console.WriteLine($"Substring: {sub}");
            }
            Console.ReadLine();
        }

        static void Exe06()
        {
            //Contains
            //Retorna um valor que indica se uma subcadeia especificada ocorre nesta cadeia de caracteres.
            string s1 = "A rápida raposa marrom pula sobre o cachorro preguiçoso";
            string s2 = "raposa";
            bool b = s1.Contains(s2);
            Console.WriteLine("'{0}' está na string '{1}': {2}",
                            s2, s1, b);
            if (b)
            {
                int index = s1.IndexOf(s2);
                if (index >= 0)
                    Console.WriteLine("'{0} começa na posição do personagem {1}",
                     s2, index + 1);
            }
            Console.ReadLine();
        }

        static void Exe07()
        {
            //Ends With
            //Determina se o fim desta instância de cadeia de caracteres
            //corresponde a uma cadeia de caracteres especificada.
            
            String[] strings = { "Isto e uma string.", "Ola!", "Nada.",
               "Sim.", "aleatoria" };
            foreach (var value in strings)
                {
                    bool endsInPeriod = value.EndsWith(".");
                    Console.WriteLine("'{0}' termina em um período: {1}",
                                      value, endsInPeriod);
                }
            Console.ReadLine();

        }

        static void Exe08()
        {
            //Equals
            //Determina se dois objetos String têm o mesmo valor.
            string str1 = "Ola";
            string str2 = "Ola";
            string str3 = "Mundo";

             // Usando Equals para comparar as strings
            bool resultado1 = str1.Equals(str2); // true
            bool resultado2 = str1.Equals(str3); // false
            Console.WriteLine(resultado1 == resultado2);
            Console.WriteLine(resultado2.Equals(resultado2));
            Console.ReadLine();
        }

        static void Exe09()
        {
            //GetType
            //Obtém o Type com o nome especificado, com a
            //execução de uma pesquisa que diferencia maiúsculas de minúsculas.

            string s1 = "Olá C#";
            Console.WriteLine(s1.GetType());
            Console.ReadLine();
        }

        static void Exe10()
        {
            //IndexOf
            //O IndexOf() é usado para obter o índice do caractere
            //especificado presente na string. Ele retorna o índice como um valor inteiro.
            string s1 = "Olá";
            int índice  = s1.IndexOf('e');
            Console.WriteLine(índice);
            Console.ReadLine();

        }

        static void Exe11()
        {
            //Empty
            //Representa a cadeia de caracteres vazia. Este campo é somente leitura.
            var empty = Enumerable.Empty<int>();
            Console.WriteLine($"Total Elemento = {empty.Count()}");
            int[] array = empty.ToArray();
            Console.WriteLine($"Tamanho do array = {array.Length}");
            Console.ReadLine();
        }

        static void Exe12() 
        {
            //Insert
            //o método Insert() é um método String. Ele é usado para retornar uma
            //nova string na qual uma string especificada é inserida em uma posição
            //de índice especificada na instância de string atual.
            // string
            String str = "Como você";

            Console.WriteLine("String Atual " + str);

            // insert GFG at index 5 where string is append
            Console.WriteLine("Nova string: " + str.Insert(5, "vai "));
            Console.ReadLine();

        }

        static void Exe13() 
        {
            //LastIndexOf
            //Relata a posição de índice de base zero da última ocorrência
            //de uma cadeia de caracteres ou um caractere Unicode especificado
            //nesta instância. O método retorna -1 caso o caractere ou a
            //cadeia de caracteres não seja encontrado nessa instância.
            string str = "Ariane";

            // returns last index of 'c'
            int index = str.LastIndexOf('i');

            Console.WriteLine(index);

            Console.ReadLine();

        }

        static void Exe14()
        {
            //Remove
            //Retorna uma nova cadeia de caracteres na qual um
            //número especificado de caracteres da cadeia de caracteres atual é excluído.
            string s = "abc---def";

            Console.WriteLine("Index: 012345678");
            Console.WriteLine("1)     {0}", s);
            Console.WriteLine("2)     {0}", s.Remove(3));
            Console.WriteLine("3)     {0}", s.Remove(3, 3));
            Console.ReadLine();
        }

        static void Exe15() 
        {
            //Replace
            //Retorna uma nova cadeia de caracteres na qual todas as ocorrências
            //de um caractere Unicode especificado ou String na cadeia de caracteres
            //atual são substituídas por outro caractere Unicode especificado ou por String.
            string str = "Hoje é um bom dia lindo ";

            // replaces "lindo" por "estudar" 
            string result = str.Replace("lindo", "para estudar");
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static void Exe16() 
        {
            //StarTsWith
            // Este método é usado para verificar se o início do objeto
            // string corresponde ou não a uma string específica.
            // Se corresponder, ele retorna a string, caso contrário, retorna falso.
            string s1 = "Como você está?";
            bool b1 = s1.StartsWith("c");
            bool b2 = s1.StartsWith("C");
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.ReadLine();

        }

        static void Exe17()
        {
            //ToLower
            //é usado para converter uma string em letras minúsculas.
            //Ele retorna uma string em letras minúsculas.
            string s1 = "Ariane";
            string s2 = s1.ToLower();
            Console.WriteLine(s2);
            Console.ReadLine();

        }

        static void Exe18()
        {
            //Toupper
            //é usado para converter string em letras maiúsculas. Ele retorna uma string.
            string s1 = "Ariane";
            string s2 = s1.ToUpper();
            Console.WriteLine(s2);
            Console.ReadLine();
        }

        static void Exe19()
        {
            //ToString
            //Retorna uma cadeia de caracteres que representa o objeto atual.
            string s1 = "Olá Aiane";
            int a = 123;
            string s2 = s1.ToString();
            string s3 = a.ToString();
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.ReadLine();

        }
       
        static void Main(string[] args)
        {

            int resp;

            do
            {
                resp = Menu();
                switch (resp)
                {
                    case 1:
                        Exe01();
                        break;

                    case 2:
                        Exe02();
                        break;

                    case 3:
                        Exe03();
                        break;

                    case 4:
                        Exe04();
                        break;

                    case 5:
                        Exe05();
                        break;

                    case 6:
                        Exe06();
                        break;

                    case 7:
                        Exe07();
                        break;

                    case 8:
                        Exe08();
                        break;

                    case 9:
                        Exe09();
                        break;

                    case 10:
                        Exe10();
                        break;

                    case 11:
                        Exe11();
                        break;

                    case 12:
                        Exe12();
                        break;

                    case 13:
                        Exe13();
                        break;

                    case 14:
                        Exe14();
                        break;

                    case 15:
                        Exe15();
                        break;

                    case 16:
                        Exe16();
                        break;

                    case 17:
                        Exe17();
                        break;

                    case 18:
                        Exe18();
                        break;

                    case 19:
                        Exe19();
                        break;
                }
            }
            while (resp != 0);

        }
    }
}
