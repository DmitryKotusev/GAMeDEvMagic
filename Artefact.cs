using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract public class Artefact
{
    public int amount { get; set; }
    public int artPwr { get; set; }
    public bool isRsb = false;
    public void ArtPwrRstr(object Artefact, int aPwr)
    {
        if (Artefact.isRsb == true)
            Artefact.artPwr += aPwr;
        else
            Console.WriteLine("Нельзя восстановить силу данного артефакта");
    }
}
