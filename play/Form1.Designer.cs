namespace play
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.track_list = new System.Windows.Forms.ListBox();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.volume_control = new System.Windows.Forms.TrackBar();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_vol = new System.Windows.Forms.Label();
            this.lbl_start_track = new System.Windows.Forms.Label();
            this.lbl_end_track = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.volume_control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // track_list
            // 
            this.track_list.FormattingEnabled = true;
            this.track_list.Location = new System.Drawing.Point(0, 131);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(411, 173);
            this.track_list.TabIndex = 1;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(10, 393);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(127, 41);
            this.btn_prev.TabIndex = 2;
            this.btn_prev.Text = "Preview";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(143, 393);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(127, 41);
            this.btn_next.TabIndex = 3;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(276, 393);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(127, 41);
            this.btn_play.TabIndex = 4;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(409, 393);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(127, 41);
            this.btn_pause.TabIndex = 5;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(542, 393);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(127, 41);
            this.btn_stop.TabIndex = 6;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(675, 393);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(127, 41);
            this.btn_open.TabIndex = 7;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // volume_control
            // 
            this.volume_control.Location = new System.Drawing.Point(764, 131);
            this.volume_control.Name = "volume_control";
            this.volume_control.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volume_control.Size = new System.Drawing.Size(45, 201);
            this.volume_control.TabIndex = 8;
            this.volume_control.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.volume_control.Scroll += new System.EventHandler(this.volume_control_Scroll);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(10, 363);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(790, 24);
            this.progressBar.TabIndex = 9;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(761, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Volume";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_vol
            // 
            this.lbl_vol.AutoSize = true;
            this.lbl_vol.Location = new System.Drawing.Point(761, 128);
            this.lbl_vol.Name = "lbl_vol";
            this.lbl_vol.Size = new System.Drawing.Size(33, 13);
            this.lbl_vol.TabIndex = 11;
            this.lbl_vol.Text = "100%";
            this.lbl_vol.Click += new System.EventHandler(this.lbl_vol_Click);
            // 
            // lbl_start_track
            // 
            this.lbl_start_track.AutoSize = true;
            this.lbl_start_track.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_start_track.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_start_track.Location = new System.Drawing.Point(-3, 9);
            this.lbl_start_track.Name = "lbl_start_track";
            this.lbl_start_track.Size = new System.Drawing.Size(34, 13);
            this.lbl_start_track.TabIndex = 12;
            this.lbl_start_track.Text = "00:00";
            this.lbl_start_track.Click += new System.EventHandler(this.lbl_start_track_Click);
            // 
            // lbl_end_track
            // 
            this.lbl_end_track.AutoSize = true;
            this.lbl_end_track.Location = new System.Drawing.Point(775, 9);
            this.lbl_end_track.Name = "lbl_end_track";
            this.lbl_end_track.Size = new System.Drawing.Size(34, 13);
            this.lbl_end_track.TabIndex = 13;
            this.lbl_end_track.Text = "00:00";
            this.lbl_end_track.Click += new System.EventHandler(this.lbl_end_track_Click);
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Top;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(809, 125);
            this.player.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 452);
            this.Controls.Add(this.lbl_end_track);
            this.Controls.Add(this.lbl_start_track);
            this.Controls.Add(this.lbl_vol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.volume_control);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.track_list);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.volume_control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.TrackBar volume_control;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_vol;
        private System.Windows.Forms.Label lbl_start_track;
        private System.Windows.Forms.Label lbl_end_track;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer player;
    }
}

