namespace Image_Process_Preview
{
    partial class MGNinput
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
            this.MGNvalue = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MGNvalue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "확대/축소 배율 값을 입력하세요 (1x ~ 10x)";
            // 
            // MGNvalue
            // 
            this.MGNvalue.Location = new System.Drawing.Point(70, 50);
            this.MGNvalue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MGNvalue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MGNvalue.Name = "MGNvalue";
            this.MGNvalue.Size = new System.Drawing.Size(100, 21);
            this.MGNvalue.TabIndex = 1;
            this.MGNvalue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // btnCL
            // 
            this.btnCL.Location = new System.Drawing.Point(150, 80);
            this.btnCL.Name = "btnCL";
            this.btnCL.Size = new System.Drawing.Size(75, 23);
            this.btnCL.TabIndex = 3;
            this.btnCL.Text = "Cancel";
            this.btnCL.UseVisualStyleBackColor = true;
            this.btnCL.Click += new System.EventHandler(this.btnCL_Click);
            // 
            // MGNinput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 121);
            this.Controls.Add(this.btnCL);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.MGNvalue);
            this.Controls.Add(this.label1);
            this.Name = "MGNinput";
            this.Text = "Magnification Control";
            ((System.ComponentModel.ISupportInitialize)(this.MGNvalue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCL;
        public System.Windows.Forms.NumericUpDown MGNvalue;
    }
}