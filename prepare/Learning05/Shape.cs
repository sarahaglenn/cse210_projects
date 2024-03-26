using System;
using System.Drawing;

public abstract class Shape
{
    private string _color;
    public Shape(string Color)
    {
        _color = Color;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public abstract double GetArea();
}