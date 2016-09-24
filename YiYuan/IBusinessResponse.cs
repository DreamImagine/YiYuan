namespace YiYuan
{
	/// <summary>
	/// 业务响应接口
	/// </summary>
	public interface IBusinessResponse
	{
		/// <summary>
		/// 是否成功
		/// </summary>
		bool Success { get; set; }

		/// <summary>
		/// 业务消息
		/// </summary>
		string Message { get; set; }

		/// <summary>
		/// 错误类型
		/// </summary>
		string Error { get; set; }

		/// <summary>
		/// 错误代码
		/// </summary>
		string ErrorCode { get; set; }

	}

	/// <summary>
	/// 业务响应接口
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IBusinessResponse<T> : IBusinessResponse
	{
		/// <summary>
		/// 返回数据
		/// </summary>
		T Data { get; set; }
	}
}