using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GameLogic.Character;

namespace GameLogic {
    public class Combat {
        bool playerTurn = true;
        DiceRolling dice = new DiceRolling();
        public Character playerCharacter;
        public Enemy enemy = new Enemy();

        public void SetEnemy() {
            enemy.setStrength();
            enemy.setHealth();
            enemy.setDexterity();
        }

        public void setPlayer(Character player)
        {
            playerCharacter = player;
        }

        public void OnMelee(string skill, int number) {
                int roll = dice.rollAgainstNumber(skill, number);
                if (roll >= number) {
                    enemy.health -= roll;
                }
                int enemyRoll = dice.rollAgainstNumber(skill, number - 1);
                if (enemyRoll >= number ) {
                    playerCharacter.health -= enemyRoll;
                }
        }

        public void OnRanged(string skill, int number) {
                int roll = dice.rollAgainstNumber(skill, number);
                if (roll <= number) {
                    enemy.health -= roll;
                }
                if (roll > number) {
                    int enemyRoll = dice.rollAgainstNumber(skill, number - 1);
                    playerCharacter.health -= enemyRoll;
                }
        }

        public void OnHeal() {
            if (playerCharacter.healthPotion != 0) {
                playerCharacter.health += 20;
                playerCharacter.healthPotion -= 1;
            }
        }

        public void OnMagic(string skill, int number) {
                int roll = dice.rollAgainstNumber(skill, number);
                if (roll <= number) {
                    enemy.health -= roll;
                    playerCharacter.mana -= 5;
                }
            if (roll > number)
            {
                int enemyRoll = dice.rollAgainstNumber(skill, number - 1);
                playerCharacter.health -= enemyRoll;
            }
        }
    }
}
