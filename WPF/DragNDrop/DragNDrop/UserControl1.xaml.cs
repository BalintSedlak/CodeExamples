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

namespace DragNDrop
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {

        public UserControl1(Answer answer)
        {
            InitializeComponent();
            this.DataContext = this;
            Answer = answer;
        }

        public Answer Answer { get; private set; }

        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UserControl1 userControl = sender as UserControl1;
            if (userControl != null && e.LeftButton == MouseButtonState.Pressed)
            {
                DataObject dataObject = new DataObject(Answer);

                DragDrop.DoDragDrop(userControl,
                                     dataObject,
                                     DragDropEffects.Move);
            }
        }
    }
}
