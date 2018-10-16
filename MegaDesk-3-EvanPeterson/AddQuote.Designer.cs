namespace MegaDesk_3_EvanPeterson
{
    partial class AddQuote
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
            this.cancelAddQuoteButton = new System.Windows.Forms.Button();
            this.depthNumberBox = new System.Windows.Forms.NumericUpDown();
            this.widthNumberBox = new System.Windows.Forms.NumericUpDown();
            this.depthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.depthNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumberBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelAddQuoteButton
            // 
            this.cancelAddQuoteButton.Location = new System.Drawing.Point(364, 161);
            this.cancelAddQuoteButton.Name = "cancelAddQuoteButton";
            this.cancelAddQuoteButton.Size = new System.Drawing.Size(75, 23);
            this.cancelAddQuoteButton.TabIndex = 0;
            this.cancelAddQuoteButton.Text = "Cancel";
            this.cancelAddQuoteButton.UseVisualStyleBackColor = true;
            this.cancelAddQuoteButton.Click += new System.EventHandler(this.cancelAddQuoteButton_Click);
            // 
            // depthNumberBox
            // 
            this.depthNumberBox.Location = new System.Drawing.Point(398, 88);
            this.depthNumberBox.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthNumberBox.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthNumberBox.Name = "depthNumberBox";
            this.depthNumberBox.Size = new System.Drawing.Size(120, 20);
            this.depthNumberBox.TabIndex = 1;
            this.depthNumberBox.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // widthNumberBox
            // 
            this.widthNumberBox.Location = new System.Drawing.Point(398, 125);
            this.widthNumberBox.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthNumberBox.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthNumberBox.Name = "widthNumberBox";
            this.widthNumberBox.Size = new System.Drawing.Size(120, 20);
            this.widthNumberBox.TabIndex = 2;
            this.widthNumberBox.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthNumberBox.ValueChanged += new System.EventHandler(this.widthNumberBox_ValueChanged);
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(297, 125);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(50, 17);
            this.depthLabel.TabIndex = 3;
            this.depthLabel.Text = "Depth:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(299, 91);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(48, 17);
            this.widthLabel.TabIndex = 4;
            this.widthLabel.Text = "Width:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.MaximumSize = new System.Drawing.Size(600, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 58);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please note: Width values must be between 24 and 96. Depth values must be between" +
    " 12 and 48";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthNumberBox);
            this.Controls.Add(this.depthNumberBox);
            this.Controls.Add(this.cancelAddQuoteButton);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.depthNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumberBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelAddQuoteButton;
        private System.Windows.Forms.NumericUpDown depthNumberBox;
        private System.Windows.Forms.NumericUpDown widthNumberBox;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label label1;
    }
}