using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inheritance : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Human adam = new Human();
        SecondChild cain = new SecondChild();
        FirstChild abele = new FirstChild();
        cain.Breath();
        abele.Eat();

        List<Human> humans = new List<Human>();
        humans.Add(adam);
        humans.Add(cain);
        humans.Add(abele);
        foreach (var h in humans) {
            h.Breath();
            h.Eat();
        }
        
        
        
    }

}
public class SecondChild : Human
{
    public void TryToKillBrother(FirstChild abele) {
        abele = null;
    }
    
    
}
public class FirstChild : Human
{ 


}

public class Human {
    private int legCount = 2;
    private int armCount = 2;
    private int health;
    public void Breath() {
        Debug.Log("breathing ,,,");    
    }
    public void Eat() {
        Debug.Log("eating ,,,");


    }


}