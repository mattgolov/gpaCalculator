﻿
namespace WindowsFormsApp1
{
    partial class gpaForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gradeInput = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.enterLabel = new System.Windows.Forms.Label();
            this.averageListBox = new System.Windows.Forms.ListBox();
            this.desiredInput = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.desiredLabel = new System.Windows.Forms.Label();
            this.averageTitle = new System.Windows.Forms.Label();
            this.desiredTitle = new System.Windows.Forms.Label();
            this.gpaLabel = new System.Windows.Forms.Label();
            this.convertGPAToPct = new System.Windows.Forms.Button();
            this.actualRequiredLbl = new System.Windows.Forms.Label();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 98);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterGrade);
            // 
            // gradeInput
            // 
            this.gradeInput.Location = new System.Drawing.Point(246, 150);
            this.gradeInput.Margin = new System.Windows.Forms.Padding(1);
            this.gradeInput.Name = "gradeInput";
            this.gradeInput.Size = new System.Drawing.Size(52, 20);
            this.gradeInput.TabIndex = 0;
            this.gradeInput.TextChanged += new System.EventHandler(this.gradeInput_TextChanged);
            this.gradeInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterGrade);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(245, 178);
            this.calculate.Margin = new System.Windows.Forms.Padding(1);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(65, 27);
            this.calculate.TabIndex = 1;
            this.calculate.Text = "Calculate GPA";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Location = new System.Drawing.Point(243, 125);
            this.enterLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(67, 13);
            this.enterLabel.TabIndex = 2;
            this.enterLabel.Text = "Enter Grade:";
            // 
            // averageListBox
            // 
            this.averageListBox.FormattingEnabled = true;
            this.averageListBox.Location = new System.Drawing.Point(337, 125);
            this.averageListBox.Margin = new System.Windows.Forms.Padding(1);
            this.averageListBox.Name = "averageListBox";
            this.averageListBox.Size = new System.Drawing.Size(157, 199);
            this.averageListBox.TabIndex = 3;
            // 
            // desiredInput
            // 
            this.desiredInput.Location = new System.Drawing.Point(505, 150);
            this.desiredInput.Margin = new System.Windows.Forms.Padding(1);
            this.desiredInput.Name = "desiredInput";
            this.desiredInput.Size = new System.Drawing.Size(52, 20);
            this.desiredInput.TabIndex = 4;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(250, 5);
            this.title.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(363, 43);
            this.title.TabIndex = 5;
            this.title.Text = "GPA Calculator";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desiredLabel
            // 
            this.desiredLabel.AutoSize = true;
            this.desiredLabel.Location = new System.Drawing.Point(502, 119);
            this.desiredLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.desiredLabel.Name = "desiredLabel";
            this.desiredLabel.Size = new System.Drawing.Size(106, 13);
            this.desiredLabel.TabIndex = 6;
            this.desiredLabel.Text = "Enter Desired Grade:";
            // 
            // averageTitle
            // 
            this.averageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageTitle.Location = new System.Drawing.Point(72, 77);
            this.averageTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.averageTitle.Name = "averageTitle";
            this.averageTitle.Size = new System.Drawing.Size(363, 43);
            this.averageTitle.TabIndex = 7;
            this.averageTitle.Text = "Current Average";
            this.averageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desiredTitle
            // 
            this.desiredTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desiredTitle.Location = new System.Drawing.Point(395, 77);
            this.desiredTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.desiredTitle.Name = "desiredTitle";
            this.desiredTitle.Size = new System.Drawing.Size(363, 43);
            this.desiredTitle.TabIndex = 8;
            this.desiredTitle.Text = "Desired Average";
            this.desiredTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpaLabel
            // 
            this.gpaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gpaLabel.Location = new System.Drawing.Point(246, 224);
            this.gpaLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(61, 20);
            this.gpaLabel.TabIndex = 9;
            this.gpaLabel.Text = "GPA: ";
            this.gpaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // convertGPAToPct
            // 
            this.convertGPAToPct.Location = new System.Drawing.Point(505, 178);
            this.convertGPAToPct.Margin = new System.Windows.Forms.Padding(1);
            this.convertGPAToPct.Name = "convertGPAToPct";
            this.convertGPAToPct.Size = new System.Drawing.Size(65, 27);
            this.convertGPAToPct.TabIndex = 10;
            this.convertGPAToPct.Text = "Convert GPA to Percentage";
            this.convertGPAToPct.UseVisualStyleBackColor = true;
            this.convertGPAToPct.Click += new System.EventHandler(this.convertGPAToPct_Click);
            // 
            // actualRequiredLbl
            // 
            this.actualRequiredLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.actualRequiredLbl.Location = new System.Drawing.Point(505, 224);
            this.actualRequiredLbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.actualRequiredLbl.Name = "actualRequiredLbl";
            this.actualRequiredLbl.Size = new System.Drawing.Size(104, 20);
            this.actualRequiredLbl.TabIndex = 11;
            this.actualRequiredLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.actualRequiredLbl.Click += new System.EventHandler(this.lblPercentage_Click);
            // 
            // percentageLabel
            // 
            this.percentageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.percentageLabel.Location = new System.Drawing.Point(505, 255);
            this.percentageLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(104, 20);
            this.percentageLabel.TabIndex = 12;
            this.percentageLabel.Text = "Percentage: ";
            this.percentageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gpaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 521);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.actualRequiredLbl);
            this.Controls.Add(this.convertGPAToPct);
            this.Controls.Add(this.gpaLabel);
            this.Controls.Add(this.desiredTitle);
            this.Controls.Add(this.averageTitle);
            this.Controls.Add(this.desiredLabel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.desiredInput);
            this.Controls.Add(this.averageListBox);
            this.Controls.Add(this.enterLabel);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gradeInput);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "gpaForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox gradeInput;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.ListBox averageListBox;
        private System.Windows.Forms.TextBox desiredInput;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label desiredLabel;
        private System.Windows.Forms.Label averageTitle;
        private System.Windows.Forms.Label desiredTitle;
        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.Button convertGPAToPct;
        private System.Windows.Forms.Label actualRequiredLbl;
        private System.Windows.Forms.Label percentageLabel;
    }
}