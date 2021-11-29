using System;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {

            int escolha = -1;
            int escolhaGerente = -1;
            int escolhaCaixa = -1;
            int escolhaRepositor = -1;
            int escolhaProdutos = -1;

            Funcionarios staff = new Funcionarios();
            //Stock s = Stock.leituraProdutos();
            Stock s = new Stock();
            
            string nomeTemporario, codTemporario, nascTemp;
            string marcaTemporario ;
            bool disponibilidadeTemporario, veganTemporario;
            int quantidadeTemporario;
            int enumTp, opcaoProduto, opcaoPeixe, opcaoCarne,opcaoFruta;
            float precoTemporario;


            while (escolha != 0)
            {
                Console.WriteLine("==========|Menu Principal|==========");
                Console.WriteLine("| 1 - Login                        |");
                Console.WriteLine("| 2 - Criar Funcionario            |");
                Console.WriteLine("| 0 - Sair                         |");
                Console.WriteLine("|__________________________________|");
                Console.WriteLine("|Opcao: ");

                escolha = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (escolha)
                {
                    //============================================================|Fazer Login|============================================
  
                    case 1: 
                        TipoFuncionarios funcionarioSistema = staff.login(Console.ReadLine(), Console.ReadLine()); //Perguntar ao stor

                        if (funcionarioSistema == TipoFuncionarios.Indefenido)
                        {
                            Console.WriteLine("================================================================");
                            Console.WriteLine("|Usuário ou Password esta incorreto, por favor tente novamente.|");
                            Console.WriteLine("|______________________________________________________________|");
                        }
                        else if (funcionarioSistema == TipoFuncionarios.Gerente)
                        {//==========================|Gerente|==========================
                            #region Gerente
                            while (escolhaGerente != 0)
                            {
                                Console.WriteLine("=========================================");
                                Console.WriteLine("|Seja bem-vindo, fez login como Gerente.|");
                                Console.WriteLine("| 1 - Ver todos os Funcionarios         |");
                                Console.WriteLine("| 2 - Apagar Funcionario                |");
                                Console.WriteLine("| 3 - Efetuar uma venda                 |");
                                Console.WriteLine("| 0 - Sair                              |");
                                Console.WriteLine("|_______________________________________|");
                                Console.WriteLine("|Opcao: ");

                                escolhaGerente = int.Parse(Console.ReadLine());

                                Console.Clear();

                                switch (escolhaGerente)
                                {
                                    case 1://=========================|Ver todos os funcionarios|======================

                                        #region Todos os Funcinarios
                                        Console.WriteLine("|= Ver todos os Funcionarios =|");
                                        Console.WriteLine(staff.ToString());

                                        break;
                                    #endregion

                                    case 2://=========================|Apagar um funcionario|==========================

                                        #region Apagar Funcionario
                                        Console.WriteLine("|= Apagar Funcionario");

                                        Console.Write("Indique o funcionario que quer apagar: ");
                                        string funcionarioAApagar = Console.ReadLine();
                                        bool resultado = staff.apagarFuncionario(funcionarioAApagar);

                                        if (resultado)
                                        {
                                            Console.WriteLine("===================================");
                                            Console.WriteLine("|Funcionario apagado com sucesso! |");
                                            Console.WriteLine("|_________________________________|");
                                        }
                                        else
                                        {
                                            Console.WriteLine("===============================================");
                                            Console.WriteLine("|Algo correu mal, por favor tentar novamente! |");
                                            Console.WriteLine("|_____________________________________________|");
                                        }

                                        break;
                                    #endregion

                                    case 3: //=========================|Efetuar Venda|==========================

                                        #region Efectuar Venda
                                        Console.WriteLine("|= Efetuar Venda =|");

                                        break;
                                        #endregion

                                }

                            }
                            #endregion
                        }
                        
                        else if (funcionarioSistema == TipoFuncionarios.Caixa)
                        {//===========================|Caixa|===========================
                            #region Caixa
                            while (escolhaCaixa != 0)
                            {
                                Console.WriteLine("=========================================");
                                Console.WriteLine("|Seja bem-vindo, fez login como Caixa   |");
                                Console.WriteLine("| 1 - Vender Produtos e Criar Fatura    |");
                                Console.WriteLine("| 0 - Sair                              |");
                                Console.WriteLine("|_______________________________________|");
                                Console.WriteLine("|Opcao: ");
                                

                                escolhaCaixa = int.Parse(Console.ReadLine());

                                Console.Clear();

                                switch (escolhaCaixa)
                                {
                                    case 1://=========================|Menu Produtos|====================
                                        while (escolhaProdutos != 0)
                                        {

                                        }

                                        break;

                                    
                                }

                            }
                            #endregion
                        }

                        else if (funcionarioSistema == TipoFuncionarios.Repositor)
                        {//===========================|Repositor|===========================
                            #region Repositor
                            if (escolhaRepositor != 0)
                            {
                                Console.WriteLine("=========================================");
                                Console.WriteLine("|Seja bem-vindo, fez login como Repositor |");
                                Console.WriteLine("| 1 - Ver todos Produtos                  |");
                                Console.WriteLine("| 2 - Criar produto                       |");
                                Console.WriteLine("| 3 - Apagar lista completa               |");
                                Console.WriteLine("| 0 - Sair                                |");
                                Console.WriteLine("|_________________________________________|");
                                Console.WriteLine("|Opcao: ");

                            }
                            escolhaRepositor = int.Parse(Console.ReadLine()); 
                            switch (escolhaRepositor)
                            {
                                case 1://=========================|Ver todos os Produtos|======================

                                    #region Ver todos os Produtos
                                     Console.WriteLine("|= Ver todos os Produtos =|");
                                     Console.WriteLine(s.ToString());

                                    break;
                                #endregion

                                case 2://=========================|Criar produto|==============================

                                    #region Criar produto
                                    Console.WriteLine("|= Criar Produto");


                                    Console.Write("Indique o Marca: ");
                                    marcaTemporario  = Console.ReadLine();

                                    Console.Write("indique Preco: ");
                                    while (!float.TryParse(Console.ReadLine(),out precoTemporario));
                                    

                                    Console.Write("indique Quantidade: ");
                                    while(!int.TryParse(Console.ReadLine(), out quantidadeTemporario));

                                    Console.Write("Existe Disponibilidade: true(sim) | false(nao)  ");
                                    while(!bool.TryParse(Console.ReadLine(), out disponibilidadeTemporario));

                                    Console.Write("e vegan: true(sim) | false(nao) ");
                                    while(!bool.TryParse(Console.ReadLine(), out veganTemporario)) ; ;

                                    Console.WriteLine("Tipo de produto: 1- Peixe | 2- Carne | 3- Fruta ");
                                    while(!int.TryParse(Console.ReadLine(), out opcaoProduto)) ;


                                    switch (opcaoProduto)
                                    {

                                        case 1:
                                            #region Peixe
                                            Console.Write("Tipo de Peixe: 1-Salmao | 2-Robalo | 3- Sardinha | 4-Bacalhau ");
                                            opcaoPeixe = int.Parse(Console.ReadLine());


                                            switch (opcaoPeixe)
                                            {

                                                case 1:
                                                    s.listaPeixes.Add(new Peixe(marcaTemporario, precoTemporario, disponibilidadeTemporario, quantidadeTemporario, veganTemporario, TipoDePeixe.Salmao));
                                                    break;

                                                case 2:
                                                    s.listaPeixes.Add(new Peixe(marcaTemporario, precoTemporario, disponibilidadeTemporario, quantidadeTemporario, veganTemporario, TipoDePeixe.Robalo));
                                                    break;

                                                case 3:
                                                    s.listaPeixes.Add(new Peixe(marcaTemporario, precoTemporario, disponibilidadeTemporario, quantidadeTemporario, veganTemporario, TipoDePeixe.Sardinha));
                                                    break;

                                                case 4:
                                                    s.listaPeixes.Add(new Peixe(marcaTemporario, precoTemporario, disponibilidadeTemporario, quantidadeTemporario, veganTemporario, TipoDePeixe.Bacalhau));
                                                    break;
                                            }

                                            break;

                                            s.saveProduto();
                                        #endregion

                                        case 2:
                                            #region Carne
                                            Console.Write("Tipo de Carne: 1-Vaca | 2-Coelho | 3- Frango ");
                                            opcaoCarne = int.Parse(Console.ReadLine());

                                            switch (opcaoCarne)
                                            {

                                                case 1:
                                                    s.listaCarne.Add(new Carne(marcaTemporario, precoTemporario, disponibilidadeTemporario, quantidadeTemporario, veganTemporario, TipoDeCarne.Vaca));
                                                    break;

                                                case 2:
                                                    s.listaCarne.Add(new Carne(marcaTemporario, precoTemporario, disponibilidadeTemporario, quantidadeTemporario, veganTemporario, TipoDeCarne.Coelho));
                                                    break;

                                                case 3:
                                                    s.listaCarne.Add(new Carne(marcaTemporario, precoTemporario, disponibilidadeTemporario, quantidadeTemporario, veganTemporario, TipoDeCarne.Frango));
                                                    break;


                                            }

                                            break;

                                            s.saveProduto();
                                        #endregion

                                        case 3:
                                            #region Opcao Fruta

                                            Console.Write("Tipo de Fruta: 1-Maca | 2-Banana | 3- Pessego | 4-Ananas | 5- Melancia");
                                            opcaoFruta = int.Parse(Console.ReadLine());

                                            
                                            switch (opcaoFruta)
                                            {

                                                case 1:
                                                    s.listaFruta.Add(new Fruta(marcaTemporario, precoTemporario, disponibilidadeTemporario,quantidadeTemporario, veganTemporario, TipoDeFruta.Maca));
                                                    break;

                                                case 2:
                                                    s.listaFruta.Add(new Fruta(marcaTemporario, precoTemporario, disponibilidadeTemporario, quantidadeTemporario, veganTemporario, TipoDeFruta.Banana));
                                                    break;

                                                case 3:
                                                    s.listaFruta.Add(new Fruta(marcaTemporario, precoTemporario, disponibilidadeTemporario, quantidadeTemporario, veganTemporario, TipoDeFruta.Pessego));
                                                    break;

                                                case 4:
                                                    s.listaFruta.Add(new Fruta(marcaTemporario, precoTemporario, disponibilidadeTemporario, quantidadeTemporario, veganTemporario, TipoDeFruta.Ananas));
                                                    break;

                                                case 5:
                                                    s.listaFruta.Add(new Fruta(marcaTemporario, precoTemporario, disponibilidadeTemporario, quantidadeTemporario, veganTemporario, TipoDeFruta.Malancia));
                                                    break;



                                            }

                                            s.saveProduto();
                                            break;
                                            #endregion
                                    }

                                    break;
                                #endregion

                                case 3://===================|Apagar lista completa |===========================

                                    #region Apagar lista completa 

                                    Console.Write("Indique o produto a apagar: ");
                                    string produtoAApagar = Console.ReadLine();
                                    bool resultado = s.apagarLista(produtoAApagar);



                                    break;

                                    #endregion
                            }

                        }

                        else
                        {
                            #region Erro
                            Console.WriteLine("==========================================================");
                            Console.WriteLine("|Algo inesperado aconteceu, por favor contacte o suporte.|");
                            Console.WriteLine("|________________________________________________________|");
                            #endregion
                        }

                        break;
                    #endregion

                    //==============================================================|Criar Novo Funcionario|===============================

                    #region Criar Novo Funcionario
                    case 2:
                        Console.Write("Introduzir Nome do Funcionario: ");
                        nomeTemporario = Console.ReadLine();

                        Console.Write("Introduzir Palavra-Pass: ");
                        codTemporario = Console.ReadLine();

                        Console.Write("Introduzir Data de Nascimento do Funcionario: ");
                        nascTemp = Console.ReadLine();

                        Console.WriteLine("|1 - Gerente |2 - Caixa |3 - Repositor| ");
                        Console.Write("Introduzir Cargo do Funcionario: ");
                        enumTp = int.Parse(Console.ReadLine());

                        switch (enumTp)
                        {
                            case 1:
                                staff.listaDeFuncionarios.Add(new Funcionario(nomeTemporario, int.Parse(codTemporario), nascTemp, TipoFuncionarios.Gerente));
                                break;
                            case 2:
                                staff.listaDeFuncionarios.Add(new Funcionario(nomeTemporario, int.Parse(codTemporario), nascTemp, TipoFuncionarios.Caixa));
                                break;
                            case 3:
                                staff.listaDeFuncionarios.Add(new Funcionario(nomeTemporario, int.Parse(codTemporario), nascTemp, TipoFuncionarios.Repositor));
                                break;
                        }
                        staff.saveFuncionario();
                        
                        break;
                    #endregion

                    //===================================================|Função Secreta|==================================================
                    #region Top Secret

                    case 15: //Opcao "secreta" para ver lista de Funcionarios sem ser gerente, shhhh
                        Console.WriteLine(staff.ToString());
                        break;
                        #endregion
                }
            }
        }
    }
}
