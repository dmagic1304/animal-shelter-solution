namespace AnimalShelter.Models
{
  using System;
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public string Breed { get; set; }
    public DateTime Admission { get; set; }
  }
}