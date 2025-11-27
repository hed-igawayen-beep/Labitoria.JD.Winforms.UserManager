namespace Labitoria.JD.Winforms.UserManager
{
    partial class ListUsersForm
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
            label4 = new Label();
            btnSave = new Button();
            btnNew = new Button();
            dgViewUsers = new DataGridView();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgViewUsers).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(547, 57);
            label4.TabIndex = 9;
            label4.Text = "List of users";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.Dock = DockStyle.Bottom;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(0, 468);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(547, 41);
            btnSave.TabIndex = 11;
            btnSave.Text = "View";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.AliceBlue;
            btnNew.Dock = DockStyle.Top;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnNew.ForeColor = Color.DimGray;
            btnNew.Location = new Point(0, 57);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(547, 41);
            btnNew.TabIndex = 12;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // dgViewUsers
            // 
            dgViewUsers.BackgroundColor = Color.Linen;
            dgViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgViewUsers.Dock = DockStyle.Top;
            dgViewUsers.GridColor = Color.DimGray;
            dgViewUsers.Location = new Point(0, 98);
            dgViewUsers.Name = "dgViewUsers";
            dgViewUsers.Size = new Size(547, 322);
            dgViewUsers.TabIndex = 13;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(229, 426);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(87, 36);
            btnRefresh.TabIndex = 14;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ListUsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 509);
            Controls.Add(btnRefresh);
            Controls.Add(dgViewUsers);
            Controls.Add(btnNew);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Name = "ListUsersForm";
            Text = "ListUsersForm";
            Load += ListUsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgViewUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Button btnSave;
        private Button btnNew;
        private DataGridView dgViewUsers;
        private Button btnRefresh;
    }
}