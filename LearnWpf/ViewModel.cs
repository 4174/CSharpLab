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

        public Person PersonOne { get; set; }

        public string TextBlockForTest { get; set; } = "...";

        public ViewModel()
        {
            PersonOne = new Person
            {
                Gender = Gender.Female,
                Age = 24,
                FirstName = "Jane",
                LastName = "Doe"
            };

            ///TextBlockForTest = "!!!";
        }
    }
}
