using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCoffeeApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeeEquipmentPage : ContentPage
    {
        public CoffeeEquipmentPage()
        {
            InitializeComponent();
            LabelCount.Text = "Hello from the Code Behind!";
        }

        int count = 0;
        private void ButtonClick_Clicked(object sender, EventArgs e)
        {
            count++;
            LabelCount.Text = $"You clicked {count} time(s).";
        }
    }
}