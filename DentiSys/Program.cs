using DentiSys;
using DentiSys.Screens;
using DentiSys.Screens.PacienteScreen;
using System.Data.SqlClient;

const string CONNECTION_STRING = "Server=localhost;Database=SistemaOdontologico-Dapper;User ID=sa;Password=root; TrustServerCertificate=true";
ConexaoComBanco.Connection = new SqlConnection(CONNECTION_STRING);


ConexaoComBanco.Connection.Open();


MenuPrincipalScreen.Load();


ConexaoComBanco.Connection.Close();

