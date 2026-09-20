using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Model;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class Create_Edit : Form
    {
        public Create_Edit()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private int clientId = 0;

        public void EditClient(Client client)
        {
            this.label1.Text = "Edit Client";
            this.Text = "Edit Client";

            this.lblID.Text =" "+ client.id;
            this.tbfirst.Text = client.first_Name;
            this.tblast.Text = client.last_Name;
            this.tbage.Text = client.age.ToString();
            this.tblocation.Text = client.location;

            this.clientId = client.id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.id = this.clientId;
            client.first_Name = this.tbfirst.Text;
            client.last_Name = this.tblast.Text;
            client.age = int.Parse(this.tbage.Text);
            client.location = this.tblocation.Text;

            EmployeeData data = new EmployeeData();

            if(clientId == 0)
            {
                data.CreateClient(client);
            }
            else
            {
                data.UpdateClient(client);
            }
           
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        
    }
}
