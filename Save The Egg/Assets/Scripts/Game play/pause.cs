using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {
	
	public AudioClip Click;
	public GameObject _pause;
	public GameObject basket;
	public GameObject camera;
	public float newPosZ;
	float currentPosX, currentPosY, currentPosZ;
	public UIToolkit buttonsManager;
	ToyDartDisableScript hideDart;
	SpawnDart showDart;
	// Use this for initialization
	void Start () {
		//var settingButton = UIButton.create(buttonsManager, "pause_normal2.png","pause_active2.png",0,0);
		var settingButton = UIToggleButton.create(buttonsManager,"pause_normal2.png", "pause_active2.png","pause_normal2.png",0,0);
		settingButton.positionFromTopLeft( 0.28f, 0.9f );
		currentPosX = camera.transform.position.x;
		currentPosY = camera.transform.position.y;
		currentPosZ = camera.transform.position.z;
		//settingButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		//settingButton.onTouchUpInside += sender => Application.LoadLevel("gamePause");
		//settingButton.onTouchUpInside += sender => check (sender);
		//settingButton.onToggle += (sender, selected) => check (sender);
		settingButton.onToggle += (sender, selected) => check (sender);
		settingButton.selected = false;
		//settingButton.touchDownSound = Click;
		settingButton.setSize(50f,50f);
	
	}


	void check(UIToggleButton sender){
		if (sender.selected){
			Time.timeScale = 0;
			//hideDart = GameObject.Find("ToyDart(Clone)").GetComponent<ToyDartDisableScript>();
			//showDart = GameObject.Find("DartSpawner").GetComponent<SpawnDart>();
			//hideDart.Destroy();
//			showDart.isDartActive = false;
//			showDart.callDart();
			//camera.gameObject.transform.Translate(24.04949f,6.109401f, 18.9112f);
			camera.transform.position = new Vector3(currentPosX,currentPosY, newPosZ);
			basket.SetActive(false);
			_pause.SetActive(true);
		}
		else{
			//showDart = GameObject.Find("DartSpawner").GetComponent<SpawnDart>();
			Time.timeScale = 1;
			camera.transform.position = new Vector3(currentPosX,currentPosY, currentPosZ);
			basket.SetActive(true);
			_pause.SetActive(false);
//			showDart.isSpawn = false;
//			showDart.isDartActive = true;
//			showDart.callDart();
		}
	}
	
}
