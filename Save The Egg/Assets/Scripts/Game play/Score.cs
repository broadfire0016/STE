using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public UIToolkit textButtonManager;
	private int score;
	private int TargetScore;
	private UITextInstance scoretext1, scoretext2;
	UIText scoreText;


	void Start(){
		//Initialize Score
		scoreText = new UIText(textButtonManager,"VogueCyrBold_60_ffffff", "VogueCyrBold_60_ffffff.png");
		scoretext1 = scoreText.addTextInstance(string.Format("{0}", score), 0, 0 );
		scoretext1.positionFromTopLeft(0.11f, 0.18f); //display for score
		scoretext1.color = Color.black;
		scoretext2 = scoreText.addTextInstance(string.Format("{0}", TargetScore), 0, 0 );
		scoretext2.positionFromTopLeft(0.11f, 0.78f); //display for target score
		scoretext2.color = Color.black;
	}

	void Update(){
		scoretext1.text = string.Format("{0}", score);
		scoretext2.text = string.Format ("{0}", TargetScore);
	}

	public void SetTargetScore(int tScore){
		TargetScore = tScore;
	}

	public int getTargetScore(){
		return TargetScore;
	}

	public void setScore(int newScore){
		score = newScore;
	}
	
}
