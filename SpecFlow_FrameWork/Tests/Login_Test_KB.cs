using NUnit.Framework;
using SpecFlow_FrameWork.Step_Def;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlow_FrameWork.Tests
{
    public class Login_Test_KB
    {
        [Test]
        public void TC_01()
        {
            Login_KidsbankSteps kb = new Login_KidsbankSteps();
            kb.GivenUserShouldBeOnKidsbankLoginPage();
            kb.ThenEnterBanker_ID();
            kb.ThenEnterUserName();
            kb.ThenEnterTheUsr_Password();
            kb.ThenClickLogin_Button();   
        }


    }
}
