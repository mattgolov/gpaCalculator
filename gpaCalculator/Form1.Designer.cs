
namespace WindowsFormsApp1
{
    partial class gradeInput
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
            this.calculate = new System.Windows.Forms.Button();
            this.enterLabel = new System.Windows.Forms.Label();
            this.averageListBox = new System.Windows.Forms.ListBox();
            this.desiredInput = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.desiredLabel = new System.Windows.Forms.Label();
            this.averageTitle = new System.Windows.Forms.Label();
            this.desiredTitle = new System.Windows.Forms.Label();
            this.gpaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(492, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterGrade);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(490, 342);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(131, 51);
            this.calculate.TabIndex = 1;
            this.calculate.Text = "Calculate GPA";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Location = new System.Drawing.Point(487, 240);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(134, 25);
            this.enterLabel.TabIndex = 2;
            this.enterLabel.Text = "Enter Grade:";
            // 
            // averageListBox
            // 
            this.averageListBox.FormattingEnabled = true;
            this.averageListBox.ItemHeight = 25;
            this.averageListBox.Location = new System.Drawing.Point(673, 240);
            this.averageListBox.Name = "averageListBox";
            this.averageListBox.Size = new System.Drawing.Size(310, 379);
            this.averageListBox.TabIndex = 3;
            // 
            // desiredInput
            // 
            this.desiredInput.Location = new System.Drawing.Point(1009, 289);
            this.desiredInput.Name = "desiredInput";
            this.desiredInput.Size = new System.Drawing.Size(100, 31);
            this.desiredInput.TabIndex = 4;
            this.desiredInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(500, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(727, 82);
            this.title.TabIndex = 5;
            this.title.Text = "GPA Calculator";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desiredLabel
            // 
            this.desiredLabel.AutoSize = true;
            this.desiredLabel.Location = new System.Drawing.Point(1004, 229);
            this.desiredLabel.Name = "desiredLabel";
            this.desiredLabel.Size = new System.Drawing.Size(214, 25);
            this.desiredLabel.TabIndex = 6;
            this.desiredLabel.Text = "Enter Desired Grade:";
            // 
            // averageTitle
            // 
            this.averageTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageTitle.Location = new System.Drawing.Point(144, 147);
            this.averageTitle.Name = "averageTitle";
            this.averageTitle.Size = new System.Drawing.Size(727, 82);
            this.averageTitle.TabIndex = 7;
            this.averageTitle.Text = "Current Average";
            this.averageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desiredTitle
            // 
            this.desiredTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desiredTitle.Location = new System.Drawing.Point(789, 147);
            this.desiredTitle.Name = "desiredTitle";
            this.desiredTitle.Size = new System.Drawing.Size(727, 82);
            this.desiredTitle.TabIndex = 8;
            this.desiredTitle.Text = "Desired Average";
            this.desiredTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpaLabel
            // 
            this.gpaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gpaLabel.Location = new System.Drawing.Point(492, 430);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(120, 36);
            this.gpaLabel.TabIndex = 9;
            this.gpaLabel.Text = "GPA: ";
            this.gpaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gradeInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1749, 1002);
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
            this.Name = "gradeInput";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.ListBox averageListBox;
        private System.Windows.Forms.TextBox desiredInput;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label desiredLabel;
        private System.Windows.Forms.Label averageTitle;
        private System.Windows.Forms.Label desiredTitle;
        private System.Windows.Forms.Label gpaLabel;
    }
}

