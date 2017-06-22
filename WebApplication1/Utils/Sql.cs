using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace WebApplication1.Utils
{
    public static class Sql
    {
        public static MySqlConnection OpenConnection()
        {
            string server, database, usuario, senha;

            server = "br520.hostgator.com.br";
            database = "ferso217_testecrud";
            usuario = "ferso217_diogo";
            senha = "182421Nj";

            string CONFIG = ("Persist Security Info=False;server=" + server + ";database=" + database + ";uid=" + usuario + ";server=" + server + ";database=" + database + ";uid=" + usuario + ";pwd=" + senha);

            MySqlConnection conn = new MySqlConnection(CONFIG);
            //var command = conn.CreateCommand();
            conn.Open();
            return conn;
        }
    }
}