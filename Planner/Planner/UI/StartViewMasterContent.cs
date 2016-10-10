using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Planner.UI
{
    class StartViewMasterContent : ContentView
    {
        public StartViewMasterContent()
        {

            #region StartViewMasterContent
            Button btnOpt1 = new Button { Text = "Neues Fest", FontSize = 16 };
            Button btnOpt2 = new Button { Text = "Fest laden", FontSize = 16 };
            Button btnOpt3 = new Button { Text = "Info", FontSize = 16 };

            Image img = new Image { Source = "sonneafrica.jpg", Aspect = Aspect.AspectFit, VerticalOptions = LayoutOptions.CenterAndExpand, HorizontalOptions = LayoutOptions.CenterAndExpand };
            StackLayout stackButtons = new StackLayout { VerticalOptions = LayoutOptions.End };
            stackButtons.Children.Add(btnOpt1);
            stackButtons.Children.Add(btnOpt2);
            stackButtons.Children.Add(btnOpt3);

            //var masterPageItems = new List<MasterPageItem>();

            Grid masterGrid = new Grid
            {
                //BackgroundColor = Color.FromHex("#FF8800"),
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(3, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(2, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(3, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                }
            };

            //masterGrid.Children.Add(Header, 0, 0);
            masterGrid.Children.Add(img, 0, 1);

            masterGrid.Children.Add(stackButtons, 0, 3);
            //masterGrid.Children.Add(Footer, 0, 4);

            btnOpt1.Clicked += (sender, args) =>
            {
                App.mainPage.Detail = new NavigationPage(new CreateNamePage());
                App.mainPage.IsPresented = false;
                App.mainPage.Master = new CreationMasterPage();
                App.mainPage.Master.Title = "Neu erstellen";
                //MainPage.navMasterPage.PushAsync(new CreationMasterPage());
                //App.mainPage.Master = new NavigationPage(new CreationMasterPage { Title = "sdgag"});
            };
            btnOpt3.Clicked += (sender, args) => MainPage.navMasterPage.PushAsync(new InfoPage());
            #endregion

        }
    }
}
