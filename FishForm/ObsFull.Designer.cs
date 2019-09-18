namespace FishForm
{
    partial class ObserverFull
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
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.labelLength = new System.Windows.Forms.Label();
            this.buttonUnSub = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(292, 111);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(209, 31);
            this.textBoxLength.TabIndex = 0;
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(150, 117);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(78, 25);
            this.labelLength.TabIndex = 1;
            this.labelLength.Text = "Length";
            // 
            // buttonUnSub
            // 
            this.buttonUnSub.Location = new System.Drawing.Point(292, 284);
            this.buttonUnSub.Name = "buttonUnSub";
            this.buttonUnSub.Size = new System.Drawing.Size(140, 48);
            this.buttonUnSub.TabIndex = 2;
            this.buttonUnSub.Text = "Unsubscribe";
            this.buttonUnSub.UseVisualStyleBackColor = true;
            this.buttonUnSub.Click += new System.EventHandler(this.buttonUnSub_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Subscribe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ObserverFull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonUnSub);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.textBoxLength);
            this.Name = "ObserverFull";
            this.Text = "Full Fish Subscription";
            this.Load += new System.EventHandler(this.ObserverFull_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Button buttonUnSub;
        private System.Windows.Forms.Button button1;
    }
}