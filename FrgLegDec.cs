using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FrgLegDec : Artefact
{
    public bool isRsb = false;
    /// <summary>
    /// Метод снимающий отравление обьекту класса Person
    /// </summary>
    /// <returns></returns>
    public void DecUsed(Person trgPrs)
    {
        if (amount <= 0)
            Console.WriteLine("У вас нет декокта из лягушачих лапок :(");
        {
            if (trgPrs.state == poisoned)
            {
                if (trgPrs.max_health / 10 < trgPrs.health)
                {
                    trgPrs.state = normal;
                }
                if (trgPrs.max_health / 10 > trgPrs.health)
                {
                    trgPrs.state = weakend;
                }
                amount--;
            }
            else
                Console.WriteLine("Персонаж не отравлен");
        }
    }

}
