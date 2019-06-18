using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    // 주석 - 메모
    /*
        C++과
        똑같구만
    */
    // 콘솔 출력
    Debug.Log("Hello World!");     

    int age =23;
    int money = -1000;

    Debug.Log(age);
    Debug.Log(money);

     float height = 169.1234f;
    Debug.Log(height);

    double pi = 3.141592;
    Debug.Log(pi);

    Debug.Log("내 나이는? : "+age);

    // var은 할당하는 값을 기준으로 타입을 결정
    var myName = "오영재";
    // string myName = "오영재";
    }

   
}
