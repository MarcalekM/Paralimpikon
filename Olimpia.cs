using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paralimpikon
{
    internal class Olimpia
    {
        public int Ev {  get; set; }
        public string Orszag { get; set; }
        public string Varos { get; set; }
        public int Arany { get; set; }
        public int Ezust { get; set; }
        public int Bronz { get; set; }

        public Olimpia(string sor) {
            var t = sor.Split(';');
            Ev = int.Parse(t[0]);
            Orszag = t[1];
            Varos = t[2];
            Arany = int.Parse(t[3]);
            Ezust = int.Parse(t[4]);
            Bronz = int.Parse(t[5]);
        }

        public override string ToString()
        {
            return $"\tÉv:\t\t{Ev}\n\tOrszág:\t\t{Orszag}\n \tVáros:\t\t{Varos}\n\tEredmények:\tArany: {Arany} | Ezüst: {Ezust} | Bronz: {Bronz}";
        }
    }
}
