using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace BindEnumToCombobox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public IEnumerable<string> ComboboxItemsSource { get => ValuesEnum.First.GetAllDescription<ValuesEnum>(); }

        private ValuesEnum selectedItem;

        public ValuesEnum SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedItem))); }
        }

        public MainWindow()
        {
            InitializeComponent();
            _mainPanel.DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
