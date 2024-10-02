using System;
using Microsoft.Maui.Controls;

namespace Number1._2Maui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnShowNumberButtonClicked(object sender, EventArgs e)
        {
            string input = NumberEntry.Text;
            if (int.TryParse(input, out int number))
            {
                ResultLabel.Text = $"Ви ввели число {number}";
            }
            else
            {
                ResultLabel.Text = "Будь ласка, введіть дійсне ціле число.";
            }
        }
    }
}