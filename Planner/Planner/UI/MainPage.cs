using Planner.UI;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Planner.UI
{
    public class MainPage : MasterDetailPage
    {
        MasterPage masterPage;
        DetailPage detailPage;
        public static NavigationPage navDetailPage;
        public static NavigationPage navMasterPage;        

        public MainPage()
        {
            masterPage = new MasterPage();
            navMasterPage = new NavigationPage (masterPage);
            navMasterPage.Title = "MasterNav";

            detailPage = new DetailPage();
            navDetailPage = new NavigationPage (detailPage);
            navDetailPage.Title = "DetailNav";
            
            Master = navMasterPage;
            Detail =  navDetailPage ;                     
        }

    }
}
