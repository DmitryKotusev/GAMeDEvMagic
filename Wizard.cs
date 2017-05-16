using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Wizard : Person 
    {
        public uint mana { get; set; } //текущее значение магической энергии (маны) (неотрицательная величина)
        public uint max_mana { get; set; } //максимальное значение маны

        void Abilities()
            /*Мана расходуется на произнесение заклинаний. Если текущее значение маны
меньше того количества, которое требуется для произнесения какого-либо
заклинания, заклинание не может быть произнесено, а количество маны остается
неизменным.*/
        {
            if (this.mana == 0)
                this.abil_to_speak = false;
        }
    
        public bool Incantation(incantations i )
            /*Некоторые заклинания обладают силой, причем сила заклинания задается
волшебником в момент его произнесения. Расход маны в этом случае
пропорционален силе заклинания. Сила заклинания ограничивается текущим
значением маны.*/
        {
            if (i == incantations.абракадабра)
            {
                Console.WriteLine("Введите силу заклинания ");
                int force = Convert.ToInt32(Console.ReadLine());
                if (force > 0 && force <= this.mana)
                    return this.Abracadabra(force);
                else
                    throw new Exception("Сила заклинания должна быть больше 0 и ограничивается текущим значением маны");
            }
            return false;
        }

        public bool Abracadabra(int force)
        /*Реализовать заклинание «добавление здоровья». Суть этого заклинания – увеличить
текущее значение здоровья какого-либо персонажа(в том числе и себя) до
максимального или до предела, задаваемого текущим значением маны.На единицу
добавленного здоровья расходуется две единицы маны.*/
        {
            Console.WriteLine("Здоровье какого персонажа вы будете улучшать? 1 - себя,  2 - другого");
            int q = Convert.ToInt32(Console.ReadLine());
            if (q == 1)
            { 
                while(this.health != max_health || this.mana < 2)
                {
                    this.mana -= 2;
                    this.health++;
                }
                return true;
            }
            if (q == 2)
            {
                Console.WriteLine("Введите уникальный числовой идентификатор персонажа, здоровье которого вы будете улучшать");
                Person another = new Person(); // здесь надо вставить ссылку на нужного персонажа(а прежде написать функцию поиска)  
                while (another.health != max_health || this.mana < 2)
                {
                    this.mana -= 2;
                    another.health++;
                }
                return true;
            }
            return false;
        }
    }

    public enum incantations // заклинания
    {
        абракадабра // 0
    }
}
