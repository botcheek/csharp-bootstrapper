using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace cool_application
{
    /// <summary>
    /// Simple bootstrapper to a folder in the root of the bootstrapper.
    /// </summary>
    public partial class MainWindow : Window
    {
        System.IO.DirectoryInfo di = new DirectoryInfo("bin");
        WebClient client = new WebClient();
        

        Anim anim = new Anim();
        public MainWindow()
        {
            InitializeComponent();
            anim = new Anim();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            anim.FadeIn(TopLabel);
            await Task.Delay(1500);
            anim.FadeIn(checklabel);
            await Task.Delay(1500);
            anim.FadeOut(checklabel);
            await Task.Delay(1500);
            checklabel.Content = "checking for bin folder..."; //change these messages to your liking
            anim.FadeIn(checklabel);
            await Task.Delay(1500);
            anim.FadeOut(checklabel);
            if (Directory.Exists("bin")) //change the folder name to your liking
            {
                await Task.Delay(1500);
                checklabel.Content = "bin folder found.";
                anim.FadeIn(checklabel);
                await Task.Delay(1500);
                anim.FadeOut(checklabel);
                await Task.Delay(1500);
                checklabel.Content = "downloading...";
                anim.FadeIn(checklabel);
                await Task.Delay(1500);
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
                client.DownloadFile("DirectDownloadLink", "./bin/application.zip"); //replace DirectDownloadLink with the direct download link of the zip file
                System.IO.Compression.ZipFile.ExtractToDirectory("./bin/application.zip", "bin");
                File.Delete("./bin/*.zip");
                await Task.Delay(1500);
                anim.FadeOut(checklabel);
                await Task.Delay(1500);
                checklabel.Content = "done! launching application...";
                anim.FadeIn(checklabel);
                await Task.Delay(1500);
                Process.Start("./bin/app.exe"); //replace the argument with the dir and the name of the exe file
                this.Close();

            }
            else if (!Directory.Exists("bin"))
            {
                await Task.Delay(1500);
                checklabel.Content = "bin folder not found. creating one now...";
                anim.FadeIn(checklabel);
                Directory.CreateDirectory("bin"); //change the folder name to your liking
                await Task.Delay(1500);
                anim.FadeOut(checklabel);
                await Task.Delay(1500);
                anim.FadeIn(checklabel);
                checklabel.Content = "done!";
                anim.FadeIn(checklabel);
                await Task.Delay(1500);
                anim.FadeOut(checklabel);
                await Task.Delay(1500);
                checklabel.Content = "downloading...";
                anim.FadeIn(checklabel);
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
                client.DownloadFile("DirectDownloadLink", "/bin/application.zip"); //replace DirectDownloadLink with the direct download link of the zip file
                System.IO.Compression.ZipFile.ExtractToDirectory("/bin/application.zip", "bin");
                File.Delete("./bin/*.zip");
                await Task.Delay(1500);
                anim.FadeOut(checklabel);
                await Task.Delay(1500);
                checklabel.Content = "done! launching application...";
                anim.FadeIn(checklabel);
                await Task.Delay(1500);
                Process.Start("./bin/app.exe"); //replace the argument with the dir and the name of the exe file
                this.Close();
            }
            
            
        }
    }
}
