using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Ksiazka
    {
        public int Id { get; set; }
        public string Tytul { get; set; }
        public int RokWydania { get; set; }
        public Autor Autor { get; set; }
    }
}
