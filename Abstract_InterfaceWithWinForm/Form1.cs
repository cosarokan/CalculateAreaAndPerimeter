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
            groupBoxOperations.Enabled = false;
            StartCase();
        }    
        private void cBoxSquare_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxSquare.CheckState == CheckState.Checked)
            {
                SquareOperations();
            }
            else if (!cBoxSquare.Checked && !cBoxRectangle.Checked && !cBoxTriangle.Checked && !cBoxCircle.Checked)
            {
                groupBoxOperations.Enabled = false;
            }
        }
        private void cBoxTriangle_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxTriangle.CheckState == CheckState.Checked)
            {
                TriangleOperations();
            }
            else if (!cBoxSquare.Checked && !cBoxRectangle.Checked && !cBoxTriangle.Checked && !cBoxCircle.Checked)
            {
                groupBoxOperations.Enabled = false;
            }
        }
        private void cBoxRectangle_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxRectangle.CheckState == CheckState.Checked)
            {
                RectangleOperations();
            }
            else if (!cBoxSquare.Checked && !cBoxRectangle.Checked && !cBoxTriangle.Checked && !cBoxCircle.Checked)
            {
                groupBoxOperations.Enabled = false;
            }
        }
        private void cBoxCircle_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxCircle.CheckState == CheckState.Checked)
            {
                CircleOperations();
            }
            else if (!cBoxCircle.Checked && !cBoxSquare.Checked && !cBoxRectangle.Checked && !cBoxTriangle.Checked)
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
            else if (cBoxTriangle.Checked)
            {
                Triangle triangle = new Triangle()
                {
                    FirstSide = Convert.ToInt32(txtFirstSide.Text),
                    Height = Convert.ToInt32(txtHeight.Text),
                };
                double result = triangle.CalculateArea();
                MessageBox.Show($"{triangle.ShapeName}'s triangle area: {result}");
                Clear();
            }
            else if (cBoxCircle.Checked)
            {
                Circle circle = new Circle()
                {
                    Radius = Convert.ToInt32(txtRadius.Text)
                };
                double result = circle.CalculateArea();
                MessageBox.Show($"{circle.ShapeName}'s circle area: {result}");
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
            else if (cBoxTriangle.Checked)
            {
                Triangle triangle = new Triangle()
                {
                    ShapeName = txtShapeName.Text,
                    FirstSide = Convert.ToInt32(txtFirstSide.Text),
                    SecondSide = Convert.ToInt32(txtSecondSide.Text),
                    ThirdSide = Convert.ToInt32(txtThirdSide.Text)
                };
                double result = triangle.CalculatePerimeter();
                MessageBox.Show($"{triangle.ShapeName}'s triangle perimeter: {result}");
                Clear();
            }
            else if (cBoxCircle.Checked)
            {
                Circle circle = new Circle()
                {
                    Radius = Convert.ToInt32(txtRadius.Text)
                };
                double result = circle.CalculatePerimeter();
                MessageBox.Show($"{circle.ShapeName}'s circle perimeter: {result}");
                Clear();
            }
        }

        /// <summary>
        /// square operations (visible, enable vs.)
        /// </summary>
        void SquareOperations()
        {
            cBoxRectangle.Checked = false;
            cBoxTriangle.Checked = false;
            cBoxCircle.Checked = false;
            groupBoxOperations.Enabled = true;

            lblFirstSide.Text = "Side";
            lblFirstSide.Visible = true;
            txtFirstSide.Visible = true;

            lblSecondSide.Visible = false;
            txtSecondSide.Visible = false;

            lblThirdSide.Visible = false;
            txtThirdSide.Visible = false;

            lblHeight.Visible = false;
            txtHeight.Visible = false;

            lblSpecialForTriangleHeight.Visible = false;
            lblTriangleFloorLength.Visible = false;

            lblRadius.Visible = false;
            txtRadius.Visible = false;
        }

        /// <summary>
        /// rectangle operations (visibile, enable vs.)
        /// </summary>
        void RectangleOperations()
        {
            cBoxSquare.Checked = false; 
            cBoxTriangle.Checked = false; 
            cBoxCircle.Checked = false;
            groupBoxOperations.Enabled = true; 

            lblFirstSide.Text = "Short Side";

            lblSecondSide.Text = "Long Side";
            lblSecondSide.Visible = true; 
            txtSecondSide.Visible = true; 

            lblThirdSide.Visible = false;
            txtThirdSide.Visible = false;

            lblHeight.Visible = false;
            txtHeight.Visible = false;

            lblSpecialForTriangleHeight.Visible = false;
            lblTriangleFloorLength.Visible = false;

            lblRadius.Visible = false;
            txtRadius.Visible = false;

        }

        /// <summary>
        /// triangle operations (visible, enable vs.)
        /// </summary>
        void TriangleOperations()
        {
            cBoxRectangle.Checked = false;
            cBoxSquare.Checked = false;
            cBoxCircle.Checked = false;
            groupBoxOperations.Enabled = true;

            lblFirstSide.Visible = true;
            lblFirstSide.Text = "Side";

            lblSecondSide.Visible = true;
            lblSecondSide.Text = "Side";

            lblThirdSide.Visible = true;
            lblThirdSide.Text = "Side";

            txtFirstSide.Visible = true;
            txtSecondSide.Visible = true;
            txtThirdSide.Visible = true;

            lblHeight.Visible = true;
            txtHeight.Visible = true;

            lblSpecialForTriangleHeight.Visible = true;
            lblTriangleFloorLength.Visible = true;

            lblRadius.Visible = false;
            txtRadius.Visible = false;
        }

        /// <summary>
        /// circle operations (visible, enable vs.)
        /// </summary>
        void CircleOperations()
        {
            cBoxSquare.Checked = false;
            cBoxTriangle.Checked = false;
            cBoxRectangle.Checked = false;
            groupBoxOperations.Enabled = true;

            lblFirstSide.Visible = false;
            txtFirstSide.Visible = false;

            lblSecondSide.Visible = false;
            txtSecondSide.Visible = false;

            lblThirdSide.Visible = false;
            txtThirdSide.Visible = false;

            lblHeight.Visible = false;
            txtHeight.Visible = false;

            lblRadius.Visible = true;
            txtRadius.Visible = true;

            lblSpecialForTriangleHeight.Visible = false;
            lblTriangleFloorLength.Visible = false;
        }

        void StartCase()
        {
            lblSpecialForTriangleHeight.Visible = false;
            lblTriangleFloorLength.Visible = false;
        }

        /// <summary>
        /// Clear the text boxes
        /// </summary>
        void Clear()
        {
            txtFirstSide.Clear();
            txtSecondSide.Clear();
            txtThirdSide.Clear();
            txtShapeName.Clear();
            txtHeight.Clear();
            txtRadius.Clear();
            cBoxSquare.Checked = false;
            cBoxRectangle.Checked = false;
            cBoxTriangle.Checked = false;
            cBoxCircle.Checked = false;
            groupBoxOperations.Enabled = false;
        }


    }
}
