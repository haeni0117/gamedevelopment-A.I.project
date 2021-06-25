using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//#8-1-2

public class text1_1: MonoBehaviour
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

    public static void 선택지활성화(){


        //objects are showed
        //a
        GameObject a = GameObject.Find("a");
        Button aB =a.GetComponent<Button>();
        Text at = GameObject.Find("aText").GetComponent<Text>();
        at.text="A. 5분만 더.... ";
        aB.interactable=true;
        aB.onClick.AddListener(text1_1.a활성화);

        //b
        GameObject b = GameObject.Find("b");
        Button bB =b.GetComponent<Button>();
        Text bt = GameObject.Find("bText").GetComponent<Text>();
        bt.text="B. 지금 몇 시야 카라?";
        bB.interactable=true;
        bB.onClick.AddListener(text1_1.b활성화);
    }



    public static void a활성화(){
      GameObject b = GameObject.Find("b");
      Button bB =b.GetComponent<Button>();
      Text bt = GameObject.Find("bText").GetComponent<Text>();
      GameObject a = GameObject.Find("a");
      Button aB =a.GetComponent<Button>();
      Text at = GameObject.Find("aText").GetComponent<Text>();
      num=5;
      at.text=" ";
      aB.interactable=false;
      bt.text=" ";
      bB.interactable=false;
    }
    public static void b활성화(){
      GameObject a = GameObject.Find("a");
      Button aB =a.GetComponent<Button>();
      Text at = GameObject.Find("aText").GetComponent<Text>();
      GameObject b = GameObject.Find("b");
      Button bB =b.GetComponent<Button>();
      Text bt = GameObject.Find("bText").GetComponent<Text>();
      num=11;
      at.text=" ";
      aB.interactable=false;
      bt.text=" ";
      bB.interactable=false;
    }



    private static string text_1="00님, 일어나실 시간입니다.";
    //a. 5분만 더
    private static string text_2="그 말씀만 벌써 3번째입니다. \n씻으시는 동안 잠을 깰 수 있도록 \n커피를 한 잔 타 드리겠습니다. \n지금 일어나지 않으시면 \n어제 설정해 두셨던 \n‘강제 기상’ 모드를 \n작동하는 수밖에 없습니다.";
    //b.지금 몇 시야, 카라?
    private static string text_3="7시 45분입니다. \n이제 막 46분이 되었군요. \n오늘은 비가 와서 \n평소보다 12.3% 교통량이 많습니다. \n지금 일어나지 않으시면 \n9시 반까지 연구소에 \n도착할 확률이 24.78% 줄어듭니다. ";
    private static string text_4="어제 늦게 들어오셔서 \n많이 피곤하신가요? \n세안 후 부엌에 오시면, \n식탁 위에 특별히 샷 추가된 \n아메리카노를 준비해 두겠습니다.";




    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);
    static IEnumerator coroutine3 = Typing(text_4);




    // Start is called before the first frame update
    void Start()
    {
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text1_1.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        Debug.Log("scene1 is started "+num);
        StartCoroutine(coroutine);

        // //1. 작업실을 다시 한 번 살펴보자
        // GameObject choice1 = GameObject.Find("choice1");
        // Button choice1B =choice1.GetComponent<Button>();
        // Text choice1t = GameObject.Find("choice1Text").GetComponent<Text>();
        // choice1t.text=" ";
        // choice1B.interactable=false;
        // choice1B.onClick.AddListener(text_8_1_2.선택지활성화);

       //a
        GameObject a = GameObject.Find("a");
        Button aB =a.GetComponent<Button>();
        Text at = GameObject.Find("aText").GetComponent<Text>();
        at.text=" ";
        aB.interactable=false;
        aB.onClick.AddListener(text1_1.a활성화);

        //b
        GameObject b = GameObject.Find("b");
        Button bB =b.GetComponent<Button>();
        Text bt = GameObject.Find("bText").GetComponent<Text>();
        bt.text=" ";
        bB.interactable=false;
        bB.onClick.AddListener(text1_1.b활성화);

    }

    // Update is called once per frame
    void Update()
    {
        if(num==2){
            선택지활성화();
            num++;
            //StartCoroutine(coroutine1);
        }
        if(num==5){
            StartCoroutine(coroutine1);
            num++;

        }
        if(num==8){
            SceneManager.LoadScene("1-1-1");

        }
        if(num==11){
            StartCoroutine(coroutine2);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==14){
            StartCoroutine(coroutine3);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==17){
           SceneManager.LoadScene("1-1-1");

        }





    }
}
