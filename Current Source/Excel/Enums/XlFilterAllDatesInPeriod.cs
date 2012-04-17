using System;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Excel", 12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlFilterAllDatesInPeriod
	{
		 /// <summary>
		 /// SupportByVersion Excel 12, 14
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Excel", 12,14)]
		 xlFilterAllDatesInPeriodYear = 0,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Excel", 12,14)]
		 xlFilterAllDatesInPeriodMonth = 1,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Excel", 12,14)]
		 xlFilterAllDatesInPeriodDay = 2,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Excel", 12,14)]
		 xlFilterAllDatesInPeriodHour = 3,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Excel", 12,14)]
		 xlFilterAllDatesInPeriodMinute = 4,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersionAttribute("Excel", 12,14)]
		 xlFilterAllDatesInPeriodSecond = 5
	}
}