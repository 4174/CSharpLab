using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LearnWpf
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string oneWayValue;
        //public string OneWayValue { get => oneWayValue; set => oneWayValue = value; }
        public string OneWayValue
        {
            get { return oneWayValue; }
            set { if (oneWayValue != value) { oneWayValue = value; RaisePropertyChanged(); } }
        }

        private string twoWayValue;
        public string TwoWayValue
        {
            get { return twoWayValue; }
            set { if (twoWayValue != value) { twoWayValue = value; RaisePropertyChanged(); } }
        }

        public ViewModel()
        {
            OneWayValue = "OneWay Starting Value";
            TwoWayValue = "TwoWay Starting Value";
        }

        #region MVVM related        
        private void RaisePropertyChanged([CallerMemberName]string propertyName = "") // волшебство .NET 4.5
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
