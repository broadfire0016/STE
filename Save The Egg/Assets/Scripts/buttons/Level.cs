using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {
	public UIToolkit textManager;
	private int score;
	private int TargetScore;
	private UITextInstance scoretext1, scoretext2;
	UIText scoreText;

	// Use this for initialization
	void Start () {
		scoreText = new UIText(textManager, "VogueCyrBold_60_ffffff", "VogueCyrBold_60_ffffff.png");
		scoretext1 = scoreText.addTextInstance(string.Format("{0}", score), 0, 0 );
		scoretext1.positionFromTopLeft(0.43f, 0.455f);
		scoretext1.color = Color.black;
		scoretext1.textScale = 2f;
		scoretext2 = scoreText.addTextInstance(string.Format("{0}", TargetScore), 0, 0 );
		scoretext2.positionFromCenter(0.17f, 0.0f);
		scoretext2.color = Color.black;
	}

	void Update(){
		scoretext1.text = string.Format("{0}", score);
		scoretext2.text = string.Format("{0}", TargetScore);
	}

	public void SetTargetScore(int tScore){
		TargetScore = tScore+15;
	}
	
	public void setScore(int newScore){
		score = newScore;
	}
	
}
