//using System;

//// Fire alarm system class
//public class FireAlarmSystem
//{
//    public event EventHandler FireAlarmEvent;

//    public void DetectFire(string location)
//    {
//        Console.WriteLine($"Fire detected at {location}");
//        FireAlarmEvent?.Invoke(this, EventArgs.Empty);
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        FireAlarmSystem system = new FireAlarmSystem();

//        system.FireAlarmEvent += CallFireDepartment;
//        system.FireAlarmEvent += OpenEmergencyExits;

//        system.DetectFire("Main Building");
//    }

//    public static void CallFireDepartment(object sender, EventArgs e)
//    {
//        Console.WriteLine("Calling the fire department..0.");
//    }

//    public static void OpenEmergencyExits(object sender, EventArgs e)
//    {
//        Console.WriteLine("Opening emergency exits..0.");
//    }
//}
