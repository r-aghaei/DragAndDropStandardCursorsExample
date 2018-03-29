using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDropCursorsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Cursor = DragDropCursors.None;
            button2.Cursor = DragDropCursors.Move;
            button3.Cursor = DragDropCursors.Copy;
            button4.Cursor = DragDropCursors.Link;
            button5.Cursor = DragDropCursors.MoveDark;
            button6.Cursor = DragDropCursors.CopyDark;
            button7.Cursor = DragDropCursors.LinkDark;
        }
    }
}
