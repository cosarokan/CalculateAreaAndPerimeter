using System;
using System.Windows.Forms;
using Abstract_InterfaceWithWinForm.Entities;

namespace Abstract_InterfaceWithWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // radio buttonlar tikli olmamalı.   

            groupBoxOperations.Enabled = false;
        }

        private void cBoxSquare_CheckedChanged(object sender, EventArgs e)
        {
            // kare tiklendiği zaman dikdörtgenin tik kalksın!

            if (cBoxSquare.CheckState == CheckState.Checked)
            {
                cBoxRectangle.Checked = false;
                groupBoxOperations.Enabled = true;
                lblSecondSide.Visible = false;
                txtSecondSide.Visible = false;
                lblFirstSide.Visible = true;
                lblFirstSide.Text = "Side";
                txtFirstSide.Visible = true;
            }
            else if (cBoxSquare.Checked == false && !cBoxRectangle.Checked)
            {
                groupBoxOperations.Enabled = false;
            }
        }

        private void cBoxRectangle_CheckedChanged(object sender, EventArgs e)
        {
            // dikdörtgen tiklendiği zaman karenin tik kalksın!

            if (cBoxRectangle.CheckState == CheckState.Checked)
            {
                cBoxSquare.Checked = false; // kare tik event'i kaldırıldı.
                groupBoxOperations.Enabled = true; // işlem kısmı açıldı
                lblFirstSide.Text = "Short Side";
                lblSecondSide.Visible = true; // ikinci kenar görünüyor
                txtSecondSide.Visible = true; // ikinci kenar text box görünüyor
                lblSecondSide.Text = "Long Side";
            }
            else if (cBoxSquare.Checked == false && !cBoxRectangle.Checked)
            {
                groupBoxOperations.Enabled = false;
            }
        }

        private void btnCalculateArea_Click(object sender, EventArgs e)
        {
            if (cBoxRectangle.Checked)
            {
                Rectangle rectangle = new Rectangle()
                {
                    ShortSide = Convert.ToInt32(txtFirstSide.Text),
                    LongSide = Convert.ToInt32(txtSecondSide.Text),
                    ShapeName = txtShapeName.Text
                };
                double result = rectangle.CalculateArea();
                MessageBox.Show($"{rectangle.ShapeName}'s rectangle area: {result}");
                Clear();
            }
            else if (cBoxSquare.Checked)
            {
                Square square = new Square()
                {
                    ShapeName = txtShapeName.Text,
                    Side = Convert.ToInt32(txtFirstSide.Text)
                };
                double result = square.CalculateArea();
                MessageBox.Show($"{square.ShapeName}'s square area: {result}");
                Clear();
            }
        }

        private void btnCalculateEnvironment_Click(object sender, EventArgs e)
        {
            if (cBoxRectangle.Checked)
            {
                Rectangle rectangle = new Rectangle()
                {
                    ShortSide = Convert.ToInt32(txtFirstSide.Text),
                    LongSide = Convert.ToInt32(txtSecondSide.Text),
                    ShapeName = txtShapeName.Text
                };
                double result = rectangle.CalculatePerimeter();
                MessageBox.Show($"{rectangle.ShapeName}'s rectangle perimeter: {result}");
                Clear();
            }
            else if (cBoxSquare.Checked)
            {
                Square square = new Square()
                {
                    ShapeName = txtShapeName.Text,
                    Side = Convert.ToInt32(txtFirstSide.Text)
                };
                double result = square.CalculatePerimeter();
                MessageBox.Show($"{square.ShapeName}'s square perimeter: {result}");
                Clear();
            }
        }
        void Clear()
        {
            txtFirstSide.Clear();
            txtSecondSide.Clear();
            txtShapeName.Clear();
            cBoxSquare.Checked = false;
            cBoxRectangle.Checked = false;
            groupBoxOperations.Enabled = false;
        }
    }
}
