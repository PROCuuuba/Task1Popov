using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Task1Popov
{
    public partial class ItemsForm : Form
    {
        PostgresConnector bd = new PostgresConnector();

        public ItemsForm()
        {
            InitializeComponent();
        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            FillListView();

            comboBoxSort.Items.Add("От А до Я");
            comboBoxSort.Items.Add("От Я до А");

            comboBoxFilter.Items.Add("По возрастанию");
            comboBoxFilter.Items.Add("По убыванию");
        }

        private void FillListView()
        {
            listViewItems.View = View.Details;

            bd.openConnection();

            string sortOrder = GetSortOrder();
            string query = "SELECT item_id, article, name, cost FROM items";

            if (!string.IsNullOrEmpty(textBoxSearch.Text))
            {
                query += $" WHERE name ILIKE '%{textBoxSearch.Text}%'";
            }

            if (comboBoxFilter.SelectedIndex == 0) // По возрастанию стоимости
            {
                query += " ORDER BY cost ASC";
            }
            else if (comboBoxFilter.SelectedIndex == 1) // По убыванию стоимости
            {
                query += " ORDER BY cost DESC";
            }

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, bd.getConnection()))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = "Картинка";  // Заменить на путь к картинке
                        item.SubItems.Add(reader["article"].ToString());
                        item.SubItems.Add(reader["name"].ToString());
                        item.SubItems.Add(reader["cost"].ToString());

                        listViewItems.Items.Add(item);
                    }
                }
            }

            bd.closeConnection();
        }

        private string GetSortOrder()
        {
            if (comboBoxSort.SelectedIndex == 0) // От А до Я
            {
                return "ASC";
            }

            else if (comboBoxSort.SelectedIndex == 1) // От Я до А
            {
                return "DESC";
            }

            return "ASC";
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            listViewItems.Items.Clear();
            FillListView();
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewItems.Items.Clear();
            FillListView();
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewItems.Items.Clear();
            FillListView();
        }

        private void ItemsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
