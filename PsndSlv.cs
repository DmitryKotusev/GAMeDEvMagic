using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PsndSlv : Artefact
{
    public bool isRsb = true;
    /// <summary>
    /// Метод отравляяющий обьект класса Person
    /// </summary>
    /// <returns></returns>
    public void PsndSlvUsed(Person trgPrs, int UsedArtPwr)
    {
        if (amount <= 0)
            Console.WriteLine("У вас нет ядовитой слюны :(");
        {
            if (UsedArtPwr > 0)
            {
                trgPrs.State == poisoned;
                Poisoned(trgPrs, UsedArtPwr);
                artPwr -= UsedArtPwr;
            }
            else
                Console.WriteLine("Яд в слюне не подействовал. Возможно вы вложили слишком мало силы");
        }
    }

}
