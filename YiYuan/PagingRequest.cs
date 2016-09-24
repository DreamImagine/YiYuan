namespace YiYuan
{
	/// <summary>
	/// 分页请求
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class PagingRequest<T>
	{

		/// <summary>
		/// 
		/// </summary>
		public PagingRequest()
		{
			Data = default(T);
		}


		/// <summary>
		/// 泛型参数
		/// </summary>
		public T Data { get; set; }


		/// <summary>
		/// 当前页
		/// </summary>
		public int PageIndex { get; set; }


		/// <summary>
		/// 每页数
		/// </summary>
		public int PageSize { get; set; }


		/// <summary>
		/// 总页数
		/// </summary>
		public int PageCount { get; set; }

	}
}
