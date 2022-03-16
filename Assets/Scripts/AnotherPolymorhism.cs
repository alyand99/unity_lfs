using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherPolymorhism : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        People people = new People();
        Pterodactile pterodactile = new Pterodactile();
        List<IFly> flyingObjects = new List<IFly>();
        flyingObjects.Add(people);
        flyingObjects.Add(pterodactile);
        foreach (var fl in flyingObjects) {
            fl.Fly();
        }

    }

  
}
public class People : Human, IFly
{
    public void Fly()
    {
        Debug.Log("flying like people");
    }
}
public class Pterodactile : IFly
{
    public void Fly()
    {
        Debug.Log("flying like pterodactile");
    }
}
public interface IFly {

    void Fly();
}