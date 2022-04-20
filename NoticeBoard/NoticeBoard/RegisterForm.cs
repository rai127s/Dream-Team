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
    public partial class RegisterForm : Form
    {
        MemberInfo member;

        public RegisterForm(MemberInfo m)
        {
            this.member = m;
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            member.memberID = Convert.ToInt32(textBxMemID.Text);
            member.username = txtBxUN.Text;
            member.Fname = txtBxFN.Text;
            member.Sname=txtBxLN.

        }
    }
}
