using DentiSys;
using DentiSys.Screens.PacienteScreen;
using System.Data.SqlClient;

const string CONNECTION_STRING = "Server=localhost;Database=SistemaOdontologico-Dapper;User ID=sa;Password=root; TrustServerCertificate=true";
ConexaoComBanco.Connection = new SqlConnection(CONNECTION_STRING);


ConexaoComBanco.Connection.Open();


MenuPrincipal();

 

ConexaoComBanco.Connection.Close();

static void MenuPrincipal()
{
    Console.Clear();
    Console.WriteLine("-----------------DentiSys---------------");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("O que deseja fazer?:");
    Console.WriteLine();
    Console.WriteLine(" 1 - Gerenciar Pacientes");
    Console.WriteLine();
    Console.WriteLine(" 2 - Gerenciar Dentistas");
    Console.WriteLine();
    Console.WriteLine(" 3 - Gerenciar Planos");
    Console.WriteLine();
    Console.WriteLine(" 4 - Consultas");
    Console.WriteLine();
    Console.WriteLine(" 5 - Relatórios");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Digite abaixo:");
    var opcao = short.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            TelaDeMenuDoPaciente.Load();
            break;
    }
}