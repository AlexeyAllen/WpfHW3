//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Input;

//namespace WpfHW3
//{
//    public class MyCommandsLibrary
//    {
//        public static RoutedUICommand Exit { get; set; }

//        static MyCommandsLibrary()
//        {
//            InputGestureCollection input1 = new InputGestureCollection();
//            input1.Add(new KeyGesture(Key.T, ModifierKeys.Control, "Ctrl+T"));
//            Exit = new RoutedUICommand("Выход", "Exit", typeof(MyCommandsLibrary), input1);
//        }
//    }
//}
