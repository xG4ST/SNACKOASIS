﻿using System;
using MySql.Data.MySqlClient;

namespace Proyecto_OASIS.MySql
{
    class Connection
    {
        private static string Server = "127.0.0.1";
        private static string Database = "snack_db";
        private static string User = "root";
<<<<<<< HEAD
        private static string Password = "2000";
=======
        private static string Password = "123456";
>>>>>>> 1aaaccf1c572ba167da07b588baf87c6059786cd

        private static string StrConnection = $"server={Server}; database={Database}; Uid={User}; pwd={Password}";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn;
            try
            {
                conn = new MySqlConnection(StrConnection);
                conn.Open();
                Console.WriteLine("Conectado con exito");
            } catch(Exception e)
            {
                conn = null;
                Console.WriteLine(e);
            }

            return conn;
        }

        public static void Close(MySqlConnection conn)
        {
            try
            {
                conn.Close();
            } catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }        

    }
}
