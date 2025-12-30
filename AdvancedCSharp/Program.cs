using System;

// Define delegate for the event
public delegate void AlarmHandler();

// Fire alarm system class
public class FireAlarmSystem
{
    // Define the event based on the delegate
    public event AlarmHandler FireAlarm;

    // Method to detect fire
    public void DetectFire()
    {
        Console.WriteLine("Fire detected!");
        FireAlarm?.Invoke(); // Notify all subscribers
    }
}

// Main program class
public class Program
{
    public static void Main()
    {
        // Create an instance of the fire alarm system
        FireAlarmSystem system = new FireAlarmSystem();

        // Subscribe to the event
        system.FireAlarm += CallFireDepartment;  // Call the fire department
        system.FireAlarm += OpenEmergencyExits;  // Open emergency exits

        // Trigger the fire detection
        system.DetectFire();
    }

    // Method to call the fire department
    public static void CallFireDepartment()
    {
        Console.WriteLine("Calling the fire department...");
    }

    // Method to open emergency exits
    public static void OpenEmergencyExits()
    {
        Console.WriteLine("Opening emergency exits...");
    }
}
