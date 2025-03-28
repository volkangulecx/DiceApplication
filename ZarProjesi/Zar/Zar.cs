using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zar
{
    public class Zar
    {

        private Random random;
        public Zar() 
        {
            random = new Random(); // Rastgele sayı üretimi için

        }

        public int ZarAt()
        {
            return random.Next(1, 7); // 1 ile 6 arasında rastgele sayı üretir
        }
    }
}
