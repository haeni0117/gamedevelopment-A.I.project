using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fadeout_test : MonoBehaviour
{
    public Image image;

    private IEnumerator Fade(float start, float end){
        
        float currentTime = 0.0f; //현재시간
        float percent = 0.0f;
        // float start = 0.0f;
        // float end = 1.0f;
        

        while(percent <1){//완전히 불투명한 상태가 아니라면
            currentTime += Time.deltaTime ;//원래 0.0f으로 초기화된 상태의 currentTime값에서 시간의 흐름 만들어줌
            percent = currentTime / fadetime; //default값은 1s이지만 fadetime이라는 변수를 활용해서 얼마동안 페이드 인/아웃할 것인지를 정해줌
            //알파값은 start~end :: during fadetime 
            Color color = image.color;
            color.a = Mathf.Lerp(start,end,percent);
            image.color = color;
            yield return null;


            
        }
    }
    [SerializeField]
    [Range(0.01f,10f)]//slider UI 생성
    private float fadetime;

    //public Image image;
    //onclick_function
    public void fadeoutstart(){
        Debug.Log("fadeoutstart 함수 시작");
        StartCoroutine(Fade(0,1));
        Debug.Log("coroutine is finished");
        Invoke("nextscene",1.5f);
    }
    public void nextscene(){
        SceneManager.LoadScene("2-2");
    }

    private void Awake(){
        image = GetComponent<Image>();
    }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}