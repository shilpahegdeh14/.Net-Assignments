
using System.Windows.Forms;

namespace Assignment3_Shilpa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
               
        protected override void OnMouseMove(MouseEventArgs mouseEv)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            int posX = Cursor.Position.X;
            int posY = Cursor.Position.Y;
            string s = "X= "+ posX.ToString() + "  Y=  " + posY.ToString();
            textBox1.Text = s;
        }
    }
}
