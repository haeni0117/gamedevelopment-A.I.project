using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//7.5 #5 사라와 대화

public class text_8_1_1 : MonoBehaviour
{
    static IEnumerator Typing(string message)
    { 
        Text typingText = GameObject.Find("general text").GetComponent<Text>();
        Debug.Log("typingtext"+typingText);
        Debug.Log("message"+message);
        
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

    
    public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정 
    public static Text typingText; 
    public static GameObject fadeout;

    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num++;
    }
    private static string text_1="전화가 끊기더라도 다시 전화를 \n걸어 구조를 요청하면 된다. ";
    private static string text_2= "나는 주저하지 않고 계단을 \n내려갔다. 밑으로 내려갈수록 \n원인을 알 수 없는 냄새가 \n심해져서 옷깃으로 코를 막았다." ;
    private static string text_3="전화는 거실 테이블 위에 있다.\n이제 전화만 받으면\n카라를 벗어날 수 있다.";
    private static string text_4="\"여보세요?\"";
    private static string text_5="\"저런....\n이렇게 쉬운 줄 알았다면, \n진작 시도하는 건데.\"";
    private static string text_6="금속성의 날카로운 웃음소리가 \n거실에 울려 퍼지고, 귀가 \n멍할 정도로 큰 폭발음과 \n함께 폭풍 같은 화마가 들이닥쳤다.";
    private static string text_7= "\"안돼..... 이렇게 죽을 수는 없어...\"" ;
    private static string text_8="배드엔딩-가스 폭발\n\n-너무 성급한 결정을 내리셨군요. \n때로는 행동하기 전에 잠시 \n생각하는 시간을 갖는 것도 좋답니다.-";



    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);       
    static IEnumerator coroutine3 = Typing(text_4);
    static IEnumerator coroutine4 = Typing(text_5);
    static IEnumerator coroutine5 = Typing(text_6);       
    static IEnumerator coroutine6 = Typing(text_7);
    static IEnumerator coroutine7 = Typing(text_8);
    
    // Start is called before the first frame update
    void Start()
    {
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_8_1_1.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        Debug.Log("scene8-1-1 is started "+num);
        StartCoroutine(coroutine);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(num==2){
            StartCoroutine(coroutine1);
            num++;
            //StartCoroutine(coroutine1);
        }
        if(num==5){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine2);
            num++;
        }
        if(num==8){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine3);
            num++;
        }
        if(num==11){
            StartCoroutine(coroutine4);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==14){
            StartCoroutine(coroutine5);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==17){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine6);
            num++;
        }
        if(num==20){
            StartCoroutine(coroutine7);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
       

    }
}
