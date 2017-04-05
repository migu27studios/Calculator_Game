using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ValueTwoInput : MonoBehaviour {

    public InputField valueTwo;

    public float InputTwoToFloat ()
    {
        return float.Parse(valueTwo.text);
    }

}
