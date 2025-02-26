namespace Vehicle_App;

public class Vehicle
{
    /**
     * This is the base class for all vehicles
     *
     * The variables are protected so that they can be accessed by the child classes
     */
    protected int NumberOfWheels;
    protected int NumberOfDoors;
    protected string Serial;
    protected int SeatCount;
    
    // Constrictor
    
    public Vehicle() // this is the default constructor. This is written because we have another constructor below
    {}
    
    /**
     * This is the constructor for the Vehicle class
     * this constructor is used to create a new vehicle object with all the necessary properties
     */
    public Vehicle(int numberOfWheels, int numberOfDoors, string serial, int seatCount)
    {
        NumberOfWheels = numberOfWheels;
        NumberOfDoors = numberOfDoors;
        Serial = serial;
        SeatCount = seatCount;
    }
    
    // Functions
    
    /**
     * This function is used to start the engine of the vehicle
     * This function is virtual so that it can be overridden by the child classes
     * "virtual" keyword is used to allow the child classes to override this function
     */
    public virtual void Start_Engine()
    {
        Console.WriteLine("Vehicle Engine Started");
    }
    
    
    // Getters and Setters
    /**
     * These are the getters and setters for the Vehicle class
     * These are used to get and set the values of the private or protected variables outside the class
     */
    public int GetNumberOfWheels()
    {
        return NumberOfWheels;
    }
    
    public int GetNumberOfDoors()
    {
        return NumberOfDoors;
    }
    
    public string GetSerial()
    {
        return Serial;
    }
    
    /**
     * In Setter Functions we are not returning anything because we are setting the values of the variables
     * Also we can impose any conditions on the values that are being set.
     */
    public int GetSeatCount()
    {
        return SeatCount;
    }
    
    public void SetNumberOfWheels(int numberOfWheels)
    {
        NumberOfWheels = numberOfWheels;
    }
    
    public void SetNumberOfDoors(int numberOfDoors)
    {
        NumberOfDoors = numberOfDoors;
    }
    
    public void SetSerial(string serial)
    {
        Serial = serial;
    }
    
    public void SetSeatCount(int seatCount)
    {
        SeatCount = seatCount;
    }
}