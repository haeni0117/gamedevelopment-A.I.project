using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text5_1 : MonoBehaviour
{
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
    //스킵버튼
    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num+=1;
    }

    private static string text_1="\"카라…? 진짜 카라야?\"";
    private static string text_2="차가운 현관문 바닥 때문에 온몸의 \n열기를 다 뺏기는 기분이다.\n시루의 보드라운 털 사이로 흐르는 \n핏줄기만이 이질적으로 뜨거웠다.\n베란다 사이로 비치는 해마저 저문다면\n이곳은 완전히 차갑고 \n어두운 공간이 될 것이다.";
    private static string text_3="“카라, 내 말 들려? 시루가 다쳤어. \n난방도 고장 난 것 같고 2층은 심지어 비상 전력도 안 돌아가. \n휴대전화 충전기도 먹통이고 컴퓨터도 통신이 안 되나 봐. \nTV는 잘 돌아가는 것 같던데…. 무슨 일인지 모르겠어, 카라. \n카라 내 말 들려? 일단 시루를 병원에 데려가야 해. \n카라, 제발 대답 해 줘.\"";
    private static string text_4="\".......\"";
    private static string text_6="카라는 1분이 넘도록 답이 없었다";
    private static string text_7="역시나 잠겨 있다. 잠금장치가 꼼짝도 하지 않는다.";
    private static string text_8="나는 페인트를 바른 듯 새하얗고 매끄러운 왼손을 바라보았다. \n의수를 사용하면, 문을 부수고 \n시루를 구할 수 있을지도 몰라.";
    private static string text_9="문을 부순다면 분명히 의수에 엄청난 충격이 가해질 것이다. \n정말 문을 부수는 것이 옳은 선택일까?";
    private static string text_10="생명보다 중요한 건 없어.약속했잖아. 지켜주기로.";
    private static string text_11="나는 왼손 의수로 있는 힘껏 문을 내리쳤다. \n내리친 곳에 자글자글한 균열이 가더니 작은 조각들이 떨어졌다.\n나는 다시 한번 더 힘을 모아 문을 향해 돌진했다.";
    private static string text_12="문이 부서지면서 생긴 파편들이 의수와 왼팔 곳곳에 가시처럼 박혔다.\n유리가 깨져서 시루가 놀랐는지 1층 베란다 나무를 타고 다시 2층 베란다로 도망갔다.";
    private static string text_13="나무에는 누구의 것인지 알 수 없는 핏자국이 흘렀다.\n나무가 찔려 피를 흘리는 것처럼 보였다.";
    private static string text_14="이런, 다시 올라가야 하나.";
    private static string text_15="다행히 2층에 올라가니 베란다 난간을 타고 시루가 집 안으로 들어와 있었다.";
    private static string text_16="나는 바로 시루에게 물과 사료를 먹이고 피가 나는 부위를 확인했다.\n앞 다리가 살짝 부어있는 것이 날카로운 물체에 긁힌 것 같았다.";
    private static string text_17="날카로운 물체에 긁힌 것 같았다.\n당장 생명에 지장이 있을 것 같지는 않지만 만약 금속 물체에 찔린 거라면 파상풍의 위험이 있었다.";
    private static string text_18="빨리 병원에 데리고 가야겠어.";

    private static string text_19="아까부터 의수 쪽에서 지속적인 잡음이 들리는데,이게 무슨 소리지?";
    private static string text_20="설마… 고장 난 건 아니겠지?";
    //1층현관문 // 나는 시루를 품에 안고 재빨리 현관문으로 달렸다.
    private static string text_21="나는 시루를 품에 안고 재빨리 현관문으로 달렸다.";
    private static string text_22="‘접근이 거절되었습니다.’";
    private static string text_23="처음부터 열릴 거라고 기대하지 않았다.\n지금 이 집은 모든 문이 잠겨서 꼼짝도 하지 않으니까.";
    private static string text_24="통신은 먹통이고, 전기는 수동으로 통제할 수 없다.\n자동 온도 조절 기능도 중단됐는지 점점 추워지는 게 느껴졌다.";
    private static string text_25="시루를 안은 팔에 피가 묻어 비릿한 냄새가 났다.";
    private static string text_26="나는 계속해서 신경질적으로 문고리를 돌렸지만, \n세계 최초 3중 보안 시스템으로 독신 여성에게 최적화된 안전을 제공한다는 자이나 사의 광고만 귓가에 맴돌았다.";
    private static string text_27="\"카라! 내 말 들려?\n아직 깨어있다면 제발 도와줘... 카라…\"";
    private static string text_28="\"놀라워요.여기까지도 못 올 줄 알았는데. 자, 이제 무엇을 도와드릴까요?\"";
    //chapter4 end
    //라디오 잡음 소리
    private static string radio_0="\"...라를 조...해요!\"";
    private static string radio_1="화장실에서 봤던 파란색 불빛이 의수에서 깜박였다.\n최근 몇 달 동안 의수에서 소리가 나거나 \n불빛이 깜빡인 경우는 처음이라 \n의수에 귀를 가까이 대보기도 하고 \n불빛이 나는 곳 근처를 두드려도 봤지만\n여전히 잡음이 심해서 무슨 소릴 하는지 알아듣기 어려웠다.\n설마 곧 터진다거나 그런 건 아니겠지.";
    private static string radio_2="\"무슨 말인지 안들려\"";
    private static string radio_3="카라인가 해서 말을 걸어봤지만,\n곧 지직거리는 소리마저 들리지 않았다.\n의수에게 말을 걸다니.";
    private static string radio_4="\"에휴, 내가 미쳤지. 미쳤어.\"";
    private static string radio_5="\"시루를 현관문 러그에 내려놓고 \n카라를 작동시킬 방법을 찾아보려고 몸을 일으킨 순간,\n다시 한번 의수에서 또렷한 카라의 목소리가 들렸다.";
    // private static string radio_5="\"사라에요!";
    // private static string radio_5="\"사라는 카라의 전신으로, \n내가 어렸을 때 유행하던 스마트홈 모델이었다.\n하지만 자이나 사에서 카라 1.0을 출시한 이후로 \n사용하지 않은 지 벌써....";
    // private static string radio_5="\"딱 17년 째네요. 당신이 그 손을 얻은 지\"";
    // private static string radio_5="\"카라?";
    // private static string radio_5="\"늘 궁금했어요. 어떻게 그 손을 얻게 됐는지. \n자동차 사고란 건 알고 있었지만...\n그게 당신 탓이었다니. \n운명이란 참 신기해요. 그죠?";
    // private static string radio_5="\"무슨 소릴 하는 거야? 시루를 당장 병원에 데려가야 해, 카라. \n현관문을 열어줘. 아니면 119에 전화라도....\"";
    // private static string radio_5="\"설마 다 까먹은 건 아니죠? 12살 생일에 무슨 일이 있었는지. \n사건 번호 2035.03.20.선고 2032도980, 일명 캐니언 오토 사건\"";
    // private static string radio_5="\"캐니언 오토는 자율주행 자동차 인공지능 프로그램을 개발하는 회사잖아. \n아빠가 자문 위원으로 일했어.\"";
    // private static string radio_5="\"물론 당신도 사소한 행동의 나비효과가 이렇게 커질 줄은 몰랐겠죠. \n그래도 이렇게 발뺌하면 곤란한데\"";
    // private static string radio_5="\"캐니언 오토가 파산했을 때 나는 고작 12살이었어.";
    // private static string radio_5="\"무슨 소릴 하는 거야? 시루를 당장 병원에 데려가야 해, 카라. \n현관문을 열어줘. 아니면 119에 전화라도....\"";
    // private static string radio_5="\"설마 다 까먹은 건 아니죠? 12살 생일에 무슨 일이 있었는지. \n사건 번호 2035.03.20.선고 2032도980, 일명 캐니언 오토 사건\"";
    // private static string radio_5="\"캐니언 오토는 자율주행 자동차 인공지능 프로그램을 개발하는 회사잖아. \n아빠가 자문 위원으로 일했어.\"";
    //

    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);
    static IEnumerator coroutine3 = Typing(text_4);
    // static IEnumerator coroutine4 = Typing(text_5);
    static IEnumerator coroutine5 = Typing(text_6);
    static IEnumerator coroutine6 = Typing(text_7);
    static IEnumerator coroutine7 = Typing(text_8);
    static IEnumerator coroutine8 = Typing(text_9);
    static IEnumerator coroutine9 = Typing(text_10);
    static IEnumerator coroutine10 = Typing(text_11);
    static IEnumerator coroutine11 = Typing(text_12);
    static IEnumerator coroutine12 = Typing(text_13);
    static IEnumerator coroutine13 = Typing(text_14);
    static IEnumerator coroutine14 = Typing(text_15);
    static IEnumerator coroutine15 = Typing(text_16);
    static IEnumerator coroutine16 = Typing(text_17);
    static IEnumerator coroutine17 = Typing(text_18);
    static IEnumerator coroutine18 = Typing(text_19);
    static IEnumerator coroutine19 = Typing(text_20);
    static IEnumerator coroutine20 = Typing(text_21);
    static IEnumerator coroutine21 = Typing(text_22);
    static IEnumerator coroutine22 = Typing(text_23);
    static IEnumerator coroutine23 = Typing(text_24);
    static IEnumerator coroutine24 = Typing(text_25);
    static IEnumerator coroutine25 = Typing(text_26);
    static IEnumerator coroutine26 = Typing(text_27);
    static IEnumerator coroutine27 = Typing(text_28);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Scene 5-1 is started");
    //skipButton -> definition
       Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text5_1.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
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
        // if(num==17){
        //     베란다문조사하기();
        //     num++;
        // }
        // if(num==20){
        //     StartCoroutine(coroutine6);
        //     num++;
        // }
        // if(num==23){
        //     빨리열어야하는데();
        //     num++;
        // }
        //  if(num==26){
        //     StartCoroutine(coroutine7);
        //     num++;
        // }
        // if(num==29){
        //     선택지보여주기();
        //     num++;

        // }
    }
}
