namespace YiYuan
{
	/// <summary>
	/// 带有分页的业务响应
	/// </summary>
	public class PagingBusinessResponse<T> : BusinessResponse, IPagingBusinessResponse<T>
	{
		/// <summary>
		/// 
		/// </summary>
		public PagingBusinessResponse()
		{
			Paging = new Paging();
			Data = default(T);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="success"></param>
		/// <param name="message"></param>
		/// <param name="error"></param>
		public PagingBusinessResponse(bool success, string message, string error)
			: base(success, message, error)
		{
		}

		/// <summary>
		/// 分页信息
		/// </summary>
		public Paging Paging { get; set; }

		/// <summary>
		/// 返回数据
		/// </summary>
		public T Data { get; set; }

	}
}