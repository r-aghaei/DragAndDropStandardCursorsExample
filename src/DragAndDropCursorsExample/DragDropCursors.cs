using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDropCursorsExample
{
    public sealed class DragDropCursors
    {
        private static readonly Cursor[] Cursors = new Cursor[7];
        public static Cursor None { get { return Cursors[0]; } }
        public static Cursor Move { get { return Cursors[1]; } }
        public static Cursor Copy { get { return Cursors[2]; } }
        public static Cursor Link { get { return Cursors[3]; } }
        public static Cursor MoveDark { get { return Cursors[4]; } }
        public static Cursor CopyDark { get { return Cursors[5]; } }
        public static Cursor LinkDark { get { return Cursors[6]; } }

        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string dllToLoad);
        [DllImport("user32.dll")]
        public static extern IntPtr LoadCursor(IntPtr hInstance, UInt16 lpCursorName);

        static DragDropCursors()
        {
            var libHandle = LoadLibrary("ole32.dll");
            for (int i = 0; i < Cursors.Length; i++)
            {
                var h = LoadCursor(libHandle, (ushort)(i + 1));
                Cursors[i] = new Cursor(h);
            }
        }
    }
}
