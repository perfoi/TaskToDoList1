namespace TaskToDoList
{
    partial class Task
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelIsEmpty = new System.Windows.Forms.Label();
            this.labelDealsCount = new System.Windows.Forms.Label();
            this.textBoxDeals = new System.Windows.Forms.TextBox();
            this.buttonAddDeal = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxFoundedDeals = new System.Windows.Forms.TextBox();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.textBoxAddValue = new System.Windows.Forms.TextBox();
            this.textBoxAddData = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(885, 65);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // labelIsEmpty
            // 
            this.labelIsEmpty.AutoSize = true;
            this.labelIsEmpty.Location = new System.Drawing.Point(12, 89);
            this.labelIsEmpty.Name = "labelIsEmpty";
            this.labelIsEmpty.Size = new System.Drawing.Size(130, 13);
            this.labelIsEmpty.TabIndex = 1;
            this.labelIsEmpty.Text = "Пуст ли список дел : Да";
            // 
            // labelDealsCount
            // 
            this.labelDealsCount.AutoSize = true;
            this.labelDealsCount.Location = new System.Drawing.Point(165, 89);
            this.labelDealsCount.Name = "labelDealsCount";
            this.labelDealsCount.Size = new System.Drawing.Size(167, 13);
            this.labelDealsCount.TabIndex = 2;
            this.labelDealsCount.Text = "Сколько дел запланировано : 0";
            // 
            // textBoxDeals
            // 
            this.textBoxDeals.Enabled = false;
            this.textBoxDeals.Location = new System.Drawing.Point(394, 89);
            this.textBoxDeals.Multiline = true;
            this.textBoxDeals.Name = "textBoxDeals";
            this.textBoxDeals.ReadOnly = true;
            this.textBoxDeals.Size = new System.Drawing.Size(244, 315);
            this.textBoxDeals.TabIndex = 3;
            // 
            // buttonAddDeal
            // 
            this.buttonAddDeal.Location = new System.Drawing.Point(15, 142);
            this.buttonAddDeal.Name = "buttonAddDeal";
            this.buttonAddDeal.Size = new System.Drawing.Size(361, 40);
            this.buttonAddDeal.TabIndex = 4;
            this.buttonAddDeal.Text = "Добавить событие";
            this.buttonAddDeal.UseVisualStyleBackColor = true;
            this.buttonAddDeal.Click += new System.EventHandler(this.buttonAddDeal_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(15, 188);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(361, 40);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(644, 118);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(253, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Получить список дел по дате";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxFoundedDeals
            // 
            this.textBoxFoundedDeals.Enabled = false;
            this.textBoxFoundedDeals.Location = new System.Drawing.Point(644, 147);
            this.textBoxFoundedDeals.Multiline = true;
            this.textBoxFoundedDeals.Name = "textBoxFoundedDeals";
            this.textBoxFoundedDeals.ReadOnly = true;
            this.textBoxFoundedDeals.Size = new System.Drawing.Size(253, 257);
            this.textBoxFoundedDeals.TabIndex = 7;
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(644, 92);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(181, 20);
            this.textBoxData.TabIndex = 8;
            this.textBoxData.Text = "Введите дату от 1 до 31";
            this.textBoxData.Click += new System.EventHandler(this.textBoxData_Click);
            // 
            // textBoxAddValue
            // 
            this.textBoxAddValue.Location = new System.Drawing.Point(15, 116);
            this.textBoxAddValue.Name = "textBoxAddValue";
            this.textBoxAddValue.Size = new System.Drawing.Size(177, 20);
            this.textBoxAddValue.TabIndex = 9;
            this.textBoxAddValue.Text = "Опишите событие ";
            this.textBoxAddValue.Click += new System.EventHandler(this.textBoxAddValue_Click);
            // 
            // textBoxAddData
            // 
            this.textBoxAddData.Location = new System.Drawing.Point(206, 116);
            this.textBoxAddData.Name = "textBoxAddData";
            this.textBoxAddData.Size = new System.Drawing.Size(167, 20);
            this.textBoxAddData.TabIndex = 10;
            this.textBoxAddData.Text = "Добавьте дату от 1 до 31";
            this.textBoxAddData.Click += new System.EventHandler(this.textBoxAddData_Click);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(12, 395);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(133, 13);
            this.labelAuthor.TabIndex = 11;
            this.labelAuthor.Text = "Автор : Оля Перфильева";
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 417);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.textBoxAddData);
            this.Controls.Add(this.textBoxAddValue);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.textBoxFoundedDeals);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAddDeal);
            this.Controls.Add(this.textBoxDeals);
            this.Controls.Add(this.labelDealsCount);
            this.Controls.Add(this.labelIsEmpty);
            this.Controls.Add(this.textBox1);
            this.Name = "Task";
            this.Text = "Лист Дел";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelIsEmpty;
        private System.Windows.Forms.Label labelDealsCount;
        private System.Windows.Forms.TextBox textBoxDeals;
        private System.Windows.Forms.Button buttonAddDeal;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxFoundedDeals;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.TextBox textBoxAddValue;
        private System.Windows.Forms.TextBox textBoxAddData;
        private System.Windows.Forms.Label labelAuthor;
    }
}

