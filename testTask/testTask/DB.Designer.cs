namespace testTask
{
    partial class DB
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Parse = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.xmlShow = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.FindCurr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(504, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Parse
            // 
            this.Parse.Location = new System.Drawing.Point(609, 43);
            this.Parse.Name = "Parse";
            this.Parse.Size = new System.Drawing.Size(75, 20);
            this.Parse.TabIndex = 1;
            this.Parse.Text = "Parse Data";
            this.Parse.UseVisualStyleBackColor = true;
            this.Parse.Click += new System.EventHandler(this.Parse_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1.Location = new System.Drawing.Point(524, 19);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(224, 20);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Дата в формате dd.MM.yyyy:";
            // 
            // xmlShow
            // 
            this.xmlShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xmlShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xmlShow.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.xmlShow.Location = new System.Drawing.Point(504, 254);
            this.xmlShow.Multiline = true;
            this.xmlShow.Name = "xmlShow";
            this.xmlShow.ReadOnly = true;
            this.xmlShow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.xmlShow.Size = new System.Drawing.Size(257, 358);
            this.xmlShow.TabIndex = 3;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(686, 43);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 20);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save/Show";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // dgvTable
            // 
            this.dgvTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(13, 43);
            this.dgvTable.MultiSelect = false;
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(485, 569);
            this.dgvTable.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(504, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(257, 148);
            this.listBox1.TabIndex = 6;
            // 
            // FindCurr
            // 
            this.FindCurr.Location = new System.Drawing.Point(593, 224);
            this.FindCurr.Name = "FindCurr";
            this.FindCurr.Size = new System.Drawing.Size(91, 20);
            this.FindCurr.TabIndex = 7;
            this.FindCurr.Text = "Find Currency";
            this.FindCurr.UseVisualStyleBackColor = true;
            this.FindCurr.Click += new System.EventHandler(this.FindCurr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(773, 624);
            this.Controls.Add(this.FindCurr);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.xmlShow);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.Parse);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсы валют Сбербанка";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Parse;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox xmlShow;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button FindCurr;
    }
}

