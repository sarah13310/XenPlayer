using AxWMPLib;
using WMPLib;

namespace XenPlayer
{
    public partial class Form1 : Form
    {
        double duration;
        int minutesT;
        int secondsT;
        public Form1()
        {
            InitializeComponent();
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
                playerControl1.TrackBarValue = progressDuration;
                playerControl1.DurationText = showDuration(progressDuration);

            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                // Réinitialiser le TrackBar quand la lecture est arrêtée
                playerControl1.TrackBarValue = 0;
            }
        }
        private void trackBar1_MouseCaptureChanged(object sender, EventArgs e)
        {
            // Si l'utilisateur relâche le clic de souris sur le TrackBar, changez la position de la lecture
            if (!playerControl1.Capture)
            {
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = playerControl1.TrackBarValue;
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
                playerControl1.DurationText = showDuration(0);
                volumeCtl1.TrackBarValue = axWindowsMediaPlayer1.settings.volume;
                // voir si la durée n'est pas zéro
                if (duration > 0)
                {
                    // Mettez à jour la valeur maximale du TrackBar ici
                    playerControl1.TrackBarMaximum = (int)duration;
                    minutesT = (int)duration / 60;
                    secondsT = (int)duration % 60;

                }
                playerControl1.TrackBarValue = 0;
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

        private void playerControl1_PlayEvent(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused || axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                timer1.Start();
            }
        }

        private void playerControl1_PauseEvent(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                timer1.Stop();
            }
        }

        private void playerControl1_StopEvent(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            timer1.Stop();
            playerControl1.TrackBarValue = 0;
            playerControl1.DurationText = showDuration(0);
        }

        private void playerControl1_VolumeEvent(object sender, EventArgs e)
        {
            volumeCtl1.Show();
        }



        private void playerControl1_FileSelected(object sender, string e)
        {
            try
            {
                axWindowsMediaPlayer1.URL = e;
                timer1.Stop();
                timer1.Start();

                axWindowsMediaPlayer1.Ctlcontrols.play(); // Jouer le média
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la lecture du fichier : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
