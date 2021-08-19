using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text6_1 : MonoBehaviour
{
    public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정 
    public static Text typingText; 
    public static GameObject fadeout;
    public static Button 스킵;
    //스킵버튼

    public static GameObject a;
    public static Button aB;
    public static Text at;
//(2)반려동물 방석
    public static GameObject b;
    public static Button bB;
    public static Text bt;
//(3)의지
    public static GameObject c;
    public static Button cB;
    public static Text ct;
//(4)iot쓰레기통
    public static GameObject d;
    public static Button dB;
    public static Text dt;
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
    private static string text_1="어디부터 찾아볼까?";
    //chapter4 end
    
    static IEnumerator coroutine =  Typing(text_1);

    public static void a활성화(){
        SceneManager.LoadScene("6-1-1");
    }
    public static void b활성화(){
        SceneManager.LoadScene("6-1-2");
    }
    public static void c활성화(){
        SceneManager.LoadScene("6-1-3");
    }
    public static void d활성화(){
        SceneManager.LoadScene("6-1-4");
    }
    void Awake(){
        a = GameObject.Find("a");
        aB =a.GetComponent<Button>();
        at = GameObject.Find("aText").GetComponent<Text>();
        aB.onClick.AddListener(a활성화);

        b = GameObject.Find("b");
        bB =b.GetComponent<Button>();
        bt = GameObject.Find("bText").GetComponent<Text>();
        bB.onClick.AddListener(b활성화);

        c = GameObject.Find("c");
        cB =c.GetComponent<Button>();
        ct = GameObject.Find("cText").GetComponent<Text>();
        cB.onClick.AddListener(c활성화);

        d = GameObject.Find("d");
        dB =d.GetComponent<Button>();
        dt = GameObject.Find("dText").GetComponent<Text>();
        dB.onClick.AddListener(d활성화);

        at.text="1. 안방에 들어간다.";
        bt.text="2. 작업실에 들어간다.";
        ct.text="3. 거실에 들어간다.";
        dt.text="4. 게스트룸에 들어간다.";
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Scene 6-1 is started");
   
       스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text6_1.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       StartCoroutine(coroutine);
       스킵.interactable=false;
       

       a.SetActive(false);
       b.SetActive(false);
       c.SetActive(false);
       d.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        if(num==1){
          a.SetActive(true);
          b.SetActive(true);
          c.SetActive(true);
          d.SetActive(true);
            //StartCoroutine(coroutine1);
        }
        

    }
}

