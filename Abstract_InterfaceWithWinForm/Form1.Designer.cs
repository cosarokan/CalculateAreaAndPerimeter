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
            this.btnCalculateEnvironment = new System.Windows.Forms.Button();
            this.btnCalculateArea = new System.Windows.Forms.Button();
            this.txtSecondSide = new System.Windows.Forms.TextBox();
            this.txtFirstSide = new System.Windows.Forms.TextBox();
            this.txtShapeName = new System.Windows.Forms.TextBox();
            this.lblSecondSide = new System.Windows.Forms.Label();
            this.lblFirstSide = new System.Windows.Forms.Label();
            this.lblShapeName = new System.Windows.Forms.Label();
            this.cBoxSquare = new System.Windows.Forms.CheckBox();
            this.cBoxRectangle = new System.Windows.Forms.CheckBox();
            this.groupBoxOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOperations
            // 
            this.groupBoxOperations.Controls.Add(this.btnCalculateEnvironment);
            this.groupBoxOperations.Controls.Add(this.btnCalculateArea);
            this.groupBoxOperations.Controls.Add(this.txtSecondSide);
            this.groupBoxOperations.Controls.Add(this.txtFirstSide);
            this.groupBoxOperations.Controls.Add(this.txtShapeName);
            this.groupBoxOperations.Controls.Add(this.lblSecondSide);
            this.groupBoxOperations.Controls.Add(this.lblFirstSide);
            this.groupBoxOperations.Controls.Add(this.lblShapeName);
            this.groupBoxOperations.Location = new System.Drawing.Point(86, 76);
            this.groupBoxOperations.Name = "groupBoxOperations";
            this.groupBoxOperations.Size = new System.Drawing.Size(276, 284);
            this.groupBoxOperations.TabIndex = 2;
            this.groupBoxOperations.TabStop = false;
            this.groupBoxOperations.Text = "Math Operations";
            // 
            // btnCalculateEnvironment
            // 
            this.btnCalculateEnvironment.Location = new System.Drawing.Point(9, 217);
            this.btnCalculateEnvironment.Name = "btnCalculateEnvironment";
            this.btnCalculateEnvironment.Size = new System.Drawing.Size(245, 42);
            this.btnCalculateEnvironment.TabIndex = 2;
            this.btnCalculateEnvironment.Text = "Calculate Perimeter";
            this.btnCalculateEnvironment.UseVisualStyleBackColor = true;
            this.btnCalculateEnvironment.Click += new System.EventHandler(this.btnCalculateEnvironment_Click);
            // 
            // btnCalculateArea
            // 
            this.btnCalculateArea.Location = new System.Drawing.Point(10, 169);
            this.btnCalculateArea.Name = "btnCalculateArea";
            this.btnCalculateArea.Size = new System.Drawing.Size(245, 42);
            this.btnCalculateArea.TabIndex = 2;
            this.btnCalculateArea.Text = "Calculate Area";
            this.btnCalculateArea.UseVisualStyleBackColor = true;
            this.btnCalculateArea.Click += new System.EventHandler(this.btnCalculateArea_Click);
            // 
            // txtSecondSide
            // 
            this.txtSecondSide.Location = new System.Drawing.Point(93, 128);
            this.txtSecondSide.Name = "txtSecondSide";
            this.txtSecondSide.Size = new System.Drawing.Size(56, 20);
            this.txtSecondSide.TabIndex = 1;
            // 
            // txtFirstSide
            // 
            this.txtFirstSide.Location = new System.Drawing.Point(93, 83);
            this.txtFirstSide.Name = "txtFirstSide";
            this.txtFirstSide.Size = new System.Drawing.Size(56, 20);
            this.txtFirstSide.TabIndex = 1;
            // 
            // txtShapeName
            // 
            this.txtShapeName.Location = new System.Drawing.Point(93, 35);
            this.txtShapeName.Name = "txtShapeName";
            this.txtShapeName.Size = new System.Drawing.Size(161, 20);
            this.txtShapeName.TabIndex = 1;
            // 
            // lblSecondSide
            // 
            this.lblSecondSide.AutoSize = true;
            this.lblSecondSide.Location = new System.Drawing.Point(7, 128);
            this.lblSecondSide.Name = "lblSecondSide";
            this.lblSecondSide.Size = new System.Drawing.Size(28, 13);
            this.lblSecondSide.TabIndex = 0;
            this.lblSecondSide.Text = "Side";
            // 
            // lblFirstSide
            // 
            this.lblFirstSide.AutoSize = true;
            this.lblFirstSide.Location = new System.Drawing.Point(6, 83);
            this.lblFirstSide.Name = "lblFirstSide";
            this.lblFirstSide.Size = new System.Drawing.Size(28, 13);
            this.lblFirstSide.TabIndex = 0;
            this.lblFirstSide.Text = "Side";
            // 
            // lblShapeName
            // 
            this.lblShapeName.AutoSize = true;
            this.lblShapeName.Location = new System.Drawing.Point(7, 38);
            this.lblShapeName.Name = "lblShapeName";
            this.lblShapeName.Size = new System.Drawing.Size(69, 13);
            this.lblShapeName.TabIndex = 0;
            this.lblShapeName.Text = "Shape Name";
            // 
            // cBoxSquare
            // 
            this.cBoxSquare.AutoSize = true;
            this.cBoxSquare.Location = new System.Drawing.Point(118, 34);
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
            this.cBoxRectangle.Location = new System.Drawing.Point(265, 34);
            this.cBoxRectangle.Name = "cBoxRectangle";
            this.cBoxRectangle.Size = new System.Drawing.Size(75, 17);
            this.cBoxRectangle.TabIndex = 3;
            this.cBoxRectangle.Text = "Rectangle";
            this.cBoxRectangle.UseVisualStyleBackColor = true;
            this.cBoxRectangle.CheckedChanged += new System.EventHandler(this.cBoxRectangle_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 463);
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
    }
}

