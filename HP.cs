using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HP : Artefact
{
    enum HPSize { sml, med, big };
    public bool isRsb = false;
    /// <summary>
    /// Метод восствавливающий здоровье обьекту класса Person
    /// </summary>
    /// <returns></returns>
    public void AddHlt(Person trgPrs,  HPSize size)
    {
        if (amount <= 0)
            Console.WriteLine("У вас нет бутылки живой воды");
        {
            if (trgPrs.mana != trgPrs.max_mana)
            {
                int ahlt = 0;
                if (size == sml)
                    ahlt = 10;
                if (size == med)
                    ahlt = 25;
                if (size == big)
                    ahlt = 50;
                if (trgPrs.health + ahlt > trgPrs.max_health)
                {
                    ahlt = trgPrs.max_health - trgPrs.health;
                }
                trgPrs.health += ahlt;
                amount--;
            }
            else
                Console.WriteLine("Здоровье персонажа полно");
        }
    }

}
