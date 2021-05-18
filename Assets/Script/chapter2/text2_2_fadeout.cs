using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class text2_2_fadeout : MonoBehaviour
{
    [SerializeField]
    [Range(0.01f,10f)]//slider UI 생성
    private float fadetime;

    public Image image;
    public void fadeoutstart(){
        StartCoroutine(Fade(0,1));
        Invoke("nextscene",1.5f);
    }
    public void nextscene(){
        SceneManager.LoadScene("2-3");
    }

    private void Awake(){
        image = GetComponent<Image>();
    }

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
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update(){
        
        // Debug.Log(cnt);
        // if(Input.GetMouseButtonDown(0)){
        //     cnt++;
        // }
        // if(cnt==3001){
        //     StartCoroutine(Fade(0,1));

        }
    

    // Update is called once per frame
    // void Update()
    // {
    //     Color color = image.color;
    //     if(color.a<1){
    //         color.a += Time.deltaTime;
    //     }
    //     image.color = color; //바뀐 색상 정보를 원래의 image.color에 저장해주기
    //     //update함수에서 정상적으로 실행됨ㅇㅋㅇㅋ + Raycast;off
    // }
}
