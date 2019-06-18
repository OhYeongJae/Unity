using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloClass : MonoBehaviour
{
    void Start()
    {
        Animal jack = new Animal(); // 아무것도 없는 공간에 애니멀을 만들어라
        jack.name = "JACK";
        jack.sound = "Bark";
        jack.weight = 4.5f;

        Animal nate = new Animal();
        nate.name = "NATE";
        nate.sound = "Nyaa";
        nate.weight = 1.2f;

        Animal annie = new Animal();
        annie.name = "ANNIE";
        annie.sound = "Wee";
        annie.weight = 2.3f;

        nate = jack;

        nate.name = "JIMMY";
        nate.sound ="chee";
        Debug.Log(jack.name);
        Debug.Log(jack.sound);

        Debug.Log(nate.name);
        Debug.Log(nate.sound);
    }


}

public class Animal{

    public string name;
    public string sound;
    public float weight;

}