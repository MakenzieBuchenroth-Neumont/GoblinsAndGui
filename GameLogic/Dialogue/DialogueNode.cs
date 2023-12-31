﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace GameLogic.Dialogue {
    public class DialogueNode {
        public string playerText { get; set; }
        public string npcResponse { get; set; }
        public List<DialogueNode> Options { get; }

        public DialogueNode(string playerText, string npcResponse) {
            this.playerText = playerText;
            this.npcResponse = npcResponse;
            Options = new List<DialogueNode>();
        }
    }
}
