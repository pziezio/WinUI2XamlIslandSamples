using Microsoft.Toolkit.Forms.UI.XamlHost;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private readonly WindowsXamlHost xamlHost;

        public Form1()
        {
            InitializeComponent();

            xamlHost = new WindowsXamlHost
            {
                Dock = DockStyle.Fill,
                InitialTypeName = "MyUWPApp.MyUserControl"
            };

            Controls.Add(xamlHost);
        }
    }
}
