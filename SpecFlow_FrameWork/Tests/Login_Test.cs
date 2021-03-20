using NUnit.Framework;
using SpecFlow_FrameWork.Step_Def;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlow_FrameWork.Tests
{
    class Login_Test
    {
       // [Test]
        public void Test1()
        {
            ToDoAppSteps apptest =new  ToDoAppSteps();
            apptest.GivenThatIAmOnTheParbank_Site();
            apptest.ThenEnterTheUsername();
            apptest.ThenEnterThePassword();
            apptest.ThenClickOnLogin_Btn();
            apptest.ThenVerifyWhetherUserIsLogedin();
        }
    }
}
