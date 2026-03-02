namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}

	[TestMethod]
	public void Subtract_Valid_Patino_Blesh()
	{
		Assert.AreEqual(10, Program.Subtract("12", "2"));
		Assert.AreEqual(1, Program.Subtract("3", "2"));
		Assert.AreEqual(253, Program.Subtract("490", "237"));
    }

	[TestMethod]
	public void Subtract_Invalid_Patino_Blesh()
	{
		Assert.ThrowsException<FormatException>(() => Program.Subtract("2", "z"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("z", "2"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("z", "z"));
    }

	[TestMethod]
	public void Subtract_Null_Patino_Blesh()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("5", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "5"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
    }

    [TestMethod]
    public void Multiply_Valid_Patino_Blesh()
	{
		Assert.AreEqual(10, Program.Multiply("5", "2"));
		Assert.AreEqual(6, Program.Multiply("3", "2"));
		Assert.AreEqual(0, Program.Multiply("0", "1"));
    }

    [TestMethod]
    public void Multiply_Invalid_Patino_Blesh()
	{
		Assert.ThrowsException<FormatException>(() => Program.Multiply("2", "z"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("z", "2"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("z", "z"));
    }

    [TestMethod]
    public void Multiply_Null_Patino_Blesh()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("5", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "5"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
    }

    [TestMethod]
	public void Divide_Valid_Patino_Blesh()
	{
		Assert.AreEqual(5, Program.Divide("10", "2")); //Intentionally Wrong
		Assert.AreEqual(3, Program.Divide("6", "2"));
		Assert.AreEqual(10, Program.Divide("30", "3"));
	}
	
	[TestMethod]
	public void Divide_Invalid_Patino_Blesh()
	{
		Assert.ThrowsException<FormatException>(() => Program.Divide("2", "z"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("z", "2"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("z", "z"));
	}
	
	[TestMethod]
	public void Divide_Null_Patino_Blesh()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("5", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "5"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
    }

    [TestMethod]
	public void Power_Valid_Patino_Blesh()
	{
	Assert.AreEqual(100, Program.Power("10", "2"));
	Assert.AreEqual(4, Program.Power("2", "2"));
	Assert.AreEqual(8, Program.Power("2", "3"));
    }

    [TestMethod]
	public void Power_Invalid_Patino_Blesh()
	{
		Assert.ThrowsException<FormatException>(() => Program.Power("2", "z"));
		Assert.ThrowsException<FormatException>(() => Program.Power("z", "2"));
		Assert.ThrowsException<FormatException>(() => Program.Power("z", "z"));
    }
	
	[TestMethod]
	public void Power_Null_Patino_Blesh()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power("5", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "5"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
    }
}
