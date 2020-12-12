namespace CodeFirst
{
    partial class AddClientForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_born = new System.Windows.Forms.DateTimePicker();
            this.textBox_pas = new System.Windows.Forms.TextBox();
            this.textBox_fio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_client_name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker_born);
            this.groupBox1.Controls.Add(this.textBox_pas);
            this.groupBox1.Controls.Add(this.textBox_fio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_client_name);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заполните поля";
            // 
            // dateTimePicker_born
            // 
            this.dateTimePicker_born.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_born.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_born.Location = new System.Drawing.Point(161, 157);
            this.dateTimePicker_born.MaxDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_born.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_born.Name = "dateTimePicker_born";
            this.dateTimePicker_born.Size = new System.Drawing.Size(286, 25);
            this.dateTimePicker_born.TabIndex = 6;
            // 
            // textBox_pas
            // 
            this.textBox_pas.Location = new System.Drawing.Point(161, 108);
            this.textBox_pas.Name = "textBox_pas";
            this.textBox_pas.Size = new System.Drawing.Size(286, 25);
            this.textBox_pas.TabIndex = 4;
            // 
            // textBox_fio
            // 
            this.textBox_fio.Location = new System.Drawing.Point(161, 66);
            this.textBox_fio.Name = "textBox_fio";
            this.textBox_fio.Size = new System.Drawing.Size(286, 25);
            this.textBox_fio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.label2.Location = new System.Drawing.Point(22, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата рождения:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.label1.Location = new System.Drawing.Point(22, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Паспорт:";
            // 
            // label_client_name
            // 
            this.label_client_name.AutoSize = true;
            this.label_client_name.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.label_client_name.Location = new System.Drawing.Point(22, 69);
            this.label_client_name.Name = "label_client_name";
            this.label_client_name.Size = new System.Drawing.Size(45, 20);
            this.label_client_name.TabIndex = 0;
            this.label_client_name.Text = "ФИО:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button1.Location = new System.Drawing.Point(385, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.label3.Location = new System.Drawing.Point(22, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID:";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(161, 28);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(286, 25);
            this.textBox_id.TabIndex = 8;
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(513, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddClientForm";
            this.Text = "Новый клиент";
            this.Load += new System.EventHandler(this.AddClientForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_client_name;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox_fio;
        public System.Windows.Forms.TextBox textBox_pas;
        public System.Windows.Forms.DateTimePicker dateTimePicker_born;
        public System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label3;
    }
}