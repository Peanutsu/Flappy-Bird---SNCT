using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increaseScore : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other) 
    {
        scoreSystem.instance.UpdateScore();
    }
}
