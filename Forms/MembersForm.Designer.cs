namespace LibraryManagementSystem
{
    partial class MembersForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtSearchMember = new Button();
            grpMemberDetails = new GroupBox();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dataGridView1 = new DataGridView();

            grpMemberDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

           
            dataGridView1.Location = new System.Drawing.Point(20, 20);
            dataGridView1.Size = new System.Drawing.Size(760, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.AutoGenerateColumns = true; 
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.CellClick += dataGridView1_CellClick;

           
            grpMemberDetails.Location = new System.Drawing.Point(20, 280);
            grpMemberDetails.Size = new System.Drawing.Size(760, 70);
            grpMemberDetails.Text = "Member Details";
            grpMemberDetails.Controls.Add(txtFullName);
            grpMemberDetails.Controls.Add(txtPhone);
            grpMemberDetails.Controls.Add(txtEmail);

          
            txtFullName.Location = new System.Drawing.Point(10, 30);
            txtFullName.Size = new System.Drawing.Size(200, 27);
            txtFullName.Name = "txtFullName";

           
            txtPhone.Location = new System.Drawing.Point(220, 30);
            txtPhone.Size = new System.Drawing.Size(150, 27);
            txtPhone.Name = "txtPhone";

            txtEmail.Location = new System.Drawing.Point(380, 30);
            txtEmail.Size = new System.Drawing.Size(200, 27);
            txtEmail.Name = "txtEmail";

           
            btnAdd.Location = new System.Drawing.Point(100, 370);
            btnAdd.Size = new System.Drawing.Size(80, 30);
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;

            btnUpdate.Location = new System.Drawing.Point(200, 370);
            btnUpdate.Size = new System.Drawing.Size(80, 30);
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;

            btnDelete.Location = new System.Drawing.Point(300, 370);
            btnDelete.Size = new System.Drawing.Size(80, 30);
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;

            btnClear.Location = new System.Drawing.Point(400, 370);
            btnClear.Size = new System.Drawing.Size(80, 30);
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;

         
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(grpMemberDetails);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Name = "MembersForm";
            Text = "MembersForm";
            Load += MembersForm_Load;

            grpMemberDetails.ResumeLayout(false);
            grpMemberDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button txtSearchMember;
        private GroupBox grpMemberDetails;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dataGridView1;
    }
}
