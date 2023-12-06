using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Dialogue {
    public class DialogueTree {
        public DialogueNode Root {  get; set; }
        public DialogueTree(DialogueNode root) {
            this.Root = root;
        }
    }
}
