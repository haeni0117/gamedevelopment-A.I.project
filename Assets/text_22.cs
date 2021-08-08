using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//#1-2 부재중전화

public class text_22: MonoBehaviour
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
    //선택지 : a. 화장실로 이동한다.
    public static GameObject option;
    public static Button option_b;
    public static Button 스킵;
    public static Text option_t;


    //skip button
    public static void 스킵버튼클릭(){
        Debug.Log(num);
        num++;
    }
    //choice1activation

    //화장실 진입 전

    private static string text_2="화장실 문을 여는 순간, \n전 세계에서 가장 많은 사람이 \n불렀을 노래와 함께 \n카라의 쾌활한 목소리가 \n집 안 곳곳에서 흘러나왔다.";
    private static string text_3="\"아 참, 중요한 걸 \n깜빡할 뻔했네요. \n주인님의 32번째 생일을 \n진심으로 축하드립니다.\"";



    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);
    //선택지클릭
    static void option_click(){
      num=2;
      Debug.Log("a.화장실로 이동한다.");
    }




    // Start is called before the first frame update
    void Start()
    {
        option_b = GameObject.Find("a").GetComponent<Button>();
        option_t = GameObject.Find("atext").GetComponent<Text>();
        option_t.text = "a. 화장실로 이동한다.";
        스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_22.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        Debug.Log("scene1 is started "+num);
        스킵.interactable=false;
        option_b.onClick.AddListener(text_22.option_click);

    }

    // Update is called once per frame
    void Update()
    {
        if(num==2){
          option_t.text="";
          option_b.interactable=false;
          스킵.interactable=true;
          StartCoroutine(coroutine1);
          num++;
        }
            //StartCoroutine(coroutine1);

        if(num==5){
            StartCoroutine(coroutine2);
            num++;

        }
        if(num==8){
            SceneManager.LoadScene("1-3");//화장실씬으로 이동

        }







}}
