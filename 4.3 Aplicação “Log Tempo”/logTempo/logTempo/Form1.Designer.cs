namespace logTempo
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
            this.label1 = new System.Windows.Forms.Label();
            this.database = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.host_name = new System.Windows.Forms.TextBox();
            this.database_name = new System.Windows.Forms.TextBox();
            this.user_name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host Name:";
            // 
            // database
            // 
            this.database.AutoSize = true;
            this.database.Location = new System.Drawing.Point(12, 67);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(87, 13);
            this.database.TabIndex = 0;
            this.database.Text = "Database Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password:";
            // 
            // host_name
            // 
            this.host_name.Location = new System.Drawing.Point(105, 16);
            this.host_name.Name = "host_name";
            this.host_name.Size = new System.Drawing.Size(203, 20);
            this.host_name.TabIndex = 1;
            this.host_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // database_name
            // 
            this.database_name.Location = new System.Drawing.Point(105, 64);
            this.database_name.Name = "database_name";
            this.database_name.Size = new System.Drawing.Size(203, 20);
            this.database_name.TabIndex = 1;
            this.database_name.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(105, 118);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(203, 20);
            this.user_name.TabIndex = 1;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(105, 170);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(203, 20);
            this.password.TabIndex = 1;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 291);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.database_name);
            this.Controls.Add(this.host_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.database);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label database;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox host_name;
        private System.Windows.Forms.TextBox database_name;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

