using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using MvvmHelpers;
using MvvmHelpers.Commands;

namespace COD_Randomizer_App
{
    public class MainPageViewModel : BaseViewModel
    {
        public ICommand GenerateCommand { get; }

        int count = 1;

        string slot1;
        public string Slot1
        {
            get => slot1;
            set => SetProperty(ref slot1, value);
        }

        public MainPageViewModel()
        {
            GenerateCommand = new Command(OnGenerate);
        }

        private void OnGenerate(object obj)
        {
            Slot1 = count.ToString();
            count++;
        }
    }
}
