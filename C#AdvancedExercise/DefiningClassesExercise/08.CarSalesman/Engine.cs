﻿public class Engine
{
    public string Model { get; set; }
    public int Power { get; set; }
    public int? Displacement { get; set; }
    public string Efficiency { get; set; }

    public Engine(string model, int power, int? displacement = null, string efficiency = null)
    {
        Model = model;
        Power = power;
        Displacement = displacement;
        Efficiency = efficiency;
    }

    public override string ToString()
    {
        return $"{Model}:\n    Power: {Power}\n    Displacement: {(Displacement.HasValue ? Displacement.ToString() : "n/a")}\n    Efficiency: {(!string.IsNullOrEmpty(Efficiency) ? Efficiency : "n/a")}";
    }
}