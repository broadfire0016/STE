//Shows Score for the level complete scene and game Over Scene
//Author Levi

using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {
	public UIToolkit textManager;
	private UITextInstance scoretext1, scoretext2;
	UIText scoreText;

	// Use this for initialization
	void Start () {
		var scaleFactor = ScaleFactor.GetScaleFactor ();
		scoreText = new UIText(textManager, "VogueCyrBold_60_ffffff", "VogueCyrBold_60_ffffff.png");
		scoretext1 = scoreText.addTextInstance(string.Format("{0}", Main.getScore()), 0, 0 );
		scoretext1.color = Color.black;
		scoretext1.textScale /= scaleFactor * 0.4f;
	
		if (Application.loadedLevelName != "gameOver"){
			scoretext2 = scoreText.addTextInstance(string.Format("{0}", Main.getTargetScore()), 0, 0 );
			scoretext2.positionFromCenter(0.17f, 0.0f);
			scoretext2.color = Color.black;
		}
		scoretext1.positionFromCenter(0.0f, 0.0f);
	}

	void Update(){
		scoretext1.text = string.Format("{0}", Main.getScore());
		if (Application.loadedLevelName != "gameOver")
			scoretext2.text = string.Format("{0}", Main.getTargetScore()+15);
	}
}
