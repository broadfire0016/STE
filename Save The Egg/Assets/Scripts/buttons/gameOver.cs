//Game Over Scene
//Author : Levi Lim & Aiza Aviso

using UnityEngine;
using System.Collections;

public class gameOver : MonoBehaviour {

	public UIToolkit buttonsManager;
	// Use this for initialization
	void Start () {
		var scaleFactor = ScaleFactor.GetScaleFactor ();
		//home
		var menuButton = UIButton.create(buttonsManager, "home_normal.png","home_active.png",0,0);
		menuButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		menuButton.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
		menuButton.setSize(menuButton.width/ scaleFactor + 11, menuButton.height / scaleFactor +4);
		menuButton.positionFromBottomLeft( 0.26f, -0.15f );
		menuButton.positionFromCenter( 0.26f, -0.15f );
			
		//retry
		var retryButton = UIButton.create(buttonsManager,"retry_normal.png","retry.png",0,0);
		retryButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		retryButton.onTouchUpInside += sender => Application.LoadLevel("Level1");
		retryButton.setSize(retryButton.width/ scaleFactor + 27, retryButton.height / scaleFactor +18);
		retryButton.positionFromBottomLeft( 0.26f, 0.07f );
		//retryButton.positionFromCenter( 0.26f, 0.07f );

	}
}
