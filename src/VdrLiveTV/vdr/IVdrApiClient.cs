using MediaBrowser.Model.LiveTv;
using MediaBrowser.Controller.LiveTv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VdrLiveTV.vdr
{
    public interface IVdrApiClient
    {
        Task<List<ChannelInfo>> GetChannelsAsync();
        Task<List<ProgramInfo>> GetEventAsync(string channelId, DateTime startDateUtc, DateTime endDateUtc);
        Task<byte[]> GetEventImageAsync(int evendId, int imageNumber);
        Task<List<RecordingInfo>> GetRecordingsAsync();
        Task DeleteRecording(string recordingId);
        Task<List<TimerInfo>> GetTimersAsync();
        Task CreateTimer(TimerInfo info);
        Task UpdateTimer(TimerInfo info);
        Task CancelTimer(string timerId);
    }
}
