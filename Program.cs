using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabotaSem13
{
    class Program
    {
        static void Main(string[] args)
        {
            AeroCar auto = new AeroCar("Аэромобиль");
            Tima auto2 = new Tima("Тьма");

            Console.WriteLine("{0} {1} {2} {3}", auto.name, auto.Deistvie(), auto2.name, auto2.Deistvie2());
            Console.ReadKey();
        }
    }

    public class AeroCar
    {
        public string name { get; set; }
        public AeroCar(string name)
        {
            this.name = name;
        }

        public string Deistvie()
        {
            return "Аэромобиль, со скоростью, превышающей R17, вынес их по стальному туннелю на хмурую поверхность Магратеи, объятую мглистыми предрассветными сумерками.";
        }
    }

    public class Tima
    {
        public string name { get; set; }
        public Tima(string name)
        {
            this.name = name;
        }

        public string Deistvie2()
        {
            return "Сквозь тьму уже проступали пятна призрачного серого света.";
        }
    }
}
