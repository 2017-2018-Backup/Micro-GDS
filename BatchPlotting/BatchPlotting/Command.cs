

using Autodesk.AutoCAD.Runtime;
using Autodesk.Windows;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System;
[assembly: ExtensionApplication(typeof(BatchPlotting.BatchPlottingApplication))]
[assembly: CommandClass(typeof(BatchPlotting.Command))]
namespace BatchPlotting
{
    public class BatchPlottingApplication : IExtensionApplication
    {
        public void Initialize()
        {
            //CreateMicroGDSRibbon();
        }

        public void Terminate()
        {
            //throw new NotImplementedException();
        }

        [CommandMethod("CreateMicroGDSButton")]
        public void CreateMicroGDSRibbon()
        {
            try
            {
                RibbonTab rbnTab = new RibbonTab();
                rbnTab.Title = "MicroGDS";
                rbnTab.Id = "MicroGDS_Id";
                
                Autodesk.Windows.RibbonPanelSource rbnSource = new RibbonPanelSource();
                rbnSource.Title = "Batch Plotting";
                RibbonPanel rbnPanel = new RibbonPanel();

                RibbonButton pan1button1 = new RibbonButton();
                pan1button1.Text = "Batch Potting";
                pan1button1.ShowText = true;
                pan1button1.ShowImage = true;
                //pan1button1.Image = Images.getBitmap(Properties.Resources.batch);
                //pan1button1.LargeImage = Images.getBitmap(Properties.Resources.large);
                pan1button1.Orientation = System.Windows.Controls.Orientation.Vertical;
                pan1button1.Size = RibbonItemSize.Large;
                pan1button1.CommandHandler = new BatchPlotingCommandHandler();
                rbnSource.Items.Add(pan1button1);

                rbnPanel.Source = rbnSource;

                rbnTab.IsActive = true;

                rbnTab.Panels.Add(rbnPanel);

                //Autodesk.Windows.ComponentManager.Ribbon.Tabs.Add(rbnTab);
            }
            catch (System.Exception ex)
            {
            }
        }
    }

    public class Command
    {
        [CommandMethod("BatchPlotting", CommandFlags.Session)]
        public void BatchPlotting()
        {
            try
            {
                
                BatchPlot batchPlot = new BatchPlot(System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle);
                batchPlot.ShowDialog();
            }
            catch (System.Exception ex)
            {

            }
        }


    }

    public class BatchPlotingCommandHandler : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            Command cmd = new Command();
            cmd.BatchPlotting();
        }
    }

    public class Images
    {
        public static BitmapImage getBitmap(Bitmap image)
        {
            MemoryStream stream = new MemoryStream();
            image.Save(stream, ImageFormat.Png);
            BitmapImage bmp = new BitmapImage();
            bmp.BeginInit();
            bmp.StreamSource = stream;
            bmp.EndInit();

            return bmp;
        }
    }
}
