namespace Vehicle_App;

public class Bus : Vehicle
{
    /**
     * Constructor
     * This is the constructor for the Bus class.
     * The properties are inherited from the Vehicle class
     */
    public Bus(int numberOfWheels, int numberOfDoors, string serial, int seatCount)
    {
        this.NumberOfDoors = numberOfDoors;
        this.NumberOfWheels = numberOfWheels;
        this.Serial = serial;
        this.SeatCount = seatCount;
    }

    /**
     * This function is used to start the engine of the bus
     * This function is overridden from the Vehicle class and now
     * its behavior is defined by the Bus class
     */
    public override void Start_Engine()
    {
        Console.WriteLine("Bus Engine Started");
    }
    
}