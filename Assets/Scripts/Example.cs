using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TypesExample<int> integer = new TypesExample<int>();
        TypesExample<string> str = new TypesExample<string>();
        Debug.Log(integer.GetTypeThisClass() + "  " + str.GetTypeThisClass());





        var temporary = new string('a', 10);
        Debug.Log(temporary);


        dynamic d = "";
        d = 15;
        d = DateTime.Now;
        Debug.Log(d);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class TypesExample<T> {

    public Type GetTypeThisClass()=>typeof(T);

    

}