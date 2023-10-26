using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace MercadoSA
{
    public partial class frmWebcam : Form
    {
        private bool DeviceExist = false;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource = null;

        public frmWebcam()
        {
            InitializeComponent();
        }
        public void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            pctCapturaImagem.Image = img;
        }

        private void frmWebcam_Load(object sender, EventArgs e)
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);//Filtrando os drives
                cbbDispositivo.Items.Clear();
                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                DeviceExist = true;
                foreach (FilterInfo device in videoDevices)
                {
                    cbbDispositivo.Items.Add(device.Name);
                }
                cbbDispositivo.SelectedIndex = 0;
            }
            catch (ApplicationException)
            {
                DeviceExist = false;
                cbbDispositivo.Items.Add("Nenhum dispositivo encontrado!");
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (btnCapturar.Text == "Capturar")
            {
                if (DeviceExist)
                {
                    videoSource = new VideoCaptureDevice(videoDevices[cbbDispositivo.SelectedIndex].MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);


                    //Encerra sinal da camera.
                    if (!(videoSource == null))
                        if(videoSource.IsRunning)
                    {
                            videoSource.SignalToStop();
                            videoSource = null;
                    }
                    videoSource.DesiredFrameSize = new Size(160, 120);
                    videoSource.DesiredFrameRate = 10;
                    videoSource.Start();

                    btnCapturar.Text = "Gravar";
                }
                else
                {
                    MessageBox.Show("Nenhum dispositivo encontrado");
                }
            }
            else
            {
                if (videoSource.IsRunning)
                {
                    //Encerra o sinal da camera.
                    //note que esse código de bloco se repetiu, você pode criar um método para ele.
                    if(!(videoSource == null))
                        if (videoSource.IsRunning)
                        {
                            videoSource.SignalToStop();
                            videoSource = null;

                            //Salva imagem;
                            sfdSalvarImagem.Filter = "JPEG (*.jpg;*.jpeg;*jpeg;*.jfif) |*.jpg;*jpeg;*jpeg;*.jfif";
                            DialogResult res = sfdSalvarImagem.ShowDialog();
                            if(res == DialogResult.OK)
                            {
                                pctCapturaImagem.Image.Save(sfdSalvarImagem.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                            }
                        }
                }
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarIMG = new OpenFileDialog();
            BuscarIMG.InitialDirectory = ("d:\\imagens\\");
            BuscarIMG.FileName = "Imagem";
            BuscarIMG.Title = "Procurar Imagem";
            BuscarIMG.Filter = ("*jpg|*.jpg|*png|*.png|*bmp|*.bmp|*tif|*.tif");
            BuscarIMG.ShowDialog();
            pctCapturaImagem.ImageLocation = (BuscarIMG.FileName);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pctCapturaImagem.Image = null;
        }
    }
}
    

