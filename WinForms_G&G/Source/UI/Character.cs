using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_Diners_Drive_Ins_Dragons_Dives.UI {
    public class Character : INotifyPropertyChanged{

        public string name { get; set; }
        public int health { get; set; }
        public int maxHealth;
        public int healthPotion = 3;
        public int mana;
        public int maxMana = 10;
        public GameLogic.Character.Race race;
        public GameLogic.Character.Class playerClass { get; set; }

        public int humanHealth = 11;
        public int elfHealth = 8;
        public int halfelfHealth = 9;
        public int tieflingHealth = 9;
        public int dwarfHealth = 9;
        public int strength;
        public int dexterity;
        public int constitution;
        public int intelligence;
        public int wisdom;
        public int charisma;

        public event PropertyChangedEventHandler PropertyChanged;

        public Character()
        {
            strength = 0;
            dexterity = 0;
            constitution = 0;
            intelligence = 0;
            wisdom = 0;
            charisma = 0;

        }
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public int Constitution {
            get {
                return this.constitution;
            }
            set {
                this.constitution = value;
                NotifyPropertyChanged();
            }
        }

        public int Dexterity {
            get {
                return this.dexterity;
            }
            set {
                this.dexterity = value;
                NotifyPropertyChanged();
            }
        }

        public int Strength {
            get {
                return this.strength;
            }
            set {
                this.strength = value;
                NotifyPropertyChanged();
            }
        }

        public int Intelligence
        {
            get
            {
                return this.intelligence;
            }
            set
            {
                this.intelligence = value;
                NotifyPropertyChanged();
            }
        }

        public int Wisdom {
            get {
                return this.wisdom;
            }
            set {
                this.wisdom = value;
                NotifyPropertyChanged();
            }
        }

        public int Charisma {
            get {
                return this.charisma;
            }
            set {
                this.charisma = value;
                NotifyPropertyChanged();
            }
        }
    }
}
