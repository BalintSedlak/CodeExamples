using System;

namespace DragNDrop
{
    public class Answer
    {
        public int Column { get; set; }
        public string Text { get; set; }

        public Answer(int column, string text)
        {
            Column = column;
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }
    }
}
