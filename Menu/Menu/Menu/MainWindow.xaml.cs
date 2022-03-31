using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Menu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool menushower = false;//menu fechado

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuImageChanger(object sender, ContextMenuEventArgs e)
        {
            //menu esta aberto?
            if (!menushower)
            {
                hamburgermenu.Geometry = Geometry.Parse("M21,15.61L19.59,17L14.58,12L19.59,7L21,8.39L17.44,12L21,15.61M3,6H16V8H3V6M3,13V11H13V13H3M3,18V16H16V18H3Z");
                menushower = true;
            }
            else
            {
                hamburgermenu.Geometry = Geometry.Parse("M3,6H21V8H3V6M3,11H21V13H3V11M3,16H21V18H3V16Z");
                menushower = false;
            }
        }
    }
}
