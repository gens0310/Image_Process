namespace Image_Process_Preview
{
    partial class GMinput
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
            this.label1 = new System.Windows.Forms.Label();
            this.GMvalue = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GMvalue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "감마 상수 값을 입력하세요 (0.5 ~ 2.5)";
            // 
            // GMvalue
            // 
            this.GMvalue.DecimalPlaces = 1;
            this.GMvalue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.GMvalue.Location = new System.Drawing.Point(70, 50);
            this.GMvalue.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.GMvalue.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.GMvalue.Name = "GMvalue";
            this.GMvalue.Size = new System.Drawing.Size(100, 21);
            this.GMvalue.TabIndex = 1;
            this.GMvalue.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(20, 80);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GMinput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 121);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.GMvalue);
            this.Controls.Add(this.label1);
            this.Name = "GMinput";
            this.Text = "Gamma Control";
            ((System.ComponentModel.ISupportInitialize)(this.GMvalue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown GMvalue;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button button2;
    }
}