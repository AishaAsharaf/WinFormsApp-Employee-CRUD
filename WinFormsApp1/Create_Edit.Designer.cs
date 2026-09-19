namespace WinFormsApp1
{
    partial class Create_Edit
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
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            tbfirst = new TextBox();
            tblast = new TextBox();
            tbage = new TextBox();
            tblocation = new TextBox();
            ClientID = new Label();
            lblID = new Label();
            ClientFirstName = new Label();
            ClientLastName = new Label();
            ClientAge = new Label();
            ClientLocation = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(440, 360);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(325, 360);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(776, 31);
            label1.TabIndex = 2;
            label1.Text = "Create Client";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbfirst
            // 
            tbfirst.Location = new Point(325, 141);
            tbfirst.Name = "tbfirst";
            tbfirst.Size = new Size(294, 27);
            tbfirst.TabIndex = 3;
            // 
            // tblast
            // 
            tblast.Location = new Point(325, 192);
            tblast.Name = "tblast";
            tblast.Size = new Size(294, 27);
            tblast.TabIndex = 4;
            // 
            // tbage
            // 
            tbage.Location = new Point(325, 242);
            tbage.Name = "tbage";
            tbage.Size = new Size(294, 27);
            tbage.TabIndex = 5;
            // 
            // tblocation
            // 
            tblocation.Location = new Point(325, 298);
            tblocation.Name = "tblocation";
            tblocation.Size = new Size(294, 27);
            tblocation.TabIndex = 6;
            // 
            // ClientID
            // 
            ClientID.AutoSize = true;
            ClientID.Location = new Point(191, 96);
            ClientID.Name = "ClientID";
            ClientID.Size = new Size(66, 20);
            ClientID.TabIndex = 7;
            ClientID.Text = "Client ID";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(325, 96);
            lblID.Name = "lblID";
            lblID.Size = new Size(0, 20);
            lblID.TabIndex = 8;
            // 
            // ClientFirstName
            // 
            ClientFirstName.AutoSize = true;
            ClientFirstName.Location = new Point(191, 144);
            ClientFirstName.Name = "ClientFirstName";
            ClientFirstName.Size = new Size(80, 20);
            ClientFirstName.TabIndex = 9;
            ClientFirstName.Text = "First Name";
            // 
            // ClientLastName
            // 
            ClientLastName.AutoSize = true;
            ClientLastName.Location = new Point(191, 195);
            ClientLastName.Name = "ClientLastName";
            ClientLastName.Size = new Size(79, 20);
            ClientLastName.TabIndex = 10;
            ClientLastName.Text = "Last Name";
            // 
            // ClientAge
            // 
            ClientAge.AutoSize = true;
            ClientAge.Location = new Point(191, 245);
            ClientAge.Name = "ClientAge";
            ClientAge.Size = new Size(36, 20);
            ClientAge.TabIndex = 11;
            ClientAge.Text = "Age";
            // 
            // ClientLocation
            // 
            ClientLocation.AutoSize = true;
            ClientLocation.Location = new Point(191, 301);
            ClientLocation.Name = "ClientLocation";
            ClientLocation.Size = new Size(66, 20);
            ClientLocation.TabIndex = 12;
            ClientLocation.Text = "Location";
            // 
            // Create_Edit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClientLocation);
            Controls.Add(ClientAge);
            Controls.Add(ClientLastName);
            Controls.Add(ClientFirstName);
            Controls.Add(lblID);
            Controls.Add(ClientID);
            Controls.Add(tblocation);
            Controls.Add(tbage);
            Controls.Add(tblast);
            Controls.Add(tbfirst);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "Create_Edit";
            Text = "Create Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private Label label1;
        private TextBox tbfirst;
        private TextBox tblast;
        private TextBox tbage;
        private TextBox tblocation;
        private Label ClientID;
        private Label lblID;
        private Label ClientFirstName;
        private Label ClientLastName;
        private Label ClientAge;
        private Label ClientLocation;
    }
}