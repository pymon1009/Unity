using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class testUniRX : MonoBehaviour
{
    Subject<int> subject = new Subject<int>();

    // Start is called before the first frame update
    void Start()
    {

        //subject.Subscribe()
        subject.OnNext(0);
    }
}
