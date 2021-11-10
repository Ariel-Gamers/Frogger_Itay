using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger game over")]
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(triggeringTag) && enabled)
        {
            Debug.Log("Game over!");
            Application.Quit();
        }
    }

    private void Update()
    {
        /* Just to show the enabled checkbox in Editor */
    }

}
