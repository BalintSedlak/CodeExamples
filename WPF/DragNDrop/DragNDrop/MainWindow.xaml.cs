using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace DragNDrop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        List<Answer> _answers;

        private int goodAnswers;

        public int GoodAnswers
        {
            get { return goodAnswers; }
            set { goodAnswers = value; OnPropertyChanged(); }
        }

        int currentAnswerIndex = 0;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            _answers = new List<Answer>()
            {
                new Answer(0, "Green"),
                new Answer(1, "Red"),
                new Answer(0, "Green"),
                new Answer(1, "Red"),
                new Answer(0, "Green"),
                new Answer(1, "Red"),
                new Answer(0, "Green"),
                new Answer(1, "Red"),
                new Answer(0, "Green"),
                new Answer(1, "Red"),
                new Answer(0, "Green"),
                new Answer(1, "Red"),
                new Answer(0, "Green"),
                new Answer(1, "Red"),
                new Answer(0, "Green"),
                new Answer(1, "Red")
            };

            AddNewAnswer();
        }

        private void _rightPanel_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void _leftPanel_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void _leftPanel_Drop(object sender, DragEventArgs e)
        {
            Answer answer = (Answer)e.Data.GetData(typeof(Answer));
            if (answer.Column==0)
            {

            _leftPanel.Children.Add(new TextBlock() { Text = answer.Text });
                GoodAnswers++;

            }
                AddNewAnswer();
        }

        private void _rightPanel_Drop(object sender, DragEventArgs e)
        {
            Answer answer = (Answer)e.Data.GetData(typeof(Answer));
            if (answer.Column == 1)
            {

                _rightPanel.Children.Add(new TextBlock() { Text = answer.Text });
                GoodAnswers++;
            }

            AddNewAnswer();
        }

        public void AddNewAnswer()
        {
            _answerPanel.Children?.Clear();

            if (_answers.Count - 1 <= currentAnswerIndex)
            {
                return;
            }
            
            UserControl1 userControl = new UserControl1(_answers[currentAnswerIndex]);
            currentAnswerIndex++;
            _answerPanel.Children.Add(userControl);
        }
    }
}
