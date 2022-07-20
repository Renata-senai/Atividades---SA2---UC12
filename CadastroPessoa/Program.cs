using cadastro.Classes;

Console.Clear();
Console.WriteLine(@$"
*****************************************
*  Bem Vindo ao sistema de cadastro de  *
*      pessoas físicas e jurídicas      *
*****************************************
       █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
       █░░╦─╦╔╗╦─╔╗╔╗╔╦╗╔╗░░█
       █░░║║║╠─║─║─║║║║║╠─░░█
       █░░╚╩╝╚╝╚╝╚╝╚╝╩─╩╚╝░░█
       █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");

LoadingBar("Iniciando ", 500, 20);

List<PessoaFisica> listaPf = new List<PessoaFisica>();
List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
*****************************************
*     Escolha uma das opções abaixo:    *
*           1 - Pessoa Física           *
*           2 - Pessoa Jurídica         *
*                                       *
*           0 - Sair                    *
*****************************************
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            string? opcaoPf;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
*****************************************
*     Escolha uma das opções abaixo:    *
*      1 - Cadastrar Pessoa Física      *
*      2 - Listar Pessoa Física         *
*                                       *
*      0 - Voltar ao menu anterior      *
*****************************************
");

                opcaoPf = Console.ReadLine();
                PessoaFisica metodosPf = new PessoaFisica();

                switch (opcaoPf)
                {
                    case "1":

                        PessoaFisica novaPF = new PessoaFisica();
                        Endereco novoEndPf = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa física que deseja cadastrar:");
                        novaPF.nome = Console.ReadLine();

                        // bool datavalida;
                        // do
                        // {
                        //     Console.WriteLine($"Digite a data de nascimento (DD/MM/AAAA):");
                        //     string? dataNascimento = Console.ReadLine();

                        //     datavalida = metodosPf.validarDataNasc(dataNascimento);

                        //     if (datavalida)
                        //     {
                        //         DateTime DataConvertida;
                        //         DateTime.TryParse(dataNascimento, out DataConvertida);

                        //         novaPF.dataNasc = DataConvertida;
                        //     }
                        //     else
                        //     {
                        //         Console.ForegroundColor = ConsoleColor.Red;
                        //         Console.WriteLine("Data Inválida! Por Favor digite uma data válida");
                        //         Console.ResetColor();
                        //         Thread.Sleep(3000);
                        //     }

                        // } while (datavalida == false);

                        // Console.WriteLine($"Digite o número do CPF");
                        // novaPF.cpf = Console.ReadLine();

                        // Console.WriteLine($"Digite o rendimento mensal (Apenas números):");
                        // novaPF.rendimento = float.Parse(Console.ReadLine());

                        // Console.WriteLine($"Digite o logradouro:");
                        // novoEndPf.logradouro = Console.ReadLine();

                        // Console.WriteLine($"Digite o número:");
                        // novoEndPf.numero = int.Parse(Console.ReadLine());

                        // Console.WriteLine($"Digite o complemento (Aperte ENTER para vazio):");
                        // novoEndPf.complemento = Console.ReadLine();

                        // Console.WriteLine($"Este endereço é comercial? S/N:");
                        // string endCom = Console.ReadLine().ToUpper();

                        // if (endCom == "S")
                        // {
                        //     novoEndPf.endComercial = true;
                        // }
                        // else
                        // {
                        //     novoEndPf.endComercial = false;
                        // }

                        // novaPF.endereco = novoEndPf;

                        // listaPf.Add(novaPF);


                        // StreamWriter sw = new StreamWriter($"{novaPF.nome}.txt");
                        // sw.WriteLine(novaPF.nome);
                        // sw.Close();

                        using (StreamWriter sw = new StreamWriter($"{novaPF.nome}.txt"))
                        {
                            sw.WriteLine(novaPF.nome);
                        }



                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(@$"
Cadastro realizado com sucesso!");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        break;

                    case "2":

                        Console.Clear();

//                         if (listaPf.Count > 0)
//                         {
//                             foreach (PessoaFisica cadaPessoa in listaPf)
//                             {
//                                 Console.Clear();
//                                 Console.WriteLine(@$"
// Nome: {cadaPessoa.nome}
// Idade: {(DateTime.Now.Year - cadaPessoa.dataNasc.Year + " anos")}
// Maior de Idade: {(metodosPf.validarDataNasc(cadaPessoa.dataNasc) ? "sim" : "Não")}
// Endereço: {cadaPessoa.endereco.logradouro}, {cadaPessoa.endereco.numero}, {cadaPessoa.endereco.complemento}
// Endereço comercial: {(cadaPessoa.endereco.endComercial ? "sim" : "não")}
// Rendimento: {cadaPessoa.rendimento}
// Imposto devido: {metodosPf.PagarImposto(cadaPessoa.rendimento).ToString("C")}
// ");

//                                 Console.ForegroundColor = ConsoleColor.Blue;
//                                 Console.WriteLine($"Aperte ENTER para continuar!");
//                                 Console.ReadLine();
//                                 Console.ResetColor();

//                             }
//                         }
//                         else
//                         {
//                             Console.ForegroundColor = ConsoleColor.Red;
//                             Console.WriteLine(@$"
//     Lista Vazia!
//                             ");
//                             Thread.Sleep(3000);
//                             Console.ResetColor();
//                         }

                         
                        using (StreamReader sr = new StreamReader("Renata.txt"))
                        {
                            string linha;
                            while ((linha = sr.ReadLine()) != null)
                            {
                                Console.WriteLine($"{linha}");
                                
                            }
                        }

                         Console.WriteLine($"Aperte ENTER para continuar!");
                         Console.ReadLine();

                        break;

                    case "0":

                        break;

                    default:

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@$"Opção Incorreta!");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                        break;
                }



            } while (opcaoPf != "0");


            break;

        case "2":

            string? opcaoPj;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
*****************************************
*     Escolha uma das opções abaixo:    *
*      1 - Cadastrar Pessoa Jurídica    *
*      2 - Listar Pessoa Jurídica       *
*                                       *
*      0 - Voltar ao menu anterior      *
*****************************************
");

                opcaoPj = Console.ReadLine();
                PessoaJuridica metodosPj = new PessoaJuridica();

                switch (opcaoPj)
                {
                    case "1":

                        PessoaJuridica novaPj = new PessoaJuridica();
                        Endereco novoEndPj = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa jurídica que deseja cadastrar:");
                        novaPj.nome = Console.ReadLine();

                        Console.WriteLine($"Digite a razão social da empresa:");
                        novaPj.razaoSocial = Console.ReadLine();

                        Console.WriteLine($"Digite o número do CNPJ");
                        novaPj.cnpj = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento mensal (Apenas números):");
                        novaPj.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro:");
                        novoEndPj.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o número:");
                        novoEndPj.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento (Aperte ENTER para vazio):");
                        novoEndPj.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial? S/N:");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            novoEndPj.endComercial = true;
                        }
                        else
                        {
                            novoEndPj.endComercial = false;
                        }

                        novaPj.endereco = novoEndPj;

                        metodosPj.Inserir(novaPj);                      


                        listaPj.Add(novaPj);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(@$"Cadastro realizado com sucesso!");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        break;

                    case "2":

                        Console.Clear();                        

                        if (listaPj.Count > 0)
                        {

//                              List<PessoaJuridica> ListaPj = metodosPj.LerArquivo();

//                        foreach (PessoaJuridica cadaItem in ListaPj)
//                        {
//                            Console.Clear();
//                                 Console.WriteLine(@$"
// Nome: {cadaItem.nome}
// Razão Social: {cadaItem.razaoSocial}
// CNPJ: {cadaItem.cnpj}, Válido: {(metodosPj.validarCnpj(cadaItem.cnpj) ? "sim" : "não")}
// Endereço: {cadaItem.endereco.logradouro}, {cadaItem.endereco.numero}, {cadaItem.endereco.complemento}
// Endereço comercial: {(cadaItem.endereco.endComercial ? "sim" : "não")}
// Rendimento: {cadaItem.rendimento}
// Imposto devido: {metodosPj.PagarImposto(cadaItem.rendimento).ToString("C")}
// ");

//                                 Console.ForegroundColor = ConsoleColor.Blue;
//                                 Console.WriteLine($"Aperte ENTER para continuar!");
//                                 Console.ReadLine();
//                                 Console.ResetColor();
//                        }

                            foreach (PessoaJuridica cadaPessoaJ in listaPj)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
Nome: {cadaPessoaJ.nome}
Razão Social: {cadaPessoaJ.razaoSocial}
CNPJ: {cadaPessoaJ.cnpj}, Válido: {(metodosPj.validarCnpj(cadaPessoaJ.cnpj) ? "sim" : "não")}
Endereço: {cadaPessoaJ.endereco.logradouro}, {cadaPessoaJ.endereco.numero}, {cadaPessoaJ.endereco.complemento}
Endereço comercial: {(cadaPessoaJ.endereco.endComercial ? "sim" : "não")}
Rendimento: {cadaPessoaJ.rendimento}
Imposto devido: {metodosPj.PagarImposto(cadaPessoaJ.rendimento).ToString("C")}
");

                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine($"Aperte ENTER para continuar!");
                                Console.ReadLine();
                                Console.ResetColor();

                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(@$"
     Lista Vazia!
                            
 
                            ");
                            Thread.Sleep(3000);
                            Console.ResetColor();
                        }
                        break;

                    case "0":

                        break;

                    default:

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@$"                        
  Opção Incorreta!
                        
                      ");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                        break;
                }



            } while (opcaoPj != "0");

            break;

        case "0":
            Console.Clear();
            Console.WriteLine(@$"
 Obrigado por utilizar nosso sistema!
       
            
                 ");
            Thread.Sleep(1500);
            LoadingBar("Finalizando ", 500, 20);

            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opção Incorreta!");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;
    }
    Console.ResetColor();
} while (opcao != "0");

//Barra de Carregamento

static void LoadingBar(string texto, int tempo, int quantidade)
{
    // Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.Green;

    System.Console.Write(texto);

    for (var i = 0; i < quantidade; i++)
    {
        Console.Write("▓");
        Thread.Sleep(tempo);
    }

    Console.ResetColor();
}
