namespace BCM_Utility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ColumnText = new System.Windows.Forms.MaskedTextBox();
            this.IPText = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.NetworkGroup = new System.Windows.Forms.GroupBox();
            this.WallButton = new System.Windows.Forms.RadioButton();
            this.ClientButton = new System.Windows.Forms.RadioButton();
            this.PageGroup = new System.Windows.Forms.GroupBox();
            this.MaintButton = new System.Windows.Forms.RadioButton();
            this.MainButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RowText = new System.Windows.Forms.MaskedTextBox();
            this.NetworkGroup.SuspendLayout();
            this.PageGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColumnText
            // 
            this.ColumnText.Location = new System.Drawing.Point(298, 187);
            this.ColumnText.Margin = new System.Windows.Forms.Padding(4);
            this.ColumnText.Name = "ColumnText";
            this.ColumnText.Size = new System.Drawing.Size(132, 22);
            this.ColumnText.TabIndex = 1;
            // 
            // IPText
            // 
            this.IPText.Location = new System.Drawing.Point(298, 259);
            this.IPText.Margin = new System.Windows.Forms.Padding(4);
            this.IPText.Name = "IPText";
            this.IPText.Size = new System.Drawing.Size(132, 22);
            this.IPText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(44, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter the number of columns:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter the BCM IP address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "KVD / HVD / ODL Webpage Utility";
            // 
            // EnterButton
            // 
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.Location = new System.Drawing.Point(487, 417);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(92, 46);
            this.EnterButton.TabIndex = 11;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // NetworkGroup
            // 
            this.NetworkGroup.Controls.Add(this.WallButton);
            this.NetworkGroup.Controls.Add(this.ClientButton);
            this.NetworkGroup.Location = new System.Drawing.Point(617, 107);
            this.NetworkGroup.Name = "NetworkGroup";
            this.NetworkGroup.Size = new System.Drawing.Size(200, 100);
            this.NetworkGroup.TabIndex = 12;
            this.NetworkGroup.TabStop = false;
            // 
            // WallButton
            // 
            this.WallButton.AutoSize = true;
            this.WallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WallButton.Location = new System.Drawing.Point(31, 65);
            this.WallButton.Margin = new System.Windows.Forms.Padding(4);
            this.WallButton.Name = "WallButton";
            this.WallButton.Size = new System.Drawing.Size(129, 24);
            this.WallButton.TabIndex = 9;
            this.WallButton.TabStop = true;
            this.WallButton.Text = "Wall Network";
            this.WallButton.UseVisualStyleBackColor = true;
            this.WallButton.CheckedChanged += new System.EventHandler(this.WallButton_CheckedChanged);
            // 
            // ClientButton
            // 
            this.ClientButton.AutoSize = true;
            this.ClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientButton.Location = new System.Drawing.Point(31, 11);
            this.ClientButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.Size = new System.Drawing.Size(139, 24);
            this.ClientButton.TabIndex = 8;
            this.ClientButton.TabStop = true;
            this.ClientButton.Text = "Client Network";
            this.ClientButton.UseVisualStyleBackColor = true;
            this.ClientButton.CheckedChanged += new System.EventHandler(this.ClientButton_CheckedChanged);
            // 
            // PageGroup
            // 
            this.PageGroup.Controls.Add(this.MaintButton);
            this.PageGroup.Controls.Add(this.MainButton);
            this.PageGroup.Location = new System.Drawing.Point(617, 278);
            this.PageGroup.Name = "PageGroup";
            this.PageGroup.Size = new System.Drawing.Size(200, 100);
            this.PageGroup.TabIndex = 13;
            this.PageGroup.TabStop = false;
            // 
            // MaintButton
            // 
            this.MaintButton.AutoSize = true;
            this.MaintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaintButton.Location = new System.Drawing.Point(38, 67);
            this.MaintButton.Name = "MaintButton";
            this.MaintButton.Size = new System.Drawing.Size(125, 24);
            this.MaintButton.TabIndex = 11;
            this.MaintButton.TabStop = true;
            this.MaintButton.Text = "Maintenance";
            this.MaintButton.UseVisualStyleBackColor = true;
            this.MaintButton.CheckedChanged += new System.EventHandler(this.MaintButton_CheckedChanged);
            // 
            // MainButton
            // 
            this.MainButton.AutoSize = true;
            this.MainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButton.Location = new System.Drawing.Point(38, 9);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(75, 24);
            this.MainButton.TabIndex = 10;
            this.MainButton.TabStop = true;
            this.MainButton.Text = "Home";
            this.MainButton.UseVisualStyleBackColor = true;
            this.MainButton.CheckedChanged += new System.EventHandler(this.MainButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(44, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter number of rows:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(613, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Which page do you want to open?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(613, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Which network are you connected to?";
            // 
            // RowText
            // 
            this.RowText.Location = new System.Drawing.Point(298, 115);
            this.RowText.Margin = new System.Windows.Forms.Padding(4);
            this.RowText.Name = "RowText";
            this.RowText.Size = new System.Drawing.Size(132, 22);
            this.RowText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.EnterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PageGroup);
            this.Controls.Add(this.NetworkGroup);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPText);
            this.Controls.Add(this.ColumnText);
            this.Controls.Add(this.RowText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Vistacom BCM Webpage Utility";
            this.NetworkGroup.ResumeLayout(false);
            this.NetworkGroup.PerformLayout();
            this.PageGroup.ResumeLayout(false);
            this.PageGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox ColumnText;
        private System.Windows.Forms.MaskedTextBox IPText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.GroupBox NetworkGroup;
        private System.Windows.Forms.RadioButton WallButton;
        private System.Windows.Forms.RadioButton ClientButton;
        private System.Windows.Forms.GroupBox PageGroup;
        private System.Windows.Forms.RadioButton MaintButton;
        private System.Windows.Forms.RadioButton MainButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox RowText;
    }
}

