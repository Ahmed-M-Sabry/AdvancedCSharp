//using System;

//// Custom EventArgs class to pass data
//public class FireEventArgs : EventArgs
//{
//    public string Location { get; set; }
//    public DateTime DetectedAt { get; set; }

//    public FireEventArgs(string location, DateTime detectedAt)
//    {
//        Location = location;
//        DetectedAt = detectedAt;
//    }
//}

//// Fire alarm system class
//public class FireAlarmSystem
//{
//    // Define the event using the non-generic EventHandler
//    public event EventHandler FireAlarm;

//    // Method to detect fire
//    public void DetectFire(string location)
//    {
//        Console.WriteLine("Fire detected!");

//        // Create FireEventArgs with data to pass
//        FireEventArgs args = new FireEventArgs(location, DateTime.Now);

//        // Notify all subscribers, passing the event data
//        FireAlarm?.Invoke(this, args);
//    }
//}

//// Main program class
//public class Program
//{
//    public static void Main()
//    {
//        // Create an instance of the fire alarm system
//        FireAlarmSystem system = new FireAlarmSystem();

//        // Subscribe to the event
//        system.FireAlarm += CallFireDepartment;  // Call the fire department
//        system.FireAlarm += OpenEmergencyExits;  // Open emergency exits

//        // Trigger the fire detection with a location
//        system.DetectFire("Main Building");
//        system.DetectFire("New Building");

//    }

//    // Method to call the fire department
//    public static void CallFireDepartment(object sender, EventArgs e)
//    {
//        FireEventArgs fireArgs = (FireEventArgs)e;
//        Console.WriteLine($"Calling the fire department... Fire detected at {fireArgs.Location} at {fireArgs.DetectedAt}");
//    }

//    // Method to open emergency exits
//    public static void OpenEmergencyExits(object sender, EventArgs e)
//    {
//        FireEventArgs fireArgs = (FireEventArgs)e;
//        Console.WriteLine($"Opening emergency exits... Fire detected at {fireArgs.Location} at {fireArgs.DetectedAt}");
//    }
//}
