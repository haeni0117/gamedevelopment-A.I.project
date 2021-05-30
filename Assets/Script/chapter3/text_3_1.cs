using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text_3_1 : MonoBehaviour
{
    public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정 
    public static Text typingText; 
    public static GameObject fadeout;


    //다음씬설정만하면된다.
    public void nextscene(){
        SceneManager.LoadScene("3-2");
    }



    //최종페이드아웃함수
    public void fadeoutstart(){
        Debug.Log("3-1 -> 3-2");
        StartCoroutine(Fade(0,1));
        Invoke("nextscene",1.5f);
    }



    //fadeout coroutine
    private IEnumerator Fade(float start, float end){
        //이미지지정(검은화면 -> 페이드아웃)
        Image image= GameObject.Find("fadeout").GetComponent<Image>();

    
        float currentTime = 0.0f; //현재시간
        float percent = 0.0f;
        // float start = 0.0f;
        // float end = 1.0f;

        while(percent <1){//완전히 불투명한 상태가 아니라면
            currentTime += Time.deltaTime ;//원래 0.0f으로 초기화된 상태의 currentTime값에서 시간의 흐름 만들어줌
            percent = currentTime / 1.5f; //default값은 1s이지만 fadetime이라는 변수를 활용해서 얼마동안 페이드 인/아웃할 것인지를 정해줌
            //알파값은 start~end :: during fadetime 
            Color color = image.color;
            color.a = Mathf.Lerp(start,end,percent);
            image.color = color;
            yield return null;
        }
    }

    

//     //string -> narration
    private static string text_1="시루를 처음 만난 순간이 머릿속을 빠르게 스쳤다.\n마음이 점점 급해진다..";

    private static string text_2="다른 사람이었다면 \n상황이 심각해지기 전에 \n가까운 누군가 연락을 했겠지만,\n그래, 나 같은 걸 누가 찾겠어.";
    private static string text_3="쪽지가 없었다면 \n내 집 안방에서 쓸쓸하게 \n죽음을 맞이했을거라 \n생각하니 아찔했다.";
    private static string text_4="‘경고: 즉시 대피하십시오.’";
    private static string text_5="문을 열자마자 작업실 스크린에\n불길하게 걸린 붉은 글씨가\n나를 집요하게 파고들었다.\n굳게 닫힌 자동 조절 커튼 때문에 \n칠흑같이 어두운 작업실 사이로 \n한 줄기 빛이 가로지른다.";
    private static string text_6="도망쳐야 한다.\n하지만 무슨 수로? \n여전히 폰은 먹통이고 \n카라를 비롯한 전체 시스템이 \n다운됐다.";
    private static string text_7="게다가 거울에서 봤던\n환영들은 다 뭐란 말인가? \n모든 게 내 탓이라며 \n울부짖던 가족들과 잘려 나간 손목. ";
    private static string text_8="그리고 내 목을 조르려던 오빠,\n정체를 알 수 없는\n목소리와 쪽지까지…….";

    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);       
    static IEnumerator coroutine3 = Typing(text_4);
    static IEnumerator coroutine4 = Typing(text_5);
    static IEnumerator coroutine5 = Typing(text_6);
    static IEnumerator coroutine6 = Typing(text_7);
    static IEnumerator coroutine7 = Typing(text_8);


    
    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num+=1;
    }
   

    static IEnumerator Typing(string message)
    { 
        Text typingText = GameObject.Find("general text").GetComponent<Text>();
        Debug.Log(typingText);
        Debug.Log(message);
        
        //message=text_1;
        for (int i = 0; i < message.Length; i++) 
        { 
            typingText.text = message.Substring(0, i + 1); 
            yield return new WaitForSeconds(0.05f);

            if(num%3==1){
                num++;
                Debug.Log("coroutine is stopped+num"+num);
                yield break; //코루틴종료
                //여기서 그냥 끊고, update에서 다음 시나리오 출력해주기
            }//코루틴이 중간에 끝나는 것이 아니라 그냥 나가면? ㅇㅋㅇㅋ
           
            }
            num++;
            Debug.Log("user didn't skip the text+num"+num);
        
    
    }

    

    // Start is called before the first frame update
   void Start()
    {
        //스킵버튼 
       Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text_2_3.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       //1층계단
        Image image= GameObject.Find("fadeout").GetComponent<Image>();
        Color color = image.color;
        color.a = 0;
        //fadeout 비활성화상태
        Debug.Log("coroutine is started! #3-1 num"+num);
        StartCoroutine(coroutine);
        
        
    }

//     // Update is called once per frame
    void Update(){
        //Debug.Log(num);
        if(num==2){
            Debug.Log("coroutine1 is started!  num"+num);
            StartCoroutine(coroutine1); 
            num++;
            //StartCoroutine(coroutine1);
        }
        //skip  -> 새로운선택지보여주기
        if(num==5){
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine2);
            num++;
        }
        if(num==8){
            Debug.Log("coroutine3 is started!  num"+num);
            StartCoroutine(coroutine3);
            num++;
        }
        if(num==11){
            StartCoroutine(coroutine4);
            Debug.Log("coroutine3 is started!  num"+num);
            num++;
        }
        if(num==14){
            StartCoroutine(coroutine5);
            Debug.Log("coroutine4 is started!  num"+num);
            num++;//activate button
        }
        
        if(num==17){
            StartCoroutine(coroutine6);
            Debug.Log("coroutine5 is started!  num"+num);
            num++;//activate button    
        }
        if(num==20){
            StartCoroutine(coroutine7);
            Debug.Log("coroutine5 is started!  num"+num);
            num++;//activate button    
        }
        if(num==23){
            fadeoutstart();
            num++;//activate button    
        }
    }
}