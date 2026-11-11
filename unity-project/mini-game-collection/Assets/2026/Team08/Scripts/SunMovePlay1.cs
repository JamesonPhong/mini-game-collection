/* Name: Liam McDougall
 * Date: 2026/11/05
 */
using MiniGameCollection;
using System.Threading;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class SunMovePlay1 : MonoBehaviour
{

    float position;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        position = transform.position.x;
  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Pressed Right arrow");
            if (position < -13)
            {
                position = 13;
                transform.position = new Vector3(position, transform.position.y, transform.position.z);
            }
                position = position - 0.0001f;
                transform.position = new Vector3(position, transform.position.y, transform.position.z);
            
        }
    }
}
