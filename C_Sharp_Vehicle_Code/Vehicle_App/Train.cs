namespace Vehicle_App;

public class Train : Vehicle
{
    /**
     * Constructor
     * This is the constructor for the Train class.
     */
    public Train(int numberOfWheels, int numberOfDoors, string serial, int seatCount)
    {
        this.NumberOfDoors = numberOfDoors;
        this.NumberOfWheels = numberOfWheels;
        this.Serial = serial;
        this.SeatCount = seatCount;
    }

    /**
     * This function is used to start the engine of the train
     * This function is overridden from the Vehicle class and now
     * its behavior is defined by the Train class
     */
    public override void Start_Engine()
    {
        Console.WriteLine("Train Engine Started");
    }
}