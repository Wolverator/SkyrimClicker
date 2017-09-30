using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyrimClicker
{
    public partial class MainForm : Form
    {
        static uint _gold = 0;
        static uint Gold
        {
            get { return _gold; }
            set { _gold = value; Program.mainForm.labelGoldAmount.Text = value.ToString(); }
        }
        static uint _level = 1;
        static uint Level
        {
            get { return _gold; }
            set
            {
                _level = value;
                Program.mainForm.labelLevelCounter.Text = value.ToString();
            }
        }
        static uint _exp = 0;
        static uint Experience
        {
            get { return _exp; }
            set {
                _exp = value; Program.mainForm.labelExpAmount.Text = value.ToString()+"/"+_expNeeded.ToString();
                if (_exp == 10) { _exp = 0; _level++; }
            }
        }
        static uint _expNeeded = 10;
        static uint _clickDamage = 1;
        static Enemy _enemy = null;

        public MainForm()
        {
            InitializeComponent();
            
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            SpawnEnemy();

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            DamageEnemyByClickDamage();
        }

        protected internal void DamageEnemyByClickDamage()
        {
            if (_enemy.HP < _clickDamage) _enemy.HP = 0;
            else
                _enemy.HP -= _clickDamage;
        }

        public void SpawnEnemy()
        {
            _enemy = new Enemy(_level);
           
        }

        public void EnemyKilled()
        {
            Gold += _enemy.Gold;
            Experience++;
            pictureBoxEnemy.Image = null;
            _enemy = null;
            SpawnEnemy();
        }
        
    }

    public class Enemy
    {
        private static uint _HP;
        protected internal uint HP
        {
            get { return _HP; }
            set {
                Program.mainForm.EnemyHPBar.Value = (int)value;
                Program.mainForm.EnemyHPBar.Refresh();
                if (value == 0) Program.mainForm.EnemyKilled();
                else _HP = value;
            }
        }
        static uint _gold;
        protected internal uint Gold { get { return _gold; } }

        enum EnemyType
        {
            wolf=1,
            spider=2
        }

        public Enemy(uint level)
        {
            Program.mainForm.pictureBoxEnemy.Image = Properties.Resources.wolf1;
            HP = uint.Parse((level * 10).ToString());
            _gold = uint.Parse((Math.Round(double.Parse(level.ToString()))).ToString());
            Program.mainForm.EnemyHPBar.Maximum = (int)HP;
        }
    }
}
