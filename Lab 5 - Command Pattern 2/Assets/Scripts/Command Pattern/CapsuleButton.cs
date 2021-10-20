using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleButton : MonoBehaviour
{

    public void OnCapsuleButton_Pressed()
    {
        SceneManager.LoadScene("Main");
    }
}