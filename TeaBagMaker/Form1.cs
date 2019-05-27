using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        string[] teaList = new string[] { "홍차", "녹차", "루이보스차", "국화차" };
        int[] teaTimeList = { 120, 180, 300, 120 };
        int CountOrgNum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < teaList.Length; i++)
            {
                this.cbList.Items.Add(teaList[i]);
            }

            if(cbList.Items.Count > 0)
            {
                this.cbList.SelectedIndex = 0;
            }
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            this.timer.Enabled = true;
        }

        private void CbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cbList.Text != "")
            {
                this.CountOrgNum = teaTimeList[this.cbList.SelectedIndex];
                this.lblCountNum.Text = "차 담그는 시간 : " + Convert.ToString(CountOrgNum / 60) + "분"; 
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(CountOrgNum < 1)
            {
                this.timer.Enabled = false;
                MessageBox.Show("티백을 건지세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cbList.Focus();
                this.lblCountNum.Text = "";
            }
            else
            {
                this.CountOrgNum--;
                this.lblCountNum.Text = Convert.ToString(this.CountOrgNum / 60) + "분 " + Convert.ToString(this.CountOrgNum % 60) + "초 남았습니다!";
            }
        }
    }
}
