﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
namespace Projeto2B.Repositorio

{
    public class Conexao: IDisposable
    {
        private MySqlConnection _connection;
        //Abre a conexao
        public Conexao(string connectionString)
        {
            _connection = new MySqlConnection(connectionString);
            _connection.Open();
        }
        
        public MySqlCommand MySqlCommand()
        {
            return _connection.CreateCommand();
        }
        //Fecha a conexao
        public void Dispose()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
                _connection.Dispose();
            }
        }
        


    }

}

