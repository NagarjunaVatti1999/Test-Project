using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CustomVideoPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] VideoPlayer videoPlayer;
    [SerializeField] string videoname;
    void Start()
    {
        videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, videoname);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
