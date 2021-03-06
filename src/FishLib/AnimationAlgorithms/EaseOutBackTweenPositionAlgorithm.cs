namespace FSLib.Extension.FishLib.AnimationAlgorithms
{
	/// <summary>
	/// EaseOutBack
	/// </summary>
	public class EaseOutBackTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// 获得在指定的时间刻度上应该处于的位置
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			return (pos = pos - 1) * pos * ((1.70158 + 1) * pos + 1.70158) + 1;

		}

		#endregion
	}
}