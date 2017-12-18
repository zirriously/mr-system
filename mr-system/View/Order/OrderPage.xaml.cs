using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using mr_system.ViewModel.App;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace mr_system.View.Order
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrderPage : Page
    {
        public OrderPage()
        {
            this.InitializeComponent();
        }

        private void Button_ClickGoBack(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OrderOverviewPage));
        }

        private void ExistingCustSearch_QuerySubmitted(SearchBox sender, SearchBoxQuerySubmittedEventArgs args)
        {
            
        }

        private void OverAllPrice_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            double _priceWithoutTax;
            try
            {
                _priceWithoutTax = Convert.ToDouble(OverAllPrice.Text);
                _priceWithoutTax = _priceWithoutTax * 0.75;
                PriceWithoutTax.Text = _priceWithoutTax.ToString() + ",- dkk uden moms";
            }
            catch (Exception exception)
            {
                return;
            }
        }

        private void OrderPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            if (Singleton.Instance.OrderSelected)
            {
                request.Text = Singleton.Instance.OrderInfo;
                Mål.Text = Singleton.Instance.Measurements1;
                Mål2.Text = Singleton.Instance.Measurements2;
                Medie.Text = Singleton.Instance.Media1;
                Medie2.Text = Singleton.Instance.Media2;
                Antal.Text = Singleton.Instance.NumberOfItems;
                Laminat.Text = Singleton.Instance.Laminat1;
                Laminat2.Text = Singleton.Instance.Laminat2;
                Price.Text = Singleton.Instance.Price;
                DtpPrice.Text = Singleton.Instance.DtpPrice;
                CustomOrder.Text = Singleton.Instance.SpecialOrderInfo;
            }
        }
    }
}
