using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoController : MonoBehaviour
{
    public GameObject myVideo;
    public VideoPlayer videoClip;
    void Start(){
        myVideo.SetActive(true);
        videoClip.Play();
    }
    void Update(){
        if((ulong)videoClip.frame == (ulong)videoClip.frameCount){
            SceneManager.LoadScene("1-1");
        }
    }
}
