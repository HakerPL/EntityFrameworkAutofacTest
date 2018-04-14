namespace EntityMySQL
{
    partial class Form1
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
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnAddArticle = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnEditUser2 = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(12, 12);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(137, 23);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.Location = new System.Drawing.Point(12, 176);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(137, 23);
            this.btnAddArticle.TabIndex = 1;
            this.btnAddArticle.Text = "Add Article";
            this.btnAddArticle.UseVisualStyleBackColor = true;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(12, 41);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(137, 23);
            this.btnEditUser.TabIndex = 2;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnEditUser2
            // 
            this.btnEditUser2.Location = new System.Drawing.Point(12, 70);
            this.btnEditUser2.Name = "btnEditUser2";
            this.btnEditUser2.Size = new System.Drawing.Size(137, 23);
            this.btnEditUser2.TabIndex = 3;
            this.btnEditUser2.Text = "Edit User 2";
            this.btnEditUser2.UseVisualStyleBackColor = true;
            this.btnEditUser2.Click += new System.EventHandler(this.btnEditUser2_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(12, 99);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(137, 23);
            this.btnDeleteUser.TabIndex = 4;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnEditUser2);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnAddArticle);
            this.Controls.Add(this.btnAddUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnAddArticle;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnEditUser2;
        private System.Windows.Forms.Button btnDeleteUser;
    }
}

