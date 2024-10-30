using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mobilna
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            for(int i = 0; i < 5; i++)
            {
                Photos.Children.Add(new Image() { Source = "question.png", HeightRequest = 60 });
            }
        }
    }
}
