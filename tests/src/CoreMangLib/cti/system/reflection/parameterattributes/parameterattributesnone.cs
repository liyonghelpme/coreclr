using System;
using System.Reflection;

/// <summary>
/// None [v-ly]
/// </summary>
public class ParameterAttributesNone
{
    public static int Main()
    {
        ParameterAttributesNone test = new ParameterAttributesNone();

        TestLibrary.TestFramework.BeginTestCase("ParameterAttributesNone");

        if (test.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }

    public bool RunTests()
    {
        bool retVal = true;

        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;

        //TestLibrary.TestFramework.LogInformation("[Negative]");
        //retVal = NegTest1() && retVal;

        return retVal;
    }

    #region Postive Test Case
    public bool PosTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest1: ");

        try
        {
            int expected = 0x0000;
            int actual = (int)ParameterAttributes.None;
            if (expected != actual)
            {
                TestLibrary.TestFramework.LogError("001.1", "None's value is not 0x0000");
                TestLibrary.TestFramework.LogInformation("WARNING [LOCAL VARIABLES] expected = " + expected + ", actual = " + actual);
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception occurs: " + e);
            TestLibrary.TestFramework.LogInformation(e.Message);
            retVal = false;
        }

        return retVal;
    }
    #endregion

    #region Nagetive Test Cases
    //public bool NegTest1()
    //{
    //    bool retVal = true;

    //    TestLibrary.TestFramework.BeginScenario("NegTest1: ");

    //    try
    //    {
    //    }
    //    catch (Exception e)
    //    {
    //        TestLibrary.TestFramework.LogError("101.0", "Unexpected exception: " + e);
    //        TestLibrary.TestFramework.LogInformation(e.StackTrace);
    //        retVal = false;
    //    }

    //    return retVal;
    //}
    #endregion
}