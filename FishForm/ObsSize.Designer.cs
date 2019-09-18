namespace FishForm
{
    partial class ObsSize
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
            this.Size = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonUnsub2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.Location = new System.Drawing.Point(182, 103);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(54, 25);
            this.Size.TabIndex = 0;
            this.Size.Text = "Size";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(328, 97);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(100, 31);
            this.textBoxSize.TabIndex = 1;
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(261, 219);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(216, 44);
            this.buttonSub.TabIndex = 2;
            this.buttonSub.Text = "Subscribe";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonUnsub2
            // 
            this.buttonUnsub2.Location = new System.Drawing.Point(261, 314);
            this.buttonUnsub2.Name = "buttonUnsub2";
            this.buttonUnsub2.Size = new System.Drawing.Size(216, 44);
            this.buttonUnsub2.TabIndex = 3;
            this.buttonUnsub2.Text = "Unsubscribe";
            this.buttonUnsub2.UseVisualStyleBackColor = true;
            // 
            // ObsSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUnsub2);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.Size);
            this.Name = "ObsSize";
            this.Text = "Size Subscription";
            this.Load += new System.EventHandler(this.ObsSize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Size;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonUnsub2;
    }
}