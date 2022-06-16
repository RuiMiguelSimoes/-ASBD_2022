namespace Browser
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.userPassword = new System.Windows.Forms.MaskedTextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.dataBaseName = new System.Windows.Forms.TextBox();
            this.hostName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 271);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 37);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 271);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(182, 226);
            this.userPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userPassword.Name = "userPassword";
            this.userPassword.PasswordChar = '*';
            this.userPassword.Size = new System.Drawing.Size(144, 20);
            this.userPassword.TabIndex = 17;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(182, 173);
            this.userName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(144, 20);
            this.userName.TabIndex = 16;
            // 
            // dataBaseName
            // 
            this.dataBaseName.Location = new System.Drawing.Point(182, 114);
            this.dataBaseName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataBaseName.Name = "dataBaseName";
            this.dataBaseName.Size = new System.Drawing.Size(144, 20);
            this.dataBaseName.TabIndex = 15;
            // 
            // hostName
            // 
            this.hostName.Location = new System.Drawing.Point(182, 58);
            this.hostName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hostName.Name = "hostName";
            this.hostName.Size = new System.Drawing.Size(144, 20);
            this.hostName.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Database Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Host Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.dataBaseName);
            this.Controls.Add(this.hostName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox userPassword;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox dataBaseName;
        private System.Windows.Forms.TextBox hostName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

