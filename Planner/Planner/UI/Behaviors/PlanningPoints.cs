using System.Collections.Generic;
using Xamarin.Forms;

namespace Planner.UI.Behaviors
{
    class PlanningPoints : TableView
    {
        public PlanningPoints(List<List<string>> list)
        {
            HasUnevenRows = true;
            Intent = TableIntent.Data;

            var i = 0;
            var listIncrement = 0;

        //---------------------------------------------------------------------------
            foreach (var sublist in list)
            {
                StackLayout SSubList = new StackLayout
                {
                    StyleId = "Stack" + list[listIncrement][0],
                };
              
                ViewCell VCSubList = new ViewCell
                {
                    StyleId = "VC" + list[listIncrement][0],   
                                         
                };

                //VCSubList.Tapped += OnViewCellTapped(list[listIncrement][0]);

                TableSection TSSubList = new TableSection(list[listIncrement][0]);
                TSSubList.Add(VCSubList);
                //TableSectionBase<Label>;

                Root.Add(TSSubList);

                listIncrement++;
        //---------------------------------------------------------------------------

                foreach (var text in sublist)
                {
                    var labelCount = sublist.Count - 1;
                    //if(i == 0) { i++; continue; }
                    Label label = new Label
                    {
                        StyleId = text,
                        Text = text,
                        HorizontalTextAlignment = TextAlignment.Start,
                        IsVisible = true,
                    };
                    if (i != 0)
                    {
                        label.GestureRecognizers.Add(new TapGestureRecognizer
                        {
                            Command = new Command(() => OnLabelClicked(label)),
                        });
                    }
                                    
                    if (i <= labelCount)
                    {
                        SSubList.Children.Add(label);
                        if (i == 0) { label.IsVisible = true; }
                        else { label.Text = "\t\t\t\t" + label.Text; }
                        i++;
                    }
                    VCSubList.View = SSubList;
                    
                }
                i = 0;
            }          
        }
        #region private Methods:
        private void OnLabelClicked(Label label)
        {
            label.IsVisible = false;
            //DisplayAlert("alert", label.Text, "s");
        }
        #endregion
    }
}
