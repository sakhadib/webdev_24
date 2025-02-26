namespace Vehicle_App;

public class Truck : Vehicle
{
    /**
     * Constructor
     * This is the constructor for the Truck class.
     */
    public Truck(int numberOfWheels, int numberOfDoors, string serial, int seatCount)
    {
        this.NumberOfDoors = numberOfDoors;
        this.NumberOfWheels = numberOfWheels;
        this.Serial = serial;
        this.SeatCount = seatCount;
    }

    /**
     * This function is used to start the engine of the truck
     * This function is overridden from the Vehicle class and now
     * its behavior is defined by the Truck class
     */
    public override void Start_Engine()
    {
        Console.WriteLine("Truck Engine Started");
    }
    
}