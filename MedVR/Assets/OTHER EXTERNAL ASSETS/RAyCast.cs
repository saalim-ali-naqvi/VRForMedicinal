using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
public class RAyCast : MonoBehaviour
{
    // Start is called before the first frame update
    
public VideoPlayer videoPlayer;
    // Update is called once per frame
    void Update()
    {
       
       if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitinfo,20f))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hitinfo.distance, Color.green);
            Debug.Log("Did Hit");
             if(hitinfo.transform.tag == "Medicine"){
                videoPlayer = GetComponent<VideoPlayer>();
                videoPlayer.Play();
             }
        }
        else{
             Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 20f, Color.blue);
        }







    }
}
