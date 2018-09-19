using CalculaImc.Domain.Interfaces;
using CalculaImc.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CalculaImc.Infra.Data.Repository
{
    public class DatabaseContext
    {
        static DatabaseContext DatabaseSingleton;
        static SQLiteAsyncConnection Conn;

       
        public static SQLiteAsyncConnection Database
        {
            get
            {
                if (DatabaseSingleton == null)
                    DatabaseSingleton = new DatabaseContext();
                return Conn;
            }
        }

        public DatabaseContext()
        {
            var caminhoBancoDeDados = DependencyService.Get<IDatabaseFile>().GetFilePath("calculaimc.db3");
            Conn = new SQLiteAsyncConnection(caminhoBancoDeDados);
            Conn.CreateTableAsync<CalculoPessoa>().Wait();
        }

    }
}
