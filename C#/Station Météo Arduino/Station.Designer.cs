namespace Station_Météo_Arduino
{
    partial class Station
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Station));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxBaud = new System.Windows.Forms.TextBox();
            this.textBoxCom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LabelEtat = new System.Windows.Forms.ToolStripStatusLabel();
            this.Rx = new System.Windows.Forms.ToolStripStatusLabel();
            this.heure = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DHT11h = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DHT11t = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DS18S20 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LM335 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonStop);
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Controls.Add(this.textBoxBaud);
            this.groupBox1.Controls.Add(this.textBoxCom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paramètres de connexion";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(248, 21);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(82, 23);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Déconnexion";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Visible = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(248, 21);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(82, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Connexion";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxBaud
            // 
            this.textBoxBaud.Location = new System.Drawing.Point(173, 23);
            this.textBoxBaud.Name = "textBoxBaud";
            this.textBoxBaud.Size = new System.Drawing.Size(54, 20);
            this.textBoxBaud.TabIndex = 3;
            this.textBoxBaud.Text = "9600";
            this.textBoxBaud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBaud.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBaud_KeyDown);
            // 
            // textBoxCom
            // 
            this.textBoxCom.Location = new System.Drawing.Point(50, 23);
            this.textBoxCom.Name = "textBoxCom";
            this.textBoxCom.Size = new System.Drawing.Size(54, 20);
            this.textBoxCom.TabIndex = 2;
            this.textBoxCom.Text = "COM3";
            this.textBoxCom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCom_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vitesse :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port :";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelEtat,
            this.Rx,
            this.heure});
            this.statusStrip1.Location = new System.Drawing.Point(0, 187);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(373, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LabelEtat
            // 
            this.LabelEtat.Name = "LabelEtat";
            this.LabelEtat.Size = new System.Drawing.Size(108, 17);
            this.LabelEtat.Text = "État : Déconnecté   ";
            // 
            // Rx
            // 
            this.Rx.Name = "Rx";
            this.Rx.Size = new System.Drawing.Size(28, 17);
            this.Rx.Text = "Rx : ";
            // 
            // heure
            // 
            this.heure.Name = "heure";
            this.heure.Size = new System.Drawing.Size(0, 17);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Eih3Prog";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DHT11h);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.DHT11t);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.DS18S20);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.LM335);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valeurs des capteurs";
            // 
            // DHT11h
            // 
            this.DHT11h.AutoSize = true;
            this.DHT11h.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DHT11h.Location = new System.Drawing.Point(249, 64);
            this.DHT11h.Name = "DHT11h";
            this.DHT11h.Size = new System.Drawing.Size(73, 20);
            this.DHT11h.TabIndex = 7;
            this.DHT11h.Text = "50 % HR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(175, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "DHT11 :";
            // 
            // DHT11t
            // 
            this.DHT11t.AutoSize = true;
            this.DHT11t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DHT11t.Location = new System.Drawing.Point(249, 31);
            this.DHT11t.Name = "DHT11t";
            this.DHT11t.Size = new System.Drawing.Size(47, 20);
            this.DHT11t.TabIndex = 5;
            this.DHT11t.Text = "20 °C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(175, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "DHT11 :";
            // 
            // DS18S20
            // 
            this.DS18S20.AutoSize = true;
            this.DS18S20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DS18S20.Location = new System.Drawing.Point(107, 65);
            this.DS18S20.Name = "DS18S20";
            this.DS18S20.Size = new System.Drawing.Size(47, 20);
            this.DS18S20.TabIndex = 3;
            this.DS18S20.Text = "20 °C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "DS18S20 :";
            // 
            // LM335
            // 
            this.LM335.AutoSize = true;
            this.LM335.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LM335.Location = new System.Drawing.Point(107, 31);
            this.LM335.Name = "LM335";
            this.LM335.Size = new System.Drawing.Size(47, 20);
            this.LM335.TabIndex = 1;
            this.LM335.Text = "20 °C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "LM335 :";
            // 
            // Station
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 209);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Station";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Station Météo Arduino";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxBaud;
        private System.Windows.Forms.TextBox textBoxCom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ToolStripStatusLabel LabelEtat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label DHT11h;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label DHT11t;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label DS18S20;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LM335;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripStatusLabel Rx;
        private System.Windows.Forms.ToolStripStatusLabel heure;
    }
}

