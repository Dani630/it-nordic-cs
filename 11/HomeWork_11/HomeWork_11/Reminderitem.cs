using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_11
{
    class Reminderitem
    {
        public DateTimeOffset AlarmDate { get; set; }
        public string AlarmMessage { get; set; }
        public TimeSpan TimeToAlarm
        {
            get
            {
                return DateTimeOffset.Now - AlarmDate;
            }
        }
        public bool IsOutdated
        {
            get
            {
                if (TimeToAlarm >= new TimeSpan(0))
                    return true;
                else
                    return false;
            }
        }

        public Reminderitem (DateTimeOffset AlarmDate , string AlarmMessage)
        {
            this.AlarmDate = AlarmDate;
            this.AlarmMessage = AlarmMessage;
        }

        public virtual void WriteProperties()
        {
            Console.WriteLine
                (
                $"AlarmDate : {AlarmDate}\n" +
                $"AlarmMessage : {AlarmMessage}\n" +
                $"TimeToAlarm : {TimeToAlarm}\n" +
                $"IsOutDated : {IsOutdated}\n"
                );
        }
    }
}
