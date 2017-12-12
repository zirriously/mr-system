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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace mr_system.View.Order
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NewOrderPage : Page
    {
        public NewOrderPage()
        {
            this.InitializeComponent();
            this.myScrollViewer.AddHandler(UIElement.PointerPressedEvent,
                new PointerEventHandler(myScrollViewer_PointerPressed),
                true /*handledEventsToo*/);
            this.myScrollViewer.AddHandler(UIElement.PointerReleasedEvent,
                new PointerEventHandler(myScrollViewer_PointerReleased),
                true /*handledEventsToo*/);
            this.myScrollViewer.AddHandler(UIElement.PointerCanceledEvent,
                new PointerEventHandler(myScrollViewer_PointerCanceled),
                true /*handledEventsToo*/);
        }

        private void myScrollViewer_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            if (e.Pointer.PointerDeviceType == Windows.Devices.Input.PointerDeviceType.Pen)
            {
                (myScrollViewer.Content as UIElement).ManipulationMode &= ~ManipulationModes.System;
            }
        }

        private void myScrollViewer_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            if (e.Pointer.PointerDeviceType == Windows.Devices.Input.PointerDeviceType.Pen)
            {
                (myScrollViewer.Content as UIElement).ManipulationMode |= ManipulationModes.System;
            }
        }

        private void myScrollViewer_PointerCanceled(object sender, PointerRoutedEventArgs e)
        {
            if (e.Pointer.PointerDeviceType == Windows.Devices.Input.PointerDeviceType.Pen)
            {
                (myScrollViewer.Content as UIElement).ManipulationMode |= ManipulationModes.System;
            }
        }
    }
}