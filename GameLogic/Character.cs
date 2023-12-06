using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class Character { 
        public enum Race {
            Human,
            Elf,
            HalfElf,
            Tiefling,
            Dwarf
        }
        public enum Class {
            Wizard,
            Cleric,
            Fighter,
            Bard,
            Druid,
            Rogue,
            Ranger
        }
        public string name { get; set; }
        public int health { get; set; }
        public int maxHealth;
        public int healthPotion = 3;
        public int mana;
        public int maxMana = 10;
        public Race race;
        public Class playerClass { get; set; }

        public int humanHealth = 110;
        public int elfHealth = 80;
        public int halfelfHealth = 90;
        public int tieflingHealth = 90;
        public int dwarfHealth = 90;

    public string SetRace() {
            if (race == Race.Human) {
                maxHealth = humanHealth;
                health = humanHealth;
                mana = maxMana;
                return "Human";
            }
            else if (race == Race.Elf) {
                maxHealth = elfHealth;
                health = elfHealth;
                mana = maxMana;
                return "Elf";
            }
            else if (race == Race.HalfElf) {
                maxHealth = halfelfHealth;
                health = halfelfHealth;
                mana = maxMana;
                return "Half-Elf";
            }
            else if (race == Race.Tiefling) {
                maxHealth = tieflingHealth;
                health = tieflingHealth;
                mana = maxMana;
                return "Tiefling";
            }
            else if (race == Race.Dwarf) {
                maxHealth = dwarfHealth;
                health = dwarfHealth;
                mana = maxMana;
                return "Dwarf";
            }
            health = humanHealth;
            mana = maxMana;
            return "Human";
        }
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int constitution { get; set; }
        public int intelligence { get; set; }
        public int wisdom { get; set; }
        public int charisma { get; set; }

    }
}
