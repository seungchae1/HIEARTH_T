using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class video : MonoBehaviour
{
    public VideoPlayer vid;


    void Start() { vid.loopPointReached += CheckOver; }

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        Debug.Log("Video Is Over");
    }

}

