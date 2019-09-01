namespace multipleforms
{
    partial class adddata
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
            this.btnok = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnok
            // 
            this.btnok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnok.Location = new System.Drawing.Point(233, 247);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(151, 59);
            this.btnok.TabIndex = 0;
            this.btnok.Text = "ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.Btnok_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(418, 247);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(154, 68);
            this.btncancel.TabIndex = 1;
            this.btncancel.Text = "cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(308, 105);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(343, 26);
            this.txtdata.TabIndex = 2;
            this.txtdata.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // adddata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Name = "adddata";
            this.Text = "adddata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btncancel;
        public System.Windows.Forms.TextBox txtdata;
    }
}