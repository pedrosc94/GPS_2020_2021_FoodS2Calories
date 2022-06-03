using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodS2Calories
{
    public partial class App : Application
    {

        static FoodItemDatabase database;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.Green,
                BarTextColor = Color.White,
            };
        }

        public static FoodItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new FoodItemDatabase();
                }
                return database;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
