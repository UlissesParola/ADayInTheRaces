namespace CorridaDeCachorros
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRace = new System.Windows.Forms.Button();
            this.lblAlsBet = new System.Windows.Forms.Label();
            this.lblBobsBet = new System.Windows.Forms.Label();
            this.lblJoesBet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudDogs = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudBet = new System.Windows.Forms.NumericUpDown();
            this.btnBet = new System.Windows.Forms.Button();
            this.lblBettor = new System.Windows.Forms.Label();
            this.rdbAl = new System.Windows.Forms.RadioButton();
            this.rdbBob = new System.Windows.Forms.RadioButton();
            this.rdbJoe = new System.Windows.Forms.RadioButton();
            this.lblMinimumBet = new System.Windows.Forms.Label();
            this.imgDog4 = new System.Windows.Forms.PictureBox();
            this.imgDog3 = new System.Windows.Forms.PictureBox();
            this.imgDog2 = new System.Windows.Forms.PictureBox();
            this.imgDog1 = new System.Windows.Forms.PictureBox();
            this.imgBackground = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRace);
            this.groupBox1.Controls.Add(this.lblAlsBet);
            this.groupBox1.Controls.Add(this.lblBobsBet);
            this.groupBox1.Controls.Add(this.lblJoesBet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudDogs);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudBet);
            this.groupBox1.Controls.Add(this.btnBet);
            this.groupBox1.Controls.Add(this.lblBettor);
            this.groupBox1.Controls.Add(this.rdbAl);
            this.groupBox1.Controls.Add(this.rdbBob);
            this.groupBox1.Controls.Add(this.rdbJoe);
            this.groupBox1.Controls.Add(this.lblMinimumBet);
            this.groupBox1.Location = new System.Drawing.Point(12, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // btnRace
            // 
            this.btnRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRace.Location = new System.Drawing.Point(514, 106);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(80, 27);
            this.btnRace.TabIndex = 13;
            this.btnRace.Text = "Race!";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // lblAlsBet
            // 
            this.lblAlsBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlsBet.Location = new System.Drawing.Point(337, 86);
            this.lblAlsBet.Name = "lblAlsBet";
            this.lblAlsBet.Size = new System.Drawing.Size(257, 17);
            this.lblAlsBet.TabIndex = 12;
            this.lblAlsBet.Text = "Al\'s bet";
            // 
            // lblBobsBet
            // 
            this.lblBobsBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBobsBet.Location = new System.Drawing.Point(337, 64);
            this.lblBobsBet.Name = "lblBobsBet";
            this.lblBobsBet.Size = new System.Drawing.Size(257, 17);
            this.lblBobsBet.TabIndex = 11;
            this.lblBobsBet.Text = "Bob\'s bet";
            // 
            // lblJoesBet
            // 
            this.lblJoesBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJoesBet.Location = new System.Drawing.Point(337, 41);
            this.lblJoesBet.Name = "lblJoesBet";
            this.lblJoesBet.Size = new System.Drawing.Size(257, 17);
            this.lblJoesBet.TabIndex = 10;
            this.lblJoesBet.Text = "Joe\'s bet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bets";
            // 
            // nudDogs
            // 
            this.nudDogs.Location = new System.Drawing.Point(334, 113);
            this.nudDogs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDogs.Name = "nudDogs";
            this.nudDogs.Size = new System.Drawing.Size(49, 20);
            this.nudDogs.TabIndex = 8;
            this.nudDogs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "bucks on dog number";
            // 
            // nudBet
            // 
            this.nudBet.Location = new System.Drawing.Point(143, 111);
            this.nudBet.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudBet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBet.Name = "nudBet";
            this.nudBet.Size = new System.Drawing.Size(69, 20);
            this.nudBet.TabIndex = 6;
            this.nudBet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(64, 111);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(58, 20);
            this.btnBet.TabIndex = 5;
            this.btnBet.Text = "Bets";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // lblBettor
            // 
            this.lblBettor.AutoSize = true;
            this.lblBettor.Location = new System.Drawing.Point(11, 115);
            this.lblBettor.Name = "lblBettor";
            this.lblBettor.Size = new System.Drawing.Size(0, 13);
            this.lblBettor.TabIndex = 4;
            // 
            // rdbAl
            // 
            this.rdbAl.AutoSize = true;
            this.rdbAl.Location = new System.Drawing.Point(10, 87);
            this.rdbAl.Name = "rdbAl";
            this.rdbAl.Size = new System.Drawing.Size(34, 17);
            this.rdbAl.TabIndex = 3;
            this.rdbAl.Text = "Al";
            this.rdbAl.UseVisualStyleBackColor = true;
            this.rdbAl.CheckedChanged += new System.EventHandler(this.rdbAl_CheckedChanged);
            // 
            // rdbBob
            // 
            this.rdbBob.AutoSize = true;
            this.rdbBob.Location = new System.Drawing.Point(10, 64);
            this.rdbBob.Name = "rdbBob";
            this.rdbBob.Size = new System.Drawing.Size(44, 17);
            this.rdbBob.TabIndex = 2;
            this.rdbBob.Text = "Bob";
            this.rdbBob.UseVisualStyleBackColor = true;
            this.rdbBob.CheckedChanged += new System.EventHandler(this.rdbBob_CheckedChanged);
            // 
            // rdbJoe
            // 
            this.rdbJoe.AutoSize = true;
            this.rdbJoe.Checked = true;
            this.rdbJoe.Location = new System.Drawing.Point(10, 41);
            this.rdbJoe.Name = "rdbJoe";
            this.rdbJoe.Size = new System.Drawing.Size(42, 17);
            this.rdbJoe.TabIndex = 1;
            this.rdbJoe.TabStop = true;
            this.rdbJoe.Text = "Joe";
            this.rdbJoe.UseVisualStyleBackColor = true;
            this.rdbJoe.CheckedChanged += new System.EventHandler(this.rdbJoe_CheckedChanged);
            // 
            // lblMinimumBet
            // 
            this.lblMinimumBet.AutoSize = true;
            this.lblMinimumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimumBet.Location = new System.Drawing.Point(7, 20);
            this.lblMinimumBet.Name = "lblMinimumBet";
            this.lblMinimumBet.Size = new System.Drawing.Size(103, 17);
            this.lblMinimumBet.TabIndex = 0;
            this.lblMinimumBet.Text = "Minimum bet:";
            // 
            // imgDog4
            // 
            this.imgDog4.Image = global::CorridaDeCachorros.Properties.Resources.dog;
            this.imgDog4.Location = new System.Drawing.Point(26, 177);
            this.imgDog4.Name = "imgDog4";
            this.imgDog4.Size = new System.Drawing.Size(75, 20);
            this.imgDog4.TabIndex = 5;
            this.imgDog4.TabStop = false;
            // 
            // imgDog3
            // 
            this.imgDog3.Image = global::CorridaDeCachorros.Properties.Resources.dog;
            this.imgDog3.Location = new System.Drawing.Point(26, 125);
            this.imgDog3.Name = "imgDog3";
            this.imgDog3.Size = new System.Drawing.Size(75, 20);
            this.imgDog3.TabIndex = 4;
            this.imgDog3.TabStop = false;
            // 
            // imgDog2
            // 
            this.imgDog2.Image = global::CorridaDeCachorros.Properties.Resources.dog;
            this.imgDog2.Location = new System.Drawing.Point(26, 70);
            this.imgDog2.Name = "imgDog2";
            this.imgDog2.Size = new System.Drawing.Size(75, 20);
            this.imgDog2.TabIndex = 3;
            this.imgDog2.TabStop = false;
            // 
            // imgDog1
            // 
            this.imgDog1.Image = global::CorridaDeCachorros.Properties.Resources.dog;
            this.imgDog1.Location = new System.Drawing.Point(26, 22);
            this.imgDog1.Name = "imgDog1";
            this.imgDog1.Size = new System.Drawing.Size(75, 20);
            this.imgDog1.TabIndex = 2;
            this.imgDog1.TabStop = false;
            // 
            // imgBackground
            // 
            this.imgBackground.BackgroundImage = global::CorridaDeCachorros.Properties.Resources.racetrack;
            this.imgBackground.Location = new System.Drawing.Point(12, 12);
            this.imgBackground.Name = "imgBackground";
            this.imgBackground.Size = new System.Drawing.Size(600, 200);
            this.imgBackground.TabIndex = 1;
            this.imgBackground.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 392);
            this.Controls.Add(this.imgDog4);
            this.Controls.Add(this.imgDog3);
            this.Controls.Add(this.imgDog2);
            this.Controls.Add(this.imgDog1);
            this.Controls.Add(this.imgBackground);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imgBackground;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Label lblAlsBet;
        private System.Windows.Forms.Label lblBobsBet;
        private System.Windows.Forms.Label lblJoesBet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudDogs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudBet;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label lblBettor;
        private System.Windows.Forms.RadioButton rdbAl;
        private System.Windows.Forms.RadioButton rdbBob;
        private System.Windows.Forms.RadioButton rdbJoe;
        private System.Windows.Forms.Label lblMinimumBet;
        private System.Windows.Forms.PictureBox imgDog1;
        private System.Windows.Forms.PictureBox imgDog2;
        private System.Windows.Forms.PictureBox imgDog3;
        private System.Windows.Forms.PictureBox imgDog4;
    }
}

