using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text_0_0: MonoBehaviour
{// Start is called before the first frame update
   public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정
    public static Text typingText;
    public static GameObject fadeout;




//     //string -> narration
    private static string text_1="빗소리가 기분 좋게 들려온다. \n\n풍경들이 내 주변을 빠르게 지나간다.\n\n창문으로 들어오는 시원한 바람이 \n어린 마음을 들뜨게 한다.\n바깥 풍경을 보고싶지만 \n키가 작아 잘 보이지 않는다. ";
    private static string text_2="급한 마음에 나는 안전벨트를 풀고 다리를 올려 \n창문 밖을 보려고 했다.\n\n사고는 순식간에 일어났다.";
    private static string text_3="\"...생존확인\"\n\n머리가 아프다.\n왼팔이 타는 듯한 느낌이 든다. \n흐려지는 시야 속에서 잔뜩 갈라진 기계적인 목소리가 \n희미하게 들린다.";
    private static string text_4="\"...심장박동을 인식했습니다. \n...신체가 일부 손실되었으나 \n예상 손상 정도보다 95.7 퍼센트 감소...\n\n...깨어나세요. 일어나셔야 합니다.\"";

    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);
    static IEnumerator coroutine3 = Typing(text_4);

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
            }//

            }
            num++;
            Debug.Log("user didn't skip the text+num"+num);


    }



    // Start is called before the first frame update
   void Start()
    {
       Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text_0_0.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.

        Debug.Log("coroutin is started! #0-0 num"+num);
        StartCoroutine(coroutine);

    }

//     // Update is called once per frame
    void Update(){
        //Debug.Log(num);
        if(num==2){
            Debug.Log("coroutine is started!  num"+num);
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
            SceneManager.LoadScene("1-0");
        }


    }
}
