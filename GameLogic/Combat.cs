using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static GameLogic.Character;

namespace GameLogic {
    public class Combat {
        bool playerTurn = true;
        DiceRolling dice = new DiceRolling();
        public Character playerCharacter;
        public Enemy enemy = new Enemy();

        public Combat(Character character) {
            this.playerCharacter = character;
        }

        public void SetEnemy() {
            enemy.setStrength();
            enemy.setHealth();
            enemy.setDexterity();
            enemy.setWisdom();
        }

        public Enemy getEnemy()
        {
            return enemy;
        }

        //public void setPlayer(Character player)
        //{
            //playerCharacter = player;
        //}

        public Enemy OnMelee(string skill, int number) {
                int roll = dice.rollAgainstNumber(skill, number);
                if (roll >= number) {
                    enemy.health -= roll;
                }
                int enemyRoll = dice.rollAgainstNumber(skill, number - 1);
                if (enemyRoll >= number ) {
                    playerCharacter.health -= enemyRoll;
                }
                return enemy;
        }

        public Enemy OnRanged(string skill, int number) {
                int roll = dice.rollAgainstNumber(skill, number);
                if (roll <= number) {
                    enemy.health -= roll;
                }
                if (roll > number) {
                    int enemyRoll = dice.rollAgainstNumber(skill, number - 1);
                    playerCharacter.health -= enemyRoll;
                }
                return enemy;
        }

        public void OnHeal() {
            if (playerCharacter.healthPotion != 0) {
                playerCharacter.health += 20;
                playerCharacter.healthPotion -= 1;
            }
        }

        public Enemy OnMagic(string skill, int number) {
                int roll = dice.rollAgainstNumber(skill, number);
                if (roll <= number) {
                    enemy.health -= roll;
                    playerCharacter.mana -= 3;
                }
            if (roll > number)
            {
                int enemyRoll = dice.rollAgainstNumber(skill, number - 1);
                playerCharacter.health -= enemyRoll;
            }
            return enemy;
        }
    }
}
