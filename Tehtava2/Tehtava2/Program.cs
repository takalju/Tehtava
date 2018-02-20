using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Tehtava2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Piste> pisteet = new List<Piste>();

            Piste eka = new Piste("ekapiste", 1, 2);
            Piste toka = new Piste("tokapiste", 3, 4);

            pisteet.Add(eka);
            pisteet.Add(toka);

            string s = JsonConvert.SerializeObject(pisteet);

            Console.WriteLine(s);
            Console.ReadLine();

            using (FileStream fs = new FileStream(@"C:\Users\k1600741\OneDrive - Epedu O365\Verkko-ohjelmointi\Tentti\Tehtava2\bindataTentti.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    br.BaseStream.Seek(0, SeekOrigin.Begin);
                    while (br != null && br.BaseStream.Position < br.BaseStream.Length)
                    {
                        string p = br.ReadString();
                        double px = br.ReadDouble();
                        double py = br.ReadDouble();

                        Piste po = new Piste(p, px, py);
                        pisteet.Add(po);


                    }
                }

            }

            string s2 = JsonConvert.SerializeObject(pisteet);
            Console.WriteLine(s2);
            Console.ReadLine();
        }
    }
}
