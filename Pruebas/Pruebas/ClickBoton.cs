using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas
{
    class ClickBoton
    {
        public static void Click()
        {
            Form1 Form = new Form1();

            Form.textBox1.Text = "Pruebas";
            Form.Refresh();
        }
    }
}
