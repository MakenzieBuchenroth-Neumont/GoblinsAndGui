using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Dialogue {
    public class DialogueNode {
        public string playerText { get; set; }
        public string npcResponse { get; set; }
        public List<DialogueNode> Options { get;}

        public DialogueNode(string playerText, string npcResponse) {
            this.playerText = playerText;
            this.npcResponse = npcResponse;
            Options = new List<DialogueNode>();
        }
    }
}
