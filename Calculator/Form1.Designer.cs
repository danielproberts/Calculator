namespace Calculator
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.cmdClear = new System.Windows.Forms.Button();
            this.dig7 = new System.Windows.Forms.Button();
            this.dig4 = new System.Windows.Forms.Button();
            this.dig1 = new System.Windows.Forms.Button();
            this.dig8 = new System.Windows.Forms.Button();
            this.dig5 = new System.Windows.Forms.Button();
            this.dig2 = new System.Windows.Forms.Button();
            this.dig9 = new System.Windows.Forms.Button();
            this.dig6 = new System.Windows.Forms.Button();
            this.dig3 = new System.Windows.Forms.Button();
            this.dig0 = new System.Windows.Forms.Button();
            this.cmdDivide = new System.Windows.Forms.Button();
            this.cmdMultiply = new System.Windows.Forms.Button();
            this.cmdSubtract = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(36, 28);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(314, 57);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "0";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDisplay.Click += new System.EventHandler(this.lblDisplay_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClear.Location = new System.Drawing.Point(36, 327);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(74, 63);
            this.cmdClear.TabIndex = 1;
            this.cmdClear.Text = "C";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // dig7
            // 
            this.dig7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dig7.Location = new System.Drawing.Point(36, 120);
            this.dig7.Name = "dig7";
            this.dig7.Size = new System.Drawing.Size(74, 63);
            this.dig7.TabIndex = 2;
            this.dig7.Text = "7";
            this.dig7.UseVisualStyleBackColor = true;
            this.dig7.Click += new System.EventHandler(this.dig7_Click);
            // 
            // dig4
            // 
            this.dig4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dig4.Location = new System.Drawing.Point(36, 189);
            this.dig4.Name = "dig4";
            this.dig4.Size = new System.Drawing.Size(74, 63);
            this.dig4.TabIndex = 3;
            this.dig4.Text = "4";
            this.dig4.UseVisualStyleBackColor = true;
            this.dig4.Click += new System.EventHandler(this.dig4_Click);
            // 
            // dig1
            // 
            this.dig1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dig1.Location = new System.Drawing.Point(36, 258);
            this.dig1.Name = "dig1";
            this.dig1.Size = new System.Drawing.Size(74, 63);
            this.dig1.TabIndex = 4;
            this.dig1.Text = "1";
            this.dig1.UseVisualStyleBackColor = true;
            this.dig1.Click += new System.EventHandler(this.dig1_Click);
            // 
            // dig8
            // 
            this.dig8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dig8.Location = new System.Drawing.Point(116, 120);
            this.dig8.Name = "dig8";
            this.dig8.Size = new System.Drawing.Size(74, 63);
            this.dig8.TabIndex = 5;
            this.dig8.Text = "8";
            this.dig8.UseVisualStyleBackColor = true;
            this.dig8.Click += new System.EventHandler(this.dig8_Click);
            // 
            // dig5
            // 
            this.dig5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dig5.Location = new System.Drawing.Point(116, 189);
            this.dig5.Name = "dig5";
            this.dig5.Size = new System.Drawing.Size(74, 63);
            this.dig5.TabIndex = 6;
            this.dig5.Text = "5";
            this.dig5.UseVisualStyleBackColor = true;
            this.dig5.Click += new System.EventHandler(this.dig5_Click);
            // 
            // dig2
            // 
            this.dig2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dig2.Location = new System.Drawing.Point(116, 258);
            this.dig2.Name = "dig2";
            this.dig2.Size = new System.Drawing.Size(74, 63);
            this.dig2.TabIndex = 7;
            this.dig2.Text = "2";
            this.dig2.UseVisualStyleBackColor = true;
            this.dig2.Click += new System.EventHandler(this.dig2_Click);
            // 
            // dig9
            // 
            this.dig9.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dig9.Location = new System.Drawing.Point(196, 120);
            this.dig9.Name = "dig9";
            this.dig9.Size = new System.Drawing.Size(74, 63);
            this.dig9.TabIndex = 8;
            this.dig9.Text = "9";
            this.dig9.UseVisualStyleBackColor = true;
            this.dig9.Click += new System.EventHandler(this.dig9_Click);
            // 
            // dig6
            // 
            this.dig6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dig6.Location = new System.Drawing.Point(196, 189);
            this.dig6.Name = "dig6";
            this.dig6.Size = new System.Drawing.Size(74, 63);
            this.dig6.TabIndex = 9;
            this.dig6.Text = "6";
            this.dig6.UseVisualStyleBackColor = true;
            this.dig6.Click += new System.EventHandler(this.dig6_Click);
            // 
            // dig3
            // 
            this.dig3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dig3.Location = new System.Drawing.Point(196, 258);
            this.dig3.Name = "dig3";
            this.dig3.Size = new System.Drawing.Size(74, 63);
            this.dig3.TabIndex = 10;
            this.dig3.Text = "3";
            this.dig3.UseVisualStyleBackColor = true;
            this.dig3.Click += new System.EventHandler(this.dig3_Click);
            // 
            // dig0
            // 
            this.dig0.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dig0.Location = new System.Drawing.Point(116, 327);
            this.dig0.Name = "dig0";
            this.dig0.Size = new System.Drawing.Size(74, 63);
            this.dig0.TabIndex = 11;
            this.dig0.Text = "0";
            this.dig0.UseVisualStyleBackColor = true;
            this.dig0.Click += new System.EventHandler(this.dig0_Click);
            // 
            // cmdDivide
            // 
            this.cmdDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDivide.Location = new System.Drawing.Point(276, 120);
            this.cmdDivide.Name = "cmdDivide";
            this.cmdDivide.Size = new System.Drawing.Size(74, 63);
            this.cmdDivide.TabIndex = 12;
            this.cmdDivide.Text = "/";
            this.cmdDivide.UseVisualStyleBackColor = true;
            this.cmdDivide.Click += new System.EventHandler(this.cmdDivide_Click);
            // 
            // cmdMultiply
            // 
            this.cmdMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMultiply.Location = new System.Drawing.Point(276, 189);
            this.cmdMultiply.Name = "cmdMultiply";
            this.cmdMultiply.Size = new System.Drawing.Size(74, 63);
            this.cmdMultiply.TabIndex = 13;
            this.cmdMultiply.Text = "x";
            this.cmdMultiply.UseVisualStyleBackColor = true;
            this.cmdMultiply.Click += new System.EventHandler(this.cmdMultiply_Click);
            // 
            // cmdSubtract
            // 
            this.cmdSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSubtract.Location = new System.Drawing.Point(276, 258);
            this.cmdSubtract.Name = "cmdSubtract";
            this.cmdSubtract.Size = new System.Drawing.Size(74, 63);
            this.cmdSubtract.TabIndex = 14;
            this.cmdSubtract.Text = "-";
            this.cmdSubtract.UseVisualStyleBackColor = true;
            this.cmdSubtract.Click += new System.EventHandler(this.cmdSubtract_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd.Location = new System.Drawing.Point(276, 327);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(74, 63);
            this.cmdAdd.TabIndex = 15;
            this.cmdAdd.Text = "+";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCalculate.Location = new System.Drawing.Point(196, 327);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(74, 63);
            this.cmdCalculate.TabIndex = 16;
            this.cmdCalculate.Text = "=";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 411);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.cmdSubtract);
            this.Controls.Add(this.cmdMultiply);
            this.Controls.Add(this.cmdDivide);
            this.Controls.Add(this.dig0);
            this.Controls.Add(this.dig3);
            this.Controls.Add(this.dig6);
            this.Controls.Add(this.dig9);
            this.Controls.Add(this.dig2);
            this.Controls.Add(this.dig5);
            this.Controls.Add(this.dig8);
            this.Controls.Add(this.dig1);
            this.Controls.Add(this.dig4);
            this.Controls.Add(this.dig7);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.lblDisplay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button dig7;
        private System.Windows.Forms.Button dig4;
        private System.Windows.Forms.Button dig1;
        private System.Windows.Forms.Button dig8;
        private System.Windows.Forms.Button dig5;
        private System.Windows.Forms.Button dig2;
        private System.Windows.Forms.Button dig9;
        private System.Windows.Forms.Button dig6;
        private System.Windows.Forms.Button dig3;
        private System.Windows.Forms.Button dig0;
        private System.Windows.Forms.Button cmdDivide;
        private System.Windows.Forms.Button cmdMultiply;
        private System.Windows.Forms.Button cmdSubtract;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdCalculate;
    }
}

