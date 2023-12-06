using GameLogic;
using GameLogic.Dialogue;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Microsoft.Maui.Controls;


namespace MauiApp1 {
    public partial class Dialogue : ContentPage, INotifyPropertyChanged {
        private Character character;
        private DialogueSystem dialogueSystem;
        private DialogueTree dialogueTree;


        public Dialogue(Character character)
        {
            InitializeComponent();

            this.character = character;
        }


        private DialogueTree CreateDialogueTree() {
            var rootNode = new DialogueNode("Are you alright?", "Are you alright?");
            var nodeA = new DialogueNode("Ja", "That's good."); // player response to are you alright
            var nodeB = new DialogueNode("Nej", "That's unfortunate."); // player response to a
            var nodeC = new DialogueNode("ATTACK", "Prepare to die!"); // player response to a
            var nodeD = new DialogueNode("rizz em", "This is most unusual...why am I falling for it?"); // response to b

            rootNode.Options.Add(nodeA);
            rootNode.Options.Add(nodeB);
            rootNode.Options.Add(nodeC);
            rootNode.Options.Add(nodeD);

            // second level
            var nodeA1 = new DialogueNode("OK.", "That's good."); // player response to 'that's good'.
            var nodeB1 = new DialogueNode("OK.", "That's unfortunate."); // player response to 'that's unfortunate'.
            var nodeD1 = new DialogueNode("Wanna get out of here?", "This is most unusual...why am I falling for it?");

            return new DialogueTree(rootNode);
        }
    }
}
