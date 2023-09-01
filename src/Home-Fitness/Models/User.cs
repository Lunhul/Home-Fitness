using System;

namespace HomeFitness.Models;
public class User
{
    public DateTime RegistrationDate { get; }
    public Gender Gender { get; private set; }
    public DateTime BirthDate { get; private set; }
    public int Age { get; }
    public double Height { get; private set; }
    public double Weight { get; private set; }
    public User(Gender gender, DateTime birthDate, double height, double weight)
    {}
    public void UpdateGender(Gender gender)
    {}
    public void UpdateBirthDate(DateTime birthDate)
    {}
    public void UpdateHeight(double height)
    {}
    public void UpdateWeight(double weight)
    {}
}