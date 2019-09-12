using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchPlotting
{
    internal class BatchPlottingProperties
    {
        private static BatchPlottingProperties _batchPlottingInstance = null;
        public static BatchPlottingProperties BatchPlottingPropertiesInstance
        {
            get
            {
                if (_batchPlottingInstance == null)
                {
                    _batchPlottingInstance = new BatchPlottingProperties();
                }
                return _batchPlottingInstance;
            }
        }

        public bool isUpdatePublishDateChecked { get; set; }
        public bool isCreatedPDFChecked { get; set; }
        public bool isCreateDWFChecked { get; set; }
        public bool isUpdateSearchInfoChecked { get; set; }
        public bool isFixGridChecked { get; set; }
        public string UserId { get; set; }
    }

    internal class ClsProperties
    {
        public static bool IsFormClosed { get; set; }

        public static bool IsCancelled { get; set; }
    }
}
