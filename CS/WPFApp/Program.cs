using System;
using System.Collections.Generic;
using System.Text;

namespace WPFApp
{
    public class Program
    {
        [STAThreadAttribute()]
        public static void Main()
        {
            using (new MyUWPApp.App())
            {
                WPFApp.App app = new WPFApp.App();
                app.InitializeComponent();
                app.Run();
            }
        }
    }
}
