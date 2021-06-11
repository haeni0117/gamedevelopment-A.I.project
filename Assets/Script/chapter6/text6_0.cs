using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text6_0 : MonoBehaviour
{
    public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정 
    public static Text typingText; 
    public static GameObject fadeout;
    //스킵버튼
    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num++;
    }
    

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
    //스킵버튼
   
    
    //string -> narration
    private static string text_1="다시 카라를 소리쳐 불렀지만, \n답이 없었다.\n차라리 화라도 냈다면 \n덜 불안했을까?";
    private static string text_2="카라 앞에서 내 목숨은 \n플라스틱 장난감에 쌀알을 넣고 \n흔드는 것만큼이나 가벼웠다. ";
    private static string text_3="나를 죽이기 위해 \n카라는 난방 시스템을 \n완전히 끊어 버리거나\n바닥 온도를 걸어 다닐 수 없을 만큼 \n높일 수 있었다.";
    private static string text_4="아니면 그냥, \n외부와의 연결을 끊은 채 \n굶어 죽을 때까지 \n내버려 둘 수도 있다.";
    private static string text_5="어차피 2주쯤 연락이 없다고 해도 \n나를 찾는 사람은 \n아무도 없을 테니까. \n하지만 다행히 카라와 연락이 끊긴 지 \n꽤 오랜 시간이 지난 후에도 \n1층 거실은 밝았고, \n바닥은 뜨겁지 않았다.";
    private static string text_6="나는 그저\n차갑고 어두운 이곳에\n또다시,\n혼자,\n갇힌 것이다.";
    private static string text_7="'야-옹'";
    private static string text_8="나도 모르게 힘을 너무 세게 줬는지\n시루가 품을 빠져나왔다.\n시루는 고작 허리에서 바닥으로 \n점프하는데도 착지할 때 \n비틀거렸다.\n회색빛 대리석에 \n고양이 발바닥 모양의 \n핏자국이 선명하게 찍혔다";
    private static string text_9="'약속했잖아, 지켜주겠다고.'";
    private static string text_10="나는 두려움을 삼키고 \n다시 몸을 일으켰다. \n약속을 지키기 위해.";
    private static string text_11="자꾸만 도망가는 시루를 \n겨우 붙잡고 \n피가 흐르는 뒷다리를 살폈다.\n왼쪽 뒤 발바닥에 \n베인 상처가 뚜렷했다. \n아마 나무에서 미끄러지면서 \n거친 껍질에 상처가 난 것 같다. ";
    private static string text_12="어서 구급상자를 찾아야 해.";
    
    //chapter4 end
    
    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);       
    static IEnumerator coroutine3 = Typing(text_4);
    static IEnumerator coroutine4 = Typing(text_5);
    static IEnumerator coroutine5 = Typing(text_6);
    static IEnumerator coroutine6 = Typing(text_7);
    static IEnumerator coroutine7 = Typing(text_8);
    static IEnumerator coroutine8 = Typing(text_9);
    static IEnumerator coroutine9 = Typing(text_10);
    static IEnumerator coroutine10 = Typing(text_11);       
    static IEnumerator coroutine11 = Typing(text_12);


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Scene 6-0 is started");
   
       Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text6_0.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
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
            num++;//activate button
        }
        if(num==17){
            StartCoroutine(coroutine6);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==20){
            StartCoroutine(coroutine7);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==23){
            StartCoroutine(coroutine8);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
         if(num==26){
            StartCoroutine(coroutine9);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==29){
            StartCoroutine(coroutine10);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==32){
            StartCoroutine(coroutine11);
            Debug.Log("coroutine is started!  num"+num);
            num++;

        } 
        if(num==35){
            SceneManager.LoadScene("6-1");
        }

    }
}

