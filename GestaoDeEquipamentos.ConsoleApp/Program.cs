using System;

namespace GestaoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomesEquipamento = new string[1000];
            decimal[] precoEquipamento = new decimal[1000];
            string[] serieEquipamento = new string[1000];
            int[] dataFabricacaoEquipamento = new int[1000];
            string[] fabricanteEquipamento = new string[1000];
            string[] tituloChamado = new string[1000];
            string[] descricaoChamado = new string[1000];
            string[] equipamentoChamado = new string[1000];
            int[] dataAberturaChamado = new int[1000];


            while (true)
            {
                for (int i = 0; i < 5; i++)
                {
                    
                    MenuPrincipal();

                    string opcaoMenu = Console.ReadLine();
                   
                    if (opcaoMenu == "s")
                    {
                        break;
                    }
                       
                    if (opcaoMenu == "1")
                    {
                        string OpcaoSubMenu =  SubMenuEquipamentos(); 
                       

                        if (OpcaoSubMenu == "s")
                            continue;

                        if (OpcaoSubMenu == "1")
                        {
                            Console.Clear();
                            RegistrarNovoEquipamento(nomesEquipamento, precoEquipamento, serieEquipamento, dataFabricacaoEquipamento, fabricanteEquipamento);
                        }

                        if (OpcaoSubMenu == "2")
                        {
                            Console.Clear();
                            VisualizandoEquipamentos(nomesEquipamento, precoEquipamento, serieEquipamento, dataFabricacaoEquipamento, fabricanteEquipamento, i, OpcaoSubMenu);
                        } 

                        if (OpcaoSubMenu == "3")
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Editar Equipamentos");
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Digite qual equipamento você deseja editar: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            
                            //codigo pra fazer a edição
                            
                            Console.WriteLine("\nEquipamento editado com sucesso :-)");
                            Console.ResetColor();

                            Console.ReadLine();


                        }
                        if (OpcaoSubMenu == "4")
                        {

                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Excluir Equipamentos");
                            Console.WriteLine("--------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Informe qual equipamento você deseja excluir: ");
                            Console.ReadLine();

                            //codigo pra excluir :/

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nEquipamento excluído com sucesso :-)");
                            Console.ResetColor();
                        }
                                               
                        if (OpcaoSubMenu == "s")
                            continue;                               
                    }

                    if (opcaoMenu == "2")
                    {
                        SubMenuChamados();

                        string OpcaoSubMenuChamados = Console.ReadLine();

                        if (OpcaoSubMenuChamados == "1")
                        {
                            RegistrarNovoChamado(tituloChamado, descricaoChamado, equipamentoChamado, dataAberturaChamado);

                        }


                        if (OpcaoSubMenuChamados == "2")
                        {
                            VisualizarChamados(tituloChamado, descricaoChamado, equipamentoChamado, dataAberturaChamado, i);
                        }

                        if (OpcaoSubMenuChamados == "3")
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Editar Chamados:");
                            Console.WriteLine();
                            Console.WriteLine("-----------------------------------------------------------------------");
                            Console.WriteLine("Selecione qual chamado você deseja editar: ");

                            //cod pra editar o chamado..

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nChamado editado com sucesso :-)");
                            Console.ResetColor();

                        }
                        if (OpcaoSubMenuChamados == "4")
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Excluir Chamados:");
                            Console.WriteLine();
                            Console.WriteLine("----------------------------------------------------------------------------");
                            Console.WriteLine("Selecione qual chamado você deseja excluir: ");

                            //cod pra exclusao de algum chamado
                            
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nChamado excluído com sucesso :-)");
                            Console.ResetColor();
                        }

                        if (OpcaoSubMenuChamados == "s")
                        {
                            continue;
                        }
                            
                    }
                    Console.ReadLine();
                }
            }  
        }

        private static void VisualizarChamados(string[] tituloChamado, string[] descricaoChamado, string[] equipamentoChamado, int[] dataAberturaChamado, int i)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Visualizar chamados:");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Título: " + tituloChamado[i]);
            Console.WriteLine("Descrição: " + descricaoChamado[i]);
            Console.WriteLine("Equipamento: " + equipamentoChamado[i]);
            Console.WriteLine("Data: " + dataAberturaChamado[i]);
        }

        private static void RegistrarNovoChamado(string[] tituloChamado, string[] descricaoChamado, string[] equipamentoChamado, int[] dataAberturaChamado)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Registrar novo chamado:");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Título do chamado:");
            string titulo = Console.ReadLine();
            tituloChamado[0] = titulo;

            Console.WriteLine("Descrição do chamado:");
            string descricao = Console.ReadLine();
            descricaoChamado[0] = descricao;

            Console.WriteLine("Equipamento:");
            string equipamento = Console.ReadLine();
            equipamentoChamado[0] = equipamento;

            Console.WriteLine("Data de abertura:");
            int dataAbertura = int.Parse(Console.ReadLine());
            dataAberturaChamado[0] = dataAbertura;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Chamado registrado! :) ");
            Console.ResetColor();
        }

        private static void SubMenuChamados()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Controle de Chamados");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Digite '1' para registrar novo chamado");
            Console.WriteLine("Digite '2' para visualizar chamados");
            Console.WriteLine("Digite '3' para editar chamados");
            Console.WriteLine("Digite '4' para excluir chamados");
            Console.WriteLine("Digite 's' para sair");
        }

        private static void VisualizandoEquipamentos(string[] nomesEquipamento, decimal[] precoEquipamento, string[] serieEquipamento, int[] dataFabricacaoEquipamento, string[] fabricanteEquipamento, int i, string OpcaoSubMenu)
        {
            Console.WriteLine("Visualizando Equipamentos");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Nome: " + nomesEquipamento[i]);
            Console.WriteLine("Preço: " + precoEquipamento[i]);
            Console.WriteLine("Serie: " + serieEquipamento[i]);
            Console.WriteLine("Data de fabricação: " + dataFabricacaoEquipamento[i]);
            Console.WriteLine("Fabricante: " + fabricanteEquipamento[i]);
        }

        private static void RegistrarNovoEquipamento(string[] nomesEquipamento, decimal[] precoEquipamento, string[] serieEquipamento, int[] dataFabricacaoEquipamento, string[] fabricanteEquipamento)
        {
            Console.WriteLine("Cadastro de Equipamentos");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Registrando novo equipamento:");
            Console.WriteLine();
            Console.WriteLine("Nome do equipamento com no mínimo 6 caracteres: ");
            string Nome = Console.ReadLine();
            nomesEquipamento[0] = Nome;

            Console.WriteLine("Preço de aquisição: ");
            decimal preco = decimal.Parse(Console.ReadLine());
            precoEquipamento[0] = preco;

            Console.WriteLine("número de série: ");
            string Serie = Console.ReadLine();
            serieEquipamento[0] = Serie;

            Console.WriteLine("Data de fabricação: ");
            int Data = int.Parse(Console.ReadLine());
            dataFabricacaoEquipamento[0] = Data;

            Console.WriteLine("Fabricante: ");
            string Fabricante = Console.ReadLine();
            fabricanteEquipamento[0] = Fabricante;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Equipamento registrado! :D");
            Console.ResetColor();
        }

        private static string SubMenuEquipamentos()
        {
            string OpcaoSubMenu;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine();
            Console.WriteLine("Digite '1' para registrar novo equipamento");
            Console.WriteLine("Digite '2' para visualizar equipamentos");
            Console.WriteLine("Digite '3' para editar equipamentos");
            Console.WriteLine("Digite '4' para excluir equipamentos");
            Console.WriteLine("Digite 's' para sair");
            OpcaoSubMenu = Console.ReadLine();
            return OpcaoSubMenu;
        }

        private static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Digite '1' para o Cadastro de Equipamentos");
            Console.WriteLine("Digite '2' para o Controle de chamados");
            Console.WriteLine("Digite 's' para sair");

        }
    }
}
