using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LearnWpf
{
    public static class FormatCommands
    {
        static RoutedUICommand setBackground = new RoutedUICommand("Set the Background",
            "SetBackground", typeof(FormatCommands));

        public static RoutedUICommand SetBackground { get { return setBackground; } }
    }
}
