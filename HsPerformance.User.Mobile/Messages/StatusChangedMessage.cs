using HsPerformance.User.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HsPerformance.User.Mobile.Messages
{
    public class StatusChangedMessage
    {
        public Guid ExerciseId { get; } 
        public ExerciseStatusEnum Status { get; }

        public StatusChangedMessage(Guid id, ExerciseStatusEnum status)
        {
            ExerciseId = id;
            Status = status;
        }
    }
}
