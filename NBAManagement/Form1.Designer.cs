namespace NBAManagement
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTechnAdmin = new System.Windows.Forms.Button();
            this.btnEventAdmin = new System.Windows.Forms.Button();
            this.btnVisitor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTechnAdmin);
            this.panel1.Controls.Add(this.btnEventAdmin);
            this.panel1.Controls.Add(this.btnVisitor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 275);
            this.panel1.TabIndex = 0;
            // 
            // btnTechnAdmin
            // 
            this.btnTechnAdmin.Location = new System.Drawing.Point(16, 183);
            this.btnTechnAdmin.Name = "btnTechnAdmin";
            this.btnTechnAdmin.Size = new System.Drawing.Size(200, 55);
            this.btnTechnAdmin.TabIndex = 3;
            this.btnTechnAdmin.Text = "Технический администратор";
            this.btnTechnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnEventAdmin
            // 
            this.btnEventAdmin.Location = new System.Drawing.Point(16, 122);
            this.btnEventAdmin.Name = "btnEventAdmin";
            this.btnEventAdmin.Size = new System.Drawing.Size(200, 55);
            this.btnEventAdmin.TabIndex = 2;
            this.btnEventAdmin.Text = "Администратор мероприятия";
            this.btnEventAdmin.UseVisualStyleBackColor = true;
            this.btnEventAdmin.Click += new System.EventHandler(this.btnEventAdmin_Click);
            // 
            // btnVisitor
            // 
            this.btnVisitor.Location = new System.Drawing.Point(16, 61);
            this.btnVisitor.Name = "btnVisitor";
            this.btnVisitor.Size = new System.Drawing.Size(200, 55);
            this.btnVisitor.TabIndex = 1;
            this.btnVisitor.Text = "Посетитель";
            this.btnVisitor.UseVisualStyleBackColor = true;
            this.btnVisitor.Click += new System.EventHandler(this.btnVisitor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите пользователя";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 275);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "NBAManagement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTechnAdmin;
        private System.Windows.Forms.Button btnEventAdmin;
        private System.Windows.Forms.Button btnVisitor;
    }
}

