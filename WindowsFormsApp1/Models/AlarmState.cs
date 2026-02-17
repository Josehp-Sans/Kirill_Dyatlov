using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class AlarmState
    {
        public DateTime AlarmTime { get; set; }

        public string AlarmMassage { get; set; }
        
        public bool IsAlarmActive { get; set; }

        public bool IsSoundActive { get; set; }

        public bool IsAwakeActived { get; set; }
    }
}
