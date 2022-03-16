using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polymorphism : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Triangle tr = new Triangle();
        Circle c = new Circle();
        List<Shape> shapes = new List<Shape>();
        shapes.Add(tr);
        shapes.Add(c);
        foreach (var s in shapes) {
            s.GetS();
        }
    }

 }
public abstract class Shape {
    public abstract void GetS();

}
public class Triangle : Shape
{
    public override void GetS()
    {
        Debug.Log("Calculate S for triangle");
    }
    
}

public class Circle : Shape
{
    public override void GetS()
    {
        Debug.Log("Calculate S for circle");
    }

}

