namespace WindowsFormPersonajes
{
    partial class FormPelea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNamePlayer = new System.Windows.Forms.Label();
            this.lblNameEnemy = new System.Windows.Forms.Label();
            this.Vida = new System.Windows.Forms.Label();
            this.Daño = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LifePlayer = new System.Windows.Forms.Label();
            this.DamPlayer = new System.Windows.Forms.Label();
            this.DamEnemy = new System.Windows.Forms.Label();
            this.LifeEnemy = new System.Windows.Forms.Label();
            this.BtFight = new System.Windows.Forms.Button();
            this.DGVHistorial = new System.Windows.Forms.DataGridView();
            this.Result = new System.Windows.Forms.Label();
            this.btLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNamePlayer
            // 
            this.lblNamePlayer.AutoSize = true;
            this.lblNamePlayer.Location = new System.Drawing.Point(60, 25);
            this.lblNamePlayer.Name = "lblNamePlayer";
            this.lblNamePlayer.Size = new System.Drawing.Size(33, 13);
            this.lblNamePlayer.TabIndex = 0;
            this.lblNamePlayer.Text = "Thrall";
            // 
            // lblNameEnemy
            // 
            this.lblNameEnemy.AutoSize = true;
            this.lblNameEnemy.Location = new System.Drawing.Point(303, 25);
            this.lblNameEnemy.Name = "lblNameEnemy";
            this.lblNameEnemy.Size = new System.Drawing.Size(48, 13);
            this.lblNameEnemy.TabIndex = 1;
            this.lblNameEnemy.Text = "Enemigo";
            // 
            // Vida
            // 
            this.Vida.AutoSize = true;
            this.Vida.Location = new System.Drawing.Point(60, 55);
            this.Vida.Name = "Vida";
            this.Vida.Size = new System.Drawing.Size(31, 13);
            this.Vida.TabIndex = 2;
            this.Vida.Text = "Vida:";
            // 
            // Daño
            // 
            this.Daño.AutoSize = true;
            this.Daño.Location = new System.Drawing.Point(60, 82);
            this.Daño.Name = "Daño";
            this.Daño.Size = new System.Drawing.Size(36, 13);
            this.Daño.TabIndex = 3;
            this.Daño.Text = "Daño:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Daño:";
            // 
            // LifePlayer
            // 
            this.LifePlayer.AutoSize = true;
            this.LifePlayer.Location = new System.Drawing.Point(102, 55);
            this.LifePlayer.Name = "LifePlayer";
            this.LifePlayer.Size = new System.Drawing.Size(25, 13);
            this.LifePlayer.TabIndex = 6;
            this.LifePlayer.Text = "150";
            // 
            // DamPlayer
            // 
            this.DamPlayer.AutoSize = true;
            this.DamPlayer.Location = new System.Drawing.Point(102, 82);
            this.DamPlayer.Name = "DamPlayer";
            this.DamPlayer.Size = new System.Drawing.Size(19, 13);
            this.DamPlayer.TabIndex = 7;
            this.DamPlayer.Text = "50";
            // 
            // DamEnemy
            // 
            this.DamEnemy.AutoSize = true;
            this.DamEnemy.Location = new System.Drawing.Point(338, 82);
            this.DamEnemy.Name = "DamEnemy";
            this.DamEnemy.Size = new System.Drawing.Size(19, 13);
            this.DamEnemy.TabIndex = 8;
            this.DamEnemy.Text = "10";
            // 
            // LifeEnemy
            // 
            this.LifeEnemy.AutoSize = true;
            this.LifeEnemy.Location = new System.Drawing.Point(338, 55);
            this.LifeEnemy.Name = "LifeEnemy";
            this.LifeEnemy.Size = new System.Drawing.Size(25, 13);
            this.LifeEnemy.TabIndex = 9;
            this.LifeEnemy.Text = "100";
            // 
            // BtFight
            // 
            this.BtFight.Location = new System.Drawing.Point(185, 121);
            this.BtFight.Name = "BtFight";
            this.BtFight.Size = new System.Drawing.Size(90, 25);
            this.BtFight.TabIndex = 10;
            this.BtFight.Text = "Peleen";
            this.BtFight.UseVisualStyleBackColor = true;
            this.BtFight.Click += new System.EventHandler(this.BtFight_Click);
            // 
            // DGVHistorial
            // 
            this.DGVHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVHistorial.Location = new System.Drawing.Point(79, 152);
            this.DGVHistorial.Name = "DGVHistorial";
            this.DGVHistorial.Size = new System.Drawing.Size(303, 225);
            this.DGVHistorial.TabIndex = 13;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(207, 25);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(55, 13);
            this.Result.TabIndex = 14;
            this.Result.Text = "Resultado";
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(63, 121);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(90, 25);
            this.btLoad.TabIndex = 15;
            this.btLoad.Text = "Cargar";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // FormPelea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 472);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.DGVHistorial);
            this.Controls.Add(this.BtFight);
            this.Controls.Add(this.LifeEnemy);
            this.Controls.Add(this.DamEnemy);
            this.Controls.Add(this.DamPlayer);
            this.Controls.Add(this.LifePlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Daño);
            this.Controls.Add(this.Vida);
            this.Controls.Add(this.lblNameEnemy);
            this.Controls.Add(this.lblNamePlayer);
            this.Name = "FormPelea";
            this.Text = "FormPelea";
            ((System.ComponentModel.ISupportInitialize)(this.DGVHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNameEnemy;
        private System.Windows.Forms.Label Vida;
        private System.Windows.Forms.Label Daño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DamEnemy;
        private System.Windows.Forms.Label LifeEnemy;
        private System.Windows.Forms.Button BtFight;
        public System.Windows.Forms.Label lblNamePlayer;
        public System.Windows.Forms.Label LifePlayer;
        public System.Windows.Forms.Label DamPlayer;
        private System.Windows.Forms.DataGridView DGVHistorial;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button btLoad;
    }
}