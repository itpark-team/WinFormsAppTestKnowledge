namespace WinFormsAppTestKnowledge.UI
{
    partial class FormUsers
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
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.buttonGetAllUsers = new System.Windows.Forms.Button();
            this.numericUpDownUserId = new System.Windows.Forms.NumericUpDown();
            this.buttonGetUserById = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUserId)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(28, 33);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowTemplate.Height = 23;
            this.dataGridViewUsers.Size = new System.Drawing.Size(465, 150);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // buttonGetAllUsers
            // 
            this.buttonGetAllUsers.Location = new System.Drawing.Point(28, 189);
            this.buttonGetAllUsers.Name = "buttonGetAllUsers";
            this.buttonGetAllUsers.Size = new System.Drawing.Size(75, 23);
            this.buttonGetAllUsers.TabIndex = 1;
            this.buttonGetAllUsers.Text = "GetAllUsers";
            this.buttonGetAllUsers.UseVisualStyleBackColor = true;
            this.buttonGetAllUsers.Click += new System.EventHandler(this.buttonGetAllUsers_Click);
            // 
            // numericUpDownUserId
            // 
            this.numericUpDownUserId.Location = new System.Drawing.Point(28, 260);
            this.numericUpDownUserId.Name = "numericUpDownUserId";
            this.numericUpDownUserId.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownUserId.TabIndex = 2;
            // 
            // buttonGetUserById
            // 
            this.buttonGetUserById.Location = new System.Drawing.Point(28, 287);
            this.buttonGetUserById.Name = "buttonGetUserById";
            this.buttonGetUserById.Size = new System.Drawing.Size(120, 23);
            this.buttonGetUserById.TabIndex = 3;
            this.buttonGetUserById.Text = "GetUserById";
            this.buttonGetUserById.UseVisualStyleBackColor = true;
            this.buttonGetUserById.Click += new System.EventHandler(this.buttonGetUserById_Click);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGetUserById);
            this.Controls.Add(this.numericUpDownUserId);
            this.Controls.Add(this.buttonGetAllUsers);
            this.Controls.Add(this.dataGridViewUsers);
            this.Name = "FormUsers";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUserId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewUsers;
        private Button buttonGetAllUsers;
        private NumericUpDown numericUpDownUserId;
        private Button buttonGetUserById;
    }
}