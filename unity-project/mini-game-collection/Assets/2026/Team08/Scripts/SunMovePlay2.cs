/* Name: Liam McDougall
 * Date: 2026/11/10
 */
using UnityEngine;


public class SunMovePlay2 : MonoBehaviour
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
        if (Input.GetKey(KeyCode.D))
        {
            //Slowly moves the sun as the player goes left
            position = position - 0.0001f;
            transform.position = new Vector3(position, transform.position.y, transform.position.z);
        }
    }
}
