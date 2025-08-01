using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using MyBnb;
using MyBnb.Logica_Negocio;


namespace MyBnBTestFixture
{       
    [TestFixture]
    public class Twitter_UnitTest
    {
        #region Variables
        /// <summary>
        /// Represents an instance of the <see cref="Twitter"/> class used for testing Twitter-related functionality.
        /// </summary>
        Twitter twitterObj;
        string ppublicacion;
        #endregion

        [TestFixtureSetUp]
        public void Init()
        {
            twitterObj = new Twitter();
            ppublicacion = "Se ha registrado una nueva propiedad";
        }

        [Test]
        public void realizarPublicacion_Test()
        {
            twitterObj.realizarPublicacion(ppublicacion);
        }


    }
}
