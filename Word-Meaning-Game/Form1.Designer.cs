namespace Word_Meaning_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txtEnglish = new TextBox();
            txtTurkce = new TextBox();
            label3 = new Label();
            label4 = new Label();
            lblSüre = new Label();
            lblSkor = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblMean = new Label();
            lblAnswer = new Label();
            btnPas = new Button();
            rdGoster = new RadioButton();
            rdGizle = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 15);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 40);
            label1.TabIndex = 0;
            label1.Text = "İngilizce:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 82);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 40);
            label2.TabIndex = 1;
            label2.Text = "Türkçe:";
            // 
            // txtEnglish
            // 
            txtEnglish.Location = new Point(166, 12);
            txtEnglish.Name = "txtEnglish";
            txtEnglish.Size = new Size(234, 48);
            txtEnglish.TabIndex = 2;
            // 
            // txtTurkce
            // 
            txtTurkce.Location = new Point(166, 79);
            txtTurkce.Name = "txtTurkce";
            txtTurkce.Size = new Size(234, 48);
            txtTurkce.TabIndex = 1;
            txtTurkce.KeyDown += txtTurkce_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(491, 15);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 40);
            label3.TabIndex = 4;
            label3.Text = "Süre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(466, 82);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 40);
            label4.TabIndex = 5;
            label4.Text = "Kelime:";
            // 
            // lblSüre
            // 
            lblSüre.AutoSize = true;
            lblSüre.Location = new Point(565, 15);
            lblSüre.Margin = new Padding(6, 0, 6, 0);
            lblSüre.Name = "lblSüre";
            lblSüre.Size = new Size(34, 40);
            lblSüre.TabIndex = 6;
            lblSüre.Text = "0";
            // 
            // lblSkor
            // 
            lblSkor.AutoSize = true;
            lblSkor.Location = new Point(565, 82);
            lblSkor.Margin = new Padding(6, 0, 6, 0);
            lblSkor.Name = "lblSkor";
            lblSkor.Size = new Size(34, 40);
            lblSkor.TabIndex = 7;
            lblSkor.Text = "0";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblMean
            // 
            lblMean.AutoSize = true;
            lblMean.Location = new Point(166, 185);
            lblMean.Name = "lblMean";
            lblMean.Size = new Size(86, 40);
            lblMean.TabIndex = 8;
            lblMean.Text = "label5";
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Location = new Point(631, 20);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(86, 40);
            lblAnswer.TabIndex = 10;
            lblAnswer.Text = "label5";
            // 
            // btnPas
            // 
            btnPas.Location = new Point(466, 142);
            btnPas.Name = "btnPas";
            btnPas.Size = new Size(94, 45);
            btnPas.TabIndex = 11;
            btnPas.Text = "Pas";
            btnPas.UseVisualStyleBackColor = true;
            btnPas.Click += btnPas_Click;
            // 
            // rdGoster
            // 
            rdGoster.AutoSize = true;
            rdGoster.Location = new Point(166, 133);
            rdGoster.Name = "rdGoster";
            rdGoster.Size = new Size(114, 44);
            rdGoster.TabIndex = 12;
            rdGoster.TabStop = true;
            rdGoster.Text = "Göster";
            rdGoster.UseVisualStyleBackColor = true;
            rdGoster.CheckedChanged += rdGoster_CheckedChanged;
            // 
            // rdGizle
            // 
            rdGizle.AutoSize = true;
            rdGizle.Location = new Point(306, 133);
            rdGizle.Name = "rdGizle";
            rdGizle.Size = new Size(94, 44);
            rdGizle.TabIndex = 13;
            rdGizle.TabStop = true;
            rdGizle.Text = "Gizle";
            rdGizle.UseVisualStyleBackColor = true;
            rdGizle.CheckedChanged += rdGizle_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(710, 239);
            Controls.Add(rdGizle);
            Controls.Add(rdGoster);
            Controls.Add(btnPas);
            Controls.Add(lblAnswer);
            Controls.Add(lblMean);
            Controls.Add(lblSkor);
            Controls.Add(lblSüre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtTurkce);
            Controls.Add(txtEnglish);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "Form1";
            Text = "World-Meaning-Game";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEnglish;
        private TextBox txtTurkce;
        private Label label3;
        private Label label4;
        private Label lblSüre;
        private Label lblSkor;
        private System.Windows.Forms.Timer timer1;
        private Label lblMean;
        private Label lblAnswer;
        private Button btnPas;
        private RadioButton rdGoster;
        private RadioButton rdGizle;
    }
}
