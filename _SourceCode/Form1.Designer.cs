
namespace WorkerClock
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbTime1 = new System.Windows.Forms.Label();
            this.lbTime2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerBeep = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beepWinFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exclamationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doremiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configSaveiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMin5010 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMinites10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMinites05 = new System.Windows.Forms.ToolStripMenuItem();
            this.seconds570ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.second350ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXiTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbWeekDay = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTime1
            // 
            this.lbTime1.AutoSize = true;
            this.lbTime1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime1.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbTime1.Location = new System.Drawing.Point(19, 24);
            this.lbTime1.Name = "lbTime1";
            this.lbTime1.Size = new System.Drawing.Size(153, 65);
            this.lbTime1.TabIndex = 0;
            this.lbTime1.Text = "00:00";
            // 
            // lbTime2
            // 
            this.lbTime2.AutoSize = true;
            this.lbTime2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime2.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbTime2.Location = new System.Drawing.Point(12, 77);
            this.lbTime2.Name = "lbTime2";
            this.lbTime2.Size = new System.Drawing.Size(168, 50);
            this.lbTime2.TabIndex = 1;
            this.lbTime2.Text = "00:00:00";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 129);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(97, 129);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerBeep
            // 
            this.timerBeep.Interval = 1000;
            this.timerBeep.Tick += new System.EventHandler(this.timerBeep_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(184, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beepWinFormToolStripMenuItem,
            this.configToolStripMenuItem,
            this.eXiTToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.menuToolStripMenuItem.Text = "SmartWatch";
            // 
            // beepWinFormToolStripMenuItem
            // 
            this.beepWinFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beepToolStripMenuItem,
            this.exclamationToolStripMenuItem,
            this.doremiToolStripMenuItem});
            this.beepWinFormToolStripMenuItem.Name = "beepWinFormToolStripMenuItem";
            this.beepWinFormToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.beepWinFormToolStripMenuItem.Text = "Beep Win Form";
            // 
            // beepToolStripMenuItem
            // 
            this.beepToolStripMenuItem.Name = "beepToolStripMenuItem";
            this.beepToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.beepToolStripMenuItem.Text = "Beep";
            this.beepToolStripMenuItem.Click += new System.EventHandler(this.beepToolStripMenuItem_Click);
            // 
            // exclamationToolStripMenuItem
            // 
            this.exclamationToolStripMenuItem.Name = "exclamationToolStripMenuItem";
            this.exclamationToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exclamationToolStripMenuItem.Text = "Exclamation";
            this.exclamationToolStripMenuItem.Click += new System.EventHandler(this.exclamationToolStripMenuItem_Click);
            // 
            // doremiToolStripMenuItem
            // 
            this.doremiToolStripMenuItem.Name = "doremiToolStripMenuItem";
            this.doremiToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.doremiToolStripMenuItem.Text = "Doremi";
            this.doremiToolStripMenuItem.Click += new System.EventHandler(this.doremiToolStripMenuItem_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configSaveiniToolStripMenuItem,
            this.toolStripMenuItemMin5010,
            this.toolStripMenuItemMinites10,
            this.toolStripMenuItemMinites05,
            this.seconds570ToolStripMenuItem,
            this.second350ToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // configSaveiniToolStripMenuItem
            // 
            this.configSaveiniToolStripMenuItem.Name = "configSaveiniToolStripMenuItem";
            this.configSaveiniToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.configSaveiniToolStripMenuItem.Text = "ConfigSaveini";
            this.configSaveiniToolStripMenuItem.Click += new System.EventHandler(this.configSaveiniToolStripMenuItem_Click);
            // 
            // toolStripMenuItemMin5010
            // 
            this.toolStripMenuItemMin5010.Name = "toolStripMenuItemMin5010";
            this.toolStripMenuItemMin5010.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItemMin5010.Text = "Minites50+10";
            this.toolStripMenuItemMin5010.Click += new System.EventHandler(this.toolStripMenuItemMin5010_Click);
            // 
            // toolStripMenuItemMinites10
            // 
            this.toolStripMenuItemMinites10.Name = "toolStripMenuItemMinites10";
            this.toolStripMenuItemMinites10.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItemMinites10.Text = "Minites10";
            this.toolStripMenuItemMinites10.Click += new System.EventHandler(this.toolStripMenuItemMinites10_Click);
            // 
            // toolStripMenuItemMinites05
            // 
            this.toolStripMenuItemMinites05.Name = "toolStripMenuItemMinites05";
            this.toolStripMenuItemMinites05.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItemMinites05.Text = "Minites05";
            this.toolStripMenuItemMinites05.Click += new System.EventHandler(this.toolStripMenuItemMinites05_Click);
            // 
            // seconds570ToolStripMenuItem
            // 
            this.seconds570ToolStripMenuItem.Name = "seconds570ToolStripMenuItem";
            this.seconds570ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.seconds570ToolStripMenuItem.Text = "Second570";
            this.seconds570ToolStripMenuItem.Click += new System.EventHandler(this.seconds570ToolStripMenuItem_Click);
            // 
            // second350ToolStripMenuItem
            // 
            this.second350ToolStripMenuItem.Name = "second350ToolStripMenuItem";
            this.second350ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.second350ToolStripMenuItem.Text = "Second350";
            this.second350ToolStripMenuItem.Click += new System.EventHandler(this.second350ToolStripMenuItem_Click);
            // 
            // eXiTToolStripMenuItem
            // 
            this.eXiTToolStripMenuItem.Name = "eXiTToolStripMenuItem";
            this.eXiTToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.eXiTToolStripMenuItem.Text = "EXiT";
            this.eXiTToolStripMenuItem.Click += new System.EventHandler(this.eXiTToolStripMenuItem_Click);
            // 
            // lbWeekDay
            // 
            this.lbWeekDay.AutoSize = true;
            this.lbWeekDay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWeekDay.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbWeekDay.Location = new System.Drawing.Point(3, 27);
            this.lbWeekDay.Name = "lbWeekDay";
            this.lbWeekDay.Size = new System.Drawing.Size(19, 13);
            this.lbWeekDay.TabIndex = 4;
            this.lbWeekDay.Text = "52";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.lbWeekDay);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbTime2);
            this.Controls.Add(this.lbTime1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTime1;
        private System.Windows.Forms.Label lbTime2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerBeep;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beepWinFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exclamationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doremiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configSaveiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXiTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMin5010;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMinites10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMinites05;
        private System.Windows.Forms.Label lbWeekDay;
        private System.Windows.Forms.ToolStripMenuItem seconds570ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem second350ToolStripMenuItem;
    }
}

