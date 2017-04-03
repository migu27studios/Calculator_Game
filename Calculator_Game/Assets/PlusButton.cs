using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlusButton : MonoBehaviour {

    public ValueOneInput valueOneInput;
    float additionTest = 2f;

    float Addition (float valueOne)
    {
        float additionFinal = valueOne + additionTest;
        return additionFinal;
    }

    public void ButtonClick ()
    {
        print(Addition(valueOneInput.InputOneToFloat()));
    }
}
