namespace stdiu
{
    partial class SchoolSurvior
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolSurvior));
            this.panelStart = new System.Windows.Forms.Panel();
            this.lblStartScreen = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.panelWalk = new System.Windows.Forms.Panel();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbOra = new System.Windows.Forms.PictureBox();
            this.timerWalk = new System.Windows.Forms.Timer(this.components);
            this.timerFade = new System.Windows.Forms.Timer(this.components);
            this.panelExam = new System.Windows.Forms.Panel();
            this.btnExamen = new System.Windows.Forms.Button();
            this.panelExamQuestion = new System.Windows.Forms.Panel();
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.rdD = new System.Windows.Forms.RadioButton();
            this.rdC = new System.Windows.Forms.RadioButton();
            this.rdB = new System.Windows.Forms.RadioButton();
            this.lblFeedBack = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnVerfica = new System.Windows.Forms.Button();
            this.rdA = new System.Windows.Forms.RadioButton();
            this.lblIntrebare = new System.Windows.Forms.Label();
            this.lblProgres = new System.Windows.Forms.Label();
            this.panelStart.SuspendLayout();
            this.panelWalk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOra)).BeginInit();
            this.panelExam.SuspendLayout();
            this.panelExamQuestion.SuspendLayout();
            this.panelQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStart
            // 
            this.panelStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelStart.BackgroundImage")));
            this.panelStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelStart.Controls.Add(this.lblStartScreen);
            this.panelStart.Controls.Add(this.btnStart);
            this.panelStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStart.Location = new System.Drawing.Point(0, 0);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(1422, 853);
            this.panelStart.TabIndex = 0;
            // 
            // lblStartScreen
            // 
            this.lblStartScreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStartScreen.AutoSize = true;
            this.lblStartScreen.BackColor = System.Drawing.Color.Transparent;
            this.lblStartScreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblStartScreen.Font = new System.Drawing.Font("Press Start 2P", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(223)))));
            this.lblStartScreen.Location = new System.Drawing.Point(245, 206);
            this.lblStartScreen.Name = "lblStartScreen";
            this.lblStartScreen.Size = new System.Drawing.Size(935, 82);
            this.lblStartScreen.TabIndex = 1;
            this.lblStartScreen.Text = "School Survivor";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(111)))), ((int)(((byte)(154)))));
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(67)))), ((int)(((byte)(95)))));
            this.btnStart.FlatAppearance.BorderSize = 2;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Press Start 2P", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(223)))));
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(558, 314);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Padding = new System.Windows.Forms.Padding(20);
            this.btnStart.Size = new System.Drawing.Size(287, 79);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = " Start";
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.bttnStart_Click);
            // 
            // panelWalk
            // 
            this.panelWalk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelWalk.BackgroundImage")));
            this.panelWalk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelWalk.Controls.Add(this.pbPlayer);
            this.panelWalk.Controls.Add(this.pbOra);
            this.panelWalk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWalk.Location = new System.Drawing.Point(0, 0);
            this.panelWalk.Name = "panelWalk";
            this.panelWalk.Size = new System.Drawing.Size(1422, 853);
            this.panelWalk.TabIndex = 2;
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPlayer.BackgroundImage")));
            this.pbPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbPlayer.Location = new System.Drawing.Point(669, 689);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(100, 104);
            this.pbPlayer.TabIndex = 1;
            this.pbPlayer.TabStop = false;
            // 
            // pbOra
            // 
            this.pbOra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbOra.BackColor = System.Drawing.Color.Transparent;
            this.pbOra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbOra.BackgroundImage")));
            this.pbOra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbOra.Location = new System.Drawing.Point(594, 58);
            this.pbOra.MinimumSize = new System.Drawing.Size(251, 100);
            this.pbOra.Name = "pbOra";
            this.pbOra.Size = new System.Drawing.Size(251, 100);
            this.pbOra.TabIndex = 0;
            this.pbOra.TabStop = false;
            // 
            // timerWalk
            // 
            this.timerWalk.Interval = 30;
            this.timerWalk.Tick += new System.EventHandler(this.timerWalk_Tick);
            // 
            // timerFade
            // 
            this.timerFade.Interval = 30;
            this.timerFade.Tick += new System.EventHandler(this.timerFade_Tick);
            // 
            // panelExam
            // 
            this.panelExam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelExam.BackgroundImage")));
            this.panelExam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelExam.Controls.Add(this.btnExamen);
            this.panelExam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExam.Location = new System.Drawing.Point(0, 0);
            this.panelExam.Name = "panelExam";
            this.panelExam.Size = new System.Drawing.Size(1422, 853);
            this.panelExam.TabIndex = 2;
            // 
            // btnExamen
            // 
            this.btnExamen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(122)))), ((int)(((byte)(110)))));
            this.btnExamen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamen.Font = new System.Drawing.Font("Press Start 2P", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExamen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(223)))));
            this.btnExamen.Location = new System.Drawing.Point(620, 215);
            this.btnExamen.Name = "btnExamen";
            this.btnExamen.Size = new System.Drawing.Size(188, 61);
            this.btnExamen.TabIndex = 0;
            this.btnExamen.Text = "Start Examen";
            this.btnExamen.UseVisualStyleBackColor = false;
            this.btnExamen.Click += new System.EventHandler(this.btnExamen_Click);
            // 
            // panelExamQuestion
            // 
            this.panelExamQuestion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelExamQuestion.BackgroundImage")));
            this.panelExamQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelExamQuestion.Controls.Add(this.panelQuestion);
            this.panelExamQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExamQuestion.Location = new System.Drawing.Point(0, 0);
            this.panelExamQuestion.Name = "panelExamQuestion";
            this.panelExamQuestion.Size = new System.Drawing.Size(1422, 853);
            this.panelExamQuestion.TabIndex = 1;
            // 
            // panelQuestion
            // 
            this.panelQuestion.AutoSize = true;
            this.panelQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(223)))));
            this.panelQuestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelQuestion.Controls.Add(this.rdD);
            this.panelQuestion.Controls.Add(this.rdC);
            this.panelQuestion.Controls.Add(this.rdB);
            this.panelQuestion.Controls.Add(this.lblFeedBack);
            this.panelQuestion.Controls.Add(this.btnNext);
            this.panelQuestion.Controls.Add(this.btnVerfica);
            this.panelQuestion.Controls.Add(this.rdA);
            this.panelQuestion.Controls.Add(this.lblIntrebare);
            this.panelQuestion.Controls.Add(this.lblProgres);
            this.panelQuestion.Location = new System.Drawing.Point(106, 124);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(1210, 593);
            this.panelQuestion.TabIndex = 0;
            // 
            // rdD
            // 
            this.rdD.Font = new System.Drawing.Font("Press Start 2P", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(67)))), ((int)(((byte)(95)))));
            this.rdD.Location = new System.Drawing.Point(53, 396);
            this.rdD.Name = "rdD";
            this.rdD.Size = new System.Drawing.Size(684, 55);
            this.rdD.TabIndex = 11;
            this.rdD.TabStop = true;
            this.rdD.Text = "radioButton1";
            this.rdD.UseVisualStyleBackColor = true;
            // 
            // rdC
            // 
            this.rdC.Font = new System.Drawing.Font("Press Start 2P", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(67)))), ((int)(((byte)(95)))));
            this.rdC.Location = new System.Drawing.Point(53, 319);
            this.rdC.Name = "rdC";
            this.rdC.Size = new System.Drawing.Size(684, 55);
            this.rdC.TabIndex = 10;
            this.rdC.TabStop = true;
            this.rdC.Text = "radioButton1";
            this.rdC.UseVisualStyleBackColor = true;
            // 
            // rdB
            // 
            this.rdB.Font = new System.Drawing.Font("Press Start 2P", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(67)))), ((int)(((byte)(95)))));
            this.rdB.Location = new System.Drawing.Point(53, 234);
            this.rdB.Name = "rdB";
            this.rdB.Size = new System.Drawing.Size(684, 55);
            this.rdB.TabIndex = 9;
            this.rdB.TabStop = true;
            this.rdB.Text = "radioButton1";
            this.rdB.UseVisualStyleBackColor = true;
            // 
            // lblFeedBack
            // 
            this.lblFeedBack.AutoSize = true;
            this.lblFeedBack.Font = new System.Drawing.Font("Press Start 2P", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(67)))), ((int)(((byte)(95)))));
            this.lblFeedBack.Location = new System.Drawing.Point(618, 501);
            this.lblFeedBack.Name = "lblFeedBack";
            this.lblFeedBack.Size = new System.Drawing.Size(112, 23);
            this.lblFeedBack.TabIndex = 8;
            this.lblFeedBack.Text = "label1";
            this.lblFeedBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(16)))), ((int)(((byte)(75)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Press Start 2P", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(67)))), ((int)(((byte)(95)))));
            this.btnNext.Location = new System.Drawing.Point(351, 501);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(170, 48);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Urmatoarea";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnVerfica
            // 
            this.btnVerfica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(67)))), ((int)(((byte)(95)))));
            this.btnVerfica.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(16)))), ((int)(((byte)(75)))));
            this.btnVerfica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerfica.Font = new System.Drawing.Font("Press Start 2P", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerfica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(223)))));
            this.btnVerfica.Location = new System.Drawing.Point(53, 501);
            this.btnVerfica.Name = "btnVerfica";
            this.btnVerfica.Size = new System.Drawing.Size(170, 48);
            this.btnVerfica.TabIndex = 6;
            this.btnVerfica.Text = "Verifica";
            this.btnVerfica.UseVisualStyleBackColor = false;
            this.btnVerfica.Click += new System.EventHandler(this.btnVerfica_Click);
            // 
            // rdA
            // 
            this.rdA.Font = new System.Drawing.Font("Press Start 2P", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(67)))), ((int)(((byte)(95)))));
            this.rdA.Location = new System.Drawing.Point(53, 148);
            this.rdA.Name = "rdA";
            this.rdA.Size = new System.Drawing.Size(684, 55);
            this.rdA.TabIndex = 2;
            this.rdA.TabStop = true;
            this.rdA.Text = "radioButton1";
            this.rdA.UseVisualStyleBackColor = true;
            // 
            // lblIntrebare
            // 
            this.lblIntrebare.Font = new System.Drawing.Font("Press Start 2P", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntrebare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(67)))), ((int)(((byte)(95)))));
            this.lblIntrebare.Location = new System.Drawing.Point(53, 79);
            this.lblIntrebare.Name = "lblIntrebare";
            this.lblIntrebare.Size = new System.Drawing.Size(1099, 65);
            this.lblIntrebare.TabIndex = 1;
            this.lblIntrebare.Text = "label1";
            // 
            // lblProgres
            // 
            this.lblProgres.AutoSize = true;
            this.lblProgres.Font = new System.Drawing.Font("Press Start 2P", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(67)))), ((int)(((byte)(95)))));
            this.lblProgres.Location = new System.Drawing.Point(49, 40);
            this.lblProgres.Name = "lblProgres";
            this.lblProgres.Size = new System.Drawing.Size(25, 21);
            this.lblProgres.TabIndex = 0;
            this.lblProgres.Text = "d";
            // 
            // SchoolSurvior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 853);
            this.Controls.Add(this.panelExamQuestion);
            this.Controls.Add(this.panelExam);
            this.Controls.Add(this.panelWalk);
            this.Controls.Add(this.panelStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SchoolSurvior";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchoolSurvior";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelStart.ResumeLayout(false);
            this.panelStart.PerformLayout();
            this.panelWalk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOra)).EndInit();
            this.panelExam.ResumeLayout(false);
            this.panelExamQuestion.ResumeLayout(false);
            this.panelExamQuestion.PerformLayout();
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblStartScreen;
        private System.Windows.Forms.Panel panelWalk;
        private System.Windows.Forms.PictureBox pbOra;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Timer timerWalk;
        private System.Windows.Forms.Timer timerFade;
        private System.Windows.Forms.Panel panelExam;
        private System.Windows.Forms.Button btnExamen;
        private System.Windows.Forms.Panel panelExamQuestion;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.RadioButton rdA;
        private System.Windows.Forms.Label lblIntrebare;
        private System.Windows.Forms.Label lblProgres;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnVerfica;
        private System.Windows.Forms.Label lblFeedBack;
        private System.Windows.Forms.RadioButton rdD;
        private System.Windows.Forms.RadioButton rdC;
        private System.Windows.Forms.RadioButton rdB;
    }
}

