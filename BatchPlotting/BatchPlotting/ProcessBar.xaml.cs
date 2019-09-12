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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BatchPlotting
{
    /// <summary>
    /// Interaction logic for ProcessBar.xaml
    /// </summary>
    public partial class BatchProcessBar : Window
    {
        private BatchPlotingSubscriber<double> _pbarMaximumSubscriber;
        private BatchPlotingSubscriber<double> _pbarValueSubscriber;
        private BatchPlotingSubscriber<string> _pbarStatusSubscriber;
        private BatchPlotingSubscriber<string> _pbarHeaderSubscriber;
        private BatchPlot _batchPlot;
        public BatchProcessBar(BatchPlot batchPlot, IntPtr ptHandler)
        {
            InitializeComponent();
            new WindowInteropHelper(this).Owner = ptHandler;
            _batchPlot = batchPlot;
            _pbarMaximumSubscriber = new BatchPlotingSubscriber<double>(BatchPlotingPublisher.ProgressBarMaximumPublisher);
            _pbarMaximumSubscriber.Publisher.DataPublisher += Publisher_MaximumDataPublisher;

            _pbarValueSubscriber = new BatchPlotingSubscriber<double>(BatchPlotingPublisher.ProgressValuePublisher);
            _pbarValueSubscriber.Publisher.DataPublisher += Publisher_ValueDataPublisher;

            _pbarStatusSubscriber = new BatchPlotingSubscriber<string>(BatchPlotingPublisher.ProgressStatusPublisher);
            _pbarStatusSubscriber.Publisher.DataPublisher += Publisher_StatusDataPublisher;

            _pbarHeaderSubscriber = new BatchPlotingSubscriber<string>(BatchPlotingPublisher.ProgressHeaderPublisher);
            _pbarHeaderSubscriber.Publisher.DataPublisher += Publisher_HeaderDataPublisher;
        }

        private void Publisher_HeaderDataPublisher(object sender, BatchPlotingPublisher.MessageArgument<string> e)
        {
            lblHeader.Dispatcher.Invoke(() => { lblHeader.Content = e.Message; });
            DoEventsHandler.DoEvents();
        }

        private void Publisher_StatusDataPublisher(object sender, BatchPlotingPublisher.MessageArgument<string> e)
        {
            lblStatusPublisher.Dispatcher.Invoke(() => { lblStatusPublisher.Content = e.Message; });
            DoEventsHandler.DoEvents();
        }

        private void Publisher_ValueDataPublisher(object sender, BatchPlotingPublisher.MessageArgument<double> e)
        {
            pbStatus.Dispatcher.Invoke(() => { pbStatus.Value = pbStatus.Value + e.Message; });
            txtPercentage.Dispatcher.Invoke(() =>
            {
                var value = Convert.ToInt32((pbStatus.Value / pbStatus.Maximum) * 100);
                txtPercentage.Text = value + "%";
            });
            DoEventsHandler.DoEvents();
        }

        private void Publisher_MaximumDataPublisher(object sender, BatchPlotingPublisher.MessageArgument<double> e)
        {
            pbStatus.Dispatcher.Invoke(() => { pbStatus.Maximum = e.Message; });
            DoEventsHandler.DoEvents();
        }

        protected override void OnContentRendered(EventArgs e)
        {
            base.OnContentRendered(e);
            _batchPlot.DoProcess();
            Close();
        }

    }
}
