using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text6_1 : MonoBehaviour
{// Start is called before the first frame update
   public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정
    public static Text typingText;
    public static GameObject fadeout;

    //욕조로 간다
    private static string text_1="머릿속에 떠오른 \n십대 시절 나를 안심시켜주던 \n사라의 차분한 목소리를 \n되뇌었다.요동치던 심장이 \n가라앉는 것이 느껴졌다. ";
    private static string text_2="[ 웬만하면 믿을 수 있는 사람한테 맡기고 싶단 말이야. 이상한 사람한테 보냈다가 \n학대라도 당하면 어떡해? 평생 죄책감에 시달릴 거야. ]";
    private static string text_9="혼자 사는 대학생치고 집이 좁지는 않지만, \n그래도 고양이를 키우기에 적합한 환경인지는 확신이 들지 않았다.";
    private static string text_10="게다가 나는 아직 상담 치료도 받고 있고…. \n나 같은 사람이 동물을 키워도 되는 걸까?";
    private static string text_11="하지만 걱정으로 가득한 머리와는 반대로 \n이미 내 손은 청주로 가는 기차표를 예매하고 있었다.";
    private static string text_12="[ 알았어, 내려갈게. ]\n\n[ 진짜지? 잘 키워주기로 약속한 거다? ]\n\n[ 그렇다니깐 ]";
    private static string text_13="[ 그럼 이름은 뭘로 할래? ]\n\n[ 이름? ]\n\n[ 시루. 시루로 할래. ]";
    private static string text_14="허피스 때문에 눈곱이 잔뜩 껴서 \n눈도 제대로 못 뜨면서도 \n악착같이 우유를 \n받아먹는 모습이 꼭.....";
    private static string text_15="[ 시루?? 그게 뭐야 - -;;\n원래 강아지 고양이 이름은 먹는 거로 하는 거 아니랬어 ]";
    private static string text_16="[ 나 기차표 취소한다? ]";
    private static string text_17="답이 없어서 다른 입양처를 찾았나 했더니 얼마 지나지 않아 \n시루라고 적힌 이름표를 단 삼색 고양이, \n그러니까 시루의 사진을 받았다.";
    private static string text_18="밑에는 보라색 네온사인으로 ‘집사 너를 선택했다! 나를 잘 키워라냥! \n그렇지 않으면 고양이의 저주를 내리겠다냥!’이라고 적혀 있었다.";
    private static string text_19="\"하여튼, 못 말린다니까.\"\n[ 그래 약속할게 ]";
    //
    // static IEnumerator coroutine =  Typing(text_1);
    // static IEnumerator coroutine1 = Typing(text_2);
    // static IEnumerator coroutine2 = Typing(text_3);
    // static IEnumerator coroutine3 = Typing(text_4);
    // static IEnumerator coroutine4 = Typing(text_5);
    // static IEnumerator coroutine5 = Typing(text_6);
    // static IEnumerator coroutine6 = Typing(text_7);
    // static IEnumerator coroutine7 = Typing(text_8);
    // static IEnumerator coroutine8=  Typing(text_9);
    // static IEnumerator coroutine9 = Typing(text_10);
    // static IEnumerator coroutine10 = Typing(text_11);
    // static IEnumerator coroutine11 = Typing(text_12);
    // static IEnumerator coroutine12 = Typing(text_13);
    // static IEnumerator coroutine13 = Typing(text_14);
    // static IEnumerator coroutine14 = Typing(text_15);
    // static IEnumerator coroutine15 = Typing(text_16);
    // static IEnumerator coroutine16 = Typing(text_17);
    // static IEnumerator coroutine17 = Typing(text_18);
    // static IEnumerator coroutine18 = Typing(text_19);

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
       Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(textfourone.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.



        Debug.Log("coroutin is started! #3-1 num"+num);
        // StartCoroutine(coroutine);

    }

//     // Update is called once per frame
    void Update(){
        //Debug.Log(num);
        // if(num==2){
        //     Debug.Log("coroutine is started!  num"+num);
        //     StartCoroutine(coroutine1);
        //     num++;
        //     //StartCoroutine(coroutine1);
        // }
        // if(num==5){
        //     Debug.Log("coroutine is started!  num"+num);
        //     StartCoroutine(coroutine2);
        //     num++;
        // }
        // if(num==8){
        //     Debug.Log("coroutine is started!  num"+num);
        //     StartCoroutine(coroutine3);
        //     num++;
        // }
        // if(num==11){
        //     StartCoroutine(coroutine4);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;
        // }
        // if(num==14){
        //     StartCoroutine(coroutine5);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        //
        // if(num==17){
        //     StartCoroutine(coroutine6);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==20){
        //     StartCoroutine(coroutine7);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==23){
        //     StartCoroutine(coroutine8);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==26){
        //     StartCoroutine(coroutine9);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==29){
        //     StartCoroutine(coroutine10);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==32){
        //     StartCoroutine(coroutine11);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==35){
        //     StartCoroutine(coroutine12);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==38){
        //     StartCoroutine(coroutine13);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==41){
        //     StartCoroutine(coroutine14);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==44){
        //     StartCoroutine(coroutine15);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==47){
        //     StartCoroutine(coroutine16);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==50){
        //     StartCoroutine(coroutine17);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==53){
        //     StartCoroutine(coroutine18);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==56){
        //     SceneManager.LoadScene("4-2");
        //     num++;//activate button
        // }


    }
}
