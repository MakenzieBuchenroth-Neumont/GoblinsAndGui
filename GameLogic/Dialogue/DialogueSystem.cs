using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Dialogue {
    public class DialogueSystem {
        private DialogueNode currentNode;

        public event EventHandler CurrentNodeChanged;

        public DialogueNode CurrentNode {
            get { return currentNode; }
            set {
                if (currentNode != value) {
                    currentNode = value;

                    // Raise the event when the current node changes
                    OnCurrentNodeChanged();

                    // You can also raise PropertyChanged event if you implement INotifyPropertyChanged
                }
            }
        }
        protected virtual void OnCurrentNodeChanged()
        {
            CurrentNodeChanged?.Invoke(this, EventArgs.Empty);
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
        public bool hasOptions() {
            return currentNode.Options.Count > 0;
        }
    }
}
