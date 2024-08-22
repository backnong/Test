using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
    int intValue;

    float floatValue = 10.5f;
    float floatValue2 = 20.3f;

    int FloatToInt(float _parameter,float _parameter2 )
    {
        return Multiply((int)(_parameter+_parameter2));
         

    }

    int Multiply(int _parameter)
    {
        return _parameter * _parameter;
    }
    
      void Start()
    {

       intValue= FloatToInt(floatValue, floatValue2);
        print(intValue);

    }

}
