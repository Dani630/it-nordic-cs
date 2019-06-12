using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_11
{
    class ChatReminderItem : Reminderitem
    {
        public string ChatName { get; set; }
        public string AccountName { get; set; }

        //  public ChatReminderItem(DateTimeOffset AlarmDate, string AlarmMessage, TimeSpan TimeToAlarm, bool IsOutDated, string ChatName, string AccountName)
        //    : base(AlarmDate, AlarmMessage)
        public ChatReminderItem(DateTimeOffset AlarmDate, string AlarmMessage, string ChatName, string AccountName)
            : base (AlarmDate , AlarmMessage)
        {
            this.ChatName = ChatName;
            this.AccountName = AccountName;
        }

        override public void WriteProperties()
        {
            Console.WriteLine
    (
    $"AlarmDate : {AlarmDate}\n" +
    $"AlarmMessage : {AlarmMessage}\n" +
    $"TimeToAlarm : {TimeToAlarm}\n" +
    $"IsOutDated : {IsOutdated}\n" +
    $"ChatName : {ChatName}\n" +
    $"AccountName : {AccountName}\n"

    );
        }
    }
}
