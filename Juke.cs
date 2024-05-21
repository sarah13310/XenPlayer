using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XenLibrary;

namespace XenPlayer
{
    public partial class Juke : Form
    {
        public Juke()
        {
            InitializeComponent();
            volumeCtl.TrackBarValue = playerCtl1.TrackBarValue;
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            playerCtl1.ShowDialog();
        }

        private void OnVolume(object sender, int e)
        {
            playerCtl1.setVolume(e);
        }

        private void onShowVolume(object sender, EventArgs e)
        {
            volumeCtl.Visible = true;
        }

        private void volumeCtl_MouseLeave(object sender, EventArgs e)
        {
            volumeCtl.Visible = false;
        }

        private void on_FileSelected(object sender, string fullPath)
        {
            if (!string.IsNullOrEmpty(fullPath))
            {
                // Créer un nouvel objet FileListItem avec le nom du fichier et le chemin complet
                FileListItem item = new FileListItem
                {
                    FileName = System.IO.Path.GetFileName(fullPath),
                    FullPath = fullPath
                };

                if (listBox1.InvokeRequired)
                {
                    // Si appelé depuis un thread autre que l'interface utilisateur, acheminer l'opération vers le thread de l'interface utilisateur
                    listBox1.Invoke((MethodInvoker)delegate
                    {
                        // Ajouter l'objet FileListItem à la liste
                        listBox1.Items.Add(item);
                        listBox1.TopIndex = listBox1.Items.Count - 1;
                        listBox1.SelectedIndex = listBox1.Items.Count - 1;
                    });
                }
                else
                {
                    listBox1.Items.Add(item);
                    if (listBox1.Items.Count > 0)
                    {
                        // Faire défiler jusqu'au dernier élément
                        listBox1.TopIndex = listBox1.Items.Count - 1;
                        // Sélectionner le dernier élément ajouté
                        //listBox1.SelectedIndex = listBox1.Items.Count - 1;
                    }
                }
            }
        }

        private void on_MusicChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1)
                return;
            playerCtl1.PlayList(index);

        }
        private Point startPoint;


        // Gestion de l'événement DragEnter pour le ListBox
        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        // Gestion de l'événement DragDrop pour le ListBox
        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            List<FileListItem> list = new ();
            if (e.Data== null) return;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string file in files)
                {
                    FileListItem item = new FileListItem
                    {
                        FileName = System.IO.Path.GetFileName(file),
                        FullPath = file
                    };
                    list.Add(item);
                    // Ajouter chaque chemin de fichier à la ListBox
                    listBox1.Items.Add(item);
                }  
                playerCtl1.setPlayList(list);
            }
        }


    }
}
