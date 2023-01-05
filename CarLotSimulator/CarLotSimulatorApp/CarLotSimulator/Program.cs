using CarLotSimulator;
using System;
//TODO

//Create a seperate class file called Car-DONE
//Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable-DONE
//Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()-DONE
//The methods should take one string parameter: the respective noise property-DONE
CarLot myLot = new CarLot();


//Now that the Car class is created we can instanciate 3 new cars-DONE
//Set the properties for each of the cars-DONE
//Call each of the methods for each car-DONE
var firstCar = new Car() { Year = 2021, Make = "GMC", Model = "YukonXL", EngineNoise = "grrrmble grrrmble", HonkNoise = "Wahhhnnn", IsDriveable = true };
var secondCar = new Car() { Year = 2004, Make = "Ford", Model = "Taurus", EngineNoise = "tiktok", HonkNoise = "beep beep", IsDriveable = false };
var thirdCar = new Car() { Year = 2020, Make = "Hyundai", Model = "SantaFe", EngineNoise = "hmmmmmm", HonkNoise = "bip bip", IsDriveable = true };
//*************BONUS*************//-DONE
myLot.CarList.Add(firstCar);
myLot.CarList.Add(secondCar);
myLot.CarList.Add(thirdCar);
// Set the properties utilizing the 3 different ways we learned about, one way for each car-DONE
Console.WriteLine($"Our inventory currently is composed of....");
//*************BONUS X 2*************//-DONE
foreach (var car in myLot.CarList)
{
    Console.WriteLine($"{car.Year} {car.Make} {car.Model}.");



}
