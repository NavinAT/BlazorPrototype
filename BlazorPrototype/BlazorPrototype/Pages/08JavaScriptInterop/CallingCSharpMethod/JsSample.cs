using Microsoft.JSInterop;

namespace BlazorPrototype
{
	public class JsSample
	{
		#region Fields
		private int _count;
		#endregion

		#region Publics
		[JSInvokable]
		public int IncrementCount()
		{
			return _count++;
		}
		#endregion
	}
}