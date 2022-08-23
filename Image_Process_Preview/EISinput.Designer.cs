namespace Image_Process_Preview
{
    partial class EISinput
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
            this.LEFTvalue = new System.Windows.Forms.NumericUpDown();
            this.RIGHTvalue = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LEFTvalue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIGHTvalue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "좌우측 임계값을 입력하세요 (0% ~ 100%)";
            // 
            // LEFTvalue
            // 
            this.LEFTvalue.Location = new System.Drawing.Point(30, 50);
            this.LEFTvalue.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.LEFTvalue.Name = "LEFTvalue";
            this.LEFTvalue.Size = new System.Drawing.Size(50, 21);
            this.LEFTvalue.TabIndex = 1;
            this.LEFTvalue.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // RIGHTvalue
            // 
            this.RIGHTvalue.Location = new System.Drawing.Point(160, 50);
            this.RIGHTvalue.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.RIGHTvalue.Name = "RIGHTvalue";
            this.RIGHTvalue.Size = new System.Drawing.Size(50, 21);
            this.RIGHTvalue.TabIndex = 2;
            this.RIGHTvalue.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(20, 80);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCL
            // 
            this.btnCL.Location = new System.Drawing.Point(150, 80);
            this.btnCL.Name = "btnCL";
            this.btnCL.Size = new System.Drawing.Size(75, 23);
            this.btnCL.TabIndex = 4;
            this.btnCL.Text = "Cancel";
            this.btnCL.UseVisualStyleBackColor = true;
            this.btnCL.Click += new System.EventHandler(this.btnCL_Click);
            // 
            // EISinput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 121);
            this.Controls.Add(this.btnCL);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.RIGHTvalue);
            this.Controls.Add(this.LEFTvalue);
            this.Controls.Add(this.label1);
            this.Name = "EISinput";
            this.Text = "End-in Control";
            ((System.ComponentModel.ISupportInitialize)(this.LEFTvalue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIGHTvalue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCL;
        public System.Windows.Forms.NumericUpDown LEFTvalue;
        public System.Windows.Forms.NumericUpDown RIGHTvalue;
    }
}