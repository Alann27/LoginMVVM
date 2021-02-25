using LoginMVVM.Models;
using LoginMVVM.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginMVVM.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public MenuOption BarAndHotelMenuOption { get;} = new MenuOption { Image = "beerJar.png", Title = "Bars & Hotels", Places = "42 Place" };
        public MenuOption FineDiningMenuOption { get;} = new MenuOption{Image = "dining.png", Title = "Fine Dining", Places= "15 Place"}; 
        public MenuOption CafesMenuOption { get; } = new MenuOption{Image = "cafe.png", Title = "Cafes", Places= "28 Place"};
        public MenuOption NearbyMenuOption { get; } = new MenuOption { Image = "nearby.png", Title = "Nearby", Places = "34 Place" };
        public MenuOption FastFoodsMenuOption { get; } = new MenuOption{Image = "fastFood.png", Title = "Fast Foods", Places= "29 Place"};
        public MenuOption FeaturedFoodsMenuOption { get; } = new MenuOption{Image = "pizza.png", Title = "Featured Foods", Places= "21 Place"};

        public ICommand ChangeSelectedMenuOptionCommand { get; }

        public HomeViewModel(IAlertService alertService, INavigationService navigationService) : base(alertService, navigationService)
        {
            ChangeSelectedMenuOptionCommand = new Command(OnChangeSelectedOption); 
        }

        private void OnChangeSelectedOption (object sender)
        {
            StackLayout stackLayoutSelected = (StackLayout)sender;

            stackLayoutSelected.BackgroundColor = Color.Gold;


            Grid stackLayoutsOnMenu = (Grid)stackLayoutSelected.Parent;

            foreach (object children in stackLayoutsOnMenu.Children)
            {
                if (children is StackLayout)
                {
                    StackLayout stackLayoutNonSelected = (StackLayout)children;
                    if (stackLayoutSelected != children)
                    {
                        stackLayoutNonSelected.BackgroundColor = Color.White;
                    }
                }

            }
        }
    }
}
