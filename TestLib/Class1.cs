/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace TestLib
{
	[XmlRoot(ElementName = "Answer")]
	public class Answer
	{
		[XmlElement(ElementName = "Description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "IsRight")]
		public string IsRight { get; set; }
	}

	[XmlRoot(ElementName = "Question")]
	public class Question
	{
		[XmlElement(ElementName = "Description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "Difficulty")]
		public int Difficulty { get; set; }
		[XmlElement(ElementName = "Answer")]
		public List<Answer> Answer { get; set; } = new List<Answer>();
	}

	[XmlRoot(ElementName = "Test")]
	public class Test
	{
		[XmlElement(ElementName = "Author")]
		public string Author { get; set; }
		[XmlElement(ElementName = "TestName")]
		public string TestName { get; set; }
		[XmlElement(ElementName = "Qty_questions")]
		public int Qty_questions { get; set; }
		[XmlElement(ElementName = "Question")]
		public List<Question> Question { get; set; } = new List<Question>();
	}

}
