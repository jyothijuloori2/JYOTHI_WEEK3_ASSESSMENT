using System;

// Delegate for event handling
public delegate void ButtonClickHandler();

public class Button
{
    public event ButtonClickHandler OnClick;

    public string ButtonName { get; set; }


    public Button(string name)
    {
        ButtonName = name;
    }

    public void Click()
    {
        Console.WriteLine($"{ButtonName} button clicked.");


        OnClick?.Invoke();
    }
}
