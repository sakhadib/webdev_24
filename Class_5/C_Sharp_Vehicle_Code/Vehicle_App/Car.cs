namespace Vehicle_App;

public class Car : Vehicle
{
    /**
     * Constructor
     * This is the constructor for the Car class.
     * The properties are inherited from the Vehicle class
     */
    public Car(int numberOfWheels, int numberOfDoors, string serial, int seatCount)
    {
        this.NumberOfDoors = numberOfDoors;
        this.NumberOfWheels = numberOfWheels;
        this.Serial = serial;
        this.SeatCount = seatCount;
    }

    /**
     * This function is used to start the engine of the car
     * This function is overridden from the Vehicle class and now
     * its behavior is defined by the Car class
     */
    public override void Start_Engine()
    {
        Console.WriteLine("Car Engine Started");
    }
}