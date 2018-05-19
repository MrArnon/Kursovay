namespace BrodcastAlgorithm
{
    partial class AppForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
			this.tb1 = new System.Windows.Forms.TextBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.tb2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tb1
			// 
			this.tb1.Location = new System.Drawing.Point(25, 30);
			this.tb1.Multiline = true;
			this.tb1.Name = "tb1";
			this.tb1.ReadOnly = true;
			this.tb1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tb1.Size = new System.Drawing.Size(352, 280);
			this.tb1.TabIndex = 0;
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnStart.Enabled = false;
			this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
			this.btnStart.Location = new System.Drawing.Point(135, 317);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(69, 74);
			this.btnStart.TabIndex = 1;
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
			this.btnExit.Location = new System.Drawing.Point(543, 317);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(69, 74);
			this.btnExit.TabIndex = 2;
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnStop
			// 
			this.btnStop.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
			this.btnStop.Location = new System.Drawing.Point(347, 316);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(69, 74);
			this.btnStop.TabIndex = 3;
			this.btnStop.UseVisualStyleBackColor = false;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// tb2
			// 
			this.tb2.BackColor = System.Drawing.SystemColors.Control;
			this.tb2.Location = new System.Drawing.Point(383, 30);
			this.tb2.Multiline = true;
			this.tb2.Name = "tb2";
			this.tb2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tb2.Size = new System.Drawing.Size(324, 280);
			this.tb2.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(131, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 19);
			this.label1.TabIndex = 5;
			this.label1.Text = "Генерация потоков";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(474, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(169, 19);
			this.label2.TabIndex = 6;
			this.label2.Text = "Распределение потоков";
			// 
			// AppForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(731, 403);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb2);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.tb1);
			this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AppForm";
			this.Text = "BrodcastAlgorithm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox tb2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

