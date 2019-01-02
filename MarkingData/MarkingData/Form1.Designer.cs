namespace MarkingData
{
    partial class MainForm
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
            this.wB = new System.Windows.Forms.WebBrowser();
            this.NextBtn = new System.Windows.Forms.Button();
            this.PersonBtn = new System.Windows.Forms.Button();
            this.SpamBtn = new System.Windows.Forms.Button();
            this.countLbl = new System.Windows.Forms.Label();
            this.countOfPersonLbl = new System.Windows.Forms.Label();
            this.countOfNotPersonLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wB
            // 
            this.wB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wB.Location = new System.Drawing.Point(0, 0);
            this.wB.MinimumSize = new System.Drawing.Size(20, 20);
            this.wB.Name = "wB";
            this.wB.Size = new System.Drawing.Size(992, 515);
            this.wB.TabIndex = 0;
            this.wB.Url = new System.Uri("http://google.com", System.UriKind.Absolute);
            // 
            // NextBtn
            // 
            this.NextBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NextBtn.Location = new System.Drawing.Point(326, 454);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(120, 40);
            this.NextBtn.TabIndex = 1;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // PersonBtn
            // 
            this.PersonBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PersonBtn.BackColor = System.Drawing.Color.LightGreen;
            this.PersonBtn.Location = new System.Drawing.Point(449, 454);
            this.PersonBtn.Name = "PersonBtn";
            this.PersonBtn.Size = new System.Drawing.Size(120, 40);
            this.PersonBtn.TabIndex = 2;
            this.PersonBtn.Text = "Person";
            this.PersonBtn.UseVisualStyleBackColor = false;
            this.PersonBtn.Click += new System.EventHandler(this.PersonBtn_Click);
            // 
            // SpamBtn
            // 
            this.SpamBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SpamBtn.BackColor = System.Drawing.Color.Crimson;
            this.SpamBtn.Location = new System.Drawing.Point(572, 454);
            this.SpamBtn.Name = "SpamBtn";
            this.SpamBtn.Size = new System.Drawing.Size(120, 40);
            this.SpamBtn.TabIndex = 6;
            this.SpamBtn.Text = "Spam";
            this.SpamBtn.UseVisualStyleBackColor = false;
            this.SpamBtn.Click += new System.EventHandler(this.SpamBtn_Click);
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.countLbl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.countLbl.Location = new System.Drawing.Point(889, 9);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(77, 23);
            this.countLbl.TabIndex = 7;
            this.countLbl.Text = "label1";
            // 
            // countOfPersonLbl
            // 
            this.countOfPersonLbl.AutoSize = true;
            this.countOfPersonLbl.BackColor = System.Drawing.Color.LightGreen;
            this.countOfPersonLbl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countOfPersonLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.countOfPersonLbl.Location = new System.Drawing.Point(889, 41);
            this.countOfPersonLbl.Name = "countOfPersonLbl";
            this.countOfPersonLbl.Size = new System.Drawing.Size(77, 23);
            this.countOfPersonLbl.TabIndex = 8;
            this.countOfPersonLbl.Text = "label1";
            // 
            // countOfNotPersonLbl
            // 
            this.countOfNotPersonLbl.AutoSize = true;
            this.countOfNotPersonLbl.BackColor = System.Drawing.Color.Crimson;
            this.countOfNotPersonLbl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countOfNotPersonLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.countOfNotPersonLbl.Location = new System.Drawing.Point(889, 73);
            this.countOfNotPersonLbl.Name = "countOfNotPersonLbl";
            this.countOfNotPersonLbl.Size = new System.Drawing.Size(77, 23);
            this.countOfNotPersonLbl.TabIndex = 9;
            this.countOfNotPersonLbl.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 515);
            this.Controls.Add(this.countOfNotPersonLbl);
            this.Controls.Add(this.countOfPersonLbl);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.SpamBtn);
            this.Controls.Add(this.PersonBtn);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.wB);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wB;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button PersonBtn;
        private System.Windows.Forms.Button SpamBtn;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.Label countOfPersonLbl;
        private System.Windows.Forms.Label countOfNotPersonLbl;
    }
}

