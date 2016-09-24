namespace YiYuan
{
	/// <summary>
	/// 数据状态
	/// </summary>
	public enum DataState : byte
	{
		/// <summary>
		/// 未激活
		/// </summary>
		None = 0,

		/// <summary>
		/// 正常
		/// </summary>
		Normal = 1,

		/// <summary>
		/// 异常
		/// </summary>
		Unusual = 2,

		/// <summary>
		/// 删除
		/// </summary>
		Deleted = 3
	}
}
