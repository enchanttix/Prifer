using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Prifer
{
    internal class Kod
    {
        /// <summary>
        /// структура для обращения к переменным в листе
        /// </summary>
        struct rids 
        {
            public int start;
            public int end;
        }

        List<rids> listRids = new List<rids>();

        /// <summary>
        /// запись исходных данных в лист
        /// </summary>
        void initialData() 
        {
            using (StreamReader sr = new StreamReader("1.txt"))
            {
                while (sr.EndOfStream != true)
                {
                    string[] tree = sr.ReadLine().Split(' ');
                    rids rids = new rids();
                    rids.start = int.Parse(tree[0]);
                    rids.end = int.Parse(tree[1]);
                    listRids.Add(rids);
                }
            }
        }

        /// <summary>
        /// поиск ребра с минимальным листом
        /// </summary>
        /// <returns>возвращает номер строки с минимальным элементом</returns>
        int element()
        {
            int perv = 0;
            bool flag = true;
            int min = 0;
            int index = 0;
            foreach (rids ele in listRids)
            {
                if (perv==0)// берем первый элемент, сделали так чтоб программка была аля адаптивнее
                {
                    for (int i = 0; i < listRids.Count; i++)
                    {
                        if (listRids[i].start == ele.end)
                        {
                            flag = false;
                        }
                    }
                    if (flag)
                    {                       
                        min = ele.end;
                        perv++;                       
                    }
                }
                else// после того как он взял первый элемент будет заходить сюда в каждом круге и проверять нет ли элемента меньше
                {
                    if (ele.end < min)
                    {
                        for (int i = 0; i < listRids.Count; i++)
                        {
                            if (listRids[i].start == ele.end)
                            {
                                flag = false;
                            }
                        }
                        if (flag)
                        {
                            min = ele.end;
                        }
                    }
                }
                flag = true;
            }

            
            for (int i = 0; i < listRids.Count; i++)// возвращаем не сам элемент, а его индекс тк записывать мы должны вершину из которой выходит минимальный элемент
            {
                if (min == listRids[i].end)
                {
                    index = i;
                }
            }
            return index;
        }
        /// <summary>
        /// запись самого кода
        /// </summary>
        /// <returns>возврашает строку закодированного дерева</returns>
        string prufer()
        {
            string code = "";
            int n = listRids.Count - 1;
            for (int i = 0; i < n; i++)
            {
                int index = element();
                code += listRids[index].start + " ";
                listRids.RemoveAt(index);
            }
            return code;
        }
        
        /// <summary>
        /// запись данных в итоговый файл 
        /// </summary>
        public void total()
        {
            initialData();
            using (StreamWriter str = new StreamWriter("2.txt"))
            {
                str.WriteLine(prufer());
            }
        }     
    }
}
