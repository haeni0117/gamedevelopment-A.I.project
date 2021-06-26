using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//#1-2 부재중전화

public class text1_6: MonoBehaviour
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






    //text수정완
    private static string text_1="노란색 스쿨버스의 구겨진 운전석엔 \n절망스러운 표정의 운전사가 \n머리에 피를 흘리며 앉아 있다.";
    private static string text_2="비틀거리며 일어난 선생님은 사고의 충격으로 \n잠든 아이들을 꼭 껴안는다.";
    private static string text_3="하지만 괜찮을 것이다.";
    private static string text_4="아이들은 곧 병원에서 눈을 뜨고, \n자신을 붙잡고 안도의 눈물을 흘리는 \n부모님을 향해 어리둥절한 표정을 지을 것이다.";
    private static string text_4_1="그리고 아이들 대신 자신이 위험한 방향으로 \n핸들을 돌린 운전사의 장례식에서,\n태어나 처음으로 \n죽음의 의미를 받아들일 것이다.";
    private static string text_4_2="그러나 차가운 빗소리 사이로\n 흐르는 상처는 두 번 다시\n회복되지 않을 것이다.";
    private static string text_5="아빠의 오랜 꿈이었던 \n검은 캐니언 오토가 \n순식간에 오빠의 목을 꺾고, \n엄마의 다리를 뒤틀고, \n아빠의 팔을 부러뜨린다.";
    private static string text_6="그리고 나는 놀란 눈으로 \n날카롭게 부러진 손목뼈가 \n피부를 뚫고 나온 \n왼손을 바라본다.";
    private static string text_7="그리고 그건 다....";
    private static string text_8="\"너 때문이야!\"";

    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);
    static IEnumerator coroutine3 = Typing(text_4);
    static IEnumerator coroutine4_1 =  Typing(text_4_1);
    static IEnumerator coroutine4_2 =  Typing(text_4_2);
    static IEnumerator coroutine4 =  Typing(text_5);
    static IEnumerator coroutine5 = Typing(text_6);
    static IEnumerator coroutine6 = Typing(text_7);
    static IEnumerator coroutine7 = Typing(text_8);




    // Start is called before the first frame update
    void Start()
    {
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text1_6.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        Debug.Log("scene1 is started "+num);
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
            StartCoroutine(coroutine2);
            num++;

        }
        if(num==8){
            StartCoroutine(coroutine3);
            num++;

        }
        if(num==11){
            StartCoroutine(coroutine4);
            num++;
            //StartCoroutine(coroutine1);
        }
        if(num==14){
            StartCoroutine(coroutine4_1);
            num++;

        }
        if(num==17){
            StartCoroutine(coroutine4_2);
            num++;

        }
        if(num==20){
            StartCoroutine(coroutine5);
            num++;
            //StartCoroutine(coroutine1);
        }
        if(num==23){
            StartCoroutine(coroutine6);
            num++;
            //StartCoroutine(coroutine1);
        }
        if(num==26){
            StartCoroutine(coroutine7);
            num++;
            //StartCoroutine(coroutine1);
        }
        if(num==29){
          SceneManager.LoadScene("1-7");
        }


}}
