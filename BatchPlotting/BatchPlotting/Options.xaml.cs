using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BatchPlotting
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Options : Window
    {
        public Options()
        {
            InitializeComponent();
            //chkPublishDate.IsChecked = BatchPlottingProperties.BatchPlottingPropertiesInstance.isUpdatePublishDateChecked;
            chkCreatePDF.IsChecked = BatchPlottingProperties.BatchPlottingPropertiesInstance.isCreatedPDFChecked;
            chkCreateDWF.IsChecked = BatchPlottingProperties.BatchPlottingPropertiesInstance.isCreateDWFChecked;
            //chkUpdateSearchInfo.IsChecked = BatchPlottingProperties.BatchPlottingPropertiesInstance.isUpdateSearchInfoChecked;
            //chkFixGrid.IsChecked = BatchPlottingProperties.BatchPlottingPropertiesInstance.isFixGridChecked;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            //BatchPlottingProperties.BatchPlottingPropertiesInstance.isUpdatePublishDateChecked = (bool)chkPublishDate.IsChecked;
            BatchPlottingProperties.BatchPlottingPropertiesInstance.isCreateDWFChecked = (bool)chkCreateDWF.IsChecked;
            BatchPlottingProperties.BatchPlottingPropertiesInstance.isCreatedPDFChecked = (bool)chkCreatePDF.IsChecked;
            //BatchPlottingProperties.BatchPlottingPropertiesInstance.isUpdateSearchInfoChecked = (bool)chkUpdateSearchInfo.IsChecked;
            //BatchPlottingProperties.BatchPlottingPropertiesInstance.isFixGridChecked = (bool)chkFixGrid.IsChecked;
            Close();
        }
    }
}
