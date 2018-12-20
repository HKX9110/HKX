using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16剪刀石头布
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fist = "石头";
            PlayGame(fist);

        }

        private void PlayGame(string fist)
        {
            //创建玩家对象
            Play play = new Play();
            int playNumber = play.ChuQuan(fist);
            this.lblPlay.Text = fist;

            //创建电脑对象
            Computer cpu = new Computer();
            int cpuNumber = cpu.ChuQuan();
            this.lblCpu.Text = cpu.Fist.ToString();

            //创建裁判对象
            CaiPan caipan = new CaiPan();
            Result res = caipan.GetResult(playNumber, cpuNumber);
            this.lblResult.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fist = "剪刀";
            PlayGame(fist);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fist = "布";
            PlayGame(fist);
        }

        

    }
}
