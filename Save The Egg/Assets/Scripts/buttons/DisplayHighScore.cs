using UnityEngine;
using System.Collections;

public class DisplayHighScore : MonoBehaviour {

	private int highScore;
	private UITextInstance highscoretext;
	private UIText highScoreText;
	public UIToolkit textManager;
	// Use this for initialization
	void Start () {
		highScore = Main.getHighScore();
		highScoreText = new UIText(textManager, "VogueCyrBold_60_ffffff", "VogueCyrBold_60_ffffff.png");
		highscoretext = highScoreText.addTextInstance(string.Format("{0}", highScore), 0, 0 );
		highscoretext.textScale = 2f;
		highscoretext.positionFromTopLeft(0.47f, 0.465f);
		highscoretext.color = Color.black;
	}
	

}
