using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ValueOneInput : MonoBehaviour {

    public InputField valueOne;

    public float InputOneToFloat ()
    {
        return float.Parse(valueOne.text);
    }
}
