
namespace SolidColours
{
    partial class TextureMaker
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
            this.numTextWidth = new System.Windows.Forms.NumericUpDown();
            this.numTextHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelText = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPoints = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.numericPenSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTextWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTextHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPenSize)).BeginInit();
            this.SuspendLayout();
            // 
            // numTextWidth
            // 
            this.numTextWidth.Location = new System.Drawing.Point(12, 23);
            this.numTextWidth.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numTextWidth.Name = "numTextWidth";
            this.numTextWidth.Size = new System.Drawing.Size(100, 20);
            this.numTextWidth.TabIndex = 1;
            this.numTextWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numTextWidth.ValueChanged += new System.EventHandler(this.numTextWidth_ValueChanged);
            // 
            // numTextHeight
            // 
            this.numTextHeight.Location = new System.Drawing.Point(12, 49);
            this.numTextHeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numTextHeight.Name = "numTextHeight";
            this.numTextHeight.Size = new System.Drawing.Size(100, 20);
            this.numTextHeight.TabIndex = 2;
            this.numTextHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numTextHeight.ValueChanged += new System.EventHandler(this.numTextHeight_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height";
            // 
            // panelText
            // 
            this.panelText.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelText.Location = new System.Drawing.Point(12, 154);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(100, 100);
            this.panelText.TabIndex = 5;
            this.panelText.Click += new System.EventHandler(this.panelText_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 101);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxPoints
            // 
            this.textBoxPoints.Location = new System.Drawing.Point(465, 29);
            this.textBoxPoints.Multiline = true;
            this.textBoxPoints.Name = "textBoxPoints";
            this.textBoxPoints.Size = new System.Drawing.Size(100, 270);
            this.textBoxPoints.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 348);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // numericPenSize
            // 
            this.numericPenSize.Location = new System.Drawing.Point(12, 75);
            this.numericPenSize.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericPenSize.Name = "numericPenSize";
            this.numericPenSize.Size = new System.Drawing.Size(100, 20);
            this.numericPenSize.TabIndex = 9;
            this.numericPenSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pen size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name";
            // 
            // TextureMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericPenSize);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxPoints);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.panelText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numTextHeight);
            this.Controls.Add(this.numTextWidth);
            this.Name = "TextureMaker";
            this.Text = "TextureMaker";
            this.Load += new System.EventHandler(this.TextureMaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTextWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTextHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPenSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numTextWidth;
        private System.Windows.Forms.NumericUpDown numTextHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelText;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPoints;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.NumericUpDown numericPenSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}