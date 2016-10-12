using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Reflection;
namespace Planner.UI
{
    class MasterPage : ContentPage
    {
        public MasterPage()
        {
            #region Header Definition
            StackLayout Header = new StackLayout();
            Header.HorizontalOptions = LayoutOptions.Center;
            Header.VerticalOptions = LayoutOptions.Center;
            Grid headerGrid = new Grid { HorizontalOptions = LayoutOptions.Fill, VerticalOptions = LayoutOptions.Fill, };

            Header.Children.Add(new Frame
            {
                OutlineColor = Color.Gray,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Content = headerGrid,
            });


            ColumnDefinition leftHeaderColumn = new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) };
            ColumnDefinition middleHeaderColumn = new ColumnDefinition { Width = new GridLength(5, GridUnitType.Star) };
            ColumnDefinition rightHeaderColumn = new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) };

            Label headerLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                Text = "Header"
            };

            headerGrid.ColumnDefinitions.Add(leftHeaderColumn);
            headerGrid.ColumnDefinitions.Add(middleHeaderColumn);
            headerGrid.ColumnDefinitions.Add(rightHeaderColumn);

            //headerGrid.Children.Add(backIcon, 0, 0);
            headerGrid.Children.Add(headerLabel, 1, 0);
            #endregion
            #region Footer Definition
            StackLayout Footer = new StackLayout();
            //Footer.HorizontalOptions = LayoutOptions.Fill;
            //Footer.VerticalOptions = LayoutOptions.Fill;
            Grid footerGrid = new Grid { HorizontalOptions = LayoutOptions.Fill, VerticalOptions = LayoutOptions.Fill, };

            footerGrid.Children.Add(new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                Text = "Footer"
            });

            Footer.Children.Add(new Frame
            {
                OutlineColor = Color.Gray,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Content = footerGrid,
            });

            #endregion

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

            masterGrid.Children.Add(Header, 0, 0);
            masterGrid.Children.Add(img, 0, 1);

            masterGrid.Children.Add(stackButtons, 0, 3);
            masterGrid.Children.Add(Footer, 0, 4);
            #endregion
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
            Title = "Master";
            Content = masterGrid;/*new StartViewMasterContent();*/
        }
    }
}
