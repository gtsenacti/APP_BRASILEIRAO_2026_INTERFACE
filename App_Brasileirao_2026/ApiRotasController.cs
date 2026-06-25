using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Brasileirao_2026
{
    public static class ApiRotasController
    {
        private static readonly string baseUrl = "http://127.0.0.1:5000";

        public static string ConsultarSerieA => $"{baseUrl}/SerieA";
        // Adicione mais endpoints aqui, se quiser:
    }
}
