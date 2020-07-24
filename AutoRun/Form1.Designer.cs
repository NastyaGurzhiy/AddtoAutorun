namespace AutoRun
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
            this.buttonAddAutoRun = new System.Windows.Forms.Button();
            this.buttonDeleteAuto = new System.Windows.Forms.Button();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxFound = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddAutoRun
            // 
            this.buttonAddAutoRun.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddAutoRun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAddAutoRun.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAddAutoRun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAddAutoRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAutoRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddAutoRun.Location = new System.Drawing.Point(28, 93);
            this.buttonAddAutoRun.Name = "buttonAddAutoRun";
            this.buttonAddAutoRun.Size = new System.Drawing.Size(120, 47);
            this.buttonAddAutoRun.TabIndex = 0;
            this.buttonAddAutoRun.Text = "Добавить в автозагрузку";
            this.buttonAddAutoRun.UseVisualStyleBackColor = false;
            this.buttonAddAutoRun.Click += new System.EventHandler(this.buttonAddAutoRun_Click);
            // 
            // buttonDeleteAuto
            // 
            this.buttonDeleteAuto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDeleteAuto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonDeleteAuto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonDeleteAuto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonDeleteAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteAuto.Location = new System.Drawing.Point(296, 93);
            this.buttonDeleteAuto.Name = "buttonDeleteAuto";
            this.buttonDeleteAuto.Size = new System.Drawing.Size(111, 48);
            this.buttonDeleteAuto.TabIndex = 1;
            this.buttonDeleteAuto.Text = "Удалить с автозагрузки";
            this.buttonDeleteAuto.UseVisualStyleBackColor = false;
            this.buttonDeleteAuto.Click += new System.EventHandler(this.buttonDeleteAuto_Click);
            // 
            // textBoxURL
            // 
            this.textBoxURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxURL.Location = new System.Drawing.Point(28, 39);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(379, 27);
            this.textBoxURL.TabIndex = 2;
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheck.Location = new System.Drawing.Point(164, 93);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(114, 47);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "Проверить автозагрузку";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(113, 217);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(35, 27);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "...";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxFound
            // 
            this.textBoxFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFound.Location = new System.Drawing.Point(28, 262);
            this.textBoxFound.Name = "textBoxFound";
            this.textBoxFound.Size = new System.Drawing.Size(379, 27);
            this.textBoxFound.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoRun.Properties.Resources.Одиночество;
            this.ClientSize = new System.Drawing.Size(436, 329);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.textBoxFound);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.buttonDeleteAuto);
            this.Controls.Add(this.buttonAddAutoRun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddAutoRun;
        private System.Windows.Forms.Button buttonDeleteAuto;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxFound;
    }
}

