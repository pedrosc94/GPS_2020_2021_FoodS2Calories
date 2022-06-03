using System;
using Xamarin.Forms;

namespace FoodS2Calories
{
    public partial class ConvertedPage : ContentPage
    {
        public ConvertedPage()
        {

            InitializeComponent();
        }

   

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetItemsDoneAsync();

            double sum = 0;
            foreach (FoodItem food in listView.ItemsSource)
            {
                sum = sum + food.Total;

            }


            totalx.Text = String.Format("{0:0.00}", sum)  + " cal";
            if(sum>100000)
            { easterEgg.Text = Resx.AppResources.guiness; }
        }

        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TodoItemPage
            {
                BindingContext = new FoodItem()
            });
        }

     
    }
}
