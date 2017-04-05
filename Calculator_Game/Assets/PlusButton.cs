using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlusButton : MonoBehaviour {

    public ValueOneInput valueOneInput;
    public ValueTwoInput valueTwoInput;
    
    float Addition ()
    {
        return 0;
    }
    


   // float Addition (float valueOne)
    //{
    //    float additionFinal = 0;

    //    additionFinal = valueOne + addition;

      //  return additionFinal;
 //   } 

  //  public void ButtonClick ()
   // {
     //   print(Addition(valueOneInput.InputOneToFloat()) + " Is your addition.");
   // }

    public void ButtonClick()
    {
        print(Addition());
    }
}
