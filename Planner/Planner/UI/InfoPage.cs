using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Planner.UI
{
    class InfoPage : ContentPage
    {

        public InfoPage()
        {
            Label infoLabel = new Label
            {
                Text = "Diese App wurde nicht zu kommerziellen Zwecken erstellt und dient einzig der Organisation von Veranstaltungen im Rahmen der WACAF-Group der Hochschule Augsburg. Diese App vermittelt keinen Anspruch auf Rechtssicherheit und Aktualität. Alle Rechte vorbehalten. Entwickler: Georg Kumpf",
                FontSize = 14,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
            };

            Button btnback = new Button
            {
                Text = "Zurück"
            };

            StackLayout infoPageGrid = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,               
                Children = {infoLabel, btnback}
            };
            Content = infoPageGrid;

            btnback.Clicked += (sender, args) => MainPage.navMasterPage.PopAsync();

        }
    }
}
