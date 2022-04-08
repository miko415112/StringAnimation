using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace StringAnimation
{
    public partial class Form1 : Form
    {
        string fps ="";
        string time ="";
        string inputPath ="";
        string filePath = System.Environment.CurrentDirectory;

        public Form1()
        {
            InitializeComponent();
            Console.SetWindowSize(180, 45);
            Console.SetBufferSize(180, 45);
            Form.CheckForIllegalCrossThreadCalls = false; //跨執行緒存取form
        }

        public void VideoToImage()
        {
            //打開CMD
            Process p = new Process();                 
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = false; 
            p.Start();
            
            //在cmd中對ffmpeg下達截圖指令
            string FFcommand = @"ffmpeg -i "+ inputPath + " -vf fps="+fps+" "+filePath+ @"\jpg\%d.jpg";

            //CMD執行指令
            p.StandardInput.WriteLine(FFcommand);

            information.Text = "Extracting frames from the video......";
        }
        public void ImageToString()
        {
            int number = 1;
            int maxNumber = Convert.ToInt32(time) * Convert.ToInt32(fps);
            string replaceChar = "@B%8&Wdrja)1,.   "; //依照灰度值不同而替代的字符列表
            while(!File.Exists(filePath + @"\jpg\" + maxNumber + ".jpg")) //等待FFmpeg截圖完畢
            {
            }
            information.Text = "Converting frames to chars......";
            while (number < maxNumber)
            {
                if (File.Exists(filePath + @"\jpg\" + maxNumber + ".jpg"))
                {
                    Bitmap bitmap = new Bitmap(filePath + @"\jpg\" + number + ".jpg");
                    string s = "";//用來紀錄替代字符的字串
                    int pixelGap = bitmap.Height / 45;    //將字符動畫尺寸高度限制在45行內
                    for (int i = 0; i < bitmap.Height; i += pixelGap)
                    {
                        for (int j = 0; j < bitmap.Width; j += (pixelGap / 2))  //字型大小16的寬度像素是高度的一半
                        {
                            Color c = bitmap.GetPixel(j, i);
                            int rgb = (int)(c.R * .3 + c.G * .59 + c.B * .11);
                            int index = (int)(rgb / 256.0 * replaceChar.Length);
                            s += replaceChar[index];
                        }
                        s += "\n";
                    }
                    //將轉換成字符圖片的紀錄在txt內
                    FileStream fs = new FileStream(filePath + @"\txt\" + number + ".txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(s);
                    sw.Close();
                    number++;
                }
            }
            information.Text = "Mission completed,Ready to play!";
        }

        public void PlayString()
        {
            int number = 1;
            int maxNumber = Convert.ToInt32(time) * Convert.ToInt32(fps);
            int timeGap = 1000 / Convert.ToInt32(fps); //依照fps來決定每張圖片的時間間格
            string filePath = System.Environment.CurrentDirectory;
            string s = "";//用來紀錄替代字符的字串
            while (number <= maxNumber)
            {

                //沒找到檔案就切換到下一張
                if (!File.Exists(filePath + @"\txt\" + number + ".txt"))
                {
                    continue;
                }
                FileStream fs = new FileStream(filePath + @"\txt\" + number + ".txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                //一行一行紀錄到字串內
                while (!sr.EndOfStream)
                {
                    s += sr.ReadLine();
                    s += "\n";
                }

                Console.SetCursorPosition(0, 0);
                Console.Write(s);
                s = "";
                Thread.Sleep(timeGap);
                number++;
            }
        }

        public void deleteFiles()
        {
            //打開CMD
            Process p = new Process();             
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = false; 
            p.Start();

            //刪除資料夾
            string filePath = System.Environment.CurrentDirectory;
            p.StandardInput.WriteLine(@"rd /s/q " + filePath + @"\jpg");
            p.StandardInput.WriteLine(@"rd /s/q " + filePath + @"\txt");
            //創建空資料夾
            p.StandardInput.WriteLine(@"md " + filePath + @"\jpg");
            p.StandardInput.WriteLine(@"md " + filePath + @"\txt");
        }

       

        //拖曳檔案
        private void inputBox_DragDrop(object sender, DragEventArgs e)
        {
            inputBox.Text = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            inputPath = inputBox.Text;
        }

        private void inputBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
                this.timeBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

       
        private void CreateButton_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(VideoToImage);
            Thread t2 = new Thread(ImageToString);
            t1.Start();
            t2.Start();
        }
        private void playButton_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(PlayString);
            t1.Start();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            deleteFiles();
            information.Text = "";
        }

        private void timeBox_TextChanged(object sender, EventArgs e)
        {
            time = timeBox.Text;
        }

        private void fpsBox_TextChanged(object sender, EventArgs e)
        {
            fps = fpsBox.Text;
        }
    }
}
