using System.Collections;
using UnityEngine;

public class syntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this line is there to tell me the x position of my object 

        /*Hi there!
         * this is two lines!
         * */
        Debug.Log(transform.position.x);

        if(transform.position.y <= 5f)
        {
            Debug.Log("i'm about to hit the ground!");
        }
    }
}       
    

