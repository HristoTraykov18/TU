using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectLibrary;

namespace CourseProject
{
    public partial class mainForm : Form
    {
        FormsRenderer renderer;
        Scene sc;

        public mainForm()
        {
            InitializeComponent();
            renderer = new FormsRenderer(this);
            sc = new Scene(renderer);
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            this.Size = new Size(800, 600);

            label.Text = "Draw a figure";
            label.Location = new Point(330, 10);

            buttonDraw.Enabled = false;
            buttonDraw.Visible = false;

            buttonImport.Size = new Size(120, 40);
            
            List<Button> secondaryButtons = new List<Button> { buttonSave, buttonImport, buttonTriangle, buttonRectangle, buttonLine };

            int i = 0;
            foreach(Button b in secondaryButtons)
            {
                b.Location = new Point(40 + (i * 140), 40);
                b.Enabled = true;
                b.Visible = true;
                i++;
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            sc.ImportFigures("figures.bin");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!sc.SaveFigures<Figure>("figures.bin"))
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }

        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            sc.DrawFigures(1);
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            sc.DrawFigures(2);
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            sc.DrawFigures(3);
        }

        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    break;
                case MouseButtons.Middle:
                    sc.RotateFigure(e.X, e.Y);
                    break;
                case MouseButtons.Right:
                    break;
            }
        }
    }
}
