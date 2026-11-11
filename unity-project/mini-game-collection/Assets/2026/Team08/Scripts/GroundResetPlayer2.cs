/* Name: Liam McDougall
 * Date: 2026/11/05
 */
using MiniGameCollection;
using System.Threading;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class GroundReset2 : MonoBehaviour
{
    Vector2 begin = new Vector2 (0f, 0f);
    GameObject curPosition;
    ArcadeInput input;
    float position;
    int initTimer = 25; //Number for moving the timer
    int timer = 25; //Will delay moving the waves too fast

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        position = transform.position.x;
  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Pressed D Key");
            if (position < -13)
            {
                position = 13;
                transform.position = new Vector3(position, transform.position.y, transform.position.z);
            }
                position = position - 0.01f;
                transform.position = new Vector3(position, transform.position.y, transform.position.z);
            
        }
    }
}
