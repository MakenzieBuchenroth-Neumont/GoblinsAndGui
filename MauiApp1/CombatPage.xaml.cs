using System;
using Microsoft.Maui.Controls;
using GameLogic;

namespace MauiApp1 {
    public partial class CombatPage : ContentPage {
        private Character character;
        Combat combat;
        DiceRolling dice = new DiceRolling();
        Enemy enemy = new Enemy();
        Random rnd = new Random();
        int r;
        public CombatPage(Character character) {
            combat = new Combat(character);
            InitializeComponent();

            this.character = character;
            //combat.setPlayer(character);
            combat.SetEnemy();
            enemy = combat.getEnemy();

            character.healthPotion = 3;
            character.health = character.maxHealth;
            character.mana = character.maxMana;

            heal.Text = "Healing Potion (" + character.healthPotion.ToString() + ")";

            r = rand14();
        }

        public bool checkDead() {
            if (character.health <= 0) {
                Navigation.PushAsync(new Lose());
                return true;
            }
            else if (combat.getEnemy().health <= 0) {
                Navigation.PushAsync(new Win());
                return true;
            }
            return false;
        }

        public int rand14() {
            int rand = rnd.Next(1, 4);
            return rand;
        }

        public void setBars() {
            checkDead();
            playerHealth.Progress = (float)character.health / character.maxHealth;
            playerMana.Progress = (float)character.mana / character.maxMana;
            enemyHealth.Progress = (float)enemy.health / enemy.maxHealth;
        }

        private void melee_Clicked(object sender, EventArgs e) {
            enemy = combat.OnMelee("Strength", enemy.strength);
            setBars();
        }

        private void range_Clicked(object sender, EventArgs e) {
            enemy = combat.OnRanged("Dexterity", enemy.dexterity);
            setBars();
        }

        private void magic_Clicked(object sender, EventArgs e) {
            enemy = combat.OnMagic("Wisdom", enemy.wisdom);
            setBars();
        }

        private void heal_Clicked(object sender, EventArgs e) {
            if (character.health != character.maxHealth && character.healthPotion != 0) {
                if (character.health == (character.maxHealth - 5) || character.health == (character.maxHealth - 4) || character.health == (character.maxHealth - 3) || character.health == (character.maxHealth - 2) || character.health == (character.maxHealth - 1)) {
                        character.health = character.maxHealth;
                }
                else {
                    character.health += 5;
                    character.healthPotion -= 1;
                    heal.Text = "Healing Potion (" + character.healthPotion.ToString() + ")";
                }
            }
            setBars();
        }
    }
}
