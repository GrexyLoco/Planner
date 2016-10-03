using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Planner.UI
{
    class CreateNamePage : ContentPage
    {
        public CreateNamePage()
        {
            Label instructionLabel = new Label
            {
                Text = "Wie soll dein Fest heißen?",
                FontSize = 14,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            

            Frame instructionFrame = new Frame { /*HeightRequest = ParentView.Height * 0.4,*/ BackgroundColor = Color.FromHex("F8800") };
            instructionFrame.Content = instructionLabel;

            Entry partyTitle = new Entry
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Placeholder = "Gebe den Namen der Veranstaltung an"
            };

            Grid titleStack = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(3, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(3, GridUnitType.Star) }
                },
            };
            titleStack.Children.Add(instructionLabel, 0, 0);
            titleStack.Children.Add(partyTitle, 0, 2);
            Content = titleStack;
        }


    }
}
