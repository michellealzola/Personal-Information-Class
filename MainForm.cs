using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Information_Class
{
    public partial class MainForm : Form
    {
        private List<PersonalInformation> personalInformationList = new List<PersonalInformation>();    
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tBoxInputName.Text;
            string address = tBoxInputAddress.Text;
            int age;

            if (!int.TryParse(tBoxInputAge.Text, out age) )
            {
                MessageBox.Show("Invalid age.");
            }

            string phone = tBoxInputPhone.Text; 

            PersonalInformation personalInformation = new PersonalInformation(name, address, age, phone);
            personalInformationList.Add(personalInformation);

            tBoxInputName.Text = "";
            tBoxInputAddress.Text = "";
            tBoxInputAge.Text = "";
            tBoxInputPhone.Text = "";

            tBoxInputName.Focus();

        }

        private void btnSeeContacts_Click(object sender, EventArgs e)
        {
            InformationForm contactsForm = new InformationForm();

            for(int i = 0; i < personalInformationList.Count; i++)
            {
                contactsForm.lBoxOutContacts.Items.Add("Name: " + personalInformationList[i].Name.ToString());
                contactsForm.lBoxOutContacts.Items.Add("Address: " + personalInformationList[i].Address.ToString());    
                contactsForm.lBoxOutContacts.Items.Add("Age: " + personalInformationList[i].Age.ToString());
                contactsForm.lBoxOutContacts.Items.Add("Phone: " + personalInformationList[i].Phone.ToString());
                contactsForm.lBoxOutContacts.Items.Add("--------------------------");
            }
            contactsForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
