namespace ДЗ_7
{
    partial class Doubler
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
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnPlusOne = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.lblTarget = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(77, 26);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(122, 37);
            this.btnDouble.TabIndex = 1;
            this.btnDouble.Text = "btnDouble";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Visible = false;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnPlusOne
            // 
            this.btnPlusOne.Location = new System.Drawing.Point(77, 69);
            this.btnPlusOne.Name = "btnPlusOne";
            this.btnPlusOne.Size = new System.Drawing.Size(122, 37);
            this.btnPlusOne.TabIndex = 2;
            this.btnPlusOne.Text = "btnPlusOne";
            this.btnPlusOne.UseVisualStyleBackColor = true;
            this.btnPlusOne.Visible = false;
            this.btnPlusOne.Click += new System.EventHandler(this.btnPlusOne_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(152, 9);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(77, 112);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(122, 37);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "btnPlay";
            this.btnPlay.UseMnemonic = false;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Visible = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(77, 112);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(122, 37);
            this.btnReverse.TabIndex = 4;
            this.btnReverse.Text = "Undo";
            this.btnReverse.UseMnemonic = false;
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Visible = false;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(74, 9);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(38, 13);
            this.lblTarget.TabIndex = 5;
            this.lblTarget.Text = "Target";
            // 
            // Doubler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 161);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnPlusOne);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnReverse);
            this.Name = "Doubler";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnPlusOne;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Label lblTarget;
    }
}

