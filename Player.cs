using AxWMPLib;
using System.Windows.Forms;
using WMPLib;

namespace XenPlayer
{
    public partial class Player : Form
    {
        public Player()
        {

        }
        
        private void trackBar1_MouseCaptureChanged(object sender, EventArgs e)
        {
            // Si l'utilisateur relâche le clic de souris sur le TrackBar, changez la position de la lecture
            if (!playerCtl1.Capture)
            {
               /// axWindowsMediaPlayer1.Ctlcontrols.currentPosition = playerCtl1.TrackBarValue;
            }
        }
        
        private void volumeCtl1_MouseLeave(object sender, EventArgs e)
        {
            volumeCtl1.Hide();
        }
              

        private void playerControl1_VolumeEvent(object sender, EventArgs e)
        {
            volumeCtl1.Show();
        }


        private void btnFile_Click(object sender, EventArgs e)
        {
            try
            {
                playerCtl1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la lecture du fichier : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
