namespace SkyrimClicker
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBoxBattleField = new System.Windows.Forms.GroupBox();
            this.pictureBoxEnemy = new System.Windows.Forms.PictureBox();
            this.EnemyHPBar = new System.Windows.Forms.ProgressBar();
            this.labelGold = new System.Windows.Forms.Label();
            this.labelGoldAmount = new System.Windows.Forms.Label();
            this.labelLevelCounter = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelClickDamageAmount = new System.Windows.Forms.Label();
            this.labelClickDamage = new System.Windows.Forms.Label();
            this.labelExpAmount = new System.Windows.Forms.Label();
            this.labelExp = new System.Windows.Forms.Label();
            this.groupBoxBattleField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBattleField
            // 
            this.groupBoxBattleField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxBattleField.Controls.Add(this.pictureBoxEnemy);
            this.groupBoxBattleField.Controls.Add(this.EnemyHPBar);
            this.groupBoxBattleField.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBattleField.ForeColor = System.Drawing.SystemColors.MenuText;
            this.groupBoxBattleField.Location = new System.Drawing.Point(317, 12);
            this.groupBoxBattleField.Name = "groupBoxBattleField";
            this.groupBoxBattleField.Size = new System.Drawing.Size(451, 533);
            this.groupBoxBattleField.TabIndex = 0;
            this.groupBoxBattleField.TabStop = false;
            this.groupBoxBattleField.Text = "Battlefield";
            // 
            // pictureBoxEnemy
            // 
            this.pictureBoxEnemy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxEnemy.BackgroundImage")));
            this.pictureBoxEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxEnemy.Location = new System.Drawing.Point(6, 35);
            this.pictureBoxEnemy.Name = "pictureBoxEnemy";
            this.pictureBoxEnemy.Size = new System.Drawing.Size(439, 463);
            this.pictureBoxEnemy.TabIndex = 1;
            this.pictureBoxEnemy.TabStop = false;
            this.pictureBoxEnemy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // EnemyHPBar
            // 
            this.EnemyHPBar.BackColor = System.Drawing.Color.Black;
            this.EnemyHPBar.ForeColor = System.Drawing.Color.Crimson;
            this.EnemyHPBar.Location = new System.Drawing.Point(6, 504);
            this.EnemyHPBar.Name = "EnemyHPBar";
            this.EnemyHPBar.Size = new System.Drawing.Size(439, 23);
            this.EnemyHPBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.EnemyHPBar.TabIndex = 0;
            // 
            // labelGold
            // 
            this.labelGold.AutoSize = true;
            this.labelGold.Location = new System.Drawing.Point(12, 9);
            this.labelGold.Name = "labelGold";
            this.labelGold.Size = new System.Drawing.Size(87, 27);
            this.labelGold.TabIndex = 1;
            this.labelGold.Text = "Gold: ";
            // 
            // labelGoldAmount
            // 
            this.labelGoldAmount.AutoSize = true;
            this.labelGoldAmount.Location = new System.Drawing.Point(284, 9);
            this.labelGoldAmount.Name = "labelGoldAmount";
            this.labelGoldAmount.Size = new System.Drawing.Size(27, 27);
            this.labelGoldAmount.TabIndex = 2;
            this.labelGoldAmount.Text = "0";
            // 
            // labelLevelCounter
            // 
            this.labelLevelCounter.AutoSize = true;
            this.labelLevelCounter.Location = new System.Drawing.Point(284, 36);
            this.labelLevelCounter.Name = "labelLevelCounter";
            this.labelLevelCounter.Size = new System.Drawing.Size(27, 27);
            this.labelLevelCounter.TabIndex = 4;
            this.labelLevelCounter.Text = "0";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(12, 36);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(91, 27);
            this.labelLevel.TabIndex = 3;
            this.labelLevel.Text = "Level: ";
            // 
            // labelClickDamageAmount
            // 
            this.labelClickDamageAmount.AutoSize = true;
            this.labelClickDamageAmount.Location = new System.Drawing.Point(284, 90);
            this.labelClickDamageAmount.Name = "labelClickDamageAmount";
            this.labelClickDamageAmount.Size = new System.Drawing.Size(27, 27);
            this.labelClickDamageAmount.TabIndex = 6;
            this.labelClickDamageAmount.Text = "0";
            // 
            // labelClickDamage
            // 
            this.labelClickDamage.AutoSize = true;
            this.labelClickDamage.Location = new System.Drawing.Point(12, 90);
            this.labelClickDamage.Name = "labelClickDamage";
            this.labelClickDamage.Size = new System.Drawing.Size(207, 27);
            this.labelClickDamage.TabIndex = 5;
            this.labelClickDamage.Text = "Click damage: ";
            // 
            // labelExpAmount
            // 
            this.labelExpAmount.AutoSize = true;
            this.labelExpAmount.Location = new System.Drawing.Point(258, 63);
            this.labelExpAmount.Name = "labelExpAmount";
            this.labelExpAmount.Size = new System.Drawing.Size(53, 27);
            this.labelExpAmount.TabIndex = 8;
            this.labelExpAmount.Text = "0/0";
            // 
            // labelExp
            // 
            this.labelExp.AutoSize = true;
            this.labelExp.Location = new System.Drawing.Point(12, 63);
            this.labelExp.Name = "labelExp";
            this.labelExp.Size = new System.Drawing.Size(163, 27);
            this.labelExp.TabIndex = 7;
            this.labelExp.Text = "Experience: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.labelExpAmount);
            this.Controls.Add(this.labelExp);
            this.Controls.Add(this.labelClickDamageAmount);
            this.Controls.Add(this.labelClickDamage);
            this.Controls.Add(this.labelLevelCounter);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.labelGoldAmount);
            this.Controls.Add(this.labelGold);
            this.Controls.Add(this.groupBoxBattleField);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkyrimClicker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxBattleField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.GroupBox groupBoxBattleField;
        protected internal System.Windows.Forms.ProgressBar EnemyHPBar;
        protected internal System.Windows.Forms.PictureBox pictureBoxEnemy;
        protected internal System.Windows.Forms.Label labelGold;
        protected internal System.Windows.Forms.Label labelGoldAmount;
        protected internal System.Windows.Forms.Label labelLevelCounter;
        protected internal System.Windows.Forms.Label labelLevel;
        protected internal System.Windows.Forms.Label labelClickDamageAmount;
        protected internal System.Windows.Forms.Label labelClickDamage;
        protected internal System.Windows.Forms.Label labelExpAmount;
        protected internal System.Windows.Forms.Label labelExp;
    }
}

