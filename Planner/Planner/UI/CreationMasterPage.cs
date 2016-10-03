using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Planner.UI.Behaviors;

namespace Planner.UI
{
    class CreationMasterPage : ContentPage
    {
        private const bool expanded = true;
        private const bool closed = false;
        public CreationMasterPage()
        {
            TableView TBPoints = new TableView();
            TBPoints.Intent = TableIntent.Menu;
            TBPoints.HasUnevenRows = true;

            #region stackPlannings - Auflistung aktueller Daten und einfügen in ScrollView:
            //#region Point EventName:

            //#region Labels:
            //Label LBEventNameHeader = new Label { Text = "Veranstaltungsname:", HorizontalTextAlignment = TextAlignment.Start };
            //Label LBEventNameDetail1 = new Label
            //{
            //    Text = "\t\tAfrican Taste",
            //    FontSize = LBEventNameHeader.FontSize * 0.8,
            //    IsVisible = false,
            //};
            //#endregion

            //#region EventName: Combine Titel-Label and Detail-Labels into StackCellEventName:
            //StackLayout StackCellEventName = new StackLayout();
            //StackCellEventName.Children.Add(LBEventNameHeader);
            //StackCellEventName.Children.Add(LBEventNameDetail1);
            //#endregion

            //#region Combine StackCellEventName into ViewCell "VCEventName":
            //ViewCell VCEventName = new ViewCell
            //{
            //    View = StackCellEventName
            //};
            //#endregion

            //#region Combine VCEventName into TableSection TSEventName:
            //TableSection TSEventname = new TableSection();
            //TSEventname.Add(VCEventName);
            //#endregion

            //#region Combine TSEventName into TableView "TBPoints":
            //TBPoints.Root.Add(TSEventname);
            //#endregion
            
            #region ExpandedClosedGestureRecognizer EventName:
            //var expandedClosed = closed;
            //var ExpandedClosedTapGestureRecognizer = new TapGestureRecognizer();
            //ExpandedClosedTapGestureRecognizer.Tapped += (s, e) => {
            //    if (expandedClosed)
            //    {//Wenn aufgeklappt => zuklappen
            //        LBEventNameDetail1.IsVisible = false;
            //        expandedClosed = closed;
            //    }
            //    else
            //    {//Wenn zugeklappt => aufklappen
            //        LBEventNameDetail1.IsVisible = true;
            //        expandedClosed = expanded;
            //    }
            //};
            //LBEventNameHeader.GestureRecognizers.Add(ExpandedClosedTapGestureRecognizer);
            #endregion
            #endregion

            #region List Generation:
            var i = 0;
            List<List<string>> list = new List<List<string>>();
            List<string> Eventname = new List<string> ();
            list.Add(new List<string>());
            list[i].Add("Eventname:");
            list[i].Add("African - Taste"); i++;

            List<string> Motto = new List<string>();
            list.Add(new List<string>());
            list[i].Add("Motto:");
            list[i].Add("Afrika"); i++;

            List<string> Location = new List<string>();
            list.Add(new List<string>());
            list[i].Add("Location:");
            list[i].Add("Primär-Location:");
            list[i].Add("Bibliothek");
            list[i].Add("Ausweich-Location:");
            list[i].Add("M-Bau, M3.02"); i++;

            List<string> Datum = new List<string>();
            list.Add(new List<string>());
            list[i].Add("Datum:");
            list[i].Add("Primär-Datum");
            list[i].Add("12.06.2017");
            list[i].Add("Ausweich-Datum");
            list[i].Add("01.02.2017"); i++;

            List<string> Uhrzeit = new List<string>();
            list.Add(new List<string>());
            list[i].Add("Uhrzeit:");
            list[i].Add("17:30"); i++;

            List<string> Gäste = new List<string>();
            list.Add(new List<string>());
            list[i].Add("Gäste:");
            list[i].Add("Einladungen:");
            list[i].Add("Offene Veranstaltung"); i++;

            List<string> Equipment = new List<string>();
            list.Add(new List<string>());
            list[i].Add("Equipment:");
            list[i].Add("Musikanlage");
            list[i].Add("Verlängerungskabel 3,5m");
            list[i].Add("Kühltruhe");
            list[i].Add("Biertischgarnituren"); i++;

            List<string> SanitäreAnlagen =  new List<string>();
            list.Add(new List<string>());
            list[i].Add("Sanitäre Anlagen:");
            list[i].Add("W3.21"); i++;

            List<string> Dekoration = new List<string>();
            list.Add(new List<string>());
            list[i].Add("Dekoration:");
            list[i].Add("Tischdecken");
            list[i].Add("Pappaufsteller");
            list[i].Add("Wimpel"); i++;

            List<string> Gastronomie = new List<string>();
            list.Add(new List<string>());
            list[i].Add("Gastronomie:");
            list[i].Add("Getränke:");
            list[i].Add("Bier");
            list[i].Add("Limo");
            list[i].Add("Essen:");
            list[i].Add("Frittierte Süßkartoffeln");
            list[i].Add("Bohnensalat"); i++;
            #endregion
            
            PlanningPoints test = new PlanningPoints(list);

            #region Combine all Items generated by PlanningPoints(list) into the Scrollview "scrollPoints"
            ScrollView scrollPoints = new ScrollView();
            scrollPoints.Content = new PlanningPoints(list);
            #endregion

            //EventName.GestureRecognizers.Add(new TapGestureRecognizer() => OnLabelClicked()));

            #region stackOptions - Optionen-Buttons unterhalb der Auflistung, außerhalb der ScrollView:
            StackLayout stackOptions = new StackLayout { VerticalOptions = LayoutOptions.EndAndExpand};
            stackOptions.Children.Add(new Button { Text = "Veranstaltung speichern" });
            stackOptions.Children.Add(new Button { Text = "Budget Planer" });
            stackOptions.Children.Add(new Button { Text = "Veranstaltung verwerfen" });
            #endregion

            #region stackCreation - Gesamt-StackLayout mit stackPlannings und stackOptions für Content der CreationMasterPage:
            StackLayout stackCreation = new StackLayout();
            stackCreation.Children.Add(scrollPoints);
            stackCreation.Children.Add(stackOptions);
            #endregion

            Title = "Neues Fest - Master";





        Content = stackCreation;
        }
    }
}
