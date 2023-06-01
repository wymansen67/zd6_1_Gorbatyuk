using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Forms.Internals.Profile;

namespace zd6._1_Gorbatyuk
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Additional : ContentPage
    {
        private Label selectedLbl;
        private Button Button0;
        private Button Button1;
        private Button Button2;
        private Button Button3;
        private Button Button4;
        private Button Button5;
        private Button Button6;
        private Button Button7;
        private Button Button8;
        private Picker Picker;
        private Switch CheckBox0;
        private Switch CheckBox1;
        private Switch CheckBox2;
        private Switch CheckBox3;
        private Switch CheckBox4;
        private Switch CheckBox5;
        private Slider Slider0;
        private Slider Slider1;
        private Slider Slider2;
        private Slider Slider3;
        private Slider Slider4;

        public Additional(string user)
        {
            InitializeComponent();

            selectedLbl = new Label
            {
                TextColor = Color.Black,
                Text = $"Вы выбрали {0}"
            };

            Button0 = new Button
            {
                Text = "STATIC",
                Margin = new Thickness(5, 0, 5, 0),
                StyleId = "bttnStyle0",
                WidthRequest = 120
            };

            Button0.Clicked += MyButton_Clicked;

            Button1 = new Button
            {
                Text = "STATIC",
                Margin = new Thickness(0, 0, 5, 0),
                StyleId = "bttnStyle1",
                WidthRequest = 120
            };

            Button1.Clicked += MyButton_Clicked;

            Button2 = new Button
            {
                Text = "STATIC",
                Margin = new Thickness(0, 0, 0, 0),
                StyleId = "bttnStyle2",
                WidthRequest = 120
            };

            Button2.Clicked += MyButton_Clicked;

            Button3 = new Button
            {
                Text = "HOVER",
                Margin = new Thickness(5, 0, 5, 0),
                StyleId = "bttnStyle3",
                WidthRequest = 120
            };

            Button3.Clicked += MyButton_Clicked;

            Button4 = new Button
            {
                Text = "HOVER",
                Margin = new Thickness(0, 0, 5, 0),
                StyleId = "bttnStyle4",
                WidthRequest = 120
            };

            Button4.Clicked += MyButton_Clicked;

            Button5 = new Button
            {
                Text = "HOVER",
                Margin = new Thickness(0, 0, 0, 0),
                StyleId = "bttnStyle5",
                WidthRequest = 120
            };

            Button5.Clicked += MyButton_Clicked;

            CheckBox0 = new Switch
            {
                OnColor = Color.White,
                ThumbColor = Color.White
            };

            CheckBox0.Toggled += (sender, e) =>
            {
                if (CheckBox0.IsToggled)
                {
                    CheckBox0.ThumbColor = Color.White;
                    CheckBox0.OnColor = Color.Red;
                }
                else
                {
                    CheckBox0.ThumbColor = Color.White;
                    CheckBox0.OnColor = Color.White;
                }
            };

            CheckBox1 = new Switch
            {
                OnColor = Color.Gray,
                ThumbColor = Color.White

            };

            CheckBox1.Toggled += (sender, e) =>
            {
                if (CheckBox1.IsToggled)
                {
                    CheckBox1.ThumbColor = Color.White;
                    CheckBox1.OnColor = Color.Red;
                }
                else
                {
                    CheckBox1.ThumbColor = Color.White;
                    CheckBox1.OnColor = Color.White;
                }
            };

            CheckBox2 = new Switch
            {
                OnColor = Color.Gray,
                ThumbColor = Color.White

            };

            CheckBox2.Toggled += (sender, e) =>
            {
                if (CheckBox2.IsToggled)
                {
                    CheckBox2.ThumbColor = Color.White;
                    CheckBox2.OnColor = Color.Red;
                }
                else
                {
                    CheckBox2.ThumbColor = Color.White;
                    CheckBox2.OnColor = Color.White;
                }
            };

            CheckBox3 = new Switch
            {
                OnColor = Color.Red,
                ThumbColor = Color.Gray,
                HorizontalOptions = LayoutOptions.EndAndExpand,
            };

            CheckBox3.Toggled += (sender, e) =>
            {
                if (CheckBox3.IsToggled)
                {
                    CheckBox3.ThumbColor = Color.Red;
                    CheckBox3.OnColor = Color.Black;
                }
                else
                {
                    CheckBox3.ThumbColor = Color.Gray;
                    CheckBox3.OnColor = Color.Black;
                }
            };

            CheckBox4 = new Switch
            {
                OnColor = Color.Red,
                ThumbColor = Color.Gray,
                HorizontalOptions = LayoutOptions.EndAndExpand,
            };

            CheckBox4.Toggled += (sender, e) =>
            {
                if (CheckBox4.IsToggled)
                {
                    CheckBox4.ThumbColor = Color.Red;
                    CheckBox4.OnColor = Color.Black;
                }
                else
                {
                    CheckBox4.ThumbColor = Color.Gray;

                }
            };

            CheckBox5 = new Switch
            {
                OnColor = Color.Red,
                ThumbColor = Color.Gray,
                HorizontalOptions = LayoutOptions.EndAndExpand,

            };

            CheckBox5.Toggled += (sender, e) =>
            {
                if (CheckBox5.IsToggled)
                {
                    CheckBox5.ThumbColor = Color.Red;
                    CheckBox5.OnColor = Color.Black;
                }
                else
                {
                    CheckBox5.ThumbColor = Color.Gray;

                }
            };

            Button6 = new Button
            {
                Text = "PRESSED",
                Margin = new Thickness(5, 0, 5, 0),
                StyleId = "bttnStyle6",
                WidthRequest = 120
            };

            Button6.Clicked += MyButton_Clicked;

            Button7 = new Button
            {
                Text = "PRESSED",
                Margin = new Thickness(0, 0, 5, 0),
                StyleId = "bttnStyle7",
                WidthRequest = 120
            };

            Button7.Clicked += MyButton_Clicked;

            Button8 = new Button
            {
                Text = "PRESSED",
                Margin = new Thickness(0, 0, 0, 0),
                StyleId = "bttnStyle8",
                WidthRequest = 120
            };

            Button8.Clicked += MyButton_Clicked;

            Picker = new Picker
            {
                Title = "DROPDOWN",
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            Picker.Items.Add("Select One");
            Picker.Items.Add("Select Two");
            Picker.Items.Add("Select Three");
            Picker.Items.Add("Select Four");
            Picker.SelectedIndexChanged += MyPicker_SelectedIndexChanged;

            Slider0 = new Slider
            {
                Minimum = 0,
                Maximum = 100,
                Value = 5,
                ThumbColor = Color.White,
                MinimumTrackColor = Color.Green,
                Margin = new Thickness(30, 0, 30, 0)
            };

            Slider0 = new Slider
            {
                Minimum = 0,
                Maximum = 100,
                Value = 5,
                ThumbColor = Color.White,
                MinimumTrackColor = Color.Green,
                Margin = new Thickness(30, 0, 30, 0)
            };

            Slider1 = new Slider
            {
                Minimum = 0,
                Maximum = 60,
                Value = 5,
                ThumbColor = Color.Gray,
                MinimumTrackColor = Color.Green,
                Margin = new Thickness(30, 0, 30, 0)
            };

            Slider2 = new Slider
            {
                Minimum = 0,
                Maximum = 60,
                Value = 5,
                ThumbColor = Color.Gray,
                MinimumTrackColor = Color.Green,
                Margin = new Thickness(30, 0, 30, 0)
            };

            Slider3 = new Slider
            {
                Minimum = 0,
                Maximum = 100,

                Value = 60,
                ThumbColor = Color.Gray,
                MinimumTrackColor = Color.Green,
                Margin = new Thickness(30, 0, 30, 0)
            };

            Slider4 = new Slider
            {
                Minimum = 0,
                Maximum = 100,
                Value = 5,
                ThumbColor = Color.Gray,
                HeightRequest = 20,
                MinimumTrackColor = Color.White,
                Margin = new Thickness(30, 0, 150, 0),
            };

            Content = new StackLayout
            {
                BackgroundColor = Color.White,
                Padding = new Thickness(10, 10, 10, 0),
                Children =
    {
        new StackLayout
        {
            Orientation = StackOrientation.Horizontal,
            Children = { Button0, Button1, Button2 }
        },
        new StackLayout
        {
            Orientation = StackOrientation.Horizontal,
            Children = { Button3, Button4, Button5 }
        },
        new StackLayout
        {
            Orientation = StackOrientation.Horizontal,
            Children = { Button6, Button7, Button8 }
        },
        Picker,
        new StackLayout
        {
            Orientation = StackOrientation.Horizontal,
            Children =
            {
                new StackLayout
                {
                    Orientation = StackOrientation.Vertical,
                    Children = { CheckBox0, CheckBox1, CheckBox2, }
                },
                new StackLayout
                {
                    Orientation = StackOrientation.Vertical,
                    Children = { CheckBox3, CheckBox4, CheckBox5, }
                }
            }
        },

        Slider0, Slider1,Slider2,

        new Grid
        {
            Children =
            {
                { Slider3, 0, 0 }, { Slider4, 0, 0 }
            }
        },
                }
            };

        }

        private void MyPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ItemPicker = Picker.SelectedItem as string;

            Slider0.IsVisible = false;
            Slider1.IsVisible = false;
            Slider2.IsVisible = false;
            Slider3.IsVisible = false;
            Slider4.IsVisible = false;

            switch (ItemPicker)
            {
                case "Select One":
                    Slider0.IsVisible = true;
                    selectedLbl.Text = $"You chose {Slider0.Value}";
                    break;
                case "Select Two":
                    Slider1.IsVisible = true;
                    selectedLbl.Text = $"You chose {Slider1.Value}";
                    break;
                case "Select Three":
                    Slider2.IsVisible = true;
                    selectedLbl.Text = $"You chose {Slider2.Value}";
                    break;
                case "Select Four":
                    Slider3.IsVisible = true;
                    Slider4.IsVisible = true;
                    selectedLbl.Text = $"You chose {Slider3.Value}";
                    break;
            }
        }

        private void MyButton_Clicked(object sender, EventArgs e)
        {
            string ItemPicker = Picker.SelectedItem as string;
            double sliderValue = Slider1.Value;

            Secret page = new Secret(ItemPicker, sliderValue);
            Navigation.PushAsync(page);
        }
    }
}