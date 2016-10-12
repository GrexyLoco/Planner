using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Planner.UI
{
    class DetailPage : ContentPage
    {
        private bool hasBackButton = true;

        public DetailPage()
        {
            Title = "RootDetailPage";

            #region Header Definition
            StackLayout Header = new StackLayout();
            Header.HorizontalOptions = LayoutOptions.FillAndExpand;
            Header.VerticalOptions = LayoutOptions.FillAndExpand;
            Grid headerGrid = new Grid { HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, };

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
                FontSize = 30,
                Text = "Header"
            };

            headerGrid.ColumnDefinitions.Add(leftHeaderColumn);
            headerGrid.ColumnDefinitions.Add(middleHeaderColumn);
            headerGrid.ColumnDefinitions.Add(rightHeaderColumn);
            
            //headerGrid.Children.Add(backIcon, 0, 0);
            headerGrid.Children.Add(headerLabel, 1, 0);
            #endregion

            #region Body Definition
            //------------------------------------------------------------------------------------------------------
            Grid Body = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(7, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                },
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };      

            Image detailImg = new Image { Source = "africantaste.jpg", Aspect = Aspect.AspectFit, VerticalOptions = LayoutOptions.CenterAndExpand, HorizontalOptions = LayoutOptions.Start };
            Button btnPDF = new Button { Text = "Veranstaltungs-PDF laden" };

            Body.Children.Add(detailImg, 0, 0);
            Body.Children.Add(btnPDF, 0, 1);
            //------------------------------------------------------------------------------------------------------
            #endregion

            #region Footer Definition
            StackLayout Footer = new StackLayout();
            Footer.HorizontalOptions = LayoutOptions.Fill;
            Footer.VerticalOptions = LayoutOptions.Fill;
            Grid footerGrid = new Grid { HorizontalOptions = LayoutOptions.Fill, VerticalOptions = LayoutOptions.Fill, };

            footerGrid.Children.Add(new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                Text = "Footerrr"
            });

            Footer.Children.Add(new Frame
            {
                OutlineColor = Color.Gray,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Content = footerGrid,
            });

            #endregion

            #region Main-Grid Definition
            Grid mainGrid = new Grid {/* BackgroundColor = Color.FromHex("#FF8800") */};

            RowDefinition maingridRowHeader = new RowDefinition { Height = new GridLength(1, GridUnitType.Star) };
            RowDefinition maingridRowBody = new RowDefinition { Height = new GridLength(8, GridUnitType.Star) };
            RowDefinition maingridRowFooter = new RowDefinition { Height = new GridLength(1, GridUnitType.Star) };

            mainGrid.RowDefinitions.Add(maingridRowHeader);
            mainGrid.RowDefinitions.Add(maingridRowBody);
            mainGrid.RowDefinitions.Add(maingridRowFooter); 


            mainGrid.Children.Add(Header, 0, 0);
            mainGrid.Children.Add(Body, 0, 1);
            mainGrid.Children.Add(Footer, 0, 2);
            #endregion
            
            Content = mainGrid;

            
            btnPDF.Clicked += (sender, args) => MainPage.navDetailPage.PushAsync(new SecondPage());
        }

        

        #region Methoden


        public bool HasBackButton
        {
            get
            {
                return hasBackButton;
            }
            set
            {
                hasBackButton = value;
            }
        }

        

        #endregion
    }
}
