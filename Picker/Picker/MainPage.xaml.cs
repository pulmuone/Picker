using Picker.Models;
using Picker.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Picker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysPageViewModel();
        }

        private void BtnConfirm_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine((this.pickerMonkey.SelectedItem as Monkey).Location);
        }
    }
}
