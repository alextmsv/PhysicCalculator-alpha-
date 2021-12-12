
namespace GraphicalPhysicCalculator
{
    partial class massForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.stregthNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tmr_emulation = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.aNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.stregthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "F (сила) =";
            // 
            // stregthNum
            // 
            this.stregthNum.Location = new System.Drawing.Point(123, 17);
            this.stregthNum.Name = "stregthNum";
            this.stregthNum.Size = new System.Drawing.Size(60, 22);
            this.stregthNum.TabIndex = 4;
            this.stregthNum.ValueChanged += new System.EventHandler(this.stregthNum_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(247, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "m (масса) =";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Вычислить!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tmr_emulation
            // 
            this.tmr_emulation.Tick += new System.EventHandler(this.tmr_emulation_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "A (ускорение) =";
            // 
            // aNum
            // 
            this.aNum.Location = new System.Drawing.Point(123, 48);
            this.aNum.Name = "aNum";
            this.aNum.Size = new System.Drawing.Size(60, 22);
            this.aNum.TabIndex = 10;
            // 
            // massForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 103);
            this.Controls.Add(this.aNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stregthNum);
            this.Controls.Add(this.label1);
            this.Name = "massForm";
            this.Text = "Масса";
            this.Load += new System.EventHandler(this.massForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stregthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown stregthNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer tmr_emulation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown aNum;
    }
}