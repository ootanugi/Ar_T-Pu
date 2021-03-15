using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBackground : MonoBehaviour {

	// public List<Transform> Balloon;
	// private float[] _xBalloon=new float[3],_yBalloon=new float[3],_xCloud=new float[5],_yCloud=new float[5];
	// public List<Transform> Cloud;

	// public Transform Rocket;
	// private float _xRocket,_yRocket;
    // private float height = 30f;//max height of Box's movement

	private float posX,posY;
	public float height,speed;
    public bool _Horizontal;

 
    void Start () {
		// for(int i=0;i<Balloon.Count;i++){
		// 	_xBalloon[i]=Balloon[i].localPosition.x;
		// 	_yBalloon[i]=Balloon[i].localPosition.y;
		// }
		// for(int j=0;j<Cloud.Count;j++){
		// 	_xCloud[j]=Cloud[j].localPosition.x;
		// 	_yCloud[j]=Cloud[j].localPosition.y;
		// }

		// _xRocket = Rocket.localPosition.x;
		// _yRocket = Rocket.localPosition.y;

		
		posX = this.gameObject.transform.localPosition.x;
		posY = this.gameObject.transform.localPosition.y;

    }
 
    void Update () {
        if(_Horizontal){
            this.gameObject.transform.localPosition = new Vector3(posX + Mathf.PingPong(Time.time * speed,height), posY ,this.gameObject.transform.position.z);
        }
        else{
            this.gameObject.transform.localPosition = new Vector3(posX, posY + Mathf.PingPong(Time.time * speed,height),this.gameObject.transform.position.z);
        }
		// Balloon[0].transform.localPosition = new Vector3(_xBalloon[0], _yBalloon[0] + Mathf.PingPong(Time.time * 20, 50), transform.position.z);//move on y axis only
		// Balloon[1].transform.localPosition = new Vector3(_xBalloon[1], _yBalloon[1]+ Mathf.PingPong(Time.time * 20, 55), transform.position.z);
		// Balloon[2].transform.localPosition = new Vector3(_xBalloon[2], _yBalloon[2]+ Mathf.PingPong(Time.time * 20, 45), transform.position.z);

		// Cloud[0].transform.localPosition = new Vector3(_xCloud[0] + Mathf.PingPong(Time.time * 10, 40),_yCloud[0] , transform.position.z);
		// Cloud[1].transform.localPosition = new Vector3(_xCloud[1] + Mathf.PingPong(Time.time * 10, 30),_yCloud[1] , transform.position.z);
		// Cloud[2].transform.localPosition = new Vector3(_xCloud[2] + Mathf.PingPong(Time.time * 10, 35),_yCloud[2] , transform.position.z);
		// Cloud[3].transform.localPosition = new Vector3(_xCloud[3] + Mathf.PingPong(Time.time * 10, 38),_yCloud[3] , transform.position.z);
		// Cloud[4].transform.localPosition = new Vector3(_xCloud[4] + Mathf.PingPong(Time.time * 10, 42),_yCloud[4] , transform.position.z);

		// Rocket.transform.localPosition = new Vector3(_xRocket, _yRocket+ Mathf.PingPong(Time.time * 20, 30), transform.position.z);
		

    }
}
