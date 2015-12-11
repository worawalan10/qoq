namespace _qoq
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.player2 = new System.Windows.Forms.PictureBox();
            this.item_2 = new System.Windows.Forms.PictureBox();
            this.end_2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.end_2)).BeginInit();
            this.SuspendLayout();
            // 
            // player2
            // 
            this.player2.Image = ((System.Drawing.Image)(resources.GetObject("player2.Image")));
            this.player2.Location = new System.Drawing.Point(23, 99);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(30, 30);
            this.player2.TabIndex = 0;
            this.player2.TabStop = false;
            // 
            // item_2
            // 
            this.item_2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.item_2.Location = new System.Drawing.Point(133, 99);
            this.item_2.Name = "item_2";
            this.item_2.Size = new System.Drawing.Size(30, 30);
            this.item_2.TabIndex = 1;
            this.item_2.TabStop = false;
            // 
            // end_2
            // 
            this.end_2.BackColor = System.Drawing.SystemColors.Highlight;
            this.end_2.Location = new System.Drawing.Point(282, 99);
            this.end_2.Name = "end_2";
            this.end_2.Size = new System.Drawing.Size(30, 30);
            this.end_2.TabIndex = 2;
            this.end_2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.end_2);
            this.Controls.Add(this.item_2);
            this.Controls.Add(this.player2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.end_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox item_2;
        private System.Windows.Forms.PictureBox end_2;
    }
}