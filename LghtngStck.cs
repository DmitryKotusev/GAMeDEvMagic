using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LghtngStck : Artefact
{
    public bool isRsb = true;
    /// <summary>
    /// Метод снимающий здоровье обьекту класса Person
    /// </summary>
    /// <returns></returns>
    public void LghtngUsed(Person trgPrs, int UsedArtPwr)
    {
        if (amount <= 0)
            Console.WriteLine("У вас нет посоха :(");
        {
            if (UsedArtPwr > 0)
            {
                trgPrs.health -= UsedArtPwr;
                artPwr -= UsedArtPwr;
                if (trgPrs.health <= 0)
                    trgPrs.State == dead;
            }
            else
                Console.WriteLine("Посох не сработал. Возможно вы вложили слишком мало силы");
        }
    }

}
