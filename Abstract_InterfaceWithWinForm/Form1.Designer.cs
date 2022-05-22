namespace Abstract_InterfaceWithWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxOperations = new System.Windows.Forms.GroupBox();
            this.lblSpecialForTriangleHeight = new System.Windows.Forms.Label();
            this.lblTriangleFloorLength = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.btnCalculateEnvironment = new System.Windows.Forms.Button();
            this.btnCalculateArea = new System.Windows.Forms.Button();
            this.txtThirdSide = new System.Windows.Forms.TextBox();
            this.txtSecondSide = new System.Windows.Forms.TextBox();
            this.txtFirstSide = new System.Windows.Forms.TextBox();
            this.lblThirdSide = new System.Windows.Forms.Label();
            this.txtShapeName = new System.Windows.Forms.TextBox();
            this.lblSecondSide = new System.Windows.Forms.Label();
            this.lblFirstSide = new System.Windows.Forms.Label();
            this.lblShapeName = new System.Windows.Forms.Label();
            this.cBoxSquare = new System.Windows.Forms.CheckBox();
            this.cBoxRectangle = new System.Windows.Forms.CheckBox();
            this.cBoxTriangle = new System.Windows.Forms.CheckBox();
            this.cBoxCircle = new System.Windows.Forms.CheckBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.groupBoxOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOperations
            // 
            this.groupBoxOperations.Controls.Add(this.lblSpecialForTriangleHeight);
            this.groupBoxOperations.Controls.Add(this.lblTriangleFloorLength);
            this.groupBoxOperations.Controls.Add(this.txtHeight);
            this.groupBoxOperations.Controls.Add(this.lblHeight);
            this.groupBoxOperations.Controls.Add(this.btnCalculateEnvironment);
            this.groupBoxOperations.Controls.Add(this.btnCalculateArea);
            this.groupBoxOperations.Controls.Add(this.txtRadius);
            this.groupBoxOperations.Controls.Add(this.txtThirdSide);
            this.groupBoxOperations.Controls.Add(this.txtSecondSide);
            this.groupBoxOperations.Controls.Add(this.lblRadius);
            this.groupBoxOperations.Controls.Add(this.txtFirstSide);
            this.groupBoxOperations.Controls.Add(this.lblThirdSide);
            this.groupBoxOperations.Controls.Add(this.txtShapeName);
            this.groupBoxOperations.Controls.Add(this.lblSecondSide);
            this.groupBoxOperations.Controls.Add(this.lblFirstSide);
            this.groupBoxOperations.Controls.Add(this.lblShapeName);
            this.groupBoxOperations.Location = new System.Drawing.Point(86, 92);
            this.groupBoxOperations.Name = "groupBoxOperations";
            this.groupBoxOperations.Size = new System.Drawing.Size(407, 294);
            this.groupBoxOperations.TabIndex = 2;
            this.groupBoxOperations.TabStop = false;
            // 
            // lblSpecialForTriangleHeight
            // 
            this.lblSpecialForTriangleHeight.AutoSize = true;
            this.lblSpecialForTriangleHeight.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSpecialForTriangleHeight.Location = new System.Drawing.Point(154, 146);
            this.lblSpecialForTriangleHeight.Name = "lblSpecialForTriangleHeight";
            this.lblSpecialForTriangleHeight.Size = new System.Drawing.Size(38, 13);
            this.lblSpecialForTriangleHeight.TabIndex = 5;
            this.lblSpecialForTriangleHeight.Text = "Height";
            // 
            // lblTriangleFloorLength
            // 
            this.lblTriangleFloorLength.AutoSize = true;
            this.lblTriangleFloorLength.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTriangleFloorLength.Location = new System.Drawing.Point(154, 47);
            this.lblTriangleFloorLength.Name = "lblTriangleFloorLength";
            this.lblTriangleFloorLength.Size = new System.Drawing.Size(66, 13);
            this.lblTriangleFloorLength.TabIndex = 5;
            this.lblTriangleFloorLength.Text = "Floor Length";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(92, 141);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(56, 20);
            this.txtHeight.TabIndex = 4;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(5, 148);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "Height";
            // 
            // btnCalculateEnvironment
            // 
            this.btnCalculateEnvironment.Location = new System.Drawing.Point(5, 247);
            this.btnCalculateEnvironment.Name = "btnCalculateEnvironment";
            this.btnCalculateEnvironment.Size = new System.Drawing.Size(384, 42);
            this.btnCalculateEnvironment.TabIndex = 2;
            this.btnCalculateEnvironment.Text = "Calculate Perimeter";
            this.btnCalculateEnvironment.UseVisualStyleBackColor = true;
            this.btnCalculateEnvironment.Click += new System.EventHandler(this.btnCalculateEnvironment_Click);
            // 
            // btnCalculateArea
            // 
            this.btnCalculateArea.Location = new System.Drawing.Point(6, 199);
            this.btnCalculateArea.Name = "btnCalculateArea";
            this.btnCalculateArea.Size = new System.Drawing.Size(383, 42);
            this.btnCalculateArea.TabIndex = 2;
            this.btnCalculateArea.Text = "Calculate Area";
            this.btnCalculateArea.UseVisualStyleBackColor = true;
            this.btnCalculateArea.Click += new System.EventHandler(this.btnCalculateArea_Click);
            // 
            // txtThirdSide
            // 
            this.txtThirdSide.Location = new System.Drawing.Point(92, 109);
            this.txtThirdSide.Name = "txtThirdSide";
            this.txtThirdSide.Size = new System.Drawing.Size(56, 20);
            this.txtThirdSide.TabIndex = 1;
            // 
            // txtSecondSide
            // 
            this.txtSecondSide.Location = new System.Drawing.Point(92, 77);
            this.txtSecondSide.Name = "txtSecondSide";
            this.txtSecondSide.Size = new System.Drawing.Size(56, 20);
            this.txtSecondSide.TabIndex = 1;
            // 
            // txtFirstSide
            // 
            this.txtFirstSide.Location = new System.Drawing.Point(92, 45);
            this.txtFirstSide.Name = "txtFirstSide";
            this.txtFirstSide.Size = new System.Drawing.Size(56, 20);
            this.txtFirstSide.TabIndex = 1;
            // 
            // lblThirdSide
            // 
            this.lblThirdSide.AutoSize = true;
            this.lblThirdSide.Location = new System.Drawing.Point(5, 115);
            this.lblThirdSide.Name = "lblThirdSide";
            this.lblThirdSide.Size = new System.Drawing.Size(28, 13);
            this.lblThirdSide.TabIndex = 0;
            this.lblThirdSide.Text = "Side";
            // 
            // txtShapeName
            // 
            this.txtShapeName.Location = new System.Drawing.Point(92, 13);
            this.txtShapeName.Name = "txtShapeName";
            this.txtShapeName.Size = new System.Drawing.Size(161, 20);
            this.txtShapeName.TabIndex = 1;
            // 
            // lblSecondSide
            // 
            this.lblSecondSide.AutoSize = true;
            this.lblSecondSide.Location = new System.Drawing.Point(6, 82);
            this.lblSecondSide.Name = "lblSecondSide";
            this.lblSecondSide.Size = new System.Drawing.Size(28, 13);
            this.lblSecondSide.TabIndex = 0;
            this.lblSecondSide.Text = "Side";
            // 
            // lblFirstSide
            // 
            this.lblFirstSide.AutoSize = true;
            this.lblFirstSide.Location = new System.Drawing.Point(6, 49);
            this.lblFirstSide.Name = "lblFirstSide";
            this.lblFirstSide.Size = new System.Drawing.Size(28, 13);
            this.lblFirstSide.TabIndex = 0;
            this.lblFirstSide.Text = "Side";
            // 
            // lblShapeName
            // 
            this.lblShapeName.AutoSize = true;
            this.lblShapeName.Location = new System.Drawing.Point(6, 16);
            this.lblShapeName.Name = "lblShapeName";
            this.lblShapeName.Size = new System.Drawing.Size(69, 13);
            this.lblShapeName.TabIndex = 0;
            this.lblShapeName.Text = "Shape Name";
            // 
            // cBoxSquare
            // 
            this.cBoxSquare.AutoSize = true;
            this.cBoxSquare.Location = new System.Drawing.Point(195, 24);
            this.cBoxSquare.Name = "cBoxSquare";
            this.cBoxSquare.Size = new System.Drawing.Size(60, 17);
            this.cBoxSquare.TabIndex = 3;
            this.cBoxSquare.Text = "Square";
            this.cBoxSquare.UseVisualStyleBackColor = true;
            this.cBoxSquare.CheckedChanged += new System.EventHandler(this.cBoxSquare_CheckedChanged);
            // 
            // cBoxRectangle
            // 
            this.cBoxRectangle.AutoSize = true;
            this.cBoxRectangle.Location = new System.Drawing.Point(281, 24);
            this.cBoxRectangle.Name = "cBoxRectangle";
            this.cBoxRectangle.Size = new System.Drawing.Size(75, 17);
            this.cBoxRectangle.TabIndex = 3;
            this.cBoxRectangle.Text = "Rectangle";
            this.cBoxRectangle.UseVisualStyleBackColor = true;
            this.cBoxRectangle.CheckedChanged += new System.EventHandler(this.cBoxRectangle_CheckedChanged);
            // 
            // cBoxTriangle
            // 
            this.cBoxTriangle.AutoSize = true;
            this.cBoxTriangle.Location = new System.Drawing.Point(195, 62);
            this.cBoxTriangle.Name = "cBoxTriangle";
            this.cBoxTriangle.Size = new System.Drawing.Size(64, 17);
            this.cBoxTriangle.TabIndex = 4;
            this.cBoxTriangle.Text = "Triangle";
            this.cBoxTriangle.UseVisualStyleBackColor = true;
            this.cBoxTriangle.CheckedChanged += new System.EventHandler(this.cBoxTriangle_CheckedChanged);
            // 
            // cBoxCircle
            // 
            this.cBoxCircle.AutoSize = true;
            this.cBoxCircle.Location = new System.Drawing.Point(281, 62);
            this.cBoxCircle.Name = "cBoxCircle";
            this.cBoxCircle.Size = new System.Drawing.Size(52, 17);
            this.cBoxCircle.TabIndex = 5;
            this.cBoxCircle.Text = "Circle";
            this.cBoxCircle.UseVisualStyleBackColor = true;
            this.cBoxCircle.CheckedChanged += new System.EventHandler(this.cBoxCircle_CheckedChanged);
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(6, 176);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(40, 13);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Radius";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(92, 173);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(56, 20);
            this.txtRadius.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(572, 397);
            this.Controls.Add(this.cBoxCircle);
            this.Controls.Add(this.cBoxTriangle);
            this.Controls.Add(this.cBoxRectangle);
            this.Controls.Add(this.cBoxSquare);
            this.Controls.Add(this.groupBoxOperations);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxOperations.ResumeLayout(false);
            this.groupBoxOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxOperations;
        private System.Windows.Forms.Button btnCalculateEnvironment;
        private System.Windows.Forms.Button btnCalculateArea;
        private System.Windows.Forms.TextBox txtSecondSide;
        private System.Windows.Forms.TextBox txtFirstSide;
        private System.Windows.Forms.TextBox txtShapeName;
        private System.Windows.Forms.Label lblSecondSide;
        private System.Windows.Forms.Label lblFirstSide;
        private System.Windows.Forms.Label lblShapeName;
        private System.Windows.Forms.CheckBox cBoxSquare;
        private System.Windows.Forms.CheckBox cBoxRectangle;
        private System.Windows.Forms.TextBox txtThirdSide;
        private System.Windows.Forms.Label lblThirdSide;
        private System.Windows.Forms.CheckBox cBoxTriangle;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblSpecialForTriangleHeight;
        private System.Windows.Forms.Label lblTriangleFloorLength;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.CheckBox cBoxCircle;
    }
}

