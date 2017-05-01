using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Poisoned
{
	public Poisoned(Person trgPrs, int UsedArtPwr)
	{
        int time = UsedArtPwr / 5;
        for (int i = 0; i < time; i++)
        {
            if (trgPrs.health <= 0)
            {
                trgPrs.State == dead;
                break; 
            }
            else
            {
                if (trgPrs.State == poisoned)
                    trgPrs.health -= UsedArtPwr / time;
                else break;
            }
            System.Threading.Thread.Sleep(1000);
        }
	}
}
