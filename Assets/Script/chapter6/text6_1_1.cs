using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text6_1_1 : MonoBehaviour
{

    public static void desk(){

    }
    //스킵버튼
    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num++;
    }
    public static void 선택지1이동(){
        SceneManager.LoadScene("6-1");//탐색할 장소 선택하기
        
    }
    public static void 선택지2이동(){
        //아니다, 더 찾아보자
         //선택지1
        GameObject 선택지1 = GameObject.Find("선택지1");
        Button 선택지1B =선택지1.GetComponent<Button>();
        Text 선택지1t = GameObject.Find("선택지1Text").GetComponent<Text>();
        선택지1t.text=" ";
        선택지1B.interactable=false;
        
        //선택지2
        GameObject 선택지2 = GameObject.Find("선택지2");
        Button 선택지2B =선택지2.GetComponent<Button>();
        Text 선택지2t = GameObject.Find("선택지2Text").GetComponent<Text>();
        선택지2t.text=" ";
        선택지2B.interactable=false;
        
        
    }


    public static void 다른장소탐색활성화(){
         //선택지1
        GameObject 선택지1 = GameObject.Find("선택지1");
        Button 선택지1B =선택지1.GetComponent<Button>();
        Text 선택지1t = GameObject.Find("선택지1Text").GetComponent<Text>();
        선택지1t.text="▶ 다른 장소 탐색하기";
        선택지1B.interactable=true;
        
        //선택지2
        GameObject 선택지2 = GameObject.Find("선택지2");
        Button 선택지2B =선택지2.GetComponent<Button>();
        Text 선택지2t = GameObject.Find("선택지2Text").GetComponent<Text>();
        선택지2t.text="▶ 아니다, 더 찾아보자.";
        선택지2B.interactable=true;
        
    }

    public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정 
    public static Text typingText; 
    public static GameObject fadeout;
    


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
    //침대text
    private static string text_1="당장이라도 눕고 싶지만 \n그럴 여유는 없다.";
    //서랍장text
    private static string text_2="텅 빈 서랍장은 \n뒤져봐도 소용없다.";
    //옷장text
    private static string text_3="옷을 헤치고 \n안쪽을 더듬어 봤지만, \n당연히 옷 말고는 \n아무것도 없다.";
    private static string text_4="옷장 밑 1단 서랍장은 \n잠금이 걸려 있다. ";
    private static string text_5="역시 비밀번호는 \n기억나지 않는다.\n구급상자를 \n금고에 넣어뒀을 리는 없으니 \n일단 구급상자부터 찾아보자.";
    //사이드테이블text
    private static string text_6="구급상자는 보이지 않는다.";
    //수납대text
    private static string text_7="수납장 위를 훑어봐도 \n구급상자는 보이지 않아.";
    //가방걸이text
    private static string text_8="백팩을 한 번 더 뒤졌다. \n역시 쓸 만한 것은 \n보이지 않아.";
    //안방화장실text
    private static string text_9="화장실에는 \n다시 들어가고 싶지 않다.";
    //다른장소탐색
    private static string text_10="다른 곳도 둘러볼까?";
    
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
   
    //boolean -> 데이터관리

    public static void 침대조사하기(){
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.interactable=false;
        GameObject 침대 = GameObject.Find("침대");
        Button 침대B =침대.GetComponent<Button>();
        Text 침대t = GameObject.Find("침대Text").GetComponent<Text>();
        침대t.text="● 침대";
        침대B.interactable=false;
        num=2;
    }

    public static void 서랍장조사하기(){
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.interactable=false;
        GameObject 서랍장 = GameObject.Find("서랍장");
        Button 서랍장B =서랍장.GetComponent<Button>();
        Text 서랍장t = GameObject.Find("서랍장Text").GetComponent<Text>();
        서랍장t.text="● 서랍장";
        서랍장B.interactable=false;
        num=5;
    }

    public static void 옷장조사하기(){
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.interactable=true;
        GameObject 옷장 = GameObject.Find("옷장");
        Button 옷장B =옷장.GetComponent<Button>();
        Text 옷장t = GameObject.Find("옷장Text").GetComponent<Text>();
        옷장t.text="● 옷장";
        옷장B.interactable=false;
        num=8;
    }

    public static void 사이드테이블조사하기(){
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.interactable=false;
        GameObject 사이드테이블 = GameObject.Find("사이드테이블");
        Button 사이드테이블B =사이드테이블.GetComponent<Button>();
        Text 사이드테이블t = GameObject.Find("사이드테이블Text").GetComponent<Text>();
        사이드테이블t.text="● 사이드테이블 ";
        사이드테이블B.interactable=false;
        num=17;
    }
    public static void 가방걸이조사하기(){
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.interactable=false;
        GameObject 가방걸이 = GameObject.Find("가방걸이");
        Button 가방걸이B =가방걸이.GetComponent<Button>();
        Text 가방걸이t = GameObject.Find("가방걸이Text").GetComponent<Text>();
        가방걸이t.text="● 가방걸이 ";
        가방걸이B.interactable=false;
        num=20;
    }
     public static void 안방화장실조사하기(){
         Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
         스킵.interactable=false;
        GameObject 안방화장실 = GameObject.Find("안방화장실");
        Button 안방화장실B =안방화장실.GetComponent<Button>();
        Text 안방화장실t = GameObject.Find("안방화장실Text").GetComponent<Text>();
        안방화장실t.text="● 안방화장실 ";
        안방화장실B.interactable=false;
        num=23;
    }
    public static void 다른장소탐색하기(){
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.interactable=false;
        GameObject 다른장소탐색 = GameObject.Find("다른장소탐색");
        Button 다른장소탐색B =다른장소탐색.GetComponent<Button>();
        Text 다른장소탐색t = GameObject.Find("다른장소탐색Text").GetComponent<Text>();
        다른장소탐색t.text="▷ 다른 장소로 가본다.";
        다른장소탐색B.interactable=true;
        num=26;

         //선택지1
        GameObject 선택지1 = GameObject.Find("선택지1");
        Button 선택지1B =선택지1.GetComponent<Button>();
        Text 선택지1t = GameObject.Find("선택지1Text").GetComponent<Text>();
        선택지1t.text="▷ 다른 곳을 둘러본다.";
        선택지1B.interactable=true;
        
        선택지1.SetActive(true);
        //선택지2
        GameObject 선택지2 = GameObject.Find("선택지2");
        Button 선택지2B =선택지2.GetComponent<Button>();
        Text 선택지2t = GameObject.Find("선택지2Text").GetComponent<Text>();
        선택지2t.text="▷ 아니다, 더 찾아보자.";
        선택지2B.interactable=true;
        
        선택지2.SetActive(true);
    }




    

    // Start is called before the first frame update
    void Start()
    {
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text6_1_1.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        //(1)침대
        GameObject 침대 = GameObject.Find("침대");
        Button 침대B =침대.GetComponent<Button>();
        Text 침대t = GameObject.Find("침대Text").GetComponent<Text>();
        침대t.text="◎ 침대";
        침대B.interactable=true;
        침대B.onClick.AddListener(text6_1_1.침대조사하기);

        //(2)서랍장
        GameObject 서랍장 = GameObject.Find("서랍장");
        Button 서랍장B =서랍장.GetComponent<Button>();
        Text 서랍장t = GameObject.Find("서랍장Text").GetComponent<Text>();
        서랍장t.text="◎ 서랍장";
        서랍장B.interactable=true;
        서랍장B.onClick.AddListener(text6_1_1.서랍장조사하기);

        //(3)옷장
        GameObject 옷장 = GameObject.Find("옷장");
        Button 옷장B =옷장.GetComponent<Button>();
        Text 옷장t = GameObject.Find("옷장Text").GetComponent<Text>();
        옷장t.text="◎ 옷장";
        옷장B.interactable=true;
        옷장B.onClick.AddListener(text6_1_1.옷장조사하기);

        //(4)사이드테이블
        GameObject 사이드테이블 = GameObject.Find("사이드테이블");
        Button 사이드테이블B =사이드테이블.GetComponent<Button>();
        Text 사이드테이블t = GameObject.Find("사이드테이블Text").GetComponent<Text>();
        사이드테이블t.text="◎ 사이드테이블 ";
        사이드테이블B.interactable=true;
        사이드테이블B.onClick.AddListener(text6_1_1.사이드테이블조사하기);

        //(5)가방걸이
        GameObject 가방걸이 = GameObject.Find("가방걸이");
        Button 가방걸이B =가방걸이.GetComponent<Button>();
        Text 가방걸이t = GameObject.Find("가방걸이Text").GetComponent<Text>();
        가방걸이t.text="◎ 가방걸이 ";
        가방걸이B.interactable=true;
        가방걸이B.onClick.AddListener(text6_1_1.가방걸이조사하기);

        //(6)안방화장실
        GameObject 안방화장실 = GameObject.Find("안방화장실");
        Button 안방화장실B =안방화장실.GetComponent<Button>();
        Text 안방화장실t = GameObject.Find("안방화장실Text").GetComponent<Text>();
        안방화장실t.text="◎ 안방화장실 ";
        안방화장실B.interactable=true;
        안방화장실B.onClick.AddListener(text6_1_1.안방화장실조사하기);

        //(7)다른장소탐색
        GameObject 다른장소탐색 = GameObject.Find("다른장소탐색");
        Button 다른장소탐색B =다른장소탐색.GetComponent<Button>();
        Text 다른장소탐색t = GameObject.Find("다른장소탐색Text").GetComponent<Text>();
        다른장소탐색t.text="▷ 다른 장소 탐색하기";
        다른장소탐색B.interactable=true;
        다른장소탐색B.onClick.AddListener(text6_1_1.다른장소탐색하기);

         //선택지1
        GameObject 선택지1 = GameObject.Find("선택지1");
        Button 선택지1B =선택지1.GetComponent<Button>();
        Text 선택지1t = GameObject.Find("선택지1Text").GetComponent<Text>();
        선택지1t.text="▷ 다른 곳을 둘러본다.";
        선택지1B.interactable=false;
        선택지1B.onClick.AddListener(text6_1_1.선택지1이동);
        선택지1.SetActive(false);
        
        //선택지2
        GameObject 선택지2 = GameObject.Find("선택지2");
        Button 선택지2B =선택지2.GetComponent<Button>();
        Text 선택지2t = GameObject.Find("선택지2Text").GetComponent<Text>();
        선택지2t.text="▷ 아니다, 더 찾아보자.";
        선택지2B.interactable=false;
        선택지2B.onClick.AddListener(text6_1_1.선택지2이동);
        선택지2.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(num);
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
            Debug.Log("coroutine is started!  num"+num);
            num++;
            다른장소탐색활성화();
        }
        
    }
}
