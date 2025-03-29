using System;

interface IRemoteControl
{
    void TurnOn();
    void TurnOff();
    void ChannelUp();
    void ChannelDown();
}

abstract class PowerAppliance
{
    public bool PowerStatus;
    public int Wattage;
}

class Television : PowerAppliance, IRemoteControl
{
    public int Channel { get; set; }

    public void TurnOn()
    {
        Console.WriteLine("TV Turn on");
        PowerStatus = true;
    }

    public void TurnOff()
    {
        Console.WriteLine("TV Turn off");
        PowerStatus = false;
    }

    public void ChannelUp()
    {
        Channel++;
        Console.WriteLine($"TV Channel up: Now channel is {Channel}");
    }

    public void ChannelDown()
    {
        Channel--;
        Console.WriteLine($"TV Channel down: Now channel is {Channel}");
    }
}

class Lamp : PowerAppliance, IRemoteControl
{
    // Lamp doesn't have channel change, but implements the interface
    public void TurnOn()
    {
        Console.WriteLine("Lamp Turn on");
        PowerStatus = true;
    }

    public void TurnOff()
    {
        Console.WriteLine("Lamp Turn off");
        PowerStatus = false;
    }

    public void ChannelUp()
    {
        Console.WriteLine("Lamp cannot change channel");
    }

    public void ChannelDown()
    {
        Console.WriteLine("Lamp cannot change channel");
    }
}

class Program
{
    static void Main()
    {
        // Test for Sony TV
        Television myTV = new Television();
        myTV.Wattage = 100;
        myTV.TurnOn();
        myTV.ChannelUp();  // Increase channel
        myTV.ChannelDown(); // Decrease channel
        myTV.TurnOff();

        // Test for Desktop Lamp
        Lamp myLamp = new Lamp();
        myLamp.Wattage = 50;
        myLamp.TurnOn();
        myLamp.ChannelUp();   // Should output that the lamp cannot change channel
        myLamp.ChannelDown(); // Should output that the lamp cannot change channel
        myLamp.TurnOff();
    }
}
