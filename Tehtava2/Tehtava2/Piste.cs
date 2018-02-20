using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tehtava2
{
    class Piste
    {
        public string nimi { get; set; }
        public double x { get; set; }
        public double y { get; set; }

        public Piste()
        {

        }

        public Piste(string nimi, double x, double y)
        {
            this.nimi = nimi;
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return this.nimi + " " + this.x + " " + this.y;
        }

    }
}
