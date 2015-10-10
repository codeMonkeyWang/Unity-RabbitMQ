//  RabbitMQAndroid#FILEEXTENSION#
//  #PROJECTNAME#
//
//  Created by #SMARTDEVELOPERS# on #CREATIONDATE#.
//
//



using UnityEngine;
using System.Collections;

public class RabbitMQAndroid : MonoBehaviour {

	
	AndroidJavaObject mqClass = null;
	
	public void init(string hostName,int portNumber,string userName,string password){
		mqClass = new AndroidJavaObject("com.amqp.android.RabbitClient");
		mqClass.Call("init",hostName,portNumber,userName,password);
	}
	
	public void subscribe (string clientId)
	{
		mqClass.Call("subscribe",clientId);
	}
}
