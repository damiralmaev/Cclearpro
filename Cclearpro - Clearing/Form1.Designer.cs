namespace Cclearpro___Clearing
{
    partial class Form1
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
            this.checkTemp = new System.Windows.Forms.CheckBox();
            this.checkDown = new System.Windows.Forms.CheckBox();
            this.checkAppData = new System.Windows.Forms.CheckBox();
            this.checkChomre = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btstart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkTemp
            // 
            this.checkTemp.AutoSize = true;
            this.checkTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkTemp.Location = new System.Drawing.Point(12, 12);
            this.checkTemp.Name = "checkTemp";
            this.checkTemp.Size = new System.Drawing.Size(462, 55);
            this.checkTemp.TabIndex = 0;
            this.checkTemp.Text = "Очистки папки Temp";
            this.checkTemp.UseVisualStyleBackColor = true;
            // 
            // checkDown
            // 
            this.checkDown.AutoSize = true;
            this.checkDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkDown.Location = new System.Drawing.Point(12, 114);
            this.checkDown.Name = "checkDown";
            this.checkDown.Size = new System.Drawing.Size(528, 55);
            this.checkDown.TabIndex = 1;
            this.checkDown.Text = "Очистки папки загрузки";
            this.checkDown.UseVisualStyleBackColor = true;
            // 
            // checkAppData
            // 
            this.checkAppData.AutoSize = true;
            this.checkAppData.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkAppData.Location = new System.Drawing.Point(12, 219);
            this.checkAppData.Name = "checkAppData";
            this.checkAppData.Size = new System.Drawing.Size(520, 55);
            this.checkAppData.TabIndex = 2;
            this.checkAppData.Text = "Очистки папки AppData";
            this.checkAppData.UseVisualStyleBackColor = true;
            // 
            // checkChomre
            // 
            this.checkChomre.AutoSize = true;
            this.checkChomre.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkChomre.Location = new System.Drawing.Point(12, 326);
            this.checkChomre.Name = "checkChomre";
            this.checkChomre.Size = new System.Drawing.Size(491, 55);
            this.checkChomre.TabIndex = 3;
            this.checkChomre.Text = "Очистки кеша Chrome";
            this.checkChomre.UseVisualStyleBackColor = true;
            // 
            // btstart
            // 
            this.btstart.Location = new System.Drawing.Point(-9, 423);
            this.btstart.Name = "btstart";
            this.btstart.Size = new System.Drawing.Size(607, 67);
            this.btstart.TabIndex = 6;
            this.btstart.Text = "Старт";
            this.btstart.UseVisualStyleBackColor = true;
            this.btstart.Click += new System.EventHandler(this.Btstart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(597, 486);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btstart);
            this.Controls.Add(this.checkChomre);
            this.Controls.Add(this.checkAppData);
            this.Controls.Add(this.checkDown);
            this.Controls.Add(this.checkTemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Cclearpro - Clearing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkTemp;
        private System.Windows.Forms.CheckBox checkDown;
        private System.Windows.Forms.CheckBox checkAppData;
        private System.Windows.Forms.CheckBox checkChomre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btstart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

