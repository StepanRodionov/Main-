namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.Allcloth = new System.Windows.Forms.Button();
            this.enumChoosen = new System.Windows.Forms.Button();
            this.searcher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Go = new System.Windows.Forms.Button();
            this.Newitem = new System.Windows.Forms.Button();
            this.casualities = new System.Windows.Forms.Button();
            this.best = new System.Windows.Forms.Button();
            this.showlook = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Я собираюсь...";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 96);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(120, 19);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "В Адъ и Израиль";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 71);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(134, 19);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Заняться спортом";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(195, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Погулять в приличном месте";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(207, 19);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "На официальное мероприятие";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Allcloth
            // 
            this.Allcloth.BackColor = System.Drawing.Color.Lavender;
            this.Allcloth.Font = new System.Drawing.Font("Microsoft MHei", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Allcloth.Location = new System.Drawing.Point(12, 12);
            this.Allcloth.Name = "Allcloth";
            this.Allcloth.Size = new System.Drawing.Size(600, 50);
            this.Allcloth.TabIndex = 1;
            this.Allcloth.Text = "Посмотреть все!";
            this.Allcloth.UseVisualStyleBackColor = false;
            this.Allcloth.Click += new System.EventHandler(this.Allcloth_Click);
            // 
            // enumChoosen
            // 
            this.enumChoosen.BackColor = System.Drawing.Color.Lavender;
            this.enumChoosen.Location = new System.Drawing.Point(54, 197);
            this.enumChoosen.Name = "enumChoosen";
            this.enumChoosen.Size = new System.Drawing.Size(118, 28);
            this.enumChoosen.TabIndex = 2;
            this.enumChoosen.Text = "Вперед!";
            this.enumChoosen.UseVisualStyleBackColor = false;
            this.enumChoosen.Click += new System.EventHandler(this.enumChoosen_Click_1);
            // 
            // searcher
            // 
            this.searcher.Location = new System.Drawing.Point(268, 89);
            this.searcher.Name = "searcher";
            this.searcher.Size = new System.Drawing.Size(255, 20);
            this.searcher.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(265, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Найти вещь";
            // 
            // Go
            // 
            this.Go.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Go.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Go.Location = new System.Drawing.Point(529, 82);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(60, 31);
            this.Go.TabIndex = 5;
            this.Go.Text = "Go!";
            this.Go.UseVisualStyleBackColor = false;
            // 
            // Newitem
            // 
            this.Newitem.BackColor = System.Drawing.Color.Lavender;
            this.Newitem.Location = new System.Drawing.Point(258, 139);
            this.Newitem.Name = "Newitem";
            this.Newitem.Size = new System.Drawing.Size(166, 74);
            this.Newitem.TabIndex = 6;
            this.Newitem.Text = "Добавление вещей";
            this.Newitem.UseVisualStyleBackColor = false;
            this.Newitem.Click += new System.EventHandler(this.Newitem_Click);
            // 
            // casualities
            // 
            this.casualities.BackColor = System.Drawing.Color.Lavender;
            this.casualities.Location = new System.Drawing.Point(443, 139);
            this.casualities.Name = "casualities";
            this.casualities.Size = new System.Drawing.Size(159, 74);
            this.casualities.TabIndex = 7;
            this.casualities.Text = "Потери";
            this.casualities.UseVisualStyleBackColor = false;
            this.casualities.Click += new System.EventHandler(this.casualities_Click);
            // 
            // best
            // 
            this.best.BackColor = System.Drawing.Color.Gold;
            this.best.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.best.ForeColor = System.Drawing.Color.Firebrick;
            this.best.Location = new System.Drawing.Point(308, 240);
            this.best.Name = "best";
            this.best.Size = new System.Drawing.Size(294, 44);
            this.best.TabIndex = 8;
            this.best.Text = "Лучшие сочетания";
            this.best.UseVisualStyleBackColor = false;
            // 
            // showlook
            // 
            this.showlook.BackColor = System.Drawing.Color.SpringGreen;
            this.showlook.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showlook.Location = new System.Drawing.Point(12, 240);
            this.showlook.Name = "showlook";
            this.showlook.Size = new System.Drawing.Size(278, 44);
            this.showlook.TabIndex = 9;
            this.showlook.Text = "Перейти в примерочную";
            this.showlook.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "by Stepan Rodionov.   All rights reserved";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.showlook);
            this.Controls.Add(this.best);
            this.Controls.Add(this.casualities);
            this.Controls.Add(this.Newitem);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searcher);
            this.Controls.Add(this.enumChoosen);
            this.Controls.Add(this.Allcloth);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(640, 360);
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Что надеть?!";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Button Allcloth;
        private System.Windows.Forms.Button enumChoosen;
        private System.Windows.Forms.TextBox searcher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.Button Newitem;
        private System.Windows.Forms.Button casualities;
        private System.Windows.Forms.Button best;
        private System.Windows.Forms.Button showlook;
        private System.Windows.Forms.Label label2;
    }
}

