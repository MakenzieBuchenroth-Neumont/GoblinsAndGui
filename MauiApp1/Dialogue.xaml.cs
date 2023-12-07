using System;
using Microsoft.Maui.Controls;
using GameLogic.Dialogue;
using GameLogic;

namespace MauiApp1 {
    public partial class Dialogue : ContentPage {
        DiceRolling dice = new DiceRolling();
        Enemy enemy = new Enemy();
        private Character character;
        private DialogueSystem _dialogueSystem;
        private DialogueTree _dialogueTree;

        public Dialogue(Character character) {
            InitializeComponent();

            this.character = character;

            _dialogueSystem = new DialogueSystem(CreateDialogueTree());
            updateUI();
        }

        private void OptionsListView_ItemTapped(object sender, ItemTappedEventArgs e) {
            if (e.Item is DialogueNode selectedNode) {
                int optionIndex = _dialogueSystem.getOptionIndex(selectedNode);
                _dialogueSystem.setNextNode(optionIndex);
                updateUI();

                if (_dialogueSystem.getCurrentNpcResponse() == "Prepare to die!") {
                    Navigation.PushAsync(new CombatPage(character)); 
                }
            }
        }

        private void updateUI() {
            currentNpcResponse.Text = _dialogueSystem.getCurrentNpcResponse();
            OptionsListView.ItemsSource = _dialogueSystem.getOptions();
            OptionsListView.IsVisible = _dialogueSystem.hasOptions();
        }


        private DialogueTree CreateDialogueTree() {
            var rootNode = new DialogueNode("Are you alright?", "Are you alright?");
            var nodeA = new DialogueNode("Ja", "That's good.");
            var nodeB = new DialogueNode("Nej", "That's unfortunate.");
            var nodeC = new DialogueNode("ATTACK", "Prepare to die!");
            var nodeD = new DialogueNode("rizz em", "This is most unusual...why am I falling for it?"); 
            

            rootNode.Options.Add(nodeA);
            rootNode.Options.Add(nodeB);
            rootNode.Options.Add(nodeC);
            rootNode.Options.Add(nodeD);

            // Second level
            var additionalNodeA1 = new DialogueNode("Where am I?", "This is the city of Edgeforest.");
            var additionalNodeA2 = new DialogueNode("Who are you?", "I am Ragnar, the guard of this city..");

            nodeA.Options.Add(additionalNodeA1);
            nodeA.Options.Add(additionalNodeA2);
            nodeB.Options.Add(additionalNodeA1);
            nodeB.Options.Add(additionalNodeA2);

            var additionalNodeD1 = new DialogueNode("Wanna get out of here?", "W-what?");
            var additionalNodeD2 = new DialogueNode("*move in closer*", "*shifts uncomfortably*");

            nodeD.Options.Add(additionalNodeD1);
            nodeD.Options.Add(additionalNodeD2);

            return new DialogueTree(rootNode);
        }
    }
}
