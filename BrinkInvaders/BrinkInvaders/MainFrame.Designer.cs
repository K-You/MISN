namespace BrickInvaders
{
    namespace View
    {

        partial class MainFrame
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
                this.SuspendLayout();
                // 
                // MainFrame
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.SystemColors.InfoText;
                this.ClientSize = new System.Drawing.Size(383, 461);
                this.MaximizeBox = false;
                this.MaximumSize = new System.Drawing.Size(399, 499);
                this.MinimumSize = new System.Drawing.Size(399, 499);
                this.Name = "MainFrame";
                this.Text = "MainFrame";
                this.Load += new System.EventHandler(this.MainFrame_Load);
                this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFrame_KeyDown);
                this.ResumeLayout(false);

            }

            #endregion

        }
    }
}