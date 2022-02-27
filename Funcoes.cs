﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem01
{
    public class Funcoes
    {
        public int Soma(int[] matriz)
        {
            try
            {
                return matriz.Sum();
            }
            catch { return 0; }
        }

        public int Maior(int n1, int n2, int n3, int n4)
        {
            try
            {
                int[] numeros = { n1, n2, n3, n4 };
                return numeros.Max();
            }
            catch { return 0; }
        

        }
    }
}
