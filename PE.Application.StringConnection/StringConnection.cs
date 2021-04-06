using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Application.StringConnection
{
    public static class StringConnection
    {
        public static string DataBase = "PrivateEnglish";

        public static string Server = @"DESKTOP-NDJOGL2\SQLEXPRESS";

        public static string User = "sa";

        public static string Password = "42175";

        public static string GetStringConnection => $"Data Source={Server};" +
                                                        $"Initial Catalog={DataBase};" +
                                                        $"User Id={User};" +
                                                        $"Password ={Password};";

        public static string GetStringConnectionWin => $"Data Source={Server};" +
                                                        $"Initial Catalog={DataBase};" +
                                                        $"Integrated Security=True";


    }
}
