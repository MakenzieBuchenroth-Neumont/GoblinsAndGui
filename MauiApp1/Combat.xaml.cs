using System;
using Microsoft.Maui.Controls;
using GameLogic;

namespace MauiApp1 {
    public partial class Combat : ContentPage {
        private Character character;
        public Combat(Character character) {
            InitializeComponent();

            this.character = character;

            playerHealth.Progress = convertToNormalizedValue(character.health);
        }

        public static double convertToNormalizedValue(int inputValue)
        {
            // Normalize the value to the range [0, 1]
            double normalizedValue = (double)inputValue / int.MaxValue;

            return normalizedValue;
        }

    }
}
