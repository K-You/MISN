namespace BrickInvaders
{
    namespace View
    {
        partial class Launcher
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
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
                this.label1 = new System.Windows.Forms.Label();
                this.pseudoBox = new System.Windows.Forms.TextBox();
                this.label2 = new System.Windows.Forms.Label();
                this.modeBox = new System.Windows.Forms.ComboBox();
                this.label3 = new System.Windows.Forms.Label();
                this.shipBox = new System.Windows.Forms.ComboBox();
                this.button1 = new System.Windows.Forms.Button();
                this.SuspendLayout();
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label1.Location = new System.Drawing.Point(41, 46);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(42, 13);
                this.label1.TabIndex = 0;
                this.label1.Text = "pseudo";
                // 
                // pseudoBox
                // 
                this.pseudoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.pseudoBox.Location = new System.Drawing.Point(192, 43);
                this.pseudoBox.Name = "pseudoBox";
                this.pseudoBox.Size = new System.Drawing.Size(139, 20);
                this.pseudoBox.TabIndex = 1;
                // 
                // label2
                // 
                this.label2.AutoSize = true;
                this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label2.Location = new System.Drawing.Point(41, 107);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(66, 13);
                this.label2.TabIndex = 2;
                this.label2.Text = "Mode de jeu";
                // 
                // modeBox
                // 
                this.modeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.modeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.modeBox.FormattingEnabled = true;
                this.modeBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.modeBox.Location = new System.Drawing.Point(192, 99);
                this.modeBox.Name = "modeBox";
                this.modeBox.Size = new System.Drawing.Size(139, 21);
                this.modeBox.TabIndex = 3;
                // 
                // label3
                // 
                this.label3.AutoSize = true;
                this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label3.Location = new System.Drawing.Point(41, 167);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(50, 13);
                this.label3.TabIndex = 4;
                this.label3.Text = "Vaisseau";
                // 
                // shipBox
                // 
                this.shipBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.shipBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.shipBox.FormattingEnabled = true;
                this.shipBox.Location = new System.Drawing.Point(192, 159);
                this.shipBox.Name = "shipBox";
                this.shipBox.Size = new System.Drawing.Size(139, 21);
                this.shipBox.TabIndex = 5;
                // 
                // button1
                // 
                this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button1.Location = new System.Drawing.Point(44, 271);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(277, 23);
                this.button1.TabIndex = 6;
                this.button1.Text = "Lancer la mission";
                this.button1.UseVisualStyleBackColor = true;
                this.button1.Click += new System.EventHandler(this.button1_Click);
                // 
                // Launcher
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
                this.ClientSize = new System.Drawing.Size(372, 306);
                this.Controls.Add(this.button1);
                this.Controls.Add(this.shipBox);
                this.Controls.Add(this.label3);
                this.Controls.Add(this.modeBox);
                this.Controls.Add(this.label2);
                this.Controls.Add(this.pseudoBox);
                this.Controls.Add(this.label1);
                this.Name = "Launcher";
                this.Text = "Launcher";
                this.Load += new System.EventHandler(this.Launcher_Load);
                this.ResumeLayout(false);
                this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.TextBox pseudoBox;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.ComboBox modeBox;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.ComboBox shipBox;
            private System.Windows.Forms.Button button1;
        }
    }
}