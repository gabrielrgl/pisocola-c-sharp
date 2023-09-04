using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Pisocola.control;

namespace Pisocola
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            verifyEntities();
            Application.Run(new Frm_Initial_Menu());
        }

        //Aciona rotina para verificação e alteração de dados sensíveis à usuários
        private static void verifyEntities()
        {
            int currentMonth = Convert.ToInt32(DateTime.Now.ToString("MM"));

            if(currentMonth == 6)
            {
                Console.WriteLine("Fazendo verificação de entidades...");

                MySqlConnection c = MySqlConnectionConfig.GetConnection();
                c.Open();

                MySqlCommand cmd = new MySqlCommand("verify_entities", c);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                c.Close();
            }
        }
    }
}
