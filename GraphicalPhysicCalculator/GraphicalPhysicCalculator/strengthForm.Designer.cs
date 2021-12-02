
namespace GraphicalPhysicCalculator
{
    partial class strengthForm
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
            this.mass = new System.Windows.Forms.NumericUpDown();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.tmr_emulation = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.speedText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.strengthText = new System.Windows.Forms.Label();
            this.timeText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.verticalProgressBar1 = new verticalProgress.verticalProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.mass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            this.SuspendLayout();
            // 
            // mass
            // 
            this.mass.Location = new System.Drawing.Point(12, 12);
            this.mass.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.mass.Name = "mass";
            this.mass.Size = new System.Drawing.Size(120, 22);
            this.mass.TabIndex = 3;
            this.mass.ValueChanged += new System.EventHandler(this.mass_ValueChanged);
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(12, 40);
            this.height.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(120, 22);
            this.height.TabIndex = 4;
            this.height.ValueChanged += new System.EventHandler(this.height_ValueChanged);
            // 
            // tmr_emulation
            // 
            this.tmr_emulation.Interval = 1000;
            this.tmr_emulation.Tick += new System.EventHandler(this.tmr_emulation_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Эмулировать БУМ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Скорость падения: ";
            // 
            // speedText
            // 
            this.speedText.AutoSize = true;
            this.speedText.Location = new System.Drawing.Point(63, 111);
            this.speedText.Name = "speedText";
            this.speedText.Size = new System.Drawing.Size(20, 17);
            this.speedText.TabIndex = 8;
            this.speedText.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Сила: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // strengthText
            // 
            this.strengthText.AutoSize = true;
            this.strengthText.Location = new System.Drawing.Point(63, 154);
            this.strengthText.Name = "strengthText";
            this.strengthText.Size = new System.Drawing.Size(20, 17);
            this.strengthText.TabIndex = 10;
            this.strengthText.Text = "...";
            this.strengthText.Click += new System.EventHandler(this.strengthText_Click);
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.Location = new System.Drawing.Point(63, 198);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(20, 17);
            this.timeText.TabIndex = 11;
            this.timeText.Text = "...";
            this.timeText.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Время падения:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // verticalProgressBar1
            // 
            this.verticalProgressBar1.Location = new System.Drawing.Point(186, 12);
            this.verticalProgressBar1.Name = "verticalProgressBar1";
            this.verticalProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.verticalProgressBar1.RightToLeftLayout = true;
            this.verticalProgressBar1.Size = new System.Drawing.Size(97, 332);
            this.verticalProgressBar1.TabIndex = 5;
            this.verticalProgressBar1.Click += new System.EventHandler(this.verticalProgressBar1_Click);
            // 
            // strengthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 356);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.strengthText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.speedText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.verticalProgressBar1);
            this.Controls.Add(this.height);
            this.Controls.Add(this.mass);
            this.Name = "strengthForm";
            this.Text = "Сила";
            this.Load += new System.EventHandler(this.strengthForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown mass;
        private System.Windows.Forms.NumericUpDown height;
        private verticalProgress.verticalProgressBar verticalProgressBar1;
        private System.Windows.Forms.Timer tmr_emulation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label speedText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label strengthText;
        private System.Windows.Forms.Label timeText;
        private System.Windows.Forms.Label label4;
    }
}