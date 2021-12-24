using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();

            PeopleFoundListBox.DataSource = people;
            PeopleFoundListBox.DisplayMember = "FullInfo";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            people = db.GetPeople(LastNameText.Text);
        }

        private void FoundPeopleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
