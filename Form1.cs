using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace PictureOrganizator
{
    public partial class frmOrganizator : Form
    {
        public enum MonthNames
        {
            Janeiro = 1,
            Feveiro=2,
            Março=3,
            Abril=4,
            Maio=5,
            Junho=6,
            Julho=7,
            Agosto=8,
            Setembro=9,
            Outubro=10,
            Novembro=11,
            Dezembro=12
        }

        public frmOrganizator()
        {
            InitializeComponent();
        }

        private void btnPicDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdStructure = new FolderBrowserDialog();
            DialogResult drStructure = fbdStructure.ShowDialog();

            if (drStructure == DialogResult.OK)
            {
                txtPicDir.Text = fbdStructure.SelectedPath;
            }
        }

        private void btnDestDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdStructure = new FolderBrowserDialog();
            DialogResult drStructure = fbdStructure.ShowDialog();

            if (drStructure == DialogResult.OK)
            {
                txtDestDir.Text = fbdStructure.SelectedPath;
            }
        }

        //private static Regex r = new Regex(":");

        public static DateTime GetDateTakenFromImage(string path)
        {
            Regex r = new Regex(":");

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (Image myImage = Image.FromStream(fs, false, false))
            {
                PropertyItem propItem = myImage.GetPropertyItem(36867);
                string dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                return DateTime.Parse(dateTaken);
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            btnExecute.Enabled = false;

            if ((txtPicDir.Text != String.Empty) && (txtDestDir.Text != String.Empty))
            {
                Regex rDateSeparator = new Regex(":");
                String[] strImageFiles = Directory.GetFiles(txtPicDir.Text, "*.jpg", SearchOption.AllDirectories);

                pbrPicOrg.Maximum = strImageFiles.Length;
                pbrPicOrg.Minimum = 0;

                foreach (String file in strImageFiles)
                {
                    FileInfo fiFile = new FileInfo(file);
                    String strNewLocation = String.Empty;

                    try
                    {
                        DateTime dtTaken = GetDateTakenFromImage(file);

                        strNewLocation = txtDestDir.Text + @"\" + dtTaken.Year + @"\" + Enum.GetName(typeof(MonthNames), (object)dtTaken.Month);
                    }
                    catch
                    {
                        strNewLocation = txtDestDir.Text + @"\Atemporal";
                    }

                    if (strNewLocation != String.Empty)
                    {
                        FileInfo fiNewFile = new FileInfo(strNewLocation + @"\" + fiFile.Name);
                        fiNewFile.Directory.Create();

                        try
                        {
                            fiFile.CopyTo(fiNewFile.FullName);
                        }
                        catch (IOException ex)
                        {
                            int FileCount = 2;
                            FileInfo fiDuplicatedFile = fiNewFile;

                            while (File.Exists(fiDuplicatedFile.FullName))
                            {
                                fiDuplicatedFile = new FileInfo(strNewLocation + @"\" + Path.GetFileNameWithoutExtension(fiNewFile.Name) + "-" + FileCount + fiNewFile.Extension);
                                FileCount++;
                            }

                            fiFile.CopyTo(fiDuplicatedFile.FullName);
                        }

                    }

                    pbrPicOrg.Value++;
                }
            }
            else
            {
                MessageBox.Show("Selecione todos os Diretórios!");
            }

            btnExecute.Enabled = true;
        }
    }
}
