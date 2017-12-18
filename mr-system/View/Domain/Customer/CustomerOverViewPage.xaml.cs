using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using mr_system.Commands;
using mr_system.View.Domain.Customer;
using mr_system.ViewModel.App;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace mr_system.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CustomerOverViewPage : Page
    {
        private CustomerMasterDetailsViewModel mdvm;
        public CustomerOverViewPage()
        {
            this.InitializeComponent();
            mdvm = new CustomerMasterDetailsViewModel();
        }

        private void NewCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CustomerPage));
            Singleton.Instance.Selected = false;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CustomerPage));
            Singleton.Instance.Selected = true;
        }

        private async void CustomerOverViewPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            await Refresh();
        }

        private Task Refresh()
        {

            mdvm.RefreshCommand.Execute(mdvm);
            return Task.CompletedTask;
        }
    }
}