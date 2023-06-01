using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd6._1_Gorbatyuk
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Secret : ContentPage
{
    public Secret(string selectedPickerItem, double sliderValue)
    {
        InitializeComponent();

             var pickerLabel = new Label
            {
                Text = $"Selected element: {selectedPickerItem}",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            var sliderLabel = new Label
            {
                Text = $"Selected element: {sliderValue}",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Content = new StackLayout
            {
                Children = { pickerLabel, sliderLabel }
            };
    }
}
}