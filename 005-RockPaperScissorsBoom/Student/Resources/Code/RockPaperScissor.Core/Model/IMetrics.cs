using System.Collections.Generic;

namespace RockPaperScissor.Core.Model
{
    public interface IMetrics
    {
        void TrackEventDuration(string eventName, Dictionary<string, string> properties, Dictionary<string, double> metrics);
    }
}