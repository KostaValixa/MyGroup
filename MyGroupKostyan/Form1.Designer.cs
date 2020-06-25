namespace MyGroupKostyan
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
            this.NameLab = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.FumLab = new System.Windows.Forms.Label();
            this.txtFum = new System.Windows.Forms.TextBox();
            this.NumLab = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.butDel = new System.Windows.Forms.Button();
            this.AdresLab = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.butCreate = new System.Windows.Forms.Button();
            this.TableView = new System.Windows.Forms.DataGridView();
            this.txt1Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt1Fam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt1Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt1Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLab
            // 
            this.NameLab.AutoSize = true;
            this.NameLab.Location = new System.Drawing.Point(13, 13);
            this.NameLab.Name = "NameLab";
            this.NameLab.Size = new System.Drawing.Size(29, 13);
            this.NameLab.TabIndex = 0;
            this.NameLab.Text = "Имя";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(48, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // FumLab
            // 
            this.FumLab.AutoSize = true;
            this.FumLab.Location = new System.Drawing.Point(222, 13);
            this.FumLab.Name = "FumLab";
            this.FumLab.Size = new System.Drawing.Size(56, 13);
            this.FumLab.TabIndex = 2;
            this.FumLab.Text = "Фамилия";
            // 
            // txtFum
            // 
            this.txtFum.Location = new System.Drawing.Point(285, 13);
            this.txtFum.Name = "txtFum";
            this.txtFum.Size = new System.Drawing.Size(100, 20);
            this.txtFum.TabIndex = 3;
            // 
            // NumLab
            // 
            this.NumLab.AutoSize = true;
            this.NumLab.Location = new System.Drawing.Point(13, 68);
            this.NumLab.Name = "NumLab";
            this.NumLab.Size = new System.Drawing.Size(93, 13);
            this.NumLab.TabIndex = 4;
            this.NumLab.Text = "Номер телефона";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(113, 68);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 5;
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(433, 102);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(75, 23);
            this.butDel.TabIndex = 6;
            this.butDel.Text = "Удаление";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // AdresLab
            // 
            this.AdresLab.AutoSize = true;
            this.AdresLab.Location = new System.Drawing.Point(285, 68);
            this.AdresLab.Name = "AdresLab";
            this.AdresLab.Size = new System.Drawing.Size(38, 13);
            this.AdresLab.TabIndex = 7;
            this.AdresLab.Text = "Адрес";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(330, 68);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 20);
            this.txtAdres.TabIndex = 8;
            // 
            // butCreate
            // 
            this.butCreate.Location = new System.Drawing.Point(514, 102);
            this.butCreate.Name = "butCreate";
            this.butCreate.Size = new System.Drawing.Size(75, 23);
            this.butCreate.TabIndex = 9;
            this.butCreate.Text = "Создать";
            this.butCreate.UseVisualStyleBackColor = true;
            this.butCreate.Click += new System.EventHandler(this.butCreate_Click);
            // 
            // TableView
            // 
            this.TableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt1Name,
            this.txt1Fam,
            this.txt1Num,
            this.txt1Adres});
            this.TableView.Location = new System.Drawing.Point(12, 143);
            this.TableView.Name = "TableView";
            this.TableView.Size = new System.Drawing.Size(577, 279);
            this.TableView.TabIndex = 10;
            // 
            // txt1Name
            // 
            this.txt1Name.HeaderText = "Имя";
            this.txt1Name.Name = "txt1Name";
            // 
            // txt1Fam
            // 
            this.txt1Fam.HeaderText = "Фамилия";
            this.txt1Fam.Name = "txt1Fam";
            // 
            // txt1Num
            // 
            this.txt1Num.HeaderText = "Номер телефона";
            this.txt1Num.Name = "txt1Num";
            // 
            // txt1Adres
            // 
            this.txt1Adres.HeaderText = "Адрес";
            this.txt1Adres.Name = "txt1Adres";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 430);
            this.Controls.Add(this.TableView);
            this.Controls.Add(this.butCreate);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.AdresLab);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.NumLab);
            this.Controls.Add(this.txtFum);
            this.Controls.Add(this.FumLab);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.NameLab);
            this.Name = "Form1";
            this.Text = "Моя группа";
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLab;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label FumLab;
        private System.Windows.Forms.TextBox txtFum;
        private System.Windows.Forms.Label NumLab;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Label AdresLab;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button butCreate;
        private System.Windows.Forms.DataGridView TableView;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt1Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt1Fam;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt1Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt1Adres;
    }
}

