using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_11
{
    class PhoneReminderItem : Reminderitem
    {
        public string PhoneNumber { get; set; }
        public PhoneReminderItem(DateTimeOffset AlarmDate, string AlarmMessage , string PhoneNumber)  //, TimeSpan TimeToAlrm, bool IsOutDated)
            : base (AlarmDate , AlarmMessage)
        {
            this.PhoneNumber = PhoneNumber;
        }

        public override void WriteProperties ()
        {
            Console.WriteLine
                (
                $"AlarmDate : {AlarmDate}\n" +
                $"AlarmMessage : {AlarmMessage}\n" +
                $"TimeToAlarm : {TimeToAlarm}\n" +
                $"IsOutDated : {IsOutdated}\n" +
                $"PhoneNumber : {PhoneNumber}\n"
                );
        }
    }
}
