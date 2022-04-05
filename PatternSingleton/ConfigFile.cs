using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternSingleton
{
    internal class ConfigFile
    {

        //VARIABILE CHE RAPPRESENTA LA CLASSE STESSA
        private static ConfigFile instance = null;

        private static string username, password;
        

        //IL COSTRUTTORE VA PRIVATO
        private ConfigFile()
        {

        }

        public static ConfigFile Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new ConfigFile();
                    instance.username = "pippo";
                    instance.password = "1234";
                }
                return instance;
            }

        }
    }
}
