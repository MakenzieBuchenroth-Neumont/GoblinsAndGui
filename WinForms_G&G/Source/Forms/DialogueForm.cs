using GameLogic.Dialogue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Dungeons_Diners_Drive_Ins_Dragons_Dives
{

    public partial class DialogueForm : Form
    {
        Controller controller;
        private DialogueSystem dialogueSystem;

        public DialogueForm()
        {
            InitializeComponent();
            dialogueSystem = new DialogueSystem(CreateDialogueTree());
            listBox_options.SelectedIndexChanged += listBox_options_SelectedIndexChanged;
            updateUI();
        }

        public void setController(Controller controller)
        {
            this.controller = controller;
        }

        private void listBox_options_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_options.SelectedIndex >= 0)
            {
                dialogueSystem.setNextNode(listBox_options.SelectedIndex);
                updateUI();
                if (dialogueSystem.getCurrentNpcResponse() == "Prepare to die!")
                {
                    controller.newEventCombat(this);
                }

            }
        }

        private void updateUI()
        {
            text_dialogBox.Text = dialogueSystem.getCurrentNpcResponse();

            listBox_options.Items.Clear();
            foreach (var option in dialogueSystem.getOptions())
            {
                listBox_options.Items.Add(option.playerText);
            }

            listBox_options.Visible = dialogueSystem.hasOptions();

            if (!dialogueSystem.hasOptions() && !string.IsNullOrEmpty(dialogueSystem.getCurrentNpcResponse()))
            {
                text_dialogBox.AppendText(Environment.NewLine);
                //text_dialogBox.AppendText(dialogueSystem.getCurrentNpcResponse());
            }
        }

        private DialogueTree CreateDialogueTree()
        {
            var rootNode = new DialogueNode("Are you alright?", "Are you alright?");
            var nodeA = new DialogueNode("Ja", "That's good"); // player response to are you alright
            var nodeB = new DialogueNode("Nej", "That's unfortunate."); // player response to a
            var nodeC = new DialogueNode("ATTACK", "Prepare to die!"); // player response to a
            var nodeD = new DialogueNode("rizz em", "This is most unusual...why am I falling for it?"); // response to b

            rootNode.Options.Add(nodeA);
            rootNode.Options.Add(nodeB);
            rootNode.Options.Add(nodeC);
            rootNode.Options.Add(nodeD);

            return new DialogueTree(rootNode);
        }

        public void dialogBox_Color()
        {
            text_dialogBox.ForeColor = Color.Black;
            text_speakerName.ForeColor = Color.Black;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dialogBox_Color();

        }

        private void Form2_Shown(object sender, EventArgs e)
        {

        }
    }
}
