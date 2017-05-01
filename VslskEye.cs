using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class VslskEye : Artefact
{
    public bool isRsb = false;
    /// <summary>
    /// Метод парализующий обьект класса Person
    /// </summary>
    /// <returns></returns>
    public void DecUsed(Person trgPrs)
    {
        if (amount <= 0)
            Console.WriteLine("У вас нет глаза василиска :(");
        else
        {
            if (trgPrs.state != dead)
            {
                trgPrs.State == paralyzed;
                Paralyzed();
                amount--;
            }
            else
                Console.WriteLine("Мертвого персонажа нельзя парализовать");
        }
    }

}
