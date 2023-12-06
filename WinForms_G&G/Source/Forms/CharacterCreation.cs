using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GameLogic.Character;

namespace Dungeons_Diners_Drive_Ins_Dragons_Dives
{
    public partial class CharacterCreation : Form
    {
        GameLogic.DiceRolling roll = new GameLogic.DiceRolling();
        UI.Character playerCharacter;
        //Character gameCharacter;
        Controller controller;
        DialogueForm form2;

        public bool nameEntered = false;
        public bool strengthDone = false;
        public bool dexterityDone = false;
        public bool constitutionDone = false;
        public bool intelligenceDone = false;
        public bool wisdomDone = false;
        public bool charismaDone = false;

        public CharacterCreation()
        {
            InitializeComponent();
            playerCharacter = new UI.Character();
            controller = new Controller();
            initializeCharacterComponents();
        }
        public void setController(Controller controller)
        {
            this.controller = controller;
        }
        private void initializeCharacterComponents()
        {
            text_strengthReadOnly.DataBindings.Add("Text", playerCharacter, "strength", false, DataSourceUpdateMode.OnPropertyChanged);
            text_dexterityReadOnly.DataBindings.Add("Text", playerCharacter, "dexterity", false, DataSourceUpdateMode.OnPropertyChanged);
            text_intelligenceReadOnly.DataBindings.Add("Text", playerCharacter, "intelligence", false, DataSourceUpdateMode.OnPropertyChanged);
            text_constituionReadOnly.DataBindings.Add("Text", playerCharacter, "constitution", false, DataSourceUpdateMode.OnPropertyChanged);
            text_wisdomReadOnly.DataBindings.Add("Text", playerCharacter, "wisdom", false, DataSourceUpdateMode.OnPropertyChanged);
            text_charismaReadOnly.DataBindings.Add("Text", playerCharacter, "charisma", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void onConditionsMet()
        {
            if (nameEntered && strengthDone && dexterityDone && constitutionDone && intelligenceDone && wisdomDone && charismaDone)
            {
                button_submit.Enabled = true;
            }
        }

        private void text_name_TextChanged(object sender, EventArgs e)
        {
            playerCharacter.name = text_name.Text;
            nameEntered = true;
        }

        // race
        private void radio_race_human_CheckedChanged(object sender, EventArgs e)
        {
            playerCharacter.race = GameLogic.Character.Race.Human;
            playerCharacter.maxHealth = playerCharacter.humanHealth;
        }
        private void radio_race_elf_CheckedChanged(object sender, EventArgs e)
        {
            playerCharacter.race = GameLogic.Character.Race.Elf;
            playerCharacter.maxHealth = playerCharacter.elfHealth;
        }
        private void radio_race_halfelf_CheckedChanged(object sender, EventArgs e)
        {
            playerCharacter.race = GameLogic.Character.Race.HalfElf;
            playerCharacter.maxHealth = playerCharacter.halfelfHealth;
        }
        private void radio_race_tiefling_CheckedChanged(object sender, EventArgs e)
        {
            playerCharacter.race = GameLogic.Character.Race.Tiefling;
            playerCharacter.maxHealth = playerCharacter.tieflingHealth;
        }
        private void radio_race_dwarf_CheckedChanged(object sender, EventArgs e)
        {
            playerCharacter.race = GameLogic.Character.Race.Dwarf;
            playerCharacter.maxHealth = playerCharacter.dwarfHealth;
        }

        //class
        private void radio_class_wizard_CheckedChanged(object sender, EventArgs e)
        {
            playerCharacter.playerClass = GameLogic.Character.Class.Wizard;
        }
        private void radio_class_cleric_CheckedChanged(object sender, EventArgs e)
        {
            playerCharacter.playerClass = GameLogic.Character.Class.Cleric;
        }
        private void radio_class_fighter_CheckedChanged(object sender, EventArgs e)
        {
            playerCharacter.playerClass = GameLogic.Character.Class.Fighter;
        }
        private void radio_class_bard_CheckedChanged(object sender, EventArgs e)
        {
            playerCharacter.playerClass = GameLogic.Character.Class.Bard;
        }
        private void radio_class_druid_CheckedChanged(object sender, EventArgs e)
        {
            playerCharacter.playerClass = GameLogic.Character.Class.Druid;
        }
        private void radio_class_rogue_CheckedChanged(object sender, EventArgs e)
        {
            playerCharacter.playerClass = GameLogic.Character.Class.Rogue;
        }
        private void radio_class_ranger_CheckedChanged(object sender, EventArgs e)
        {
            playerCharacter.playerClass = GameLogic.Character.Class.Ranger;
        }
        private void button_strength_roll_Click(object sender, EventArgs e)
        {
            int roll1 = roll.rollD6();
            int roll2 = roll.rollD6();
            int roll3 = roll.rollD6();
            int roll4 = roll.rollD6();

            int lowest = Math.Min(roll1, Math.Min(roll2, Math.Min(roll3, roll4)));

            int added = roll1 + roll2 + roll3 + roll4 - lowest;

            playerCharacter.strength = added;
            text_strengthReadOnly.Text = "Strength: " + added.ToString();
            button_str_roll.Enabled = false;
            strengthDone = true;
        }
        private void button_dexterity_roll_Click(object sender, EventArgs e)
        {
            int roll1 = roll.rollD6();
            int roll2 = roll.rollD6();
            int roll3 = roll.rollD6();
            int roll4 = roll.rollD6();

            int lowest = Math.Min(roll1, Math.Min(roll2, Math.Min(roll3, roll4)));

            int added = roll1 + roll2 + roll3 + roll4 - lowest;

            playerCharacter.dexterity = added;
            text_dexterityReadOnly.Text = "Dexterity: " + added.ToString();
            button_dex_roll.Enabled = false;
            dexterityDone = true;
        }
        private void button_constitution_roll_Click(object sender, EventArgs e)
        {
            int roll1 = roll.rollD6();
            int roll2 = roll.rollD6();
            int roll3 = roll.rollD6();
            int roll4 = roll.rollD6();

            int lowest = Math.Min(roll1, Math.Min(roll2, Math.Min(roll3, roll4)));

            int added = roll1 + roll2 + roll3 + roll4 - lowest;

            playerCharacter.constitution = added;
            text_constituionReadOnly.Text = "Constitution: " + added.ToString();
            button_con_roll.Enabled = false;
            constitutionDone = true;
        }
        private void button_wisdom_roll_Click(object sender, EventArgs e)
        {
            int roll1 = roll.rollD6();
            int roll2 = roll.rollD6();
            int roll3 = roll.rollD6();
            int roll4 = roll.rollD6();

            int lowest = Math.Min(roll1, Math.Min(roll2, Math.Min(roll3, roll4)));

            int added = roll1 + roll2 + roll3 + roll4 - lowest;

            playerCharacter.wisdom = added;
            text_wisdomReadOnly.Text = "Wisdom: " + added.ToString();
            button_wis_roll.Enabled = false;
            wisdomDone = true;
        }
        private void button_charisma_roll_Click(object sender, EventArgs e)
        {
            int roll1 = roll.rollD6();
            int roll2 = roll.rollD6();
            int roll3 = roll.rollD6();
            int roll4 = roll.rollD6();

            int lowest = Math.Min(roll1, Math.Min(roll2, Math.Min(roll3, roll4)));

            int added = roll1 + roll2 + roll3 + roll4 - lowest;

            playerCharacter.charisma = added;
            text_charismaReadOnly.Text = "Charisma: " + added.ToString();
            button_chr_roll.Enabled = false;
            charismaDone = true;
        }
        private void button_intelligence_roll_Click(object sender, EventArgs e)
        {
            int roll1 = roll.rollD6();
            int roll2 = roll.rollD6();
            int roll3 = roll.rollD6();
            int roll4 = roll.rollD6();

            int lowest = Math.Min(roll1, Math.Min(roll2, Math.Min(roll3, roll4)));

            int added = roll1 + roll2 + roll3 + roll4 - lowest;

            playerCharacter.intelligence = added;
            text_intelligenceReadOnly.Text = "Intelligence: " + added.ToString();
            button_int_roll.Enabled = false;
            intelligenceDone = true;
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            Console.WriteLine(playerCharacter.race);
            Console.WriteLine(playerCharacter.playerClass);
            controller.setCharacter(playerCharacter.name, playerCharacter.race, playerCharacter.playerClass, playerCharacter.strength, playerCharacter.dexterity, playerCharacter.constitution, playerCharacter.intelligence, playerCharacter.wisdom, playerCharacter.charisma);
            switch (playerCharacter.race)
            {
                case (Race.Human):
                    playerCharacter.health = playerCharacter.humanHealth;
                    playerCharacter.maxHealth = playerCharacter.humanHealth;
                    break;
                case (Race.Elf):
                    playerCharacter.health = playerCharacter.elfHealth;
                    playerCharacter.maxHealth = playerCharacter.elfHealth;
                    break;
                case (Race.HalfElf):
                    playerCharacter.health = playerCharacter.halfelfHealth;
                    playerCharacter.maxHealth = playerCharacter.halfelfHealth;
                    break;
                case (Race.Dwarf):
                    playerCharacter.health = playerCharacter.dwarfHealth;
                    playerCharacter.maxHealth = playerCharacter.dwarfHealth;
                    break;
                case (Race.Tiefling):
                    playerCharacter.health = playerCharacter.tieflingHealth;
                    playerCharacter.maxHealth = playerCharacter.tieflingHealth;
                    break;
            }
            playerCharacter.mana = playerCharacter.maxMana;
            Console.WriteLine("Mana: " + playerCharacter.mana);
            Console.WriteLine("Max Mana: " + playerCharacter.maxMana);
            Console.WriteLine("Health: " + playerCharacter.health);
            Console.WriteLine("Max Health: " + playerCharacter.maxHealth);
            controller.newEventDialogue(this);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            onConditionsMet();
        }

        private void text_name_MouseClick(object sender, MouseEventArgs e)
        {
            text_name.Clear();
        }

        public void dialogBox_Color()
        {
            text_strengthReadOnly.ForeColor = Color.Black;
            text_dexterityReadOnly.ForeColor = Color.Black;
            text_constituionReadOnly.ForeColor = Color.Black;
            text_intelligenceReadOnly.ForeColor = Color.Black;
            text_wisdomReadOnly.ForeColor = Color.Black;
            text_charismaReadOnly.ForeColor = Color.Black;
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            dialogBox_Color();
        }
    }
}
