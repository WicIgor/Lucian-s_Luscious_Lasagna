//Time necessary in the oven
const double EXPECTED_MINUTES_IN_OVEN = 40;
//Function that calculates preparation time

void preparationTimeInMinutes()
{
    Console.WriteLine("How Many Layers the Lasagne has? (Write using Numbers):");
    double LasagneLayers = double.Parse(Console.ReadLine());
    const double PREPARATION_MINUTES_PER_LAYER = 2;
    double TotalpreparationTime = LasagneLayers * PREPARATION_MINUTES_PER_LAYER;
}
//Function that takes the minutes the lasagna has been in the oven and returns the value

void remainingMinutesInOven()
{
    Console.WriteLine("How many minutes has passed since the lasagna has been in the oven? (Use only numbers):");
    double actualMinutesInOven  = double.Parse(Console.ReadLine());
    double RemainingTime = EXPECTED_MINUTES_IN_OVEN - actualMinutesInOven;
}
//Function to calculate the total working time

void totaltimeinminutes()
{

}
