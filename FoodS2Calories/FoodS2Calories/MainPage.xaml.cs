using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;
using System.Threading;
using System.Windows.Input;



namespace FoodS2Calories
{
    public partial class MainPage : ContentPage
    {

        string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "textfile.txt");
        string var;
       



        public MainPage()
        {
            InitializeComponent();
            var appIcon = ImageSource.FromResource("FoodS2Calories.Resx.FoodS2Calories.ico");
            NavigationPage.SetTitleIconImageSource(this, appIcon);

            try { var = File.ReadAllText(fileName); }

            catch (System.IO.FileNotFoundException)
            {
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.almonds, Notes = 21.6, Glicids = 7, Lipids = 56 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.apple, Notes = 0.2, Glicids = 13, Lipids = 0.5 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.banana, Notes = 1, Glicids = 21, Lipids = 0.4 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.bread, Notes = 6, Glicids = 56, Lipids = 1 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.butter, Notes = 2, Glicids = 2, Lipids = 81 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.cake, Notes = 4, Glicids = 62, Lipids = 14 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.carrot, Notes = 0.6, Glicids = 4.4, Lipids = 0 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.cereal, Notes = 14, Glicids = 69, Lipids = 2 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.cheese, Notes = 16, Glicids = 22, Lipids = 1.5 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.chocolate, Notes = 5, Glicids = 44, Lipids = 30 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.cream, Notes = 2, Glicids = 2, Lipids = 32 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.cookies, Notes = 10, Glicids = 71, Lipids = 2 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.egg, Notes = 13, Glicids = 0, Lipids = 10.8 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.fish, Notes = 20, Glicids = 0, Lipids = 0.8 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.garlic, Notes = 3.8, Glicids = 11, Lipids = 0.6 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.lettuce, Notes = 2, Glicids = 0.2, Lipids = 0.8 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.mango, Notes = 0.5, Glicids = 11, Lipids = 0.3 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.milk, Notes = 3, Glicids = 3.5, Lipids = 4.5 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.mushrooms, Notes = 1.8, Glicids = 0.4, Lipids = 0.5 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.oliveoil, Notes = 0, Glicids = 99.9, Lipids = 0 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.onion, Notes = 0.9, Glicids = 3.1, Lipids = 0.2 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.pasta, Notes = 3.4, Glicids = 20, Lipids = 0.6 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.pea, Notes = 5, Glicids = 7, Lipids = 0.5 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.peach, Notes = 0.6, Glicids = 12, Lipids = 0.3 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.pear, Notes = 0.3, Glicids = 9.4, Lipids = 0.4 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.pizza, Notes = 8, Glicids = 26, Lipids = 8 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.potatoes, Notes = 2.5, Glicids = 19, Lipids = 0 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.redmeat, Notes = 20, Glicids = 0, Lipids = 5 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.rice, Notes = 7, Glicids = 28, Lipids = 0.5 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.shrimp, Notes = 22, Glicids = 0.4, Lipids = 0.8 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.sugar, Notes = 0, Glicids = 99.3, Lipids = 0 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.tomatoes, Notes = 0.8, Glicids = 3.5, Lipids = 0.3 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.whitemeat, Notes = 20, Glicids = 0, Lipids = 13 });
                Thread.Sleep(50);
                App.Database.SaveItemAsync(new FoodItem { Name = Resx.AppResources.yogurt, Notes = 4, Glicids = 5, Lipids = 0.2 });
                Thread.Sleep(50);

                File.WriteAllText(fileName, "a base de dados ja esta preenchida!");
            }


        }


        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConvertMeal());
            Console.WriteLine("ButtonScreen1_Clicked");


           



        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Settings());
            Console.WriteLine("ButtonScreen2_Clicked");
        }
    }
}
