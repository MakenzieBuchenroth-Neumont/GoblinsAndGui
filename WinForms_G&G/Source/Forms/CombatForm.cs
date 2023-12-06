using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLogic;

namespace Dungeons_Diners_Drive_Ins_Dragons_Dives.Source.Forms
{
    public partial class CombatForm : Form
    {
        Combat combat = new Combat();
        Controller controller;
        bool playerTurn = true;
        public CombatForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        public void setController(Controller controller, Character player)
        {
            this.controller = controller;
            combat.setPlayer(player);
            combat.SetEnemy();
        }

        private void button_melee_Click(object sender, EventArgs e)
        {
            Panel meleeOverlayPanel = new Panel();
            if (playerTurn)
            {
                button_melee.Enabled = true;
                this.Controls.Remove(meleeOverlayPanel);
                combat.OnMelee("Strength", combat.enemy.setStrength());
            }
            else if (!playerTurn)
            {
                button_melee.Enabled = false;
                meleeOverlayPanel.BackColor = Color.Transparent;
                meleeOverlayPanel.Size = button_melee.Size;
                meleeOverlayPanel.Location = button_melee.Location;
            }
        }

        private void button_ranged_Click(object sender, EventArgs e)
        {
            Panel rangedOverlayPanel = new Panel();
            if (playerTurn)
            {
                button_ranged.Enabled = true;
                this.Controls.Remove(rangedOverlayPanel);
                combat.OnRanged("Dexterity", combat.enemy.setDexterity());
            }
            else if (!playerTurn)
            {
                button_ranged.Enabled = false;
                rangedOverlayPanel.BackColor = Color.Transparent;
                rangedOverlayPanel.Size = button_ranged.Size;
                rangedOverlayPanel.Location = button_ranged.Location;
            }
        }

        private void button_healthPotion_Click(object sender, EventArgs e)
        {
            Panel healthPotionOverlayPanel = new Panel();
            if (playerTurn && combat.playerCharacter.health != combat.playerCharacter.maxHealth)
            {
                button_healthPotion.Enabled = true;
                this.Controls.Remove(healthPotionOverlayPanel);
                combat.OnHeal();
            }
            else if (playerTurn && combat.playerCharacter.health == combat.playerCharacter.maxHealth)
            {
                button_healthPotion.Enabled = false;
                this.Controls.Remove(healthPotionOverlayPanel);
            }
            else if (!playerTurn)
            {
                button_healthPotion.Enabled = false;
                healthPotionOverlayPanel.BackColor = Color.Transparent;
                healthPotionOverlayPanel.Size = button_healthPotion.Size;
                healthPotionOverlayPanel.Location = button_healthPotion.Location;
            }
        }

        private void button_magic_Click(object sender, EventArgs e)
        {
            Panel magicOverlayPanel = new Panel();
            if (playerTurn && combat.playerCharacter.mana != 0)
            {
                button_magic.Enabled = true;
                this.Controls.Remove(magicOverlayPanel);
                combat.OnMagic("Wisdom", combat.enemy.setWisdom());
            }
            else if (!playerTurn || combat.playerCharacter.mana == 0)
            {
                button_magic.Enabled = false;
                magicOverlayPanel.BackColor = Color.Transparent;
                magicOverlayPanel.Size = button_magic.Size;
                magicOverlayPanel.Location = button_magic.Location;
            }
        }

        private void CombatForm_Shown(object sender, EventArgs e)
        {
            button_healthPotion.Text = "Health Potion (" + combat.playerCharacter.healthPotion.ToString() + ")";
            healthBar.Maximum = combat.playerCharacter.maxHealth;
            healthBar.Value = combat.playerCharacter.health;
            progressBar_enemyHealth.Maximum = combat.enemy.maxHealth;
            progressBar_enemyHealth.Value = combat.enemy.health;
            manaBar.Maximum = combat.playerCharacter.maxMana;
            manaBar.Value = combat.playerCharacter.mana;

            Console.WriteLine("Max Health: " + combat.playerCharacter.maxHealth);
            Console.WriteLine("Health: " + combat.playerCharacter.health);
            Console.WriteLine("Max Mana: " + combat.playerCharacter.maxMana);
            Console.WriteLine("Mana: " + combat.playerCharacter.mana);
        }

        private void timer_tick(object sender, EventArgs e)
        {
            if (combat.playerCharacter.health <= 0 || combat.enemy.health <= 0)
            {
                controller.newEventCharacter(this);
            }
            else
            {
                if (combat.playerCharacter.health < 0)
                {
                    healthBar.Value = 0;
                }
                else
                {
                    healthBar.Value = combat.playerCharacter.maxHealth;
                }
                if (combat.playerCharacter.mana < 0)
                {
                    manaBar.Value = 0;
                }
                else
                {
                    manaBar.Value = combat.playerCharacter.mana;
                }
                if (combat.enemy.health < 0)
                {
                    progressBar_enemyHealth.Value = 0;
                }
                else
                {
                    progressBar_enemyHealth.Value = combat.enemy.health;
                }
                button_healthPotion.Text = "Health Potion (" + combat.playerCharacter.healthPotion.ToString() + ")";
            }
        }
    }
}
