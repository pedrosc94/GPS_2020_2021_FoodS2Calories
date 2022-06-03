using System;
using Xamarin.Forms;

namespace FoodS2Calories
{
    public partial class AddItemPage : ContentPage
    {
        public AddItemPage()
        {
            InitializeComponent();
        }

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var todoItem = (FoodItem)BindingContext;

            if (todoItem.Units == true)
            {
                todoItem.Done = true;
                todoItem.Weight = todoItem.Weight * 0.0022;
                await App.Database.SaveItemAsync(todoItem);
                await Navigation.PopAsync();


            }
            else
            {
                todoItem.Done = true;
                await App.Database.SaveItemAsync(todoItem);
                await Navigation.PopAsync();
            }
          
         
        }


        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;


            if (isToggled == true)

            {
                UnitsText.Text = "lb";
                var todoItem = (FoodItem)BindingContext;
                todoItem.Units = true;

            }

            else
            {
                UnitsText.Text = "g";
                var todoItem = (FoodItem)BindingContext;
                todoItem.Units = false;
            }

        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            var todoItem = (FoodItem)BindingContext;
            todoItem.Done = false;
            await App.Database.SaveItemAsync(todoItem);
            await Navigation.PopAsync();
        }
    }
}

// <Label Text="Add Food to meal:" />
// <Switch IsToggled="{Binding Done}" HorizontalOptions="StartAndExpand"/>