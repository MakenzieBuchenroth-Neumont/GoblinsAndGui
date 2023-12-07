using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Dialogue {
    public class DialogueSystem : INotifyPropertyChanged {
        private DialogueNode currentNode;

        public event EventHandler CurrentNodeChanged;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public DialogueNode CurrentNode {
            get { return currentNode; }
            set {
                if (currentNode != value) {
                    currentNode = value;
                    OnPropertyChanged(nameof(CurrentNode));
                }
            }
        }

        public DialogueSystem(DialogueTree dialogueTree) {
            currentNode = dialogueTree.Root;
        }
        public string getCurrentPlayerText() {
            return currentNode.playerText;
        }
        public string getCurrentNpcResponse()
        {
            return currentNode.npcResponse;
        }
        public List<DialogueNode> getOptions() { 
            return currentNode.Options;
        }

        public void setNextNode(int optionIndex) {
            if (optionIndex >= 0 && optionIndex < currentNode.Options.Count) {
                currentNode = currentNode.Options[optionIndex];
                CurrentNodeChanged?.Invoke(this, EventArgs.Empty);
            }
        }


        public int getOptionIndex(DialogueNode selectedOption)
        {
            return currentNode.Options.IndexOf(selectedOption);
        }

        public bool hasOptions() {
            return currentNode.Options.Count > 0;
        }
    }
}
