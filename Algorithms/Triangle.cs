namespace Algorithms;
using System;

public class Triangle

{
    private Point sommet1;
    private Point sommet2;
    private Point sommet3;

    public Triangle(Point sommet1, Point sommet2, Point sommet3)
    {
        this.sommet1 = sommet1;
        this.sommet2 = sommet2;
        this.sommet3 = sommet3;
    }

    public static Triangle Equilateral(double longueur)
    {
        Point sommet1 = new Point(0,0);
        Point sommet2 = new Point(0, longueur);

        double x = Math.Sqrt(longueur*longueur - longueur*longueur/4);
        Point sommet3 = new Point(x, longueur/2);
        return new Triangle(sommet1, sommet2, sommet3);
    }

}

public class Point
{
    private double x;
    private double y;

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double X()
    {
        return x;
    }

    public double Y()
    {
        return y;
    }

    public double Distance()
    {
        return Math.Sqrt(X() * X() + Y() * Y());
    }

    public Point MidPointOf(Point other)
    {
        double midX = (X() + other.X()) / 2;
        double midY = (Y() + other.Y()) / 2;
        return new Point(midX, midY);
    }

    public override string ToString(){
        return "{\"x\": " + this.x + ", \"y\": " + this.y +"}";
    }

}