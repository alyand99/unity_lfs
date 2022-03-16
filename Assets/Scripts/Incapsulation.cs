using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Incapsulation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SquareSolvation ss = new SquareSolvation(1, -3, 2);
        Debug.Log(ss.GetSolution());
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
public class SquareSolvation {
    int a, b, c;
    public SquareSolvation(int a, int b, int c) {
        this.a = a;
        this.b = b;
        this.c = c;

        Debug.Log("(" + a + ") x^2 +(" + b + ")x + (" + c + ") =0");
    }
    public Vector2 GetSolution() {
        Vector2 x = Vector2.zero;
        if (D() > 0)
        {
            x.x = ((-1) * b - Mathf.Sqrt(D())) / 2 * a;
            x.y = ((-1) * b + Mathf.Sqrt(D())) / 2 * a;
            return x;
        }
        else {
            Debug.Log("No solutions");
            return x;


        }

    }
    private float D() {


        return Mathf.Pow(b, 2) - 4 * a * c;
    }



}
