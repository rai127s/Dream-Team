using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoticeBoard
{
    public partial class loginForm : Form
    {
        public static List<MemberInfo> MemberList = new List<MemberInfo>();

        public loginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MemberInfo member = new MemberInfo();
            RegisterForm registerForm = new RegisterForm(member);
            DialogResult selectedButton = registerForm.ShowDialog();
            if (selectedButton==DialogResult.OK)
            {
                MemberList.Add(member);
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            MemberInfo m1 = new MemberInfo(1, "raissap", "Raissa", "Pululu", "raissa@gmail.com", 0894957871, "Limerick", 20);
            MemberInfo m2 = new MemberInfo(2, "charleyr", "Charley", "Rutledge", "charley@gmail.com", 011, "Limerick", 26);
            MemberInfo m3 = new MemberInfo(3, "jamess", "James", "Sherlock", "james@gmail.com", 087, "Limerick", 22);

            MemberList.Add(m1);
            MemberList.Add(m2);
            MemberList.Add(m3);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MemberInfo member = new MemberInfo();
            string user = Convert.ToString(txtBoxUN.Text);
            int phone = Convert.ToInt32(txtBoxPN.Text);

            if (user == MemberList.Contains() && phone == member.phone) 
            {
                MessageBox.Show("Successful Login");
            }

            else
            {
                MessageBox.Show("Invalid Details");
            }
        }

       
    }
}
