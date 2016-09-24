namespace YiYuan
{
	/// <summary>
	/// 分页参数类
	/// </summary>
	public class Paging
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Paging"/> class.
		/// </summary>
		public Paging()
		{
			PageIndex = 1;
			PageSize = 10;
		}

		/// <summary>
		/// 总页数
		/// </summary>
		public int PageCount { get; set; }

		/// <summary>
		/// 页码
		/// </summary>
		public int PageIndex { get; set; }

		/// <summary>
		/// 页大小
		/// </summary>
		public int PageSize { get; set; }

		/// <summary>
		/// 总行数
		/// </summary>
		public int Total { get; set; }
	}
}