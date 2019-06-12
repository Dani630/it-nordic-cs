using System;

namespace HomeWork_11
{
    class Program
    {
        static void Main(string[] args)
        {
           // Reminderitem p1 = new Reminderitem(DateTimeOffset.Parse("03/04/2019") , "Работа");
            //Reminderitem p2 = new Reminderitem(DateTimeOffset.Parse("04/03/2019"), "Первое апреля");
           // p1.WriteProperties();
           // p2.WriteProperties();
            PhoneReminderItem m1 = new PhoneReminderItem(DateTimeOffset.Parse("2019/04/02") , "Gffe" , "89773888356");
            m1.WriteProperties();

            ChatReminderItem c1 = new ChatReminderItem(DateTimeOffset.Parse("21:31"), "Naw", "FEK", "FMOEMo");
            c1.WriteProperties();
        }
    }
}
