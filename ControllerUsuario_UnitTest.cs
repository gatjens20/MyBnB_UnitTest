using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using MyBnb.Controller;

namespace MyBnBTestFixture
{       
    [TestFixture]
    public class ControllerUsuario_UnitTest
    {
        #region Variables
        ControllerUsuario ControllerUsuarioObj;
        #endregion

        [TestFixtureSetUp]
        public void Init()
        {
            ControllerUsuarioObj = new ControllerUsuario();
        }

        [Test]
        public void getLogin_Test()
        {
            ControllerUsuarioObj.getLogin();
        }


    }
}
