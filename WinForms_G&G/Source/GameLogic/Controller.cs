using Dungeons_Diners_Drive_Ins_Dragons_Dives.Source.Forms;
using Dungeons_Diners_Drive_Ins_Dragons_Dives.UI;
using System.Windows.Forms;
using GameLogic;

namespace Dungeons_Diners_Drive_Ins_Dragons_Dives
{
    public class Controller {
        
        DiceRolling diceRolling = new DiceRolling();
           public GameLogic.Character modelCharacter = new GameLogic.Character();
           public UI.Character uiCharacter = new UI.Character();

        Form currentForm;

        public void playGame() {
            bool end = false;
            while (!end) {
                
            }
        }
        

        public void setCharacter(string name, GameLogic.Character.Race race, GameLogic.Character.Class playerClass, int strength, int dexterity,int constitution,int intelligence, int wisdom, int charisma) {
            modelCharacter.name = uiCharacter.name;
            modelCharacter.race = uiCharacter.race;
            modelCharacter.playerClass = uiCharacter.playerClass;
            modelCharacter.strength = uiCharacter.strength;
            modelCharacter.dexterity = uiCharacter.dexterity;
            modelCharacter.constitution = uiCharacter.constitution;
            modelCharacter.intelligence = uiCharacter.intelligence;
            modelCharacter.wisdom = uiCharacter.wisdom;
            modelCharacter.charisma = uiCharacter.charisma;
            modelCharacter.SetRace();
        }

        public GameLogic.Character GetCharacter() {
            return modelCharacter;
        }

        public void newEventCombat(Form prevForm) {
            var c = FormManager.Current.CreateForm<CombatForm>();
            modelCharacter.health = modelCharacter.maxHealth;
            modelCharacter.mana = modelCharacter.maxMana;
            (c).setController(this, modelCharacter);
            currentForm = c;
            c.Show();
            prevForm.Close();
        }

        public void newEventDialogue(Form prevForm)
        {
            var c = FormManager.Current.CreateForm<DialogueForm>();
            (c).setController(this);
            currentForm = c;
            c.Show();
            prevForm.Close();
        }

        public void newEventCharacter(Form prevForm)
        {
            var c = FormManager.Current.CreateForm<CharacterCreation>();
            (c).setController(this);
            currentForm = c;
            c.Show();
            prevForm.Close();
        }
    }
}
