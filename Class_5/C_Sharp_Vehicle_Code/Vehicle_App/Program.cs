namespace Vehicle_App;
class Program
{
    static void Main(string[] args)
    {
        // Create an array of vehicles
        Vehicle[] vehicles = new Vehicle[4];
        
        
        // Create instances of the vehicles. We are creating 4 vehicles.
        // one car, one bus, one truck and one train. Each has type of "Vehicle"
        // but the behavior is defined by the class itself.
        Vehicle v1 = new Car(4, 4, "XXY", 4);
        Vehicle v2 = new Bus(6, 2, "XYY", 20);
        Vehicle v3 = new Truck(6, 2, "XYZ", 3);
        Vehicle v4 = new Train(60, 20, "XYW", 100);
        
        // Assign the vehicles to the vehicle array. Because all are of type "Vehicle"
        // we can assign them to the array of type "Vehicle" and no issue.
        vehicles[0] = v1;
        vehicles[1] = v2;
        vehicles[2] = v3;
        vehicles[3] = v4;
        
        
        // Loop through the vehicles and start the engine of each vehicle
        // The behavior of the engine start is defined by the class itself.
        for (int i = 0; i < 4; i++)
        {
            // Start the engine of the vehicle
            vehicles[i].Start_Engine();
        }

    }
    
}

/************************************************************

Output:
--------------------------------
Car Engine Started
Bus Engine Started
Truck Engine Started
Train Engine Started

************************************************************/