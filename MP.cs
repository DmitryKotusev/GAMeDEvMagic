using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HP : Artefact
{
    enum MPSize { sml, med, big };
    public bool isRsb = false;
    /// <summary>
    /// Метод восствавливающий ману обьекту класса Person
    /// </summary>
    /// <returns></returns>
    public void AddMana(Person trgPrs,  MPSize size)
    {
        if (amount <= 0)
            Console.WriteLine("У вас нет бутылки мертвой воды");
        {
            if (trgPrs.health != trgPrs.max_health)
            {
                int aMana = 0;
                if (size == sml)
                    aMana = 10;
                if (size == med)
                    aMana = 25;
                if (size == big)
                    aMana = 50;
                if (trgPrs.mana + aMana > trgPrs.max_mana)
                {
                    aMana = trgPrs.max_mana - trgPrs.mana;
                }
                trgPrs.mana += aMana;
                amount--;
            }
            else
                Console.WriteLine("Мана персонажа полна");
        }
    }
}
