using GameLogic;

namespace MauiApp1 {
    public partial class MainPage : ContentPage {
        Character character;
        DiceRolling dice = new DiceRolling();
        bool strDone = false;
        bool dexDone = false;
        bool conDone = false;
        bool intDone = false;
        bool wisDone = false;
        bool chrDone = false;


        public MainPage() {
            InitializeComponent();

            character = new Character();
        }

        private void OnRaceSelectedIndexChanged(object sender, EventArgs e) {
            string selectedRaceString = racePicker.SelectedItem as string;

            if (Enum.TryParse<Character.Race>(selectedRaceString, out var selectedRace)) {
                
                character.race = selectedRace;
                character.SetRace();
            }
        }

        private void strButtonRoll(object sender, EventArgs e) {
            int roll = dice.rollD20();
            strLabel.Text = "Strength: " + roll.ToString();
            character.strength = roll;
            bool clicked = true;
            strDone = true;
            if (clicked) {
                strButton.IsEnabled = false;
            }
        }

        private void dexButtonRoll(object sender, EventArgs e) {
            int roll = dice.rollD20();
            dexLabel.Text = "Dexterity: " + roll.ToString();
            character.dexterity = roll;
            dexDone = true;
            bool clicked = true;
            if (clicked) {
                dexButton.IsEnabled = false;
            }
        }

        private void conButtonRoll(object sender, EventArgs e) {
            int roll = dice.rollD20();
            conLabel.Text = "Constitution: " + roll.ToString();
            character.constitution = roll;
            bool clicked = true;
            conDone = true;
            if (clicked) {
                conButton.IsEnabled = false;
            }
        }

        private void intButtonRoll(object sender, EventArgs e) {
            int roll = dice.rollD20();
            intLabel.Text = "Intelligence: " +roll.ToString();
            character.intelligence = roll;
            bool clicked = true;
            intDone = true;
            if (clicked) {
                intButton.IsEnabled = false;
            }
        }

        private void wisButtonRoll(object sender, EventArgs e) {
            int roll = dice.rollD20();
            wisLabel.Text = "Wisdom: " + roll.ToString();
            character.wisdom = roll;
            bool clicked = true;
            wisDone = true;
            if (clicked) {
                wisButton.IsEnabled = false;
            }
        }

        private void chrButtonRoll(object sender, EventArgs e) {
            int roll = dice.rollD20();
            chrLabel.Text = "Charisma: " + roll.ToString();
            character.charisma = roll;
            bool clicked = true;
            chrDone = true;
            if (clicked) {
                chrButton.IsEnabled = false;
            }
        }
        private void submitButtonClick(object sender, EventArgs e) {
            if (strDone && dexDone && conDone && intDone && wisDone && chrDone) {
                Console.WriteLine(character.race);
                Navigation.PushAsync(new Dialogue(character));
            }
        }
    }

}
