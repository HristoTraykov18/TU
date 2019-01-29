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
        bool filled = false;
        int xStart, yStart, width = -1, height = -1;

        public mainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            renderer = new FormsRenderer(this);
            sc = new Scene(renderer);
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            this.Location = new Point(Location.X - 200, Location.Y - 100);
            this.Size = new Size(800, 600);

            checkBoxFilled.Enabled = true;
            checkBoxFilled.Visible = true;
            checkBoxFilled.Location = new Point(440, 10);

            label.Text = "Draw a figure";
            label.Location = new Point(330, 10);

            buttonDraw.Enabled = false;
            buttonDraw.Visible = false;

            buttonImport.Size = new Size(120, 40);
            
            List<Button> secondaryButtons = new List<Button> { buttonSave, buttonImport, buttonTriangle, buttonRectangle, buttonCircle };

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
            if (!sc.SaveFigures("figures.bin"))
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            using (Form3 form3 = new Form3())
            {
                if (form3.ShowDialog() == DialogResult.OK)
                {
                    width = form3.Width;
                    height = form3.Height;
                    xStart = form3.X_Start;
                    yStart = form3.Y_Start;
                    sc.DrawFigures(1, xStart, yStart, width, height, filled);
                }
            }
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            using (Form3 form3 = new Form3())
            {
                if (form3.ShowDialog() == DialogResult.OK)
                {
                    width = form3.Width;
                    height = form3.Height;
                    xStart = form3.X_Start;
                    yStart = form3.Y_Start;
                    sc.DrawFigures(2, xStart, yStart, width, height, filled);
                }
            }
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            using (Form3 form3 = new Form3())
            {
                if (form3.ShowDialog() == DialogResult.OK)
                {
                    width = form3.Width;
                    height = form3.Height;
                    xStart = form3.X_Start;
                    yStart = form3.Y_Start;
                    sc.DrawFigures(3, xStart, yStart, width, height, filled);
                }
            }
        }

        private void checkBoxFilled_CheckedChanged(object sender, EventArgs e) { filled = !filled; }

        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    //sc.MouseKeyEvent(Scene.MouseKeyCode.Left, new Point(e.X, e.Y));
                    break;
                case MouseButtons.Middle:
                    sc.RotateFigures(new Point(e.X, e.Y));
                    break;
                case MouseButtons.Right:
                    //sc.MouseKeyEvent(Scene.MouseKeyCode.Right, new Point(e.X, e.Y));
                    break;
            }
        }
    }
}
