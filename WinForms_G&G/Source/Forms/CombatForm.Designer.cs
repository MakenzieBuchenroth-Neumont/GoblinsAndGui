namespace Dungeons_Diners_Drive_Ins_Dragons_Dives.Source.Forms
{
    partial class CombatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CombatForm));
            panel1 = new Panel();
            progressBar_enemyHealth = new ProgressBar();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            healthBar = new ProgressBar();
            button_magic = new Button();
            button_healthPotion = new Button();
            button_ranged = new Button();
            button_melee = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            manaBar = new ProgressBar();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(progressBar_enemyHealth);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 10);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 369);
            panel1.TabIndex = 14;
            // 
            // progressBar_enemyHealth
            // 
            progressBar_enemyHealth.Location = new Point(0, -11);
            progressBar_enemyHealth.Margin = new Padding(3, 4, 3, 4);
            progressBar_enemyHealth.Name = "progressBar_enemyHealth";
            progressBar_enemyHealth.Size = new Size(861, 35);
            progressBar_enemyHealth.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(436, 31);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(422, 334);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(4, 31);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(423, 334);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // healthBar
            // 
            healthBar.ForeColor = Color.Firebrick;
            healthBar.Location = new Point(12, 535);
            healthBar.Margin = new Padding(3, 4, 3, 4);
            healthBar.Maximum = 11;
            healthBar.Name = "healthBar";
            healthBar.Size = new Size(427, 18);
            healthBar.TabIndex = 19;
            healthBar.Value = 11;
            // 
            // button_magic
            // 
            button_magic.Location = new Point(449, 461);
            button_magic.Margin = new Padding(3, 4, 3, 4);
            button_magic.Name = "button_magic";
            button_magic.Size = new Size(428, 66);
            button_magic.TabIndex = 17;
            button_magic.Text = "Magic";
            button_magic.UseVisualStyleBackColor = true;
            button_magic.Click += button_magic_Click;
            // 
            // button_healthPotion
            // 
            button_healthPotion.Location = new Point(12, 461);
            button_healthPotion.Margin = new Padding(3, 4, 3, 4);
            button_healthPotion.Name = "button_healthPotion";
            button_healthPotion.Size = new Size(428, 66);
            button_healthPotion.TabIndex = 18;
            button_healthPotion.Text = "Health Potion (";
            button_healthPotion.UseVisualStyleBackColor = true;
            button_healthPotion.Click += button_healthPotion_Click;
            // 
            // button_ranged
            // 
            button_ranged.Location = new Point(448, 388);
            button_ranged.Margin = new Padding(3, 4, 3, 4);
            button_ranged.Name = "button_ranged";
            button_ranged.Size = new Size(428, 66);
            button_ranged.TabIndex = 16;
            button_ranged.Text = "Ranged";
            button_ranged.UseVisualStyleBackColor = true;
            button_ranged.Click += button_ranged_Click;
            // 
            // button_melee
            // 
            button_melee.Location = new Point(12, 388);
            button_melee.Margin = new Padding(3, 4, 3, 4);
            button_melee.Name = "button_melee";
            button_melee.Size = new Size(428, 66);
            button_melee.TabIndex = 15;
            button_melee.Text = "Melee";
            button_melee.UseVisualStyleBackColor = true;
            button_melee.Click += button_melee_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer_tick;
            // 
            // manaBar
            // 
            manaBar.ForeColor = Color.Firebrick;
            manaBar.Location = new Point(449, 535);
            manaBar.Margin = new Padding(3, 4, 3, 4);
            manaBar.Maximum = 10;
            manaBar.Name = "manaBar";
            manaBar.Size = new Size(427, 18);
            manaBar.TabIndex = 20;
            manaBar.Value = 10;
            // 
            // CombatForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(889, 562);
            Controls.Add(panel1);
            Controls.Add(healthBar);
            Controls.Add(button_magic);
            Controls.Add(button_healthPotion);
            Controls.Add(button_ranged);
            Controls.Add(button_melee);
            Controls.Add(manaBar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CombatForm";
            Text = "CombatForm";
            Shown += CombatForm_Shown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ProgressBar healthBar;
        private Button button_magic;
        private Button button_healthPotion;
        private Button button_ranged;
        private Button button_melee;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar manaBar;
        private ProgressBar progressBar_enemyHealth;
    }
}