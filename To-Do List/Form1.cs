using System.Data;

namespace To_Do_List
{
    public partial class ToDoList :Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        DataTable toDoList = new DataTable();
        bool isEditing = false;

        private void toDoList_Load(object sender, EventArgs e)
        {
            //Create columns
            toDoList.Columns.Add("Title");
            toDoList.Columns.Add("Description");

            //Point our datagridview to our datasource
            toDoListView.DataSource = toDoList;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            isEditing = true;
            try
            {
                if(toDoList == null || toDoList.Rows.Count <= 0)
                {
                    MessageBox.Show("Empty datatable.", "Datatable error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isEditing = false;
                    return;
                }

                titleTextBox.Text = toDoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
                descriptionTextBox.Text = toDoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();

            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Please select a valid task.", "Null selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isEditing = false;
                return;
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine("Error " + ex.ToString());
                isEditing = false;
                return;
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(toDoList == null || toDoList.Rows.Count <= 0)
                {
                    MessageBox.Show("Empty datatable.", "Datatable error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                toDoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Please select a valid task.", "Null selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine("Error " + ex.ToString());
                return;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(isEditing)
            {
                try
                {
                    toDoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"] = titleTextBox.Text;
                    toDoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"] = descriptionTextBox.Text;
                }
                catch(NullReferenceException ex)
                {
                    MessageBox.Show("Please enter a valid title and description.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                catch(Exception ex)
                {
                    Console.Error.WriteLine("Error " + ex.ToString());
                    return;
                }
            }
            else
            {
                if(titleTextBox.Text != "" && descriptionTextBox.Text != "")
                {
                    toDoList.Rows.Add(titleTextBox.Text, descriptionTextBox.Text);
                }
                else
                {
                    MessageBox.Show("Please enter a valid title and description.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            //Clear fields
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
            isEditing = false;
        }
    }
}