namespace YiYuan
{
	/// <summary>
	/// 业务响应
	/// </summary>
	public class BusinessResponse : IBusinessResponse
	{
		/// <summary>
		/// 是否成功
		/// </summary>
		public bool Success { get; set; }

		/// <summary>
		/// 业务消息
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// 错误类型
		/// </summary>
		public string Error { get; set; }

		/// <summary>
		/// 错误类型
		/// <para>错误类型</para>
		/// </summary>
		public string ErrorCode { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public BusinessResponse()
		{
			Success = true;

			Message = "Success";

			Error = "Success";

			ErrorCode = "200";
		}

		/// <summary>
		/// 返回消息
		/// </summary>
		/// <param name="message">信息</param>
		public BusinessResponse(string message)
		{
			Success = true;
			Message = message;
			this.Error = "";
			ErrorCode = "201";
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="success">是否成功</param>
		/// <param name="message">成功的提示</param>
		public BusinessResponse(bool success, string message)
		{
			this.Success = success;

			this.Message = message;

			Error = "Success";

			ErrorCode = "200";
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="success"></param>
		/// <param name="message"></param>
		/// <param name="error"></param>
		public BusinessResponse(bool success, string message, string error)
			: this(success, message)
		{
			this.Error = error;
			ErrorCode = "201";
		}
	}

	/// <summary>
	/// 业务响应
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class BusinessResponse<T> : BusinessResponse, IBusinessResponse<T>
	{
		/// <summary>
		/// 响应数据
		/// </summary>
		public T Data { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public BusinessResponse()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessResponse{T}"/> class.
		/// </summary>
		/// <param name="message">信息</param>
		public BusinessResponse(string message)
			: base(message)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessResponse{T}"/> class.
		/// </summary>
		/// <param name="data">返回的数据</param>
		public BusinessResponse(T data)
		{
			this.Data = data;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="success"></param>
		/// <param name="message"></param>
		public BusinessResponse(bool success, string message)
			: base(success, message)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="success"></param>
		/// <param name="message"></param>
		/// <param name="error"></param>
		public BusinessResponse(bool success, string message, string error)
			: base(success, message, error)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="success"></param>
		/// <param name="message"></param>
		/// <param name="data"></param>
		public BusinessResponse(bool success, string message, T data)
			: base(success, message)
		{
			this.Data = data;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessResponse{T}"/> class.
		/// </summary>
		/// <param name="sucess">if set to <c>true</c> [sucess].</param>
		/// <param name="message">The message.</param>
		/// <param name="error">The error.</param>
		/// <param name="data">The data.</param>
		public BusinessResponse(bool sucess, string message, string error, T data)
			: base(sucess, message, error)
		{
			this.Data = data;
		}
	}
}