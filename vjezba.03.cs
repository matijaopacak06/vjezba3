using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba03
{
    class stablo
    {
        bool otpadajuListovi;
        string vrstaStabla;

        public bool OtpadajuListovi { get => otpadajuListovi; set => otpadajuListovi = value; }
        public string VrstaStabla { get => vrstaStabla; set => vrstaStabla = value; }
    }
    public stablo (bool otpadajuListovi)
    {
        this.otpadajuListovi = otpadajuListovi;
    }
    public override string ToString()
    {
        string ispis = "ovo je stablo";
        if (otpadajuListovi)
        {
            ispis += "Listopadno";
        }
        else
        {
            ispis += "zimzeleno";
        }
        return ispis;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Stablo stablo = new stablo(false);
            stablo stablo2 = new stablo(true);
            Console.WriteLine(stablo.ToString());
            Console.WriteLine(stablo.ToString());
            Console.ReadLine();
        }
    }
}
