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
        Scene sc;
        FormsRenderer renderer;

        bool filled = false;
        int xStart, yStart, width = -1, height = -1;

        public mainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            renderer = new FormsRenderer(this);
            sc = new Scene(renderer);
            //this.Invalidate();
            //this.Update();
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            labelStatus.Hide();
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

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            this.Location = new Point(Location.X - 200, Location.Y - 100);
            this.Size = new Size(800, 600);
            
            checkBoxFilled.Show();
            checkBoxFilled.Location = new Point(440, 10);

            label.Text = "Draw a figure";
            label.Location = new Point(330, 10);

            buttonDraw.Hide();

            buttonImport.Size = new Size(120, 40);
            
            List<Button> secondaryButtons = new List<Button> { buttonSave, buttonImport, buttonTriangle, buttonRectangle, buttonCircle };

            int i = 0;
            foreach(Button b in secondaryButtons)
            {
                b.Location = new Point(40 + (i * 140), 40);
                b.Show();
                i++;
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            labelStatus.Hide();
            if (buttonDraw.Visible)
                buttonDraw_Click(sender, e);
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.FileName = "figures.bin";
                openFileDialog.Filter = "Binary files (*.bin)|*.bin|All files(*.*)|*.*";
                openFileDialog.DefaultExt = "Binary files (*.bin)|*.bin|All files(*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (sc.ImportFigures(openFileDialog.FileName))
                    {
                        labelStatus.Text = "Import successful";
                        labelStatus.ForeColor = Color.Green;
                        labelStatus.Show();
                    }
                    else
                    {
                        labelStatus.Text = "Invalid file";
                        labelStatus.ForeColor = Color.Red;
                        labelStatus.Show();
                    }
                }

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            labelStatus.Hide();
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = "figures.bin";
                saveFileDialog.Filter = "Binary files (*.bin)|*.bin|All files(*.*)|*.*";
                saveFileDialog.DefaultExt = "Binary files (*.bin)|*.bin|All files(*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    sc.SaveFigures(saveFileDialog.FileName);
            }
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            labelStatus.Hide();
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

        private void mainForm_Paint(object sender, PaintEventArgs e)
        {
            sc.Redraw();
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            labelStatus.Hide();
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

        private void checkBoxFilled_CheckedChanged(object sender, EventArgs e) { filled = !filled; }

        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    sc.SelectFigure(new Point(e.X, e.Y));

                    break;
                case MouseButtons.Middle:
                    sc.RotateFigures(new Point(e.X, e.Y));
                    break;
                case MouseButtons.Right:
                    if (filled)
                    {
                        using (ColorDialog ColorPicker = new ColorDialog())
                            if (ColorPicker.ShowDialog() == DialogResult.OK)
                                sc.ChangeFigureColor(new Point(e.X, e.Y), ColorPicker.Color, true);
                    }
                    else
                        sc.ChangeFigureColor(new Point(e.X, e.Y), this.BackColor, false);
                    break;
            }
        }
    }
}
