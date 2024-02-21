using Iot.Device.CpuTemperature;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var rpiCpuTemp = new CpuTemperature();
if(rpiCpuTemp.IsAvailable)
   Console.WriteLine($"The cpu temp is {rpiCpuTemp.Temperature.DegreesCelsius}");
