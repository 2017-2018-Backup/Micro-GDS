using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BatchPlotting.BatchPlotingPublisher;

namespace BatchPlotting
{
    public class BatchPlotingSubscriber<T>
    {
        public IPublisher<T> Publisher { get; private set; }
        public BatchPlotingSubscriber(IPublisher<T> publisher)
        {
            Publisher = publisher;
        }
    }
}
