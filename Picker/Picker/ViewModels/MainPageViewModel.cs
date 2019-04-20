using Picker.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Picker.ViewModels
{
    public class MonkeysPageViewModel : ViewModelBase
    {
        public IList<Monkey> Monkeys { get { return MonkeyData.Monkeys; } }

        public ICommand ConfirmCommand { get; private set; } //

        Monkey selectedMonkey;

        public MonkeysPageViewModel()
        {

            ConfirmCommand = new Command(() => Confirm());
        }

        private void Confirm()
        {

            Debug.WriteLine("test");

            Debug.WriteLine((SelectedMonkey as Monkey).Location);
            Debug.WriteLine(((Monkey)SelectedMonkey).Location);



        }

        public Monkey SelectedMonkey
        {
            get { return selectedMonkey; }
            set
            {
                if (selectedMonkey != value)
                {
                    selectedMonkey = value;
                    OnPropertyChanged();
                }
            }
        }



    }
}
