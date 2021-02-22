using System;
namespace FavoriteTest.DTO
{
	public class BaseEntity
	{
		public string CreatedBy { get; set; }
		public DateTime? CreatedDate { get; set; }
		public string UpdatedBy { get; set; }
		public DateTime? UpdatedDate { get; set; }

		public string ErrorCode;
		public string ErrorMessage;

		public bool IsError()
		{
			if (ErrorCode == null) return false;
			foreach (char ch in ErrorCode)
			{
				if (ch != '0') return true;
			}
			return false;
		}

		public int? ConfirmFlow { get; set; }
		public bool? IsUnsuccessPage { get; set; }

		public string LogMessage { get; set; }
	}
}
