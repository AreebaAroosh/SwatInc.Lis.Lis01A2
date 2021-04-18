using System;
using System.Runtime.CompilerServices;

namespace SwatInc.Lis.Lis02A2
{
	public class ResultRecord : AbstractLisRecord
	{

		[LisRecordField(2)]
		public int SequenceNumber { get; set; }

		[LisRecordField(3)]
		public UniversalTestID UniversalTestID { get; set; }

		[LisRecordField(4)]
		public string Data { get; set; }

		[LisRecordField(5)]
		public string Units { get; set; }

		[LisRecordField(7)]
		public ResultAbnormalFlags ResultAbnormalFlag { get; set; }

		public override string ToLISString()
		{
			return "R" + new string(LISDelimiters.FieldDelimiter, 1) + base.ToLISString();
		}

		public ResultRecord(string aLisString)
			: base(aLisString)
		{
		}

		public ResultRecord()
		{
		}
	}
}
