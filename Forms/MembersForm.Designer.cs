namespace LibraryManagementSystem
{
    partial class MembersForm
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
            textBox1 = new TextBox();
            txtSearchMember = new Button();
            grpMemberDetails = new GroupBox();
            dataGridView1 = new DataGridView();
            MemberId = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            chkIsActive = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            grpMemberDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 27);
            textBox1.TabIndex = 0;
            // 
            // txtSearchMember
            // 
            txtSearchMember.Location = new Point(342, 34);
            txtSearchMember.Name = "txtSearchMember";
            txtSearchMember.Size = new Size(100, 27);
            txtSearchMember.TabIndex = 1;
            txtSearchMember.Text = "Search";
            txtSearchMember.UseVisualStyleBackColor = true;
            // 
            // grpMemberDetails
            // 
            grpMemberDetails.Controls.Add(chkIsActive);
            grpMemberDetails.Controls.Add(txtAddress);
            grpMemberDetails.Controls.Add(txtEmail);
            grpMemberDetails.Controls.Add(txtPhone);
            grpMemberDetails.Controls.Add(txtFullName);
            grpMemberDetails.Location = new Point(56, 307);
            grpMemberDetails.Name = "grpMemberDetails";
            grpMemberDetails.Size = new Size(828, 80);
            grpMemberDetails.TabIndex = 2;
            grpMemberDetails.TabStop = false;
            grpMemberDetails.Text = "Member Details";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MemberId, FullName, Phone, Email, Address, IsActive });
            dataGridView1.Location = new Point(56, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(828, 219);
            dataGridView1.TabIndex = 3;
            // 
            // MemberId
            // 
            MemberId.HeaderText = "MemberId";
            MemberId.MinimumWidth = 6;
            MemberId.Name = "MemberId";
            MemberId.ReadOnly = true;
            MemberId.Visible = false;
            MemberId.Width = 125;
            // 
            // FullName
            // 
            FullName.HeaderText = "FullName";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Width = 175;
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            Phone.Width = 150;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 150;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 175;
            // 
            // IsActive
            // 
            IsActive.HeaderText = "IsActive";
            IsActive.MinimumWidth = 6;
            IsActive.Name = "IsActive";
            IsActive.ReadOnly = true;
            IsActive.Width = 125;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(48, 38);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(150, 27);
            txtFullName.TabIndex = 0;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(204, 38);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 27);
            txtPhone.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(360, 38);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(516, 38);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 27);
            txtAddress.TabIndex = 3;
            // 
            // chkIsActive
            // 
            chkIsActive.Location = new Point(672, 38);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(125, 27);
            chkIsActive.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(297, 428);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(397, 428);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(497, 428);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(597, 428);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // MembersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 503);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(grpMemberDetails);
            Controls.Add(txtSearchMember);
            Controls.Add(textBox1);
            Name = "MembersForm";
            Text = "MembersForm";
            Load += MembersForm_Load;
            grpMemberDetails.ResumeLayout(false);
            grpMemberDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button txtSearchMember;
        private GroupBox grpMemberDetails;
        private TextBox txtFullName;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MemberId;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn IsActive;
        private TextBox chkIsActive;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
    }
}