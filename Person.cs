using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Person : IComparable // класс «персонаж ролевой игры»
    {
       

        static int main_ID { get; set; } // общий для всех объектов класса числовой идентификатор 
        int ID { get; set; }  // уникальный числовой идентификатор
        public string name { get; set; } // имя персонажа
        public bool gender { get; set; } // пол true - жен, false - муж
        public races race { get; set; } // раса  (человек, гном, эльф, орк, гоблин)
        public states state { get; set; } //состояние (нормальное, ослаблен, болен, отравлен, парализован, мёртв)
        public bool abil_to_speak { get; set; }  // возможность разговаривать в текущий момент времени
        public bool abil_to_move { get; set; }// возможность двигаться в текущий момент времени
        public int age { get; set; } // возраст
        public uint health { get; set; } // текущее значение здоровья персонажа (неотрицательная величина)
        public uint max_health { get; set; } //максимальное значение для здоровья персонажа
        public int experience { get; set; } // количество опыта, набранное персонажем

        public Person()
            // конструктор по умолчанию
        {
            this.ID = main_ID;
            main_ID++;
            this.name = "Галя";
            this.race = races.гном;
            this.gender = true;
            this.state = states.нормальное;
            this.abil_to_speak = true; 
            this.abil_to_move = true;
            this.age = 0;
            this.health = max_health;
            this.experience = 0;

        }
        public Person (string n, races r, bool g)
        /*конструктор, задающий значения неизменяемых полей и 
         обеспечивающий уникальность идентификатора для нового объекта*/
        {
            this.ID = main_ID;
            main_ID++;
            this.name = n;
            this.race = r;
            this.gender = g;
            this.state = states.нормальное;
            this.abil_to_speak = true; // ?
            this.abil_to_move = true; // ?
            this.age = 0;
            this.health = max_health;
            this.experience = 0;


        }

        public int CompareTo(object obj)
        //сравнение персонажей по опыту через реализацию интерфейса IComparable
        {
            if (!(obj is Person))
                throw new ArgumentException("argument is not a Character");
            Person another_person = (Person)obj;
            if (this.experience > another_person.experience)
                return 1;
            if (this.experience < another_person.experience)
                return -1;
            return 0;
        }

        void Refresh()
            /*если процент здоровья персонажа (отношение текущего здоровья персонажа
к максимальному количеству здоровья) становится менее 10, персонаж
автоматически переходит из состояния «нормальное» в состояние «ослаблен».
Если процент здоровья персонажа становится большим или равным 10,
персонаж автоматически переходит из состояния «ослаблен» в состояние
«нормальное». Если текущее значение здоровья равно 0, персонаж автоматически
переходит из любого состояния в состояние «мертв»*/
        {
            double percent = this.health / max_health;
            if (percent < 10 && this.state == states.нормальное)
                this.state = states.ослаблен;
            if (percent >= 10 && this.state == states.ослаблен)
                this.state = states.нормальное;
            if (this.health == 0)
                this.state = states.мёртв;
        }

        public override string ToString()
        //вывод информации о персонаже в строку (через метод ToString)
        {
            return string.Format("ID персонажа - {0},\nИмя персонажа - {1},\nпол - {2},\nраса - {3},\nтекущее состояние - {4},\nвозможность двигаться - {5},\nвозможность разговаривать - {6},\nвозраст - {7},\nздоровье - {8},\nопыт - {9}", this.ID, this.name, this.gender, this.race, this.state, this.abil_to_move, this.abil_to_speak, this.age, this.health, this.experience);
        }

    }

    public enum states : int
    {
        нормальное, // 0
        ослаблен, // 1
        болен, // 2
        отравлен, // 3
        парализован, // 4
        мёртв // 5
    }

    public enum races : int
    {
        человек, // 0
        гном, // 1
        эльф, // 2
        орк, // 3
        гоблин // 4
    }
}
