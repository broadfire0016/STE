using UnityEngine;
using System.Collections;

public class Settings : MonoBehaviour {
	
	
	public AudioClip scoresSound;
	public AudioClip optionsSound;
	
	void Start () {
	
		
		//game sound
		var soundtoggleButton = UIToggleButton.create( "cbUnchecked.png", "cbChecked.png", "cbDown.png", 0, 0 );
		soundtoggleButton.positionFromTopRight(0.3f, 0.2f );
		//soundtoggleButton.onToggle += sender => hSlider.hidden = !newValue;;
		soundtoggleButton.selected = true;
		
		//game music
		var musictoggleButton = UIToggleButton.create( "cbUnchecked.png", "cbChecked.png", "cbDown.png", 0, 0 );
		musictoggleButton.positionFromTopRight(0.6f, 0.2f );
		//musictoggleButton.onToggle += sender => hSlider.hidden = !newValue;;
		musictoggleButton.selected = true;
		
		//credits
		var creditstoggleButton = UIToggleButton.create( "cbUnchecked.png", "cbChecked.png", "cbDown.png", 0, 0 );
		creditstoggleButton.positionFromTopRight(0.9f, 0.2f );
		//creditstoggleButton.onToggle += sender => hSlider.hidden = !newValue;;
		creditstoggleButton.selected = true;
		
		//home/back
		var backButton = UIButton.create( "cbUnchecked.png", "cbDown.png", 0, 0 );
		backButton.positionFromTopRight(0.12f, 0.2f );
		backButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		backButton.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
		
		
}
}
