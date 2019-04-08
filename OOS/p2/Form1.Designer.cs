namespace p2
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.filenameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newFilenameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonCreate.Location = new System.Drawing.Point(65, 51);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(153, 35);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Create New File";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            this.buttonCreate.Click += new System.EventHandler(this.Common_MouseClick);
            // 
            // buttonSort
            // 
            this.buttonSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonSort.Location = new System.Drawing.Point(65, 126);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(153, 35);
            this.buttonSort.TabIndex = 1;
            this.buttonSort.Text = "Sort File Content";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonView
            // 
            this.buttonView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonView.Location = new System.Drawing.Point(65, 204);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(153, 35);
            this.buttonView.TabIndex = 2;
            this.buttonView.Text = "View File Content";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            this.buttonView.Click += new System.EventHandler(this.Common_MouseClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonDelete.Location = new System.Drawing.Point(65, 279);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(153, 35);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete File";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            this.buttonDelete.Click += new System.EventHandler(this.Common_MouseClick);
            // 
            // filenameBox
            // 
            this.filenameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.filenameBox.Location = new System.Drawing.Point(342, 78);
            this.filenameBox.Name = "filenameBox";
            this.filenameBox.Size = new System.Drawing.Size(216, 26);
            this.filenameBox.TabIndex = 4;
            this.filenameBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(407, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "File name";
            this.label1.Visible = false;
            // 
            // newFilenameBox
            // 
            this.newFilenameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newFilenameBox.Location = new System.Drawing.Point(342, 149);
            this.newFilenameBox.Name = "newFilenameBox";
            this.newFilenameBox.Size = new System.Drawing.Size(216, 26);
            this.newFilenameBox.TabIndex = 6;
            this.newFilenameBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(353, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sort in new file (optional)";
            this.label2.Visible = false;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.statusLabel.Location = new System.Drawing.Point(278, 286);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(57, 20);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Status";
            this.statusLabel.Visible = false;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonConfirm.Location = new System.Drawing.Point(342, 204);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(96, 35);
            this.buttonConfirm.TabIndex = 9;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Visible = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonCancel.Location = new System.Drawing.Point(462, 204);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(96, 35);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 358);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newFilenameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filenameBox);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonCreate);
            this.Name = "Form1";
            this.Text = "p2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox filenameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newFilenameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
    }
}

