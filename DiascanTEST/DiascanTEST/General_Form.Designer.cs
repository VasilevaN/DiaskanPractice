
namespace DiascanTEST
{
    partial class General_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passtext = new System.Windows.Forms.TextBox();
            this.logtext = new System.Windows.Forms.TextBox();
            this.dataGridView_All_Task = new System.Windows.Forms.DataGridView();
            this.btnAllTask = new System.Windows.Forms.Button();
            this.btn_Registration = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_All_Task)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btn_Registration);
            this.groupBox1.Controls.Add(this.btn_Login);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.passtext);
            this.groupBox1.Controls.Add(this.logtext);
            this.groupBox1.Location = new System.Drawing.Point(518, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Авторизация";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(191, 70);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Вход";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // passtext
            // 
            this.passtext.Location = new System.Drawing.Point(100, 47);
            this.passtext.Name = "passtext";
            this.passtext.PasswordChar = '*';
            this.passtext.Size = new System.Drawing.Size(166, 20);
            this.passtext.TabIndex = 1;
            this.passtext.UseSystemPasswordChar = true;
            // 
            // logtext
            // 
            this.logtext.Location = new System.Drawing.Point(100, 18);
            this.logtext.Name = "logtext";
            this.logtext.Size = new System.Drawing.Size(166, 20);
            this.logtext.TabIndex = 0;
            // 
            // dataGridView_All_Task
            // 
            this.dataGridView_All_Task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_All_Task.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_All_Task.Name = "dataGridView_All_Task";
            this.dataGridView_All_Task.Size = new System.Drawing.Size(499, 457);
            this.dataGridView_All_Task.TabIndex = 1;
            // 
            // btnAllTask
            // 
            this.btnAllTask.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAllTask.Location = new System.Drawing.Point(528, 441);
            this.btnAllTask.Name = "btnAllTask";
            this.btnAllTask.Size = new System.Drawing.Size(98, 44);
            this.btnAllTask.TabIndex = 3;
            this.btnAllTask.Text = "Показать все задачи";
            this.btnAllTask.UseVisualStyleBackColor = false;
            this.btnAllTask.Click += new System.EventHandler(this.btnAllTask_Click);
            // 
            // btn_Registration
            // 
            this.btn_Registration.Location = new System.Drawing.Point(20, 70);
            this.btn_Registration.Name = "btn_Registration";
            this.btn_Registration.Size = new System.Drawing.Size(88, 23);
            this.btn_Registration.TabIndex = 4;
            this.btn_Registration.Text = "Регистрация";
            this.btn_Registration.UseVisualStyleBackColor = true;
            this.btn_Registration.Click += new System.EventHandler(this.btn_Registration_Click);
            // 
            // General_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 497);
            this.Controls.Add(this.btnAllTask);
            this.Controls.Add(this.dataGridView_All_Task);
            this.Controls.Add(this.groupBox1);
            this.Name = "General_Form";
            this.Text = "Общая форма";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_All_Task)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passtext;
        public System.Windows.Forms.TextBox logtext;
        private System.Windows.Forms.DataGridView dataGridView_All_Task;
        private System.Windows.Forms.Button btnAllTask;
        private System.Windows.Forms.Button btn_Registration;
    }
}

