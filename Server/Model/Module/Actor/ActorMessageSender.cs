﻿using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace ETModel
{
	public sealed class ActorMessageSender : ComponentWithId
	{
		// actor的地址
		public IPEndPoint Address;

		public long ActorId;
		
		// 还没发送的消息
		public Queue<ActorTask> WaitingTasks = new Queue<ActorTask>();
		
		// 最近发送消息的时间
		public long LastSendTime;

		public TaskCompletionSource<ActorTask> tcs;

		public int FailTimes;

		public int MaxFailTimes;
	}
}