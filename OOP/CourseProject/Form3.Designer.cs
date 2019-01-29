namespace CourseProject
{
    partial class Form3
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
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label_xStart = new System.Windows.Forms.Label();
            this.label_yStart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAlert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxHeight.Location = new System.Drawing.Point(12, 83);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(172, 26);
            this.textBoxHeight.TabIndex = 2;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxWidth.Location = new System.Drawing.Point(11, 31);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(173, 26);
            this.textBoxWidth.TabIndex = 1;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonConfirm.Location = new System.Drawing.Point(53, 115);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(88, 29);
            this.buttonConfirm.TabIndex = 5;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCancel.Location = new System.Drawing.Point(247, 115);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 29);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelHeight.Location = new System.Drawing.Point(69, 60);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(58, 20);
            this.labelHeight.TabIndex = 9;
            this.labelHeight.Text = "Height";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelWidth.Location = new System.Drawing.Point(69, 8);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(52, 20);
            this.labelWidth.TabIndex = 7;
            this.labelWidth.Text = "Width";
            // 
            // textBoxY
            // 
            this.textBoxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxY.Location = new System.Drawing.Point(208, 83);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(173, 26);
            this.textBoxY.TabIndex = 4;
            // 
            // textBoxX
            // 
            this.textBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxX.Location = new System.Drawing.Point(208, 31);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(173, 26);
            this.textBoxX.TabIndex = 3;
            // 
            // label_xStart
            // 
            this.label_xStart.AutoSize = true;
            this.label_xStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_xStart.Location = new System.Drawing.Point(243, 8);
            this.label_xStart.Name = "label_xStart";
            this.label_xStart.Size = new System.Drawing.Size(104, 20);
            this.label_xStart.TabIndex = 8;
            this.label_xStart.Text = "Start Point X";
            // 
            // label_yStart
            // 
            this.label_yStart.AutoSize = true;
            this.label_yStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_yStart.Location = new System.Drawing.Point(245, 60);
            this.label_yStart.Name = "label_yStart";
            this.label_yStart.Size = new System.Drawing.Size(103, 20);
            this.label_yStart.TabIndex = 10;
            this.label_yStart.Text = "Start Point Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 10;
            // 
            // labelAlert
            // 
            this.labelAlert.AutoSize = true;
            this.labelAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlert.ForeColor = System.Drawing.Color.Red;
            this.labelAlert.Location = new System.Drawing.Point(120, 160);
            this.labelAlert.Name = "labelAlert";
            this.labelAlert.Size = new System.Drawing.Size(163, 20);
            this.labelAlert.TabIndex = 11;
            this.labelAlert.Text = "OUT OF BOUNDS";
            this.labelAlert.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 203);
            this.Controls.Add(this.labelAlert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_yStart);
            this.Controls.Add(this.label_xStart);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxHeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.Text = "New Figure Values";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label_xStart;
        private System.Windows.Forms.Label label_yStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAlert;
    }
}