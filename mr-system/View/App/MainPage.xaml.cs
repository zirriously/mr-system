using mr_system.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace mr_system
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void NavView_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (NavigationViewItemBase item in NavView.MenuItems)
            {
                if (item is NavigationViewItem && item.Tag.ToString() == "overView")
                {
                    NavView.SelectedItem = item;
                    break;
                }
            }
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                ContentFrame.Navigate(typeof(SettingsPage));
            }
            else
            {
                switch (args.InvokedItem)
                {
                    case "overView":
                        ContentFrame.Navigate(typeof(OverViewPage));
                        break;

                    case "OrderOverView":
                        ContentFrame.Navigate(typeof(OrderOverviewPage));
                        break;

                    case "CustomerOverView":
                        ContentFrame.Navigate(typeof(CustomerOverViewPage));
                        break;
                }
            }
        }

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
               ContentFrame.Navigate(typeof(SettingsPage));
            }
            else
            {

                NavigationViewItem item = args.SelectedItem as NavigationViewItem;

                switch (item.Tag)
                {
                    case "overView":
                        ContentFrame.Navigate(typeof(OverViewPage));
                        break;

                    case "orderOverView":
                       ContentFrame.Navigate(typeof(OrderOverviewPage));
                        break;

                    case "customerOverView":
                        ContentFrame.Navigate(typeof(CustomerOverViewPage));
                        break;
                }
            }
        }


        private void ThemeToggleButton_OnClick(object sender, RoutedEventArgs e)
        {

            if (ActualTheme == ElementTheme.Dark)
                RequestedTheme = ElementTheme.Light;
            else
                RequestedTheme = ElementTheme.Dark;
        }
    }
}
