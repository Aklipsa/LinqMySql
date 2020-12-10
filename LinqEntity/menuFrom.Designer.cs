namespace LinqEntity
{
    partial class menuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuForm));
            this.textBox_program = new System.Windows.Forms.TextBox();
            this.label_procedure = new System.Windows.Forms.Label();
            this.pageProcedure = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.label_pass = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.pageClients = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pagePrograms = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pageView = new System.Windows.Forms.TabPage();
            this.tbExit = new System.Windows.Forms.ToolStripButton();
            this.tbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tbPrint = new System.Windows.Forms.ToolStripButton();
            this.tbDel = new System.Windows.Forms.ToolStripButton();
            this.tbEdit = new System.Windows.Forms.ToolStripButton();
            this.tbAdd = new System.Windows.Forms.ToolStripButton();
            this.tbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbReport = new System.Windows.Forms.ToolStripButton();
            this.tabWorks = new System.Windows.Forms.TabControl();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pageProcedure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.pageClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pagePrograms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.pageView.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabWorks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_program
            // 
            this.textBox_program.Location = new System.Drawing.Point(103, 22);
            this.textBox_program.Name = "textBox_program";
            this.textBox_program.Size = new System.Drawing.Size(124, 23);
            this.textBox_program.TabIndex = 6;
            // 
            // label_procedure
            // 
            this.label_procedure.AutoSize = true;
            this.label_procedure.Location = new System.Drawing.Point(21, 25);
            this.label_procedure.Name = "label_procedure";
            this.label_procedure.Size = new System.Drawing.Size(69, 15);
            this.label_procedure.TabIndex = 4;
            this.label_procedure.Text = "Програмы:";
            // 
            // pageProcedure
            // 
            this.pageProcedure.Controls.Add(this.textBox_program);
            this.pageProcedure.Controls.Add(this.label_procedure);
            this.pageProcedure.Controls.Add(this.dataGridView4);
            this.pageProcedure.Location = new System.Drawing.Point(4, 29);
            this.pageProcedure.Name = "pageProcedure";
            this.pageProcedure.Padding = new System.Windows.Forms.Padding(3);
            this.pageProcedure.Size = new System.Drawing.Size(772, 367);
            this.pageProcedure.TabIndex = 3;
            this.pageProcedure.Text = "Процедура";
            this.pageProcedure.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(0, 67);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(772, 300);
            this.dataGridView4.TabIndex = 2;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(103, 22);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(124, 23);
            this.textBox_pass.TabIndex = 5;
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Location = new System.Drawing.Point(21, 25);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(49, 15);
            this.label_pass.TabIndex = 4;
            this.label_pass.Text = "Клиент:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 67);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(768, 300);
            this.dataGridView3.TabIndex = 1;
            // 
            // pageClients
            // 
            this.pageClients.Controls.Add(this.dataGridView1);
            this.pageClients.Location = new System.Drawing.Point(4, 29);
            this.pageClients.Name = "pageClients";
            this.pageClients.Padding = new System.Windows.Forms.Padding(3);
            this.pageClients.Size = new System.Drawing.Size(772, 367);
            this.pageClients.TabIndex = 0;
            this.pageClients.Text = "Клиенты";
            this.pageClients.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(772, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // pagePrograms
            // 
            this.pagePrograms.Controls.Add(this.dataGridView2);
            this.pagePrograms.Location = new System.Drawing.Point(4, 29);
            this.pagePrograms.Name = "pagePrograms";
            this.pagePrograms.Padding = new System.Windows.Forms.Padding(3);
            this.pagePrograms.Size = new System.Drawing.Size(772, 367);
            this.pagePrograms.TabIndex = 1;
            this.pagePrograms.Text = "Программы";
            this.pagePrograms.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 5);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(772, 362);
            this.dataGridView2.TabIndex = 1;
            // 
            // pageView
            // 
            this.pageView.Controls.Add(this.textBox_pass);
            this.pageView.Controls.Add(this.label_pass);
            this.pageView.Controls.Add(this.dataGridView3);
            this.pageView.Location = new System.Drawing.Point(4, 29);
            this.pageView.Name = "pageView";
            this.pageView.Padding = new System.Windows.Forms.Padding(3);
            this.pageView.Size = new System.Drawing.Size(772, 367);
            this.pageView.TabIndex = 2;
            this.pageView.Text = "Linq";
            this.pageView.UseVisualStyleBackColor = true;
            // 
            // tbExit
            // 
            this.tbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbExit.Image = ((System.Drawing.Image)(resources.GetObject("tbExit.Image")));
            this.tbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbExit.Margin = new System.Windows.Forms.Padding(355, 1, 0, 2);
            this.tbExit.Name = "tbExit";
            this.tbExit.Size = new System.Drawing.Size(34, 34);
            this.tbExit.Text = "Exit";
            this.tbExit.Click += new System.EventHandler(this.tbExit_Click);
            // 
            // tbRefresh
            // 
            this.tbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tbRefresh.Image")));
            this.tbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbRefresh.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.tbRefresh.Name = "tbRefresh";
            this.tbRefresh.Size = new System.Drawing.Size(34, 34);
            this.tbRefresh.Text = "Linq";
            // 
            // tbPrint
            // 
            this.tbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tbPrint.Image")));
            this.tbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbPrint.Margin = new System.Windows.Forms.Padding(45, 1, 0, 2);
            this.tbPrint.Name = "tbPrint";
            this.tbPrint.Size = new System.Drawing.Size(34, 34);
            this.tbPrint.Text = "GetPrograms";
            // 
            // tbDel
            // 
            this.tbDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbDel.Image = ((System.Drawing.Image)(resources.GetObject("tbDel.Image")));
            this.tbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbDel.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.tbDel.Name = "tbDel";
            this.tbDel.Size = new System.Drawing.Size(34, 34);
            this.tbDel.Text = "Delete";
            // 
            // tbEdit
            // 
            this.tbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tbEdit.Image")));
            this.tbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbEdit.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Size = new System.Drawing.Size(34, 34);
            this.tbEdit.Text = "Edit";
            // 
            // tbAdd
            // 
            this.tbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tbAdd.Image")));
            this.tbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAdd.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(34, 34);
            this.tbAdd.Text = "Add";
            this.tbAdd.Click += new System.EventHandler(this.tbAdd_Click);
            // 
            // tbSave
            // 
            this.tbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSave.Image = ((System.Drawing.Image)(resources.GetObject("tbSave.Image")));
            this.tbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(34, 34);
            this.tbSave.Text = "Save";
            this.tbSave.Click += new System.EventHandler(this.tbSave_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbSave,
            this.tbAdd,
            this.tbEdit,
            this.tbDel,
            this.tbPrint,
            this.tbRefresh,
            this.tbReport,
            this.tbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(788, 37);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbReport
            // 
            this.tbReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbReport.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(23, 34);
            this.tbReport.Text = "Report";
            // 
            // tabWorks
            // 
            this.tabWorks.Controls.Add(this.pageClients);
            this.tabWorks.Controls.Add(this.pagePrograms);
            this.tabWorks.Controls.Add(this.pageView);
            this.tabWorks.Controls.Add(this.pageProcedure);
            this.tabWorks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabWorks.ItemSize = new System.Drawing.Size(70, 25);
            this.tabWorks.Location = new System.Drawing.Point(4, 38);
            this.tabWorks.Margin = new System.Windows.Forms.Padding(1);
            this.tabWorks.Name = "tabWorks";
            this.tabWorks.SelectedIndex = 0;
            this.tabWorks.Size = new System.Drawing.Size(780, 400);
            this.tabWorks.TabIndex = 8;
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 443);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabWorks);
            this.Name = "menuForm";
            this.Text = "Entities";
            this.pageProcedure.ResumeLayout(false);
            this.pageProcedure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.pageClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pagePrograms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.pageView.ResumeLayout(false);
            this.pageView.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabWorks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.TextBox textBox_program;
        private System.Windows.Forms.Label label_procedure;
        private System.Windows.Forms.TabPage pageProcedure;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage pageClients;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage pagePrograms;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage pageView;
        private System.Windows.Forms.ToolStripButton tbExit;
        private System.Windows.Forms.ToolStripButton tbRefresh;
        private System.Windows.Forms.ToolStripButton tbPrint;
        private System.Windows.Forms.ToolStripButton tbDel;
        private System.Windows.Forms.ToolStripButton tbEdit;
        private System.Windows.Forms.ToolStripButton tbAdd;
        private System.Windows.Forms.ToolStripButton tbSave;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbReport;
        private System.Windows.Forms.TabControl tabWorks;
    }
}

