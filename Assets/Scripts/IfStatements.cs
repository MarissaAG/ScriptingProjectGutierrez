using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        // If the cofee's temperature is greater than the hottest drinking temperature
        if (coffeeTemperature > hotLimitTemperature)
        {
            // ... do this
            print("Coffee is too hot.");
        }
        // If it isn't, but the coffee tmperatature is less than the coldest drinking temperature...
        else if (coffeeTemperature < coldLimitTemperature)
        {
            // ... do this.
            print("Coffee is too cold");    
        }
        // If it is neither of those them ...
        else
        {
            // ... do this
            print("Coffe is just right");
        }
    }
}