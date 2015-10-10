
using UnityEngine;
using System;
using System.Collections;

public class RabbitMQManager : MonoBehaviour {

	RabbitMQAndroid mq;

	static RabbitMQManager _instance;

	public static RabbitMQManager Instance {
		get {
			if (_instance == null) {
				_instance = new GameObject ("RabbitMQManager").AddComponent<RabbitMQManager> ();
				DontDestroyOnLoad (_instance.gameObject);
			}
			return _instance;
		}
	}

	void Awake (){
		mq = new RabbitMQAndroid();	
	}
	
	public void init(string hostName,int portNumber,string userName,string password){
		mq.init(hostName,portNumber,userName,password);
	}

	Action<string> subscribeEvent = null;
/// <summary>
/// 用来订阅一个MQ的消息
/// </summary>
/// <param name="clientId">客户端ID的名称</param>
/// <param name="del">回调处理的代理方法</param>
	public void subscribe (string clientId,Action<string> del)
	{
		subscribeEvent = del;
		mq.subscribe(clientId);
	}

	public void subscribeMessage (string msg)
	{
		subscribeEvent.Invoke(msg);
	}

}
