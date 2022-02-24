using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            /* Random rnd = new Random();

             int newNum = rnd.Next(1, 11);


             if (ListBoxLeft.Items.Contains(TxtName.Text))
             {
                 MessageBox.Show($"honota {TxtName.Text} je již přidána");
             }
             else
             {
                 ListBoxLeft.Items.Add(TxtName.Text);
             }*/

            Person p = new Person(TxtName.Text, TxtSurname.Text,CHSub.Checked);

            ListBoxLeft.Items.Add(p);

            if (p.Subscription)
            {
                ListBoxRight.Items.Add(p);
            }
        }
    }

    class Person
    {
        private string name;
        private string surname;
        private string email;
        private bool subscription;

        public bool Subscription { get { return subscription; } }

        public Person(string n, string sn, bool sub)
        {
            name = n;
            surname = sn;
            subscription = sub;
            email = $"{n}.{sn}@hradebni.cz";
        }

       public override string ToString()
        {
            return email;
        }

    }
}
