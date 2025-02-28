using System;

public class Department
{
    public string DeptName { get; set; }
    public Manager Manager { get; set; }

    // Constructor
    public Department(string deptName, Manager manager)
    {
        DeptName = deptName;
        Manager = manager;
    }

    public Department ShallowCopy()
    {
        return (Department)this.MemberwiseClone();
    }


    public Department DeepCopy()
    {
        return new Department(DeptName, new Manager(Manager.Name));
    }


    public void Display()
    {
        Console.WriteLine($"Department: {DeptName}, Manager: {Manager.Name}");
    }
}
