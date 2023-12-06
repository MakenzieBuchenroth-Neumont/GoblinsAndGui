using Dungeons_Diners_Drive_Ins_Dragons_Dives.Source.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeons_Diners_Drive_Ins_Dragons_Dives {
    internal class FormManager : ApplicationContext {
        private static Lazy<FormManager> _current = new Lazy<FormManager>();
        public static FormManager Current => _current.Value;
        public FormManager() {
            var f1 = CreateForm<CharacterCreation>();
            f1.Show();
            //var f2 = CreateForm<DialogueForm>();
            //f2.Show();
            //var f3 = CreateForm<CombatForm>();
            //f3.Show();
        }
        private void onFormClosed(object sender, EventArgs e) {
            if (Application.OpenForms.Count == 0) {
                ExitThread();
            }
        }

        public T CreateForm<T>() where T : Form, new() {
            var ret = new T();
            ret.FormClosed += onFormClosed;
            return ret;
        }
    }
}
