using System;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            /* Faze 1
             * 
             * Random rnd = new Random();
             int tmp = rnd.Next(1, 11);

             if (ListBoxItems.Items.Contains(tmp))
             {
                 MessageBox.Show($"Value {tmp} is already in the list");
             }
             else
             {
                 ListBoxItems.Items.Add(tmp);
             }*/

            // Faze 2

            /* if (ListBoxItems.Items.Contains(TxtName.Text))
             {
                 MessageBox.Show($"Value {TxtName.Text} is already in the list");
             }
             else
             {
                 ListBoxItems.Items.Add(TxtName.Text);
             }*/

            // Faze 3
            /* if(TxtName.Text == "" || TxtSurname.Text == "")
             {
                 MessageBox.Show("Missing inputs");
                 return;
             }

             Person newPerson = new Person(TxtName.Text, TxtSurname.Text);

             if (ListBoxItems.Items.Contains(newPerson))
             {
                 MessageBox.Show($"Value {newPerson.ToString()} is already in the list");
             }
             else
             {
                 ListBoxItems.Items.Add(newPerson);
             }*/

            // Faze 4

            if (TxtName.Text == "" || TxtSurname.Text == "")
            {
                MessageBox.Show("Missing inputs");
                return;
            }

            Person newPerson = new Person(TxtName.Text, TxtSurname.Text,checkBox1.Checked);

           /* if (ListBoxItems.Items.Contains(newPerson))
           / {
                MessageBox.Show($"Value {newPerson.ToString()} is already in the list");
            }
            else
            {*/
                ListBoxItems.Items.Add(newPerson);
                if (newPerson.Subscription)
                {
                    ListBoxSubs.Items.Add(newPerson);
                }
           // }


        }
    }

    class Person
    {

        private string name;
        private string surname;
        private string email;
        private bool subscrition;

        public string Email { get; }
        public bool Subscription { get; }

        public Person(string n, string s)
        {
            name = n;
            surname = s;
            email = $"{n}.{s}@hradebni.cz";
        }

        public Person(string n, string s,bool sub)
        {
            name = n;
            surname = s;
            subscrition = sub;
            email = $"{n}.{s}@hradebni.cz";
        }

        public override string ToString()
        {
            return email;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person p2)
        {
            return p2 != null && p2.Email == Email;
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }



    }
}
