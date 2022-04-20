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
    public partial class Form1 : Form
    {
        public static List<MemberInfo> MemberList = new List<MemberInfo>();

        public Form1()
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
    }
}
