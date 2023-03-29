using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lista4PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int program;

            Console.WriteLine("escreva o numero do exercicio desejado: ");
            program = int.Parse(Console.ReadLine());

            switch (program)
            {
                case 1:
                    Console.WriteLine("Não é possivel fazer a atribuição destas variaveis de maneira direta, antes precisamos usar o comando '*nome da variavel que deseja converter*.Parse(Console.ReadLine());'");
                    break;

                case 2:
                    Console.WriteLine("O 'Console.Readline()' lê o valor digitado pelo usuario e o retorna o valor da linha inteira. Já o 'Console.Read()' lê o numero digitado pelo usuario e retorna o primeiro digito em ASCII");
                    break;

                case 3:
                    Console.WriteLine("int = necessário para a leitura de numeros inteiros. Ex. 1; float = necessário para a leitura de numeros com uma casa após a virgula. Ex. 1,5; double: necessário para numeros com duas ou mais casas após a virgula. Ex. 1,566.");
                    break;

                case 4:
                    Console.WriteLine("A função deste codigo é retornar mensagens dependendo do numero digitado pelo usuario, usando as limitações da variavel 'int'. Ao digitar '8', o programa retorna a mensagem 1, ao digitar '27' o programa retorna a mensagem 1 e ao digitar '28' o programa retorna a mensagem 1.");
                    break;

                case 5:
                    double s, so, v, t;

                    Console.WriteLine("qual é a posição inicial? ");
                    so = int.Parse(Console.ReadLine());
                    Console.WriteLine("qual é a posição final? ");
                    s = int.Parse(Console.ReadLine());
                    Console.WriteLine("qual é a velocidade? ");
                    v = int.Parse(Console.ReadLine());
                    Console.WriteLine("qual é o tempo? ");
                    t = int.Parse(Console.ReadLine());

                    s = so + v * t;

                    Console.WriteLine("a posição final é:" + s);
                    break;

                case 6:

                    int n;

                    Console.WriteLine("digite um numero: ");
                    n = int.Parse(Console.ReadLine());

                    if (n % 3 == 0)
                    {
                        Console.WriteLine("O numero é divisivel por 3");
                    }

                    else
                    {
                        Console.WriteLine("o numero não é divisivel por 3");
                    }

                    if (n % 5 == 0)
                    {
                        Console.WriteLine("o numero é divisivel por 5");
                    }

                    else
                    {
                        Console.WriteLine("o numero não é divisivel por 5");
                    }

                    if (n % 10 == 0)
                    {
                        Console.WriteLine("o numero é divisivel por 10");
                    }

                    else
                    {
                        Console.WriteLine("o numero não é divisivel por 10");
                    }
                    break;

                case 7:
                    int tempo, km;

                    Console.WriteLine("qual o km da sua casa? :");
                    km = int.Parse(Console.ReadLine());

                    if (km <= 12 && km >= 0)
                    {
                        tempo = 14 + 17 + 13 + 15 + 12;
                        Console.WriteLine("voce ira demorar: " + tempo + " minutos");
                    }

                    else if (km <= 29 && km > 12)
                    {
                        tempo = 17 + 13 + 15 + 12;
                        Console.WriteLine("voce ira demorar: " + tempo + " minutos");
                    }
                    else if (km <= 55 && km > 29)
                    {
                        tempo = 13 + 15 + 12;
                        Console.WriteLine("voce ira demorar: " + tempo + " minutos");
                    }
                    else if (km <= 82 && km > 55)
                    {
                        tempo = 15 + 12;
                        Console.WriteLine("voce ira demorar: " + tempo + " minutos");
                    }
                    else if (km <= 100 && km > 82)
                    {
                        tempo = 12;
                        Console.WriteLine("voce ira demorar: " + tempo + " minutos");
                    }
                    break;

                case 8:

                    int marca, quant;
                    double valor, custo, custot, imposto, ll;

                    Console.WriteLine("1- Royal \n 2- Wiskas \n 3- Golden \n 4- Nutrien \n 5- Specialcat \n 6- Marba \n 7- Gatus \n  Digite o numero do produto desejado: ");
                    marca = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a quantidade");
                    quant = int.Parse(Console.ReadLine());

                    switch (marca)
                    {
                        case 1:
                            valor = 129.50 * quant;
                            custo = valor * 0.775;
                            custot = valor - custo;
                            imposto = custot * 0.33;
                            ll = ((valor - custo) - imposto);

                            Console.WriteLine("O lucro liquido é de: R$" + ll);
                            break;

                        case 2:
                            valor = 182.78 * quant;
                            custo = valor * 0.897;
                            custot = valor - custo;
                            imposto = custot * 0.275;
                            ll = (valor - custo) - imposto;

                            Console.WriteLine("O lucro liquido é de: R$" + ll);
                            break;

                        case 3:
                            valor = 159.46 * quant;
                            custo = valor * 0.717;
                            custot = valor - custo;
                            imposto = custot * 0.225;
                            ll = (valor - custo) - imposto;

                            Console.WriteLine("O lucro liquido é de: R$" + ll);
                            break;

                        case 4:
                            valor = 144.80 * quant;
                            custo = valor * 0.889;
                            custot = valor - custo;
                            imposto = custot * 0.25;
                            ll = (valor - custo) - imposto;

                            Console.WriteLine("O lucro liquido é de: R$" + ll);
                            break;

                        case 5:
                            valor = 205.40 * quant;
                            custo = valor * 0.8324;
                            custot = valor - custo;
                            imposto = custot * 0.22;
                            ll = (valor - custo) - imposto;

                            Console.WriteLine("O lucro liquido é de: R$" + ll);
                            break;

                        case 6:
                            valor = 125.10 * quant;
                            custo = valor * 0.904;
                            custot = valor - custo;
                            imposto = custot * 0.179;
                            ll = (valor - custo) - imposto;

                            Console.WriteLine("O lucro liquido é de: R$" + ll);
                            break;

                        case 7:
                            valor = 133.99 * quant;
                            custo = valor * 0.946;
                            custot = valor - custo;
                            imposto = custot * 0.20;
                            ll = (valor - custo) - imposto;

                            Console.WriteLine("O lucro liquido é de: R$" + ll);
                            break;
                    }
                    

                    break;

                default:
                    Console.WriteLine("opção invalida!");
                    break;
            }
        }
    }
}
