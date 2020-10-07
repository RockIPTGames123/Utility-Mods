using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using Memory; //https://github.com/erfg12/memory.dll/releases

namespace AmongUsCheat_Senzaii
{
    public partial class Form1 : Form
    {
       public Mem memLib = new Mem();
        bool forceImposter = false;
        bool killCoolDown1s = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (memLib.OpenProcess("Among Us"))
            {
                lblConnectionToGame.Text = "Connection to game: successful";                             
            }
            else
            {
                MessageBox.Show("Could not connect to the game, please open the game BEFORE opening this tool");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!forceImposter)
            {
                forceImposter = true;
                btnForceImposter.Text = "Force Imposter [ON]";
                backgroundWorker1.RunWorkerAsync();

            }
            else
            {
                forceImposter = false;
                btnForceImposter.Text = "Force Imposter [OFF]";
                memLib.WriteMemory("GameAssembly.dll+01468910,5C,0,34,28", "int", "0");
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (forceImposter)
            {
                memLib.WriteMemory("GameAssembly.dll+01468910,5C,0,34,28", "int", "1");
                Thread.Sleep(100);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!killCoolDown1s)
            {
                killCoolDown1s = true;
                btnKillCoolDown.Text = "1s Kill Cooldown [ON]";
                backgroundWorker2.RunWorkerAsync();
            }
            else
            {
                killCoolDown1s = false;
                btnKillCoolDown.Text = "1s Kill Cooldown [OFF]";
            }                       
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            while (killCoolDown1s)
            {
                memLib.WriteMemory("GameAssembly.dll+01468910,5C,0,44", "int", "0");
                Thread.Sleep(100);
            } 
        }

        public bool Toggle(bool value)
        {
            return !value;
        }
    }
}
