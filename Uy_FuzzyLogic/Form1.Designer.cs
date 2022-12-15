namespace Uy_FuzzyLogic
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ans = new System.Windows.Forms.Label();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.lbl_dirt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fuzzy Logic to Control the Speed of a Washing Machine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weight of the Clothes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(69, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Intensity of Dirt";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(301, 97);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(367, 56);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(301, 196);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(367, 56);
            this.trackBar2.TabIndex = 4;
            this.trackBar2.Scroll += new System.EventHandler(this.TrackBar2_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(706, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Fuzzify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(706, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Fuzzify";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(352, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 43);
            this.button3.TabIndex = 7;
            this.button3.Text = "Defuzzify";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(159, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(489, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "The Speed of the Washing Machine will be:";
            // 
            // ans
            // 
            this.ans.AutoSize = true;
            this.ans.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ans.Location = new System.Drawing.Point(408, 406);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(0, 35);
            this.ans.TabIndex = 9;
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Location = new System.Drawing.Point(477, 155);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(0, 20);
            this.lbl_weight.TabIndex = 10;
            // 
            // lbl_dirt
            // 
            this.lbl_dirt.AutoSize = true;
            this.lbl_dirt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dirt.Location = new System.Drawing.Point(455, 246);
            this.lbl_dirt.Name = "lbl_dirt";
            this.lbl_dirt.Size = new System.Drawing.Size(0, 23);
            this.lbl_dirt.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.lbl_dirt);
            this.Controls.Add(this.lbl_weight);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label ans;
        private Label lbl_weight;
        private Label lbl_dirt;
    }
}