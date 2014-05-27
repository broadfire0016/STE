using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	public UIToolkit textButtonManager;
	private static UIText timeText;
	private static UITextInstance timetext1;
	private static int minutes;
	private static int seconds;


 public void Start(){
		timeText = new UIText(textButtonManager,"VogueCyrBold_60_ffffff", "VogueCyrBold_60_ffffff.png");
		timetext1 = timeText.addTextInstance(string.Format("{0} : 30" , minutes),0,0);
		timetext1.color = Color.black;
		timetext1.positionFromTopLeft(0.16f, 0.45f);
		InvokeRepeating("countDown",1,1);
 }
 
 public static void SetTimer(int mins, int secs){
		minutes = mins;
		seconds = secs;
 }
 
 public static int GetMinutes(){
		return minutes;
 }
 
 public static int GetSeconds(){
		return seconds; 
 }

 public static void plusTenSeconds(){
		seconds += 10;
 }
 
 private void countDown(){ // decreases the time

		if (minutes == 0 && seconds == 0){
			seconds = 0;
			minutes = 0;
		}
		else{
			if (seconds > 0){
				--seconds;
			}
			else{
				--minutes;
				seconds = 59;
			}

			if(seconds > 59)
				++minutes;

			if (seconds > 9)
				timetext1.text = string.Format("{0} : {1}", minutes, seconds);
			else
				timetext1.text = string.Format("{0} : 0{1}", minutes, seconds);
			
			timetext1.positionFromTopLeft(0.16f, 0.45f);
		}
	}
}
