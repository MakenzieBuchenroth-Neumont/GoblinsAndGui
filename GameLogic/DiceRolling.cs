using GameLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic {
    public class DiceRolling {
        Character playerCharacter = new Character();
        public int rollNumber;
        public int min;
        public int max;
        public string race;
        public int numToBeat;
        Random random = new Random();
        public int rollD4() {
            min = 1;
            max = 4;
            rollNumber = random.Next(min, max + 1);

            return rollNumber;
        }
        public int rollD6() {
            min = 1;
            max = 6;
            rollNumber = random.Next(min, max + 1);

            return rollNumber;
        }

        public int rollD8() {
            min = 1;
            max = 8;
            rollNumber = random.Next(min, max + 1);

            return rollNumber;
        }
        public int rollD10() {
            min = 1;
            max = 10;
            rollNumber = random.Next(min, max + 1);

            return rollNumber;
        }

        public int rollD20() {
            min = 1;
            max = 20;
            rollNumber = random.Next(min, max + 1);

            return rollNumber;
        }

        public int rollAgainstNumber(string skill, int numToBeat) {
            // human: +1 to all
            // elf: +2 to dex
            // half-elf: +2 to chr
            // tiefling: +1 to int, +2 to chr
            // dwarf: +2 to con

            rollNumber = rollD20();
            Character.Race race = playerCharacter.race;

            switch (skill)
            {
                case "Strength":
                    switch (race)
                    {
                        case Character.Race.Human:
                            rollNumber += 1;
                            break;
                    }
                    break;
                case "Dexterity":
                    switch (race)
                    {
                        case Character.Race.Human:
                            rollNumber += 1;
                            break;
                        case Character.Race.Elf:
                            rollNumber += 2;
                            break;
                    }
                    break;
                case "Constitution":
                    switch (race)
                    {
                        case Character.Race.Human:
                            rollNumber += 1;
                            break;
                        case Character.Race.Dwarf:
                            rollNumber += 2;
                            break;
                    }
                    break;
                case "Intelligence":
                    switch (race)
                    {
                        case Character.Race.Human:
                            rollNumber += 1;
                            break;
                        case Character.Race.Tiefling:
                            rollNumber += 1;
                            break;
                    }
                    break;
                case "Wisdom":
                    switch (race)
                    {
                        case Character.Race.Human:
                            rollNumber += 1;
                            break;
                    }
                    break;
                case "Charisma":
                    switch (race)
                    {
                        case Character.Race.Human:
                            rollNumber += 1;
                            break;
                        case Character.Race.HalfElf:
                            rollNumber += 2;
                            break;
                        case Character.Race.Tiefling:
                            rollNumber += 2;
                            break;
                    }
                    break;
            }

            return rollNumber;
        }
    }
}
