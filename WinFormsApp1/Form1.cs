using System.Data;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadClient();
        }

        private void ReadClient()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("First_Name");
            dataTable.Columns.Add("Last_Name");
            dataTable.Columns.Add("Age");
            dataTable.Columns.Add("Location");
            dataTable.Columns.Add("Date_Time");

            var data = new EmployeeData();
            var clients = data.GetClients();

            foreach (var client in clients)
            {
                var row = dataTable.NewRow();

                row["ID"] = client.id;
                row["First_Name"] = client.first_Name;
                row["Last_Name"] = client.last_Name;
                row["Age"] = client.age;
                row["Location"] = client.location;
                row["Date_Time"] = client.date_time;

                dataTable.Rows.Add(row);

            }

            this.EmployeeTable.DataSource = dataTable;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Create_Edit create_Edit = new Create_Edit();
            if (create_Edit.ShowDialog() == DialogResult.OK)
            {
                ReadClient();
            }

        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            var val = this.EmployeeTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0)
            {
                return;
            }
            int clientId = int.Parse(val);

            var data = new EmployeeData();
            var client = data.GetClient(clientId);

            if (client == null) return;

            Create_Edit create_Edit = new Create_Edit();
            create_Edit.EditClient(client);
            if (create_Edit.ShowDialog() == DialogResult.OK)
            {
                ReadClient();
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            var val = this.EmployeeTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0)
            {
                return;
            }
            int clientId = int.Parse(val);

            var data = new EmployeeData();
            var client = data.GetClient(clientId);

            if (client == null) return;
            DialogResult dialogresult = MessageBox.Show("Are you sure that you want to delete this client/Employee?", "Delete Client/Employee", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                data.DeleteClient(client);
            }
            else
            {
                return;
            }

            ReadClient();
           
        }
    }
}
