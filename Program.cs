using System;

namespace arrey_vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            int[] idades = new int[10];
            int pessoas, rep, escolha, posi, posia, rep2, rep3, rep5, rep6, rep7;

            rep = 1;
            do
            {  
                Console.WriteLine("Array");
                Console.WriteLine("Quantas pessoas deseja adicionar? (Numero maximo de 10 pessoas)");
                pessoas = int.Parse(Console.ReadLine());
                while (pessoas > 10 || pessoas < 2)
                {
                    Console.WriteLine("Numero maximo de 10 pessoas e numero minimo de 2 pessoas, digite o número novamente: ");
                    pessoas = int.Parse(Console.ReadLine());
                }
                for (var contador = 0; contador < pessoas; contador++)
                {
                    Console.WriteLine("digite o nome");
                    nomes[contador] = Console.ReadLine();
                    while (nomes[contador] == "")
                    {
                        Console.Write("Você nâo digitou nenhum nome \nDigite o nome novamente: ");
                        nomes[contador] = Console.ReadLine();
                    }
                    Console.WriteLine("digite a idade");
                    idades[contador] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Nomes cadastrados");
                Console.WriteLine("-----------------------");
                for (var contador = 0; contador < pessoas; contador++)
                {
                    Console.WriteLine(nomes[contador]);
                    Console.WriteLine(idades[contador]);
                    Console.WriteLine("-----------------------");
                }
                do
                {
                    rep7 = 1;
                    Console.WriteLine("Corrigindo\n[1] Para corrigir nome\n[2] Para corrigir Idade\n[3] Para continuar");
                    escolha = int.Parse(Console.ReadLine());
                    while (escolha != 1 && escolha != 2 && escolha != 3)
                    {
                        Console.WriteLine("Resposta inválida\n[1] Para corrigir nome\n[2] Para corrigir Idade\n[3] Para não corrigir");
                        escolha = int.Parse(Console.ReadLine());
                    }
                    switch (escolha)
                    {
                        case 1:
                            rep3 = 1;
                            do
                            { 
                                do
                                {
                                
                                    Console.WriteLine("Em que posição na lista o nome que você deseja alterar está?\nPosição: ");
                                    posi = int.Parse(Console.ReadLine());
                                    while (posi > pessoas)
                                    {
                                        Console.WriteLine($"Esse numero é inválido, sua lista possui apenas {pessoas} itens");
                                    }
                                    posia = posi - 1;
                                    Console.WriteLine($"Você deseja alterar ''{nomes[posia]}''\n[1] Sim\n[2] Não");
                                    rep2 = int.Parse(Console.ReadLine());
                                    while (rep2 != 1 && rep2 != 2)
                                    {
                                        Console.WriteLine($"Opção inválida\nVocê deseja alterar ''{nomes[posia]}''\n[1] Não\n[2] Sim");
                                        rep2 = int.Parse(Console.ReadLine());
                                    }
                                } while (rep2 == 2);
                                Console.Write("Digite o nome correto: ");
                                nomes[posia] = Console.ReadLine();
                                for (var contador = 0; contador < pessoas; contador++)
                                    {
                                        Console.WriteLine(nomes[contador]);
                                        Console.WriteLine(idades[contador]);
                                        Console.WriteLine("-----------------------");
                                    }
                                Console.WriteLine("Gostaria de corrigir mais algum nome?\n[1] Sim\n[2] Não");
                                rep3 = int.Parse(Console.ReadLine());
                                while (rep3 != 1 && rep3 != 2)
                                {
                                    Console.WriteLine("Resposta invalida.\nDeseja corrigir mais algum nome?\n[1] Sim\n [2] Não");
                                    rep3 = int.Parse(Console.ReadLine());  
                                }
                            } while (rep3 == 1);
                        break;
                        case (2):
                            rep6 = 1;
                            do
                            { 
                                do
                                {
                                
                                    Console.WriteLine("Em que posição na lista a data que você deseja alterar está?\nPosição: ");
                                    posi = int.Parse(Console.ReadLine());
                                    while (posi > pessoas)
                                    {
                                        Console.WriteLine($"Esse numero é inválido, sua lista possui apenas {pessoas} itens");
                                    }
                                    posia = posi - 1;
                                    Console.WriteLine($"Você deseja alterar ''{idades[posia]}''\n[1] Sim\n[2] Não");
                                    rep5 = int.Parse(Console.ReadLine());
                                    while (rep5 != 1 && rep5 != 2)
                                    {
                                        Console.WriteLine($"Opção inválida\nVocê deseja alterar ''{idades[posia]}''\n[1] Não\n[2] Sim");
                                        rep5 = int.Parse(Console.ReadLine());
                                    }
                                } while (rep5 == 2);
                                Console.Write("Digite a data correta: ");
                                idades[posia] = int.Parse(Console.ReadLine());
                                for (var contador = 0; contador < pessoas; contador++)
                                    {
                                        Console.WriteLine(nomes[contador]);
                                        Console.WriteLine(idades[contador]);
                                        Console.WriteLine("-----------------------");
                                    }
                                Console.WriteLine("Gostaria de corrigir mais alguma data?\n[1] Sim\n[2] Não");
                                rep6 = int.Parse(Console.ReadLine());
                                while (rep6 != 1 && rep6 != 2)
                                {
                                    Console.WriteLine("Resposta invalida.\nDeseja corrigir mais algum nome?\n[1] Sim\n [2] Não");
                                    rep6 = int.Parse(Console.ReadLine());  
                                }
                            } while (rep6 == 1);
                        break;
                    } 
                    Console.WriteLine("Deseja corrigir mais algum item?\n[1] Sim\n[2] Não");
                    rep7 = int.Parse(Console.ReadLine());
                    while (rep7 != 1 && rep7 != 2)
                    {
                        Console.WriteLine("Resposta invalida.\nDeseja corrigir mais algum item?\n[1] Sim\n [2] Não");
                        rep7 = int.Parse(Console.ReadLine());  
                    }
                }while(rep7 == 1);
                
                Console.WriteLine("você deseja cadastrar mais alguém?\n[1] Sim\n[2] Não");
                rep = int.Parse(Console.ReadLine());
                while (rep != 1 && rep != 2)
                {
                    Console.WriteLine("Resposta inválida\n[1] Sim\n[2] Não");
                    rep = int.Parse(Console.ReadLine());
                }
            } while (rep == 1);
            Console.WriteLine("Ok, até mais!");
        }
    }
}
