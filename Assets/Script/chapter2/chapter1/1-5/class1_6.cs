using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class class1_6_ : MonoBehaviour
{
    public void next1_6(){
        SceneManager.LoadScene("1-6");
    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke("next1_6",2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
