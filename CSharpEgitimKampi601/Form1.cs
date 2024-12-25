using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        VScrollBar vscrollbar = new VScrollBar();
        HScrollBar hscrollbar = new HScrollBar();

        private void Form1_Load(object sender, EventArgs e)
        {
            vscrollbar.Dock = DockStyle.Right;
            hscrollbar.Dock = DockStyle.Bottom;
            Controls.Add(vscrollbar);
            Controls.Add(hscrollbar);
        }
    }
}
