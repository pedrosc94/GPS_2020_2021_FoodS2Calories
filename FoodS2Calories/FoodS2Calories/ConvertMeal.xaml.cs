using Nest;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Essentials;


namespace FoodS2Calories
{
    public partial class ConvertMeal : ContentPage
    {

       

        public ConvertMeal()
        {
            InitializeComponent();
            
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConvertedPage());
            Console.WriteLine("ButtonScreen1_Clicked");
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetItemsAsync();
            
        }

       
        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TodoItemPage
            {
                BindingContext = new FoodItem()
            });
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new AddItemPage
                {
                    BindingContext = e.SelectedItem as FoodItem
                });
            }
        }
    }
}
