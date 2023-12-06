using WinForms_G_G.Properties;

namespace Dungeons_Diners_Drive_Ins_Dragons_Dives
{
    partial class CharacterCreation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterCreation));
            radio_race_human = new RadioButton();
            text_race = new TextBox();
            radio_race_elf = new RadioButton();
            radio_race_halfelf = new RadioButton();
            radio_race_tiefling = new RadioButton();
            radio_race_dwarf = new RadioButton();
            radio_class_fighter = new RadioButton();
            radio_class_cleric = new RadioButton();
            text_class = new TextBox();
            radio_class_wizard = new RadioButton();
            radio_class_bard = new RadioButton();
            radio_class_druid = new RadioButton();
            radio_class_rogue = new RadioButton();
            radio_class_ranger = new RadioButton();
            text_strengthReadOnly = new TextBox();
            button_str_roll = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            text_name = new TextBox();
            button_dex_roll = new Button();
            text_dexterityReadOnly = new TextBox();
            button_con_roll = new Button();
            text_constituionReadOnly = new TextBox();
            button_int_roll = new Button();
            text_intelligenceReadOnly = new TextBox();
            button_wis_roll = new Button();
            text_wisdomReadOnly = new TextBox();
            button_chr_roll = new Button();
            text_charismaReadOnly = new TextBox();
            button_submit = new Button();
            timer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // radio_race_human
            // 
            radio_race_human.AutoSize = true;
            radio_race_human.Location = new Point(3, 44);
            radio_race_human.Margin = new Padding(3, 4, 3, 4);
            radio_race_human.Name = "radio_race_human";
            radio_race_human.Size = new Size(95, 29);
            radio_race_human.TabIndex = 0;
            radio_race_human.TabStop = true;
            radio_race_human.Text = "Human";
            radio_race_human.UseVisualStyleBackColor = true;
            radio_race_human.CheckedChanged += radio_race_human_CheckedChanged;
            // 
            // text_race
            // 
            text_race.Enabled = false;
            text_race.Location = new Point(3, 4);
            text_race.Margin = new Padding(3, 4, 3, 4);
            text_race.Name = "text_race";
            text_race.ReadOnly = true;
            text_race.Size = new Size(111, 31);
            text_race.TabIndex = 1;
            text_race.Text = "Race";
            // 
            // radio_race_elf
            // 
            radio_race_elf.AutoSize = true;
            radio_race_elf.Location = new Point(3, 81);
            radio_race_elf.Margin = new Padding(3, 4, 3, 4);
            radio_race_elf.Name = "radio_race_elf";
            radio_race_elf.Size = new Size(56, 29);
            radio_race_elf.TabIndex = 2;
            radio_race_elf.TabStop = true;
            radio_race_elf.Text = "Elf";
            radio_race_elf.UseVisualStyleBackColor = true;
            radio_race_elf.CheckedChanged += radio_race_elf_CheckedChanged;
            // 
            // radio_race_halfelf
            // 
            radio_race_halfelf.AutoSize = true;
            radio_race_halfelf.Location = new Point(3, 119);
            radio_race_halfelf.Margin = new Padding(3, 4, 3, 4);
            radio_race_halfelf.Name = "radio_race_halfelf";
            radio_race_halfelf.Size = new Size(95, 29);
            radio_race_halfelf.TabIndex = 3;
            radio_race_halfelf.TabStop = true;
            radio_race_halfelf.Text = "Half-Elf";
            radio_race_halfelf.UseVisualStyleBackColor = true;
            radio_race_halfelf.CheckedChanged += radio_race_halfelf_CheckedChanged;
            // 
            // radio_race_tiefling
            // 
            radio_race_tiefling.AutoSize = true;
            radio_race_tiefling.Location = new Point(3, 156);
            radio_race_tiefling.Margin = new Padding(3, 4, 3, 4);
            radio_race_tiefling.Name = "radio_race_tiefling";
            radio_race_tiefling.Size = new Size(94, 29);
            radio_race_tiefling.TabIndex = 4;
            radio_race_tiefling.TabStop = true;
            radio_race_tiefling.Text = "Tiefling";
            radio_race_tiefling.UseVisualStyleBackColor = true;
            radio_race_tiefling.CheckedChanged += radio_race_tiefling_CheckedChanged;
            // 
            // radio_race_dwarf
            // 
            radio_race_dwarf.AutoSize = true;
            radio_race_dwarf.Location = new Point(3, 194);
            radio_race_dwarf.Margin = new Padding(3, 4, 3, 4);
            radio_race_dwarf.Name = "radio_race_dwarf";
            radio_race_dwarf.Size = new Size(84, 29);
            radio_race_dwarf.TabIndex = 5;
            radio_race_dwarf.TabStop = true;
            radio_race_dwarf.Text = "Dwarf";
            radio_race_dwarf.UseVisualStyleBackColor = true;
            radio_race_dwarf.CheckedChanged += radio_race_dwarf_CheckedChanged;
            // 
            // radio_class_fighter
            // 
            radio_class_fighter.AutoSize = true;
            radio_class_fighter.Location = new Point(3, 119);
            radio_class_fighter.Margin = new Padding(3, 4, 3, 4);
            radio_class_fighter.Name = "radio_class_fighter";
            radio_class_fighter.Size = new Size(92, 29);
            radio_class_fighter.TabIndex = 10;
            radio_class_fighter.TabStop = true;
            radio_class_fighter.Text = "Fighter";
            radio_class_fighter.UseVisualStyleBackColor = true;
            radio_class_fighter.CheckedChanged += radio_class_fighter_CheckedChanged;
            // 
            // radio_class_cleric
            // 
            radio_class_cleric.AutoSize = true;
            radio_class_cleric.Location = new Point(3, 81);
            radio_class_cleric.Margin = new Padding(3, 4, 3, 4);
            radio_class_cleric.Name = "radio_class_cleric";
            radio_class_cleric.Size = new Size(79, 29);
            radio_class_cleric.TabIndex = 8;
            radio_class_cleric.TabStop = true;
            radio_class_cleric.Text = "Cleric";
            radio_class_cleric.UseVisualStyleBackColor = true;
            radio_class_cleric.CheckedChanged += radio_class_cleric_CheckedChanged;
            // 
            // text_class
            // 
            text_class.Enabled = false;
            text_class.Location = new Point(3, 4);
            text_class.Margin = new Padding(3, 4, 3, 4);
            text_class.Name = "text_class";
            text_class.ReadOnly = true;
            text_class.Size = new Size(111, 31);
            text_class.TabIndex = 7;
            text_class.Text = "Class";
            // 
            // radio_class_wizard
            // 
            radio_class_wizard.AutoSize = true;
            radio_class_wizard.Location = new Point(3, 44);
            radio_class_wizard.Margin = new Padding(3, 4, 3, 4);
            radio_class_wizard.Name = "radio_class_wizard";
            radio_class_wizard.Size = new Size(92, 29);
            radio_class_wizard.TabIndex = 6;
            radio_class_wizard.TabStop = true;
            radio_class_wizard.Text = "Wizard";
            radio_class_wizard.UseVisualStyleBackColor = true;
            radio_class_wizard.CheckedChanged += radio_class_wizard_CheckedChanged;
            // 
            // radio_class_bard
            // 
            radio_class_bard.AutoSize = true;
            radio_class_bard.Location = new Point(3, 156);
            radio_class_bard.Margin = new Padding(3, 4, 3, 4);
            radio_class_bard.Name = "radio_class_bard";
            radio_class_bard.Size = new Size(73, 29);
            radio_class_bard.TabIndex = 12;
            radio_class_bard.TabStop = true;
            radio_class_bard.Text = "Bard";
            radio_class_bard.UseVisualStyleBackColor = true;
            radio_class_bard.CheckedChanged += radio_class_bard_CheckedChanged;
            // 
            // radio_class_druid
            // 
            radio_class_druid.AutoSize = true;
            radio_class_druid.Location = new Point(3, 194);
            radio_class_druid.Margin = new Padding(3, 4, 3, 4);
            radio_class_druid.Name = "radio_class_druid";
            radio_class_druid.Size = new Size(81, 29);
            radio_class_druid.TabIndex = 13;
            radio_class_druid.TabStop = true;
            radio_class_druid.Text = "Druid";
            radio_class_druid.UseVisualStyleBackColor = true;
            radio_class_druid.CheckedChanged += radio_class_druid_CheckedChanged;
            // 
            // radio_class_rogue
            // 
            radio_class_rogue.AutoSize = true;
            radio_class_rogue.Location = new Point(3, 231);
            radio_class_rogue.Margin = new Padding(3, 4, 3, 4);
            radio_class_rogue.Name = "radio_class_rogue";
            radio_class_rogue.Size = new Size(88, 29);
            radio_class_rogue.TabIndex = 14;
            radio_class_rogue.TabStop = true;
            radio_class_rogue.Text = "Rogue";
            radio_class_rogue.UseVisualStyleBackColor = true;
            radio_class_rogue.CheckedChanged += radio_class_rogue_CheckedChanged;
            // 
            // radio_class_ranger
            // 
            radio_class_ranger.AutoSize = true;
            radio_class_ranger.Location = new Point(3, 269);
            radio_class_ranger.Margin = new Padding(3, 4, 3, 4);
            radio_class_ranger.Name = "radio_class_ranger";
            radio_class_ranger.Size = new Size(93, 29);
            radio_class_ranger.TabIndex = 15;
            radio_class_ranger.TabStop = true;
            radio_class_ranger.Text = "Ranger";
            radio_class_ranger.UseVisualStyleBackColor = true;
            radio_class_ranger.CheckedChanged += radio_class_ranger_CheckedChanged;
            // 
            // text_strengthReadOnly
            // 
            text_strengthReadOnly.Enabled = false;
            text_strengthReadOnly.Location = new Point(283, 54);
            text_strengthReadOnly.Margin = new Padding(3, 4, 3, 4);
            text_strengthReadOnly.Name = "text_strengthReadOnly";
            text_strengthReadOnly.ReadOnly = true;
            text_strengthReadOnly.Size = new Size(133, 31);
            text_strengthReadOnly.TabIndex = 16;
            text_strengthReadOnly.Text = "Strength";
            // 
            // button_str_roll
            // 
            button_str_roll.Location = new Point(283, 95);
            button_str_roll.Margin = new Padding(3, 4, 3, 4);
            button_str_roll.Name = "button_str_roll";
            button_str_roll.Size = new Size(133, 42);
            button_str_roll.TabIndex = 17;
            button_str_roll.Text = "Roll";
            button_str_roll.UseVisualStyleBackColor = true;
            button_str_roll.Click += button_strength_roll_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(text_race);
            panel1.Controls.Add(radio_race_human);
            panel1.Controls.Add(radio_race_elf);
            panel1.Controls.Add(radio_race_halfelf);
            panel1.Controls.Add(radio_race_tiefling);
            panel1.Controls.Add(radio_race_dwarf);
            panel1.Location = new Point(13, 54);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(126, 325);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(text_class);
            panel2.Controls.Add(radio_class_wizard);
            panel2.Controls.Add(radio_class_cleric);
            panel2.Controls.Add(radio_class_fighter);
            panel2.Controls.Add(radio_class_bard);
            panel2.Controls.Add(radio_class_ranger);
            panel2.Controls.Add(radio_class_druid);
            panel2.Controls.Add(radio_class_rogue);
            panel2.Location = new Point(146, 52);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(131, 326);
            panel2.TabIndex = 20;
            // 
            // text_name
            // 
            text_name.Location = new Point(17, 16);
            text_name.Margin = new Padding(3, 4, 3, 4);
            text_name.Name = "text_name";
            text_name.Size = new Size(260, 31);
            text_name.TabIndex = 21;
            text_name.Text = "Enter Name:";
            text_name.MouseClick += text_name_MouseClick;
            text_name.TextChanged += text_name_TextChanged;
            // 
            // button_dex_roll
            // 
            button_dex_roll.Location = new Point(423, 95);
            button_dex_roll.Margin = new Padding(3, 4, 3, 4);
            button_dex_roll.Name = "button_dex_roll";
            button_dex_roll.Size = new Size(133, 42);
            button_dex_roll.TabIndex = 23;
            button_dex_roll.Text = "Roll";
            button_dex_roll.UseVisualStyleBackColor = true;
            button_dex_roll.Click += button_dexterity_roll_Click;
            // 
            // text_dexterityReadOnly
            // 
            text_dexterityReadOnly.Enabled = false;
            text_dexterityReadOnly.Location = new Point(423, 54);
            text_dexterityReadOnly.Margin = new Padding(3, 4, 3, 4);
            text_dexterityReadOnly.Name = "text_dexterityReadOnly";
            text_dexterityReadOnly.ReadOnly = true;
            text_dexterityReadOnly.Size = new Size(133, 31);
            text_dexterityReadOnly.TabIndex = 22;
            text_dexterityReadOnly.Text = "Dexterity";
            // 
            // button_con_roll
            // 
            button_con_roll.Location = new Point(563, 94);
            button_con_roll.Margin = new Padding(3, 4, 3, 4);
            button_con_roll.Name = "button_con_roll";
            button_con_roll.Size = new Size(133, 42);
            button_con_roll.TabIndex = 25;
            button_con_roll.Text = "Roll";
            button_con_roll.UseVisualStyleBackColor = true;
            button_con_roll.Click += button_constitution_roll_Click;
            // 
            // text_constituionReadOnly
            // 
            text_constituionReadOnly.Enabled = false;
            text_constituionReadOnly.Location = new Point(563, 52);
            text_constituionReadOnly.Margin = new Padding(3, 4, 3, 4);
            text_constituionReadOnly.Name = "text_constituionReadOnly";
            text_constituionReadOnly.ReadOnly = true;
            text_constituionReadOnly.Size = new Size(133, 31);
            text_constituionReadOnly.TabIndex = 24;
            text_constituionReadOnly.Text = "Constitution";
            // 
            // button_int_roll
            // 
            button_int_roll.Location = new Point(283, 188);
            button_int_roll.Margin = new Padding(3, 4, 3, 4);
            button_int_roll.Name = "button_int_roll";
            button_int_roll.Size = new Size(133, 42);
            button_int_roll.TabIndex = 27;
            button_int_roll.Text = "Roll";
            button_int_roll.UseVisualStyleBackColor = true;
            button_int_roll.Click += button_intelligence_roll_Click;
            // 
            // text_intelligenceReadOnly
            // 
            text_intelligenceReadOnly.Enabled = false;
            text_intelligenceReadOnly.Location = new Point(283, 146);
            text_intelligenceReadOnly.Margin = new Padding(3, 4, 3, 4);
            text_intelligenceReadOnly.Name = "text_intelligenceReadOnly";
            text_intelligenceReadOnly.ReadOnly = true;
            text_intelligenceReadOnly.Size = new Size(133, 31);
            text_intelligenceReadOnly.TabIndex = 26;
            text_intelligenceReadOnly.Text = "Intelligence";
            // 
            // button_wis_roll
            // 
            button_wis_roll.Location = new Point(423, 188);
            button_wis_roll.Margin = new Padding(3, 4, 3, 4);
            button_wis_roll.Name = "button_wis_roll";
            button_wis_roll.Size = new Size(133, 42);
            button_wis_roll.TabIndex = 29;
            button_wis_roll.Text = "Roll";
            button_wis_roll.UseVisualStyleBackColor = true;
            button_wis_roll.Click += button_wisdom_roll_Click;
            // 
            // text_wisdomReadOnly
            // 
            text_wisdomReadOnly.Enabled = false;
            text_wisdomReadOnly.Location = new Point(423, 146);
            text_wisdomReadOnly.Margin = new Padding(3, 4, 3, 4);
            text_wisdomReadOnly.Name = "text_wisdomReadOnly";
            text_wisdomReadOnly.ReadOnly = true;
            text_wisdomReadOnly.Size = new Size(133, 31);
            text_wisdomReadOnly.TabIndex = 28;
            text_wisdomReadOnly.Text = "Wisdom";
            // 
            // button_chr_roll
            // 
            button_chr_roll.Location = new Point(563, 188);
            button_chr_roll.Margin = new Padding(3, 4, 3, 4);
            button_chr_roll.Name = "button_chr_roll";
            button_chr_roll.Size = new Size(133, 42);
            button_chr_roll.TabIndex = 31;
            button_chr_roll.Text = "Roll";
            button_chr_roll.UseVisualStyleBackColor = true;
            button_chr_roll.Click += button_charisma_roll_Click;
            // 
            // text_charismaReadOnly
            // 
            text_charismaReadOnly.Enabled = false;
            text_charismaReadOnly.Location = new Point(563, 146);
            text_charismaReadOnly.Margin = new Padding(3, 4, 3, 4);
            text_charismaReadOnly.Name = "text_charismaReadOnly";
            text_charismaReadOnly.ReadOnly = true;
            text_charismaReadOnly.Size = new Size(133, 31);
            text_charismaReadOnly.TabIndex = 30;
            text_charismaReadOnly.Text = "Charisma";
            // 
            // button_submit
            // 
            button_submit.Enabled = false;
            button_submit.Location = new Point(768, 508);
            button_submit.Margin = new Padding(3, 4, 3, 4);
            button_submit.Name = "button_submit";
            button_submit.Size = new Size(108, 40);
            button_submit.TabIndex = 32;
            button_submit.Text = "Submit";
            button_submit.UseVisualStyleBackColor = true;
            button_submit.Click += button_submit_Click;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Tick += timer_Tick;
            // 
            // CharacterCreation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(889, 562);
            Controls.Add(button_submit);
            Controls.Add(button_chr_roll);
            Controls.Add(text_charismaReadOnly);
            Controls.Add(button_wis_roll);
            Controls.Add(text_wisdomReadOnly);
            Controls.Add(button_int_roll);
            Controls.Add(text_intelligenceReadOnly);
            Controls.Add(button_con_roll);
            Controls.Add(text_constituionReadOnly);
            Controls.Add(button_dex_roll);
            Controls.Add(text_dexterityReadOnly);
            Controls.Add(text_name);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button_str_roll);
            Controls.Add(text_strengthReadOnly);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CharacterCreation";
            Text = "Form1";
            Shown += Form1_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radio_race_human;
        private TextBox text_race;
        private RadioButton radio_race_elf;
        private RadioButton radio_race_halfelf;
        private RadioButton radio_race_tiefling;
        private RadioButton radio_race_dwarf;
        private RadioButton radio_class_fighter;
        private RadioButton radio_class_cleric;
        private TextBox text_class;
        private RadioButton radio_class_wizard;
        private RadioButton radio_class_bard;
        private RadioButton radio_class_druid;
        private RadioButton radio_class_rogue;
        private RadioButton radio_class_ranger;
        private TextBox text_strengthReadOnly;
        private Button button_str_roll;
        private Panel panel1;
        private Panel panel2;
        private TextBox text_name;
        private Button button_dex_roll;
        private TextBox text_dexterityReadOnly;
        private Button button_con_roll;
        private TextBox text_constituionReadOnly;
        private Button button_int_roll;
        private TextBox text_intelligenceReadOnly;
        private Button button_wis_roll;
        private TextBox text_wisdomReadOnly;
        private Button button_chr_roll;
        private TextBox text_charismaReadOnly;
        private System.Windows.Forms.Timer timer;
        public Button button_submit;
    }
}

