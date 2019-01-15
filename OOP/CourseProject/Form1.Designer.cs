namespace CourseProject
{
    partial class mainForm
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
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonImport
            // 
            this.buttonImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonImport.Location = new System.Drawing.Point(40, 100);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(150, 50);
            this.buttonImport.TabIndex = 3;
            this.buttonImport.Text = "Import drawing";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDraw.Location = new System.Drawing.Point(230, 100);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(150, 50);
            this.buttonDraw.TabIndex = 2;
            this.buttonDraw.Text = "Draw figure";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label.Location = new System.Drawing.Point(165, 40);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(107, 25);
            this.label.TabIndex = 0;
            this.label.Text = "Pick option";
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.Enabled = false;
            this.buttonTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonTriangle.Location = new System.Drawing.Point(0, 210);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(120, 40);
            this.buttonTriangle.TabIndex = 4;
            this.buttonTriangle.Text = "Triangle";
            this.buttonTriangle.UseVisualStyleBackColor = true;
            this.buttonTriangle.Visible = false;
            this.buttonTriangle.Click += new System.EventHandler(this.buttonTriangle_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Enabled = false;
            this.buttonRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonRectangle.Location = new System.Drawing.Point(120, 210);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(120, 40);
            this.buttonRectangle.TabIndex = 5;
            this.buttonRectangle.Text = "Rectangle";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Visible = false;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Enabled = false;
            this.buttonLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonLine.Location = new System.Drawing.Point(240, 210);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(120, 40);
            this.buttonLine.TabIndex = 6;
            this.buttonLine.Text = "Line";
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Visible = false;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSave.Location = new System.Drawing.Point(0, 170);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 40);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save drawing";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 253);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLine);
            this.Controls.Add(this.buttonRectangle);
            this.Controls.Add(this.buttonTriangle);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.buttonImport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainForm";
            this.Text = "Drawing";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonSave;
    }
}

