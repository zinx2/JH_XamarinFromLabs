using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CustomMdTest
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var mdp = new MyMasterDetailPage();
            mdp.DrawerWidth = 100;
            mdp.Title = "MainPage";
            mdp.Master = new ContentPage
            {
                Title = "Master",
                BackgroundColor = Color.Yellow,
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                                    new Label {
                                        XAlign = TextAlignment.Center,
                                        Text = "Welcome to Xamarin Forms!"
                                    },
                                    new Button{Text="Test 1 button"}
                                }
                }
            };
            mdp.Detail = new NavigationPage(new ContentPage
            {
                BackgroundColor = Color.Red,
                Content = new StackLayout() { BackgroundColor = Color.Aqua }
            });

            MainPage = mdp;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
