using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace winforms3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button btn = new Button();
            btn.Text = "New Custom Button";
            btn.Click += Btn_Click;
            btn.Click += Btn_StakeHolder2;
            btn.Click -= Btn_Click;
            ///extra steps for making it visible on the form
            ///
            this.Controls.Add(btn);
        }

        private void Btn_StakeHolder2(object sender, EventArgs e)
        {
            MessageBox.Show("StakeHolder 2");
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Btn_Click");
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Person Jon = new Person();
            Jon.Aadhaar = "AB203943249340YZ";
            Jon.Name = "Jon Fernandes";
            Jon.Age = 32;
            Jon.Email = "jon@gmail.com";
            Jon.Gender = PersonGender.Male;
            string[] sArray = { "Rice", "Sabji", "Sambar", "Curd" };

            textBox1.Text = $"Hi, this is  {Jon.Name}! I am a {Jon.Gender.ToString()} and " +
                            $"I'm {Jon.Age} years old. You can contact me at {Jon.Email}.";

            ///
            TextBox txtCustom = new TextBox();
            txtCustom.Name = "txtCustom";
            txtCustom.Location = new System.Drawing.Point(211, 140);
            txtCustom.Width = 200;
            txtCustom.Height = 100;
            txtCustom.Multiline = true;
            txtCustom.Text = $"{Jon.Name} has completed {Jon.Walks(2)} steps";
            //Read from the above textbox
            string txtValue = txtCustom.Text;
            this.Controls.Add(txtCustom);   //Adding the dynamic textbox to the "current" form object
            
            MessageBox.Show($"Value in txtCustom is: {txtValue}");
        }
    }
}
