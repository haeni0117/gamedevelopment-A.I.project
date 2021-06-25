using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//#8-1-2

public class text1_1_1: MonoBehaviour
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

    //basic component
    public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정
    public static Text typingText;
    public static GameObject fadeout;


    //skip button
    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num++;
    }
    //choice1activation



    private static string text_1="\"그래....... 이제 일어나야지\"";
    private static string text_2="둔기로 뒤통수를 맞은 것처럼 \n머리가 욱신거린다. \n어제 회식에서 그렇게 술을 \n많이 마신 것 같지도 않은데, \n집에 들어온 기억이 전혀 없다.";
    private static string text_3="\"스무 살 때 겪었던 \n숙취를 다시 겪는 기분이네.\"";
    private static string text_4="스무 살 때와 차이가 있다면 \n더는 퀴퀴하고 좁은 기숙사 방에서 \n밤새 토사물을 치우느라 \n화난 룸메이트를 \n마주하지 않아도 된다는 것? ";
    private static string text_5="항상 혼자 살기에는 \n집이 너무 넓다고 불평을 해왔지만, \n인공지능이 설정한 최적 온도와 습도는 \n언제나 상쾌하고, \n퀸사이즈 침대 위에 놓인 \n새하얀 침구는 오늘따라 더 눈부시다.";

    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);
    static IEnumerator coroutine3 = Typing(text_4);

    // Start is called before the first frame update
    void Start()
    {
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text1_1_1.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        Debug.Log("scene1 is started "+num);
        StartCoroutine(coroutine);

        // //1. 작업실을 다시 한 번 살펴보자
        // GameObject choice1 = GameObject.Find("choice1");
        // Button choice1B =choice1.GetComponent<Button>();
        // Text choice1t = GameObject.Find("choice1Text").GetComponent<Text>();
        // choice1t.text=" ";
        // choice1B.interactable=false;
        // choice1B.onClick.AddListener(text_8_1_2.선택지활성화);



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
            StartCoroutine(coroutine2);
            num++;
        }
        if(num==8){
            StartCoroutine(coroutine3);
            num++;
        }
        if(num==11){
            SceneManager.LoadScene("1-2");
        }






    }
}
