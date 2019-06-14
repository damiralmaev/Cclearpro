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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkTemp = new System.Windows.Forms.CheckBox();
            this.checkDown = new System.Windows.Forms.CheckBox();
            this.checkAppData = new System.Windows.Forms.CheckBox();
            this.checkChomre = new System.Windows.Forms.CheckBox();
            this.btstart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеИАвторахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.полнаяОчисткаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прочееФункцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.убратьВсеГалочкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чтоДелаетКнопкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нашСайтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.полнаяОчисткатолькоСтавитГалочкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьСистемныеУтилитыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редакторРеестраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диспечерЗадачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.команднаяСтрокаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.чтоДелатьЕслиОшибкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkTemp
            // 
            this.checkTemp.AutoSize = true;
            this.checkTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkTemp.Location = new System.Drawing.Point(12, 30);
            this.checkTemp.Name = "checkTemp";
            this.checkTemp.Size = new System.Drawing.Size(462, 55);
            this.checkTemp.TabIndex = 0;
            this.checkTemp.Text = "Очистки папки Temp";
            this.toolTip1.SetToolTip(this.checkTemp, "Это папка задержит временные файлы.");
            this.checkTemp.UseVisualStyleBackColor = true;
            this.checkTemp.CheckedChanged += new System.EventHandler(this.CheckTemp_CheckedChanged);
            // 
            // checkDown
            // 
            this.checkDown.AutoSize = true;
            this.checkDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkDown.Location = new System.Drawing.Point(12, 132);
            this.checkDown.Name = "checkDown";
            this.checkDown.Size = new System.Drawing.Size(528, 55);
            this.checkDown.TabIndex = 1;
            this.checkDown.Text = "Очистки папки загрузки";
            this.toolTip1.SetToolTip(this.checkDown, "Это папка задержит все загрузки пользователя. Внимание это функция удалит все ваш" +
        "и загрузки. У вас может быть важная информация!\r\n");
            this.checkDown.UseVisualStyleBackColor = true;
            // 
            // checkAppData
            // 
            this.checkAppData.AutoSize = true;
            this.checkAppData.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkAppData.Location = new System.Drawing.Point(12, 237);
            this.checkAppData.Name = "checkAppData";
            this.checkAppData.Size = new System.Drawing.Size(520, 55);
            this.checkAppData.TabIndex = 2;
            this.checkAppData.Text = "Очистки папки AppData";
            this.toolTip1.SetToolTip(this.checkAppData, "Это папка задержит временные файлы.");
            this.checkAppData.UseVisualStyleBackColor = true;
            // 
            // checkChomre
            // 
            this.checkChomre.AutoSize = true;
            this.checkChomre.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkChomre.Location = new System.Drawing.Point(12, 344);
            this.checkChomre.Name = "checkChomre";
            this.checkChomre.Size = new System.Drawing.Size(491, 55);
            this.checkChomre.TabIndex = 3;
            this.checkChomre.Text = "Очистки кеша Chrome";
            this.toolTip1.SetToolTip(this.checkChomre, "Если у вас есть браузер Chrome, то этот браузер создаёт такие файлы под названием" +
        " КЕШ. Он нужен для быстрой загрузки. Только если его много это тормазит загрузки" +
        " и повышает использование ресурсов ПК.");
            this.checkChomre.UseVisualStyleBackColor = true;
            // 
            // btstart
            // 
            this.btstart.Location = new System.Drawing.Point(-4, 526);
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
            this.label1.Location = new System.Drawing.Point(9, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеИАвторахToolStripMenuItem,
            this.полнаяОчисткаToolStripMenuItem,
            this.обновитьToolStripMenuItem,
            this.прочееФункцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(597, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеИАвторахToolStripMenuItem
            // 
            this.оПрограммеИАвторахToolStripMenuItem.Name = "оПрограммеИАвторахToolStripMenuItem";
            this.оПрограммеИАвторахToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.оПрограммеИАвторахToolStripMenuItem.Text = "О программе и авторах";
            this.оПрограммеИАвторахToolStripMenuItem.Click += new System.EventHandler(this.ОПрограммеИАвторахToolStripMenuItem_Click);
            // 
            // полнаяОчисткаToolStripMenuItem
            // 
            this.полнаяОчисткаToolStripMenuItem.Name = "полнаяОчисткаToolStripMenuItem";
            this.полнаяОчисткаToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.полнаяОчисткаToolStripMenuItem.Text = "Полная очистка";
            this.полнаяОчисткаToolStripMenuItem.Click += new System.EventHandler(this.ПолнаяОчисткаToolStripMenuItem_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.ОбновитьToolStripMenuItem_Click);
            // 
            // прочееФункцииToolStripMenuItem
            // 
            this.прочееФункцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.убратьВсеГалочкиToolStripMenuItem,
            this.чтоДелаетКнопкиToolStripMenuItem,
            this.нашСайтToolStripMenuItem,
            this.полнаяОчисткатолькоСтавитГалочкиToolStripMenuItem,
            this.открытьСистемныеУтилитыToolStripMenuItem,
            this.обновлениеToolStripMenuItem,
            this.чтоДелатьЕслиОшибкаToolStripMenuItem});
            this.прочееФункцииToolStripMenuItem.Name = "прочееФункцииToolStripMenuItem";
            this.прочееФункцииToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.прочееФункцииToolStripMenuItem.Text = "Прочее функции";
            // 
            // убратьВсеГалочкиToolStripMenuItem
            // 
            this.убратьВсеГалочкиToolStripMenuItem.Name = "убратьВсеГалочкиToolStripMenuItem";
            this.убратьВсеГалочкиToolStripMenuItem.Size = new System.Drawing.Size(371, 26);
            this.убратьВсеГалочкиToolStripMenuItem.Text = "Убрать все галочки";
            this.убратьВсеГалочкиToolStripMenuItem.Click += new System.EventHandler(this.УбратьВсеГалочкиToolStripMenuItem_Click);
            // 
            // чтоДелаетКнопкиToolStripMenuItem
            // 
            this.чтоДелаетКнопкиToolStripMenuItem.Name = "чтоДелаетКнопкиToolStripMenuItem";
            this.чтоДелаетКнопкиToolStripMenuItem.Size = new System.Drawing.Size(371, 26);
            this.чтоДелаетКнопкиToolStripMenuItem.Text = "Что делает кнопки?";
            this.чтоДелаетКнопкиToolStripMenuItem.Click += new System.EventHandler(this.ЧтоДелаетКнопкиToolStripMenuItem_Click);
            // 
            // нашСайтToolStripMenuItem
            // 
            this.нашСайтToolStripMenuItem.Name = "нашСайтToolStripMenuItem";
            this.нашСайтToolStripMenuItem.Size = new System.Drawing.Size(371, 26);
            this.нашСайтToolStripMenuItem.Text = "Наш сайт";
            this.нашСайтToolStripMenuItem.Click += new System.EventHandler(this.НашСайтToolStripMenuItem_Click);
            // 
            // полнаяОчисткатолькоСтавитГалочкиToolStripMenuItem
            // 
            this.полнаяОчисткатолькоСтавитГалочкиToolStripMenuItem.Name = "полнаяОчисткатолькоСтавитГалочкиToolStripMenuItem";
            this.полнаяОчисткатолькоСтавитГалочкиToolStripMenuItem.Size = new System.Drawing.Size(371, 26);
            this.полнаяОчисткатолькоСтавитГалочкиToolStripMenuItem.Text = "Полная очистка (только ставит галочки)";
            this.полнаяОчисткатолькоСтавитГалочкиToolStripMenuItem.Click += new System.EventHandler(this.ПолнаяОчисткатолькоСтавитГалочкиToolStripMenuItem_Click);
            // 
            // открытьСистемныеУтилитыToolStripMenuItem
            // 
            this.открытьСистемныеУтилитыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редакторРеестраToolStripMenuItem,
            this.диспечерЗадачToolStripMenuItem,
            this.команднаяСтрокаToolStripMenuItem});
            this.открытьСистемныеУтилитыToolStripMenuItem.Name = "открытьСистемныеУтилитыToolStripMenuItem";
            this.открытьСистемныеУтилитыToolStripMenuItem.Size = new System.Drawing.Size(371, 26);
            this.открытьСистемныеУтилитыToolStripMenuItem.Text = "Открыть системные утилиты";
            // 
            // редакторРеестраToolStripMenuItem
            // 
            this.редакторРеестраToolStripMenuItem.Name = "редакторРеестраToolStripMenuItem";
            this.редакторРеестраToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.редакторРеестраToolStripMenuItem.Text = "Редактор реестра";
            this.редакторРеестраToolStripMenuItem.Click += new System.EventHandler(this.РедакторРеестраToolStripMenuItem_Click);
            // 
            // диспечерЗадачToolStripMenuItem
            // 
            this.диспечерЗадачToolStripMenuItem.Name = "диспечерЗадачToolStripMenuItem";
            this.диспечерЗадачToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.диспечерЗадачToolStripMenuItem.Text = "Диспечер задач";
            this.диспечерЗадачToolStripMenuItem.Click += new System.EventHandler(this.ДиспечерЗадачToolStripMenuItem_Click);
            // 
            // команднаяСтрокаToolStripMenuItem
            // 
            this.команднаяСтрокаToolStripMenuItem.Name = "команднаяСтрокаToolStripMenuItem";
            this.команднаяСтрокаToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.команднаяСтрокаToolStripMenuItem.Text = "Командная строка";
            this.команднаяСтрокаToolStripMenuItem.Click += new System.EventHandler(this.КоманднаяСтрокаToolStripMenuItem_Click);
            // 
            // обновлениеToolStripMenuItem
            // 
            this.обновлениеToolStripMenuItem.Name = "обновлениеToolStripMenuItem";
            this.обновлениеToolStripMenuItem.Size = new System.Drawing.Size(371, 26);
            this.обновлениеToolStripMenuItem.Text = "Обновление программы";
            this.обновлениеToolStripMenuItem.Click += new System.EventHandler(this.ОбновлениеToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 999999999;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Информация";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(-4, 419);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(604, 116);
            this.listBox1.TabIndex = 12;
            // 
            // чтоДелатьЕслиОшибкаToolStripMenuItem
            // 
            this.чтоДелатьЕслиОшибкаToolStripMenuItem.Name = "чтоДелатьЕслиОшибкаToolStripMenuItem";
            this.чтоДелатьЕслиОшибкаToolStripMenuItem.Size = new System.Drawing.Size(371, 26);
            this.чтоДелатьЕслиОшибкаToolStripMenuItem.Text = "Что делать если есть ошибка?";
            this.чтоДелатьЕслиОшибкаToolStripMenuItem.Click += new System.EventHandler(this.ЧтоДелатьЕслиОшибкаToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(597, 591);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btstart);
            this.Controls.Add(this.checkChomre);
            this.Controls.Add(this.checkAppData);
            this.Controls.Add(this.checkDown);
            this.Controls.Add(this.checkTemp);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cclearpro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkTemp;
        private System.Windows.Forms.CheckBox checkDown;
        private System.Windows.Forms.CheckBox checkAppData;
        private System.Windows.Forms.CheckBox checkChomre;
        private System.Windows.Forms.Button btstart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеИАвторахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem полнаяОчисткаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прочееФункцииToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem убратьВсеГалочкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чтоДелаетКнопкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нашСайтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem полнаяОчисткатолькоСтавитГалочкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьСистемныеУтилитыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редакторРеестраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диспечерЗадачToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem команднаяСтрокаToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem обновлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чтоДелатьЕслиОшибкаToolStripMenuItem;
    }
}

