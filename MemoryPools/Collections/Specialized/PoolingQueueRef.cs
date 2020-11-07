﻿namespace MemoryPools.Collections.Specialized
{
	public sealed class PoolingQueueRef<T> : PoolingQueue<T> where T : class
	{
		protected override IPoolingNode<T> CreateNodeHolder()
		{
			return (IPoolingNode<T>) Pool.Get<PoolingNodeCanon<T>>().Init(PoolsDefaults.DefaultPoolBucketSize);
		}
	}
}