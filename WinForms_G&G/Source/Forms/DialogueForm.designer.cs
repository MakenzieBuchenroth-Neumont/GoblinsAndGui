namespace Dungeons_Diners_Drive_Ins_Dragons_Dives
{
    partial class DialogueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogueForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            text_speakerName = new Label();
            text_dialogBox = new RichTextBox();
            listBox_options = new ListBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(257, 15);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 268);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(22, 59);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(319, 152);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(text_speakerName);
            panel2.Location = new Point(1, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 544);
            panel2.TabIndex = 3;
            // 
            // text_speakerName
            // 
            text_speakerName.AutoSize = true;
            text_speakerName.BackColor = Color.WhiteSmoke;
            text_speakerName.Font = new Font("Gloucester MT Extra Condensed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            text_speakerName.Location = new Point(12, 310);
            text_speakerName.Name = "text_speakerName";
            text_speakerName.Size = new Size(50, 26);
            text_speakerName.TabIndex = 0;
            text_speakerName.Text = "Guard";
            // 
            // text_dialogBox
            // 
            text_dialogBox.Enabled = false;
            text_dialogBox.Font = new Font("Gloucester MT Extra Condensed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            text_dialogBox.Location = new Point(13, 350);
            text_dialogBox.Margin = new Padding(3, 4, 3, 4);
            text_dialogBox.Name = "text_dialogBox";
            text_dialogBox.ReadOnly = true;
            text_dialogBox.ScrollBars = RichTextBoxScrollBars.None;
            text_dialogBox.Size = new Size(642, 196);
            text_dialogBox.TabIndex = 0;
            text_dialogBox.Text = "u k bro?";
            // 
            // listBox_options
            // 
            listBox_options.Font = new Font("Gloucester MT Extra Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_options.FormattingEnabled = true;
            listBox_options.ItemHeight = 38;
            listBox_options.Items.AddRange(new object[] { "Ja", "Nej", "ATTACK", "rizz em" });
            listBox_options.Location = new Point(662, 352);
            listBox_options.Margin = new Padding(3, 4, 3, 4);
            listBox_options.Name = "listBox_options";
            listBox_options.Size = new Size(213, 194);
            listBox_options.TabIndex = 7;
            // 
            // DialogueForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(889, 562);
            Controls.Add(listBox_options);
            Controls.Add(panel1);
            Controls.Add(text_dialogBox);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DialogueForm";
            Text = "Form2";
            Load += Form2_Load;
            Shown += Form2_Shown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label text_speakerName;
        private RichTextBox text_dialogBox;
        private ListBox listBox_options;
    }
}