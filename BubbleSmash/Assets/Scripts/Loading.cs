using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Text textShowed = null;
    public void changeWord(string Loading)
    {
        textShowed.text = Loading;
    }
}
