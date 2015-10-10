//  RabbitTest#FILEEXTENSION#
//  #PROJECTNAME#
//
//  Created by #SMARTDEVELOPERS# on #CREATIONDATE#.
//
//

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RabbitTest : MonoBehaviour {

		
	Text mText;
	void Start () {
		mText = GetComponent<Text>();
		RabbitMQManager.Instance.init("123.57.221.76",5672,"fondle","fondle");
		RabbitMQManager.Instance.subscribe("wangwang",str=>{
			mText.text =mText.text + str+"\n";
//			Handheld.Vibrate();
		});
	}
	
}
