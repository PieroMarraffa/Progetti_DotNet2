using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellulariConFile
{
    internal static class MyList
    {

        public static void ToFile<T>(this List<T> lista, string nomeFile)
        {
            TextWriter tw = File.AppendText(nomeFile);
            foreach (var item in lista)
            {
                tw.WriteLine(item.ToString());
            }
            tw.Close();
        }
    }
}
