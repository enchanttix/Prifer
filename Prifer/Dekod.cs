using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Prifer
{
    internal class Dekod
    {
        struct tree
        {
            public int code;
            public int vertex;
        }
        List<tree> listKod = new List<tree>();
        /// <summary>
        /// запись исходных данных в лист
        /// </summary>
        void initialData()
        {
            using (StreamReader sr = new StreamReader("3.txt"))
            {
                while (sr.EndOfStream != true)
                {
                    string[] cod = sr.ReadLine().Split('\n');
                    tree tree = new tree();
                    tree.code = int.Parse(cod[0]);
                    listKod.Add(tree);
                }
                
            }
        }

        public void v()
        {
            initialData();
            for (int i = 0; i < listKod.Count; i++)
            {
                Console.WriteLine("{0} ", listKod[i]);
            }
        }


    }
}
