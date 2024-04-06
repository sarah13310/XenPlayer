using AxWMPLib;
using System.Windows.Forms;
using WMPLib;

namespace XenPlayer
{
    public partial class Player : Form
    {
        double duration;
        int minutesT;
        int secondsT;
        bool bMediaOpen = false;
        public Player()
        {
            InitializeComponent();
            this.axWindowsMediaPlayer1.uiMode = "none";
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(axWindowsMediaPlayer1_OpenStateChange);
            InitializeTrackBarTimer();
        }
        private void InitializeTrackBarTimer()
        {
            timer1.Interval = 1000; // Mise à jour toutes les secondes
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void timer1_Tick(object? sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                int progressDuration = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                playerCtl1.TrackBarValue = progressDuration;
                playerCtl1.DurationText = showDuration(progressDuration);

            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                // Réinitialiser le TrackBar quand la lecture est arrêtée
                playerCtl1.TrackBarValue = 0;
                playerCtl1.ForcePlay = true;
                playerCtl1.DurationText = showDuration(0);
            }
        }
        private void trackBar1_MouseCaptureChanged(object sender, EventArgs e)
        {
            // Si l'utilisateur relâche le clic de souris sur le TrackBar, changez la position de la lecture
            if (!playerCtl1.Capture)
            {
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = playerCtl1.TrackBarValue;
            }
        }
        private void axWindowsMediaPlayer1_OpenStateChange(object sender, _WMPOCXEvents_OpenStateChangeEvent e)
        {

            if (e.newState == (int)WMPLib.WMPOpenState.wmposMediaOpen)
            {
                duration = axWindowsMediaPlayer1.currentMedia.duration;
                lblDuration.Text = calculDuration(duration);
                lblTitle.Text = "Titre : " + Path.GetFileName(axWindowsMediaPlayer1.URL); ;
                IWMPMedia mediaInfo = axWindowsMediaPlayer1.currentMedia;
                lblMediaType.Text = "Type : " + mediaInfo.getItemInfo("FileType").ToUpper();
                playerCtl1.DurationText = showDuration(0);
                volumeCtl1.TrackBarValue = axWindowsMediaPlayer1.settings.volume;
                // voir si la durée n'est pas zéro
                if (duration > 0)
                {
                    // Mettez à jour la valeur maximale du TrackBar ici
                    playerCtl1.TrackBarMaximum = (int)duration;
                    minutesT = (int)duration / 60;
                    secondsT = (int)duration % 60;
                    bMediaOpen = true;
                    ;
                }
                playerCtl1.TrackBarValue = 0;
            }
        }

        private void volumeCtl1_MouseLeave(object sender, EventArgs e)
        {
            volumeCtl1.Hide();
        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
        }

        private void playerControl1_VolumeEvent(object sender, EventArgs e)
        {
            volumeCtl1.Show();
        }




        private string calculDuration(double duration)
        {
            // Convertissez la durée en minutes et secondes
            int minutes = (int)duration / 60;
            int seconds = (int)duration % 60;

            // Formattez la chaîne pour afficher la durée en minutes et secondes

            if (minutes > 0)
            {
                if (seconds == 0)
                {
                    return $"Durée : {minutes} minute(s) ";
                }
                return $"Durée : {minutes} minute(s) et {seconds} seconde(s)";
            }
            return $"Durée : {seconds} seconde(s)";
        }
        private string showDuration(double progressDuration)
        {
            // Convertissez la durée en minutes et secondes
            int minutesP = (int)progressDuration / 60;
            int secondsP = (int)progressDuration % 60;

            return $"{minutesP.ToString("D2")}:{secondsP.ToString("D2")} / {minutesT.ToString("D2")}:{secondsT.ToString("D2")}";
        }

        private void volumeCtl1_EventVolume(object sender, int e)
        {
            axWindowsMediaPlayer1.settings.volume = e;
        }

        private void volumeCtl1_Load(object sender, EventArgs e)
        {

        }

       
        private void playerCtl1_PlayPauseEvent(object sender, bool isPlay)
        {
            if (bMediaOpen == false)
            {
                playerCtl1.ForcePlay = true;
                return;
            }

            if (isPlay)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
                    timer1.Stop();
                    timer1.Start();

                    axWindowsMediaPlayer1.Ctlcontrols.play(); // Jouer le média
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la lecture du fichier : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
