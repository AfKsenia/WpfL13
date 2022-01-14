using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfL13
{
    class MyCommands
    {
        public static RoutedCommand Exit { get; set; }
        public static RoutedCommand Bold { get; set; }
        public static RoutedCommand Italic { get; set; }
        public static RoutedCommand Underline { get; set; }
        static MyCommands()
        {
            Exit = new RoutedUICommand("Выход", "Exit", typeof(MyCommands));
            Bold = new RoutedCommand("Bold", typeof(MyCommands));
            Italic = new RoutedCommand("Italic", typeof(MyCommands));
            Underline= new RoutedCommand("Underline", typeof(MyCommands));
        }
    }

}
