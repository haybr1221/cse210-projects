class Room
{
    private List<SmartDevice> devices = new List<SmartDevice>();

    public void TurnOnDevices()
    {
        foreach(SmartDevice device in devices)
        {
            device.FlipSwitch("on");
        }
    }

    public void TurnOffDevices()
    {
        foreach(SmartDevice device in devices)
        {
            device.FlipSwitch("off");
        }
    }

    public void ReportAllDevices()
    {
        foreach(SmartDevice device in devices)
        {
            Console.WriteLine($"Device: {device}");
            Console.WriteLine($"Status: {device.CheckIfOn()}");
            Console.WriteLine($"Duration: {device.GetDuration()}");
        }
    }

    public void ReportLongestDevice()
    {
        int maxTime = -1;
        SmartDevice longestDevice = null;

        foreach(SmartDevice device in devices)
        {
            // Check if greater than maxTime
            if(device.GetDuration() > maxTime)
            {
                maxTime = device.GetDuration();
                longestDevice = device;
            }

            if (maxTime > 60)
            {
                Console.WriteLine($"{longestDevice} has been on for the longest, for {maxTime} minutes.");
            }
            else
            {
                Console.WriteLine($"{longestDevice} has been on for the longest, for {maxTime} seconds");
            }
        }
    }
}