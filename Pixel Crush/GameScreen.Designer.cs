namespace Pixel_Crush
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkSelected
            // 
            this.checkSelected.BackColor = System.Drawing.Color.Lime;
            this.checkSelected.Location = new System.Drawing.Point(321, 378);
            this.checkSelected.Name = "checkSelected";
            this.checkSelected.Size = new System.Drawing.Size(235, 68);
            this.checkSelected.TabIndex = 0;
            this.checkSelected.Text = "Check for matches!";
            this.checkSelected.UseVisualStyleBackColor = false;
            this.checkSelected.Click += new System.EventHandler(this.checkSelected_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkSelected);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(900, 500);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameScreen_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkSelected;
    }
}
