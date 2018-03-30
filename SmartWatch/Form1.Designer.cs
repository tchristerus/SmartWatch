namespace SmartWatch
{
    partial class Gui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonBoth = new System.Windows.Forms.Button();
            this.modePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonOne
            // 
            this.buttonOne.Location = new System.Drawing.Point(23, 84);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(26, 23);
            this.buttonOne.TabIndex = 0;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Location = new System.Drawing.Point(23, 142);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(26, 23);
            this.buttonTwo.TabIndex = 1;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonBoth
            // 
            this.buttonBoth.Location = new System.Drawing.Point(13, 113);
            this.buttonBoth.Name = "buttonBoth";
            this.buttonBoth.Size = new System.Drawing.Size(49, 23);
            this.buttonBoth.TabIndex = 2;
            this.buttonBoth.Text = "Both";
            this.buttonBoth.UseVisualStyleBackColor = true;
            this.buttonBoth.Click += new System.EventHandler(this.buttonBoth_Click);
            // 
            // modePanel
            // 
            this.modePanel.Location = new System.Drawing.Point(99, 12);
            this.modePanel.Name = "modePanel";
            this.modePanel.Size = new System.Drawing.Size(300, 300);
            this.modePanel.TabIndex = 3;
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 320);
            this.Controls.Add(this.modePanel);
            this.Controls.Add(this.buttonBoth);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Gui";
            this.Text = "SmartWatch";
            this.Load += new System.EventHandler(this.Gui_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonBoth;
        private System.Windows.Forms.Panel modePanel;
    }
}

