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
                row["Age"]= client.age;
                row["Location"] = client.location;
                row["Date_Time"] = client.date_time;

                dataTable.Rows.Add(row);

            }

            this.EmployeeTable.DataSource = dataTable;
        }

       
    }
}
