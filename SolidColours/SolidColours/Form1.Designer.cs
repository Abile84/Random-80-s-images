
namespace SolidColours
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.numeriCWidth = new System.Windows.Forms.NumericUpDown();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericResolution = new System.Windows.Forms.NumericUpDown();
            this.numericNImages = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSetColor = new System.Windows.Forms.Button();
            this.checkBoxRandom = new System.Windows.Forms.CheckBox();
            this.trackBartest = new System.Windows.Forms.TrackBar();
            this.labeltrack = new System.Windows.Forms.Label();
            this.BtnTexture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeriCWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBartest)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(9, 223);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(304, 48);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(190, 168);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(123, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "destination folder";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // numeriCWidth
            // 
            this.numeriCWidth.Location = new System.Drawing.Point(9, 46);
            this.numeriCWidth.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numeriCWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeriCWidth.Name = "numeriCWidth";
            this.numeriCWidth.Size = new System.Drawing.Size(123, 20);
            this.numeriCWidth.TabIndex = 2;
            this.numeriCWidth.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // numericHeight
            // 
            this.numericHeight.Location = new System.Drawing.Point(190, 46);
            this.numericHeight.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numericHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(123, 20);
            this.numericHeight.TabIndex = 3;
            this.numericHeight.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Width (pixel)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height (pixel)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resolution (Dpi)";
            // 
            // numericResolution
            // 
            this.numericResolution.Location = new System.Drawing.Point(9, 116);
            this.numericResolution.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericResolution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericResolution.Name = "numericResolution";
            this.numericResolution.Size = new System.Drawing.Size(123, 20);
            this.numericResolution.TabIndex = 7;
            this.numericResolution.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // numericNImages
            // 
            this.numericNImages.Location = new System.Drawing.Point(190, 116);
            this.numericNImages.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericNImages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNImages.Name = "numericNImages";
            this.numericNImages.Size = new System.Drawing.Size(123, 20);
            this.numericNImages.TabIndex = 8;
            this.numericNImages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "N° of images";
            // 
            // buttonSetColor
            // 
            this.buttonSetColor.Location = new System.Drawing.Point(9, 168);
            this.buttonSetColor.Name = "buttonSetColor";
            this.buttonSetColor.Size = new System.Drawing.Size(123, 23);
            this.buttonSetColor.TabIndex = 10;
            this.buttonSetColor.Text = "Set colour";
            this.buttonSetColor.UseVisualStyleBackColor = true;
            this.buttonSetColor.Click += new System.EventHandler(this.buttonSetColor_Click);
            // 
            // checkBoxRandom
            // 
            this.checkBoxRandom.AutoSize = true;
            this.checkBoxRandom.Location = new System.Drawing.Point(9, 200);
            this.checkBoxRandom.Name = "checkBoxRandom";
            this.checkBoxRandom.Size = new System.Drawing.Size(79, 17);
            this.checkBoxRandom.TabIndex = 11;
            this.checkBoxRandom.Text = "Randomize";
            this.checkBoxRandom.UseVisualStyleBackColor = true;
            this.checkBoxRandom.CheckStateChanged += new System.EventHandler(this.checkBoxRandom_CheckStateChanged);
            // 
            // trackBartest
            // 
            this.trackBartest.Location = new System.Drawing.Point(12, 277);
            this.trackBartest.Maximum = 100;
            this.trackBartest.Minimum = 1;
            this.trackBartest.Name = "trackBartest";
            this.trackBartest.Size = new System.Drawing.Size(104, 45);
            this.trackBartest.TabIndex = 12;
            this.trackBartest.Value = 1;
            this.trackBartest.ValueChanged += new System.EventHandler(this.trackBartest_ValueChanged);
            // 
            // labeltrack
            // 
            this.labeltrack.AutoSize = true;
            this.labeltrack.Location = new System.Drawing.Point(21, 309);
            this.labeltrack.Name = "labeltrack";
            this.labeltrack.Size = new System.Drawing.Size(13, 13);
            this.labeltrack.TabIndex = 13;
            this.labeltrack.Text = "0";
            // 
            // BtnTexture
            // 
            this.BtnTexture.Location = new System.Drawing.Point(238, 299);
            this.BtnTexture.Name = "BtnTexture";
            this.BtnTexture.Size = new System.Drawing.Size(75, 23);
            this.BtnTexture.TabIndex = 14;
            this.BtnTexture.Text = "New texture";
            this.BtnTexture.UseVisualStyleBackColor = true;
            this.BtnTexture.Click += new System.EventHandler(this.BtnTexture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 347);
            this.Controls.Add(this.BtnTexture);
            this.Controls.Add(this.labeltrack);
            this.Controls.Add(this.trackBartest);
            this.Controls.Add(this.checkBoxRandom);
            this.Controls.Add(this.buttonSetColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericNImages);
            this.Controls.Add(this.numericResolution);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericHeight);
            this.Controls.Add(this.numeriCWidth);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Solid Kolours";
            ((System.ComponentModel.ISupportInitialize)(this.numeriCWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBartest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.NumericUpDown numeriCWidth;
        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericResolution;
        private System.Windows.Forms.NumericUpDown numericNImages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSetColor;
        private System.Windows.Forms.CheckBox checkBoxRandom;
        private System.Windows.Forms.TrackBar trackBartest;
        private System.Windows.Forms.Label labeltrack;
        private System.Windows.Forms.Button BtnTexture;
    }
}

