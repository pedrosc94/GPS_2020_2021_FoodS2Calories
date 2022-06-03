using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodS2Calories
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : ContentPage
    {
        public Settings()
        {
            InitializeComponent();
            
        }
       

        


        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TodoListPage());
            Console.WriteLine("ButtonScreen3_Clicked");
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WarningPage());
            Console.WriteLine("ButtonScreen3_Clicked");
        }


        static void defineLanguage(bool language) { }

        static void defineUnit(bool unit) { }

    }
}