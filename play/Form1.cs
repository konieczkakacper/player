using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace play
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            volume_control.Value = 10;
            lbl_vol.Text = "10%";
            
        }

        string[] paths, files;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect= true;
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files= ofd.FileNames;
                paths= ofd.FileNames;

                for (int x = 0; x < files.Length; x++)
                {
                    track_list.Items.Add(files[x]);
                }
            }
        }

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[track_list.SelectedIndex];
            player.Ctlcontrols.play();

        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop(); 
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex = track_list.SelectedIndex + 1;
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                progressBar.Value = (int)player.Ctlcontrols.currentPosition;
            }
            try
            {
                lbl_start_track.Text = player.Ctlcontrols.currentPositionString;
                lbl_end_track.Text = player.Ctlcontrols.currentItem.durationString.ToString();
            }
            catch { }
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void volume_control_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = volume_control.Value;
            lbl_vol.Text = volume_control.Value.ToString() + "%";
        }

        private void lbl_vol_Click(object sender, EventArgs e)
        {

        }

        private void lbl_end_track_Click(object sender, EventArgs e)
        {

        }

        private void lbl_start_track_Click(object sender, EventArgs e)
        {
            
        }
    }
}
